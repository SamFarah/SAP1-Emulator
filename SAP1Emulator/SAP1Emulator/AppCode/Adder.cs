using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Adder : Register
{

    public Adder(Register op1, Register op2)
    {
        Op1 = op1;
        Op2 = op2;
        
    }

    private Register Op1 { get; set; }
    private Register Op2 { get; set; }


    public override byte Data { get => (byte)(Op1.Data + Op2.Data); }
    
    public override  byte? Write()
    {
        if (Enable) return Data;
        return null;        
    }
}

