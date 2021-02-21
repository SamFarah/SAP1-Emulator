using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bus
{

    private byte mData { get; set; }
    public byte Data { get { Write (); return mData; } set { mData = value; } } //  output is not linked to clock

    public byte GetData() { return mData; }


    //connected modules:

    public Register A { get; set; }
    public Register B { get; set; }

    public Register Inst { get; set; }

    public ALU Sum { get; set; }

    public Register MAR { get; set; }

    public SRAM RAM { get; set; }

    public Counter PC { get; set; }
    public Register Output { get; set; }


    //funcs

    public Bus()
    {
        A = new Register();
        B = new Register();
        Inst = new Register();
        Sum = new ALU(A, B);
        MAR = new Register(0x0F);
        RAM = new SRAM(MAR);
        PC = new Counter();
        Output = new Register();

    }
    public void Read()//read data from the bus into devices
    {
        A.Read(mData);
        B.Read(mData);
        Inst.Read(mData);
        MAR.Read(mData);
        RAM.Read( mData);
        PC.Read(mData);
        Output.Read(mData);

        PC.Inc();
        //return Data;
    }

    public void Write() //put data on the bus from devices
    {
        byte? temp;
        int writes = 0;
        temp = A.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        temp = B.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        temp = Sum.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        temp = Inst.Write();
        if (temp != null)
        {
            mData = (byte)( temp & 0x0F);
            writes++;
        } //instruction register only puts 4 LSB bits on bus

        temp = MAR.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        temp = RAM.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        temp = PC.Write();
        if (temp != null)
        {
            mData = (byte)(temp & 0x0F);
            writes++;
        }

        temp = Output.Write();
        if (temp != null)
        {
            mData = (byte)temp;
            writes++;
        }

        if (writes == 0) mData = 0x00; //if no device putting on bus then zero it out
    }

    public void Reset()
    {        
        Data = 0x00;
        A.Reset();
        B.Reset ();
        Inst.Reset();
        //Sum.Reset();
        MAR .Reset();        
        PC.Reset();
        Output.Reset();

    }
}

