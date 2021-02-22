using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ControlLogic
{
    /*
     * This is made to copy Ben Eater's method of filling micro instruction EEPROM instea of being the most optimized way
     */
    public ControlLogic(Register instructionRegister, Register flags)
    {
        MicroCounter = new Counter(0x05);
        MicroCounter.Count = true;
        InstructionRegister = instructionRegister;
        FlagsRegister = flags;

        InitUCode();

    }

    private Register InstructionRegister;
    private Register FlagsRegister;

    public UInt16 GetControlWord(bool Init = false)
    {
        if (!Init) MicroCounter.Inc();


        byte Flags = (byte)(FlagsRegister.Data & 0x03);
        byte Instruction = (byte)((InstructionRegister.Data & 0xF0) >> 4);
        byte Step = (byte)(MicroCounter.Data & 0x07);


        return uCode[Flags,Instruction,Step];
    }

    public Counter MicroCounter { get; set; }
    public byte Decoder
    {
        get
        {
            byte Decoded = (byte)~(byte)Math.Pow(2, (MicroCounter.Data & 0x07));
            if ((Decoded & 0x20) == 0) MicroCounter.Reset();
            return Decoded;
        }
    }

    public void Reset()
    {
        MicroCounter.Reset();
    }

    //Control Signals

    const UInt16 HLT = 0b1000000000000000;      // Hault.................................(Stop the Clock)
    const UInt16 MI = 0b0100000000000000;       // Memory Address Register.......In......(Read from Bus)
    const UInt16 RI = 0b0010000000000000;       // RAM (at current MAR value)....In......(Read from Bus)
    const UInt16 RO = 0b0001000000000000;       // RAM (at current MAR value)....Out.....(Write to Bus)
    const UInt16 IO = 0b0000100000000000;       // Instruction Register..........Out.....(Write to Bus)
    const UInt16 II = 0b0000010000000000;       // Instruction Register..........In......(Read from Bus)
    const UInt16 AI = 0b0000001000000000;       // Accumilator A Register........In......(Read from Bus)
    const UInt16 AO = 0b0000000100000000;       // Accumilator A Register........Out.....(Write to Bus)
    const UInt16 EO = 0b0000000010000000;       // SUM ALu.......................Out.....(Write to Bus)
    const UInt16 SU = 0b0000000001000000;       // Subtract..............................(Changes ALU to subtract)
    const UInt16 BI = 0b0000000000100000;       // Accumilator B Register........In......(Read from Bus)
    const UInt16 OI = 0b0000000000010000;       // Output Register...............In......(Read From Bus)
    const UInt16 CE = 0b0000000000001000;       // Program Counter Enable................(Increment PC)
    const UInt16 CO = 0b0000000000000100;       // Program Counter...............Out.....(Write to Bus)
    const UInt16 JMP = 0b0000000000000010;      // Program Counter...............In......(Read from Bus)
    const UInt16 FI = 0b0000000000000001;       // Flags Register................In......(Read flags from Sum ALU)

    const byte FLASGS_C0Z0 = 0;
    const byte FLASGS_C0Z1 = 1;
    const byte FLASGS_C1Z0 = 2;
    const byte FLASGS_C1Z1 = 3;
    const byte JZ = 0x08;
    const byte JC = 0x07;

    UInt16[,,] uCode;



    //Micro instructions Set 
    private static readonly UInt16[,] uCodeTmeplate =
        {            
/*                             T0 -FETCH- T1           T2          T3          T4            Unused      OpCode  INST
                             -----     --------      -----       -----       -----           ------      ------  ----  */
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 0000 - NOP  
            {MI|CO,    RO|II|CE,     IO|MI,      RO|AI,      0,              0,0,0},    // 0001 - LDA   
            {MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI|FI,       0,0,0},    // 0010 - ADD
            {MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI|SU|FI,    0,0,0},    // 0011 - SUB  
            {MI|CO,    RO|II|CE,     IO|MI,      AO|RI,      0,              0,0,0},    // 0100 - STA  
            {MI|CO,    RO|II|CE,     IO|AI,      0,          0,              0,0,0},    // 0101 - LDI  
            {MI|CO,    RO|II|CE,     IO|JMP,     0,          0,              0,0,0},    // 0110 - JMP  
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 0111 - JC  
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1000 - JZ  
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1001 -   
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1010 -   
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1011 -   
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1100 -   
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1101 -        
            {MI|CO,    RO|II|CE,     AO|OI,      0,          0,              0,0,0},    // 1110 - OUT    
            {MI|CO,    RO|II|CE,     HLT,        0,          0,              0,0,0},    // 1111 - HLT            
    };

    void InitUCode()
    {
        uCode = new UInt16[4,16,8];// {   (UInt16[,])uCodeTmeplate.Clone(), (UInt16[,])uCodeTmeplate.Clone(), (UInt16[,])uCodeTmeplate.Clone(), (UInt16[,,])uCodeTmeplate.Clone() };
        arrayCopy(uCodeTmeplate, ref uCode);


        
        // CF = 0, ZF = 0
        // No change

        // CF = 0, ZF = 1        
        uCode[FLASGS_C0Z1,JZ,2] = IO | JMP;

        // CF = 1, ZF = 0        
        uCode[FLASGS_C1Z0,JC,2] = IO | JMP;

        // CF = 1, ZF = 1        
        uCode[FLASGS_C1Z1,JC,2] = IO | JMP;
        uCode[FLASGS_C1Z1,JZ,2] = IO | JMP;
        

    }

    void arrayCopy(UInt16[,] Source , ref UInt16[,,] Dest)
    {
        for (int Flags = 0; Flags < 4; Flags++)
            for (int Instruction = 0; Instruction < 16; Instruction++)
                for (int Step = 0; Step < 8; Step++)
                    Dest[Flags, Instruction, Step] = Source[Instruction, Step];
    }

}

