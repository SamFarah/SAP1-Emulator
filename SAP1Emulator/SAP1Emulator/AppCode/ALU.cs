using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ALU : Register
{

    public ALU(Register op1, Register op2)
    {
        Op1 = op1;
        Op2 = op2;
    }

    private Register Op1 { get; set; }
    private Register Op2 { get; set; }
    public bool Subtract { get; set; } //if active will will Subtract (Active HIGH)
    public bool CarryIn { get; set; }
    public bool CarryOut { get
        {
            return AluResult>255;
        }
    }

    private UInt16 AluResult;

   // public byte GetData() { return (byte)AluResult; }

    public override byte Data
    {
        get
        {
            if (Subtract)
                AluResult=(UInt16)(Op1.Data + (~Op2.Data + 0x01) + (CarryIn?1:0));
            else
                AluResult=(UInt16)(Op1.Data + Op2.Data + (CarryIn ? 1 : 0));

            return (byte)AluResult;

        }
    }

    
}

