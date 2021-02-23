using System;
namespace SAP1Modules
{
    class ALU : Register
    {
        /*
                            ALU Block Diagram
             +---------------------------------------------+
             |                                             |
             |            +---------------+                |  
             |            |  Op1 (A Reg)  |                |
             |            +---------------+                |
             |                |                            |
             |                v                            |
             |            +-------------+     +---------+  |     
             | (DATA) <== |   ADD/SUB   | ==> |  Flags  |  |     
             |            +-------------+     +---------+  |     
             |                ^                            |
             |                |                            |
             |            +---------------+                |     
             |            |  Op2 (B Reg)  |                |    
             |            +---------------+                |
             |                                             |
             +---------------------------------------------+
        */

        //Connected Devices as shown in the figure above 
        private Register Op1 { get; set; } // First operand of the operation
        private Register Op2 { get; set; } // Second operand of the operation
        private FlagsRegister Flags { get; set; } // the flags to be stored after each operation

        //Control signals and outputs
        public bool Subtract { get; set; } //if active will will Subtract (Active HIGH)
        public bool CarryIn { get; set; } //Ability to take exteranl Carry in
        public bool CarryOut { get { return AluResult > 255; } } //Active if result of operation caused an overflow
        public bool IsZero { get { return (AluResult & 0xFF) == 0; } } //Active if result of operation is zero     
        public override byte Data
        {   //ALU's data is not "stored" anywhere, it is however the continuous addition (or subtraction) result of Op1 and Op2 at any given time.
            get
            {
                //Op1 + (If subtract then take 2's compt of Op2, else Op2) + add carry if it's set
                AluResult = (UInt16)(Op1.Data + (Subtract ? (byte)(~Op2.Data + 0x01) : Op2.Data) + (byte)(CarryIn ? 1 : 0));
                return (byte)AluResult;
            }
        }

        //temp Data to hold result as 16bit to check for overflow
        private UInt16 AluResult;

        //Constructor
        public ALU(Register _op1, Register _op2, FlagsRegister _flags)
        {
            //Connect the operand registers and flag register.
            Op1 = _op1;
            Op2 = _op2;
            Flags = _flags;
        }

        //ALU doesnt read anything from bus, however this function is still called every clock pulse
        //so it is a good time to update flags if needed
        public override void SetData(byte data)
        {
            if (Flags.Load)
            {
                Flags.FlagsBits.ZeroFlag = IsZero;
                Flags.FlagsBits.CarryFlag = CarryOut;
            }
        }
    }
}
