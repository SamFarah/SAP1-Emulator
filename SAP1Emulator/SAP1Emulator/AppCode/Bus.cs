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


    public Adder Sum { get; set; }


    //funcs

    public Bus()
    {
        A = new Register();
        B = new Register();
        Sum = new Adder (A,B);
    }
    public void Read()//read data from the bus into devices
    {
        A.Read(Data);
        B.Read(Data);        
        //return Data;
    }

    public void Write() //put data on the bus from devices
    {
        byte? temp;
        temp = A.Write();
        if (temp != null) Data = (byte)temp;
        temp = B.Write();
        if (temp != null) Data = (byte)temp;
        temp = Sum.Write();
        if (temp != null) Data = (byte)temp;
    }


}

