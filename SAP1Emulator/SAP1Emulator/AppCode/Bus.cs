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

    public Register InstReg { get; set; }

    public Adder Sum { get; set; }


    //funcs

    public Bus()
    {
        A = new Register();
        B = new Register();
        InstReg = new Register();
        Sum = new Adder(A, B);
    }
    public void Read()//read data from the bus into devices
    {
        A.Read(Data);
        B.Read(Data);
        InstReg.Read(Data);
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

        temp = InstReg.Write();
        if (temp != null)
        {
            Data = (byte)((Data & 0xF0) | (temp & 0x0F));
            writes++;
        } //instruction register only puts 4 LSB bits on bus

        if (writes == 0) Data = 0x00; //if no device putting on bus then zero it out
    }


}

