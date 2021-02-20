using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bus
{
    public byte Data { get; set; }



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
        A.Read(Data);
        B.Read(Data);
        Inst.Read(Data);
        MAR.Read(Data);
        RAM.Read((byte)(MAR.Data & 0x0F), Data);
        PC.Read(Data);
        Output.Read(Data);
        //return Data;
    }

    public void Write() //put data on the bus from devices
    {
        byte? temp;
        int writes = 0;
        temp = A.Write();
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        temp = B.Write();
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        temp = Sum.Write();
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        temp = Inst.Write();
        if (temp != null)
        {
            Data = (byte)((Data & 0xF0) | (temp & 0x0F));
            writes++;
        } //instruction register only puts 4 LSB bits on bus

        temp = MAR.Write();
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        temp = RAM.Write((byte)(MAR.Data & 0x0F));
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        temp = PC.Write();
        if (temp != null)
        {
            Data = (byte)((Data & 0xF0) | (temp & 0x0F));
            writes++;
        }

        temp = Output.Write();
        if (temp != null)
        {
            Data = (byte)temp;
            writes++;
        }

        if (writes == 0) Data = 0x00; //if no device putting on bus then zero it out
    }


}

