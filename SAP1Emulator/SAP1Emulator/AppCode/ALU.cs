using System;

class ALU : Register
{
    //Connected Devices
    /*
         +-----------------------------------+
         |  ~~~~~                            |
         |  |   |        +---------------+   |  
         |  |BUS| <====> |  Op1 (A Reg)  |   |
         |  |   |        +---------------+   |
         |  |   |            |               |
         |  |   |            v               |
         |  |   |     +-------------+        |     
         |  |BUS| <== |   ADD/SUB   |        |     
         |  |   |     +-------------+        |     
         |  |   |            ^               |
         |  |   |            |               |
         |  |   |        +---------------+   |     
         |  |BUS| =====> |  Op2 (B Reg)  |   |    
         |  |   |        +---------------+   |
         |  ~~~~~                            |
         +-----------------------------------+
    */

    private Register Op1 { get; set; } // First operand of the operation
    private Register Op2 { get; set; } // Second operand of the operation

    //Signals
    public bool Subtract { get; set; } //if active will will Subtract (Active HIGH)
    public bool CarryIn { get; set; } //Ability to take exteranl Carry in
    public bool CarryOut { get { return AluResult > 255; } } //Active if result of operation caused an overflow
    public bool IsZero { get { return (AluResult & 0xFF) == 0; } } //Active if result of operation is zero

    //Constructor
    public ALU(Register _op1, Register _op2)
    {
        //Connect the operand registers.
        Op1 = _op1;
        Op2 = _op2;
    }

    //temp Data to hold result as 16bit to check for overflow
    private UInt16 AluResult;

    //ALU's data is not "stored" anywhere, it is however the continuous addition (or subtraction) result of Op1 and Op2 at any given time.
    public override byte Data
    {
        get
        {
            //                  |   Op1   + If subtract then take 2's compt of Op2, else Op2 +    add carry if it's set
            AluResult = (UInt16)(Op1.Data + (Subtract ? (byte)(~Op2.Data + 0x01) : Op2.Data) + (byte)(CarryIn ? 1 : 0));
            return (byte)AluResult;
        }
    }
}

