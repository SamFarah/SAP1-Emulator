using BitField;
using System;
namespace SAP2Modules
{
    public class ALU : Register
    {
        /*
                            ALU Block Diagram
             +---------------------------------------------+
             |                                             |
             |            +---------------+                |  
             |            |   B (A Reg)   |                |
             |            +---------------+                |
             |                |                            |
             |                v                            |
             |            +-------------+     +---------+  |     
             | (DATA) <== |   ADD/SUB   | ==> |  Flags  |  |     
             |            +-------------+     +---------+  |     
             |                ^                            |
             |                |                            |
             |            +---------------+                |     
             |            |  A (temp Reg) |                |    
             |            +---------------+                |
             |                                             |
             +---------------------------------------------+
        */

        //Connected Devices as shown in the figure above 
        private Register A { get; set; } // First operand of the operation
        private Register B { get; set; } // Second operand of the operation
        private FlagsRegister Flags { get; set; } // the flags to be stored after each operation



        //Control signals and outputs
        //public bool Subtract { get; set; } //if active will will Subtract (Active HIGH)
        public bool CarryIn { get; set; } //Ability to take exteranl Carry in
        public bool CarryOut { get { return AluResult > 255; } } //Active if result of operation caused an overflow
        public bool IsZero { get { return (AluResult & 0xFF) == 0; } } //Active if result of operation is zero     
        public bool WithCarry { get; set; }


        public bool M { get; set; }// Mode Select (LOGIC = true | ARITHMETIC = false)
        public ModeSelectField ModeSelect { get; set; } // Mode Select Bits



        /*
         * 
        +----------+------------------+-----------------+------------------------------------+ 
        |          |    Mode Select   |      LOGIC      |            ARITHMETIC              |
        |   Hex    |   S3  S2  S1  S0 |       M=1       |               M=0                  |
        +----------+------------------+-----------------+------------------------------------+
        |   0x0    |   0   0   0   0  |  F = ~A         |   F = A + CarryIn                  |
        |   0x1    |   0   0   0   1  |  F = ~(A | B)   |   F = (A | B) + CarryIn            |
        |   0x2    |   0   0   1   0  |  F = ~A & B     |   F = (A | ~B) + CarryIn           |
        |   0x3    |   0   0   1   1  |  F = 0          |   F = -1 (2's) + CarryIn           |
        |   0x4    |   0   1   0   0  |  F = ~(A & B)   |   F = A + (A & ~B) + CarryIn       | 
        |   0x5    |   0   1   0   1  |  F = ~B         |   F = (A | B) + (A & ~B) + CarryIn |       
        |   0x6    |   0   1   1   0  |  F = A ^ B      |   F = A - B - 1 + CarryIn          | 
        |   0x7    |   0   1   1   1  |  F = A & ~B     |   F = (A & ~B) - 1 + CarryIn       | 
        |   0x8    |   1   0   0   0  |  F = ~A | B     |   F = A + (A & B) + CarryIn        | 
        |   0x9    |   1   0   0   1  |  F = ~(A ^ B)   |   F = A + B + CarryIn              | 
        |   0xA    |   1   0   1   0  |  F = B          |   F = (A | ~B) + (A & B) + CarryIn | 
        |   0xB    |   1   0   1   1  |  F = A & B      |   F = (A & B) - 1 + CarryIn        | 
        |   0xC    |   1   1   0   0  |  F = 1          |   F = A + A + CarryIn              | 
        |   0xD    |   1   1   0   1  |  F = A | ~B     |   F = (A | B) + A + CarryIn        | 
        |   0xE    |   1   1   1   0  |  F = A | B      |   F = (A | ~B) + A + CarryIn       | 
        |   0xF    |   1   1   1   1  |  F = A          |   F = A - 1 + CarryIn              | 
        +----------+------------------+-----------------+------------------------------------+                                  

             */



        public override UInt16 Data
        {   //ALU's data is not "stored" anywhere, it is however the continuous addition (or subtraction) result of Op1 and Op2 at any given time.
            get
            {
                if (M) //LOGIC
                {
                    switch (ModeSelect)
                    {
                        case 0x0: AluResult = (UInt16)~A.Data; break;
                        case 0x1: AluResult = (UInt16)~(A.Data | B.Data); break;
                        case 0x2: AluResult = (UInt16)((~A.Data) & B.Data); break;
                        case 0x3: AluResult = 0x00; break;
                        case 0x4: AluResult = (UInt16)~(A.Data & B.Data); break;
                        case 0x5: AluResult = (UInt16)~B.Data; break;
                        case 0x6: AluResult = (UInt16)(A.Data ^ B.Data); break;
                        case 0x7: AluResult = (UInt16)(A.Data & ~B.Data); break;
                        case 0x8: AluResult = (UInt16)(~A.Data | B.Data); break;
                        case 0x9: AluResult = (UInt16)~(A.Data ^ B.Data); break;
                        case 0xA: AluResult = (UInt16)B.Data; break;
                        case 0xB: AluResult = (UInt16)(A.Data & B.Data); break;
                        case 0xC: AluResult = 0xFF; break;
                        case 0xD: AluResult = (UInt16)(A.Data | ~B.Data); break;
                        case 0xE: AluResult = (UInt16)(A.Data | B.Data); break;
                        case 0xF: AluResult = (UInt16)A.Data; break;
                    }
                }
                else //ARITHMETIC
                {
                    byte CI = (byte)(CarryIn ? 1 : 0);
                    switch (ModeSelect)
                    {
                        case 0x0: AluResult = (UInt16)(A.Data + CI); break;
                        case 0x1: AluResult = (UInt16)((A.Data | B.Data) + CI); break;
                        case 0x2: AluResult = (UInt16)((A.Data | ~B.Data) + CI); break;
                        case 0x3: AluResult = (UInt16)(-1 + CI); break;
                        case 0x4: AluResult = (UInt16)(A.Data + (A.Data & ~B.Data) + CI); break;
                        case 0x5: AluResult = (UInt16)((A.Data | B.Data) + (A.Data & ~B.Data) + CI); break;
                        case 0x6: AluResult = (UInt16)(A.Data + (byte)~B.Data  + CI); break;
                        case 0x7: AluResult = (UInt16)((A.Data  & ~B.Data ) - 1 + CI); break;
                        case 0x8: AluResult = (UInt16)(A.Data + (A.Data & B.Data) + CI); break;
                        case 0x9: AluResult = (UInt16)(A.Data  + B.Data  + CI); break;
                        case 0xA: AluResult = (UInt16)((A.Data | ~B.Data) + (A.Data & B.Data) + CI); break;
                        case 0xB: AluResult = (UInt16)((A.Data & B.Data) - 1  + CI); break;
                        case 0xC: AluResult = (UInt16)(A.Data + A.Data + CI); break;
                        case 0xD: AluResult = (UInt16)((A.Data | B.Data) + A.Data + CI); break;
                        case 0xE: AluResult = (UInt16)((A.Data | ~B.Data) + A.Data  + CI); break;
                        case 0xF: AluResult = (UInt16)(A.Data  - 1 + CI); break;
                    }
                }
                //Op1 + (If subtract then take 2's compt of Op2, else Op2) + add carry if it's set
                //AluResult = (UInt32)(A.Data + (Subtract ? (UInt16)(~B.Data + 0x0001) : B.Data) + (UInt16)(CarryIn ? 1 : 0));
                if (WithCarry) AluResult += (byte)(AluResult > 255 ? 1 : 0);
                return (UInt16)(AluResult & 0xFF);
            }
        }

        //temp Data to hold result as 16bit to check for overflow
        private UInt32 AluResult;

        //Constructor
        public ALU(Register _op1, Register _op2, FlagsRegister _flags)
        {
            //Connect the operand registers and flag register.
            A = _op2;
            B = _op1;
            Flags = _flags;
        }

        //ALU doesnt read anything from bus, however this function is still called every clock pulse
        //so it is a good time to update flags if needed
        public override void SetData(UInt16 data)
        {
            if (Flags.Load)
            {
                Flags.FlagsBits.ZeroFlag = IsZero;
                Flags.FlagsBits.CarryFlag = CarryOut;
            }
        }

        //Bit Field Definition
        [BitFieldNumberOfBits(4)]
        public struct ModeSelectField : IBitField
        {
            [BitFieldInfo(0x03, 1)] public bool S3 { get; set; }
            [BitFieldInfo(0x02, 1)] public bool S2 { get; set; }
            [BitFieldInfo(0x01, 1)] public bool S1 { get; set; }
            [BitFieldInfo(0x00, 1)] public bool S0 { get; set; }


            public static implicit operator byte(ModeSelectField content) => (byte)content.ToUInt64();
            public static explicit operator ModeSelectField(ulong content) => BitFieldExtensions.CreateBitField<ModeSelectField>(content);
        }
    }
}
