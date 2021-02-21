using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ControlLogic
{

    public ControlLogic(Register instructionRegister)
    {
        MicroCounter = new Counter(0x05);
        MicroCounter.Count = true;
        InstructionRegister = instructionRegister;
    }

    private Register InstructionRegister;

    public UInt16 GetControlWord(bool Init = false)
    {
        if (!Init) MicroCounter.Inc();
        return MicroInstructionSet[((InstructionRegister.Data & 0xF0) >> 1) | (MicroCounter.Data & 0x07)];
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

    const UInt16 HLT= 0b1000000000000000;
    const UInt16 MI = 0b0100000000000000;
    const UInt16 RI = 0b0010000000000000;
    const UInt16 RO = 0b0001000000000000;
    const UInt16 IO = 0b0000100000000000;
    const UInt16 II = 0b0000010000000000;
    const UInt16 AI = 0b0000001000000000;
    const UInt16 AO = 0b0000000100000000;
    const UInt16 EO = 0b0000000010000000;
    const UInt16 SU = 0b0000000001000000;
    const UInt16 BI = 0b0000000000100000;
    const UInt16 OI = 0b0000000000010000;
    const UInt16 CE = 0b0000000000001000;
    const UInt16 CO = 0b0000000000000100;
    const UInt16 JMP= 0b0000000000000010;
    const UInt16 FF = 0b0000000000000001;



    //Micro instructions Set 
    private static readonly UInt16[] MicroInstructionSet =
        {            
/*            T0 -FETCH- T1           T2          T3          T4        Unused      OpCode  INST
            -----     --------      -----       -----       -----       ------      ------  ----  */
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 0000 - NOP  
            MI|CO,    RO|II|CE,     IO|MI,      RO|AI,      0,          0,0,0,    // 0001 - LDA   
            MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI,      0,0,0,    // 0010 - ADD
            MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI|SU,   0,0,0,    // 0011 - SUB  
            MI|CO,    RO|II|CE,     IO|MI,      AO|RI,      0,          0,0,0,    // 0100 - STA  
            MI|CO,    RO|II|CE,     IO|AI,      0,          0,          0,0,0,    // 0101 - LDI  
            MI|CO,    RO|II|CE,     IO|JMP,     0,          0,          0,0,0,    // 0110 - JMP  
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 0111 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1000 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1001 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1010 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1011 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1100 -   
            MI|CO,    RO|II|CE,     0,          0,          0,          0,0,0,    // 1101 -        
            MI|CO,    RO|II|CE,     AO|OI,      0,          0,          0,0,0,    // 1110 - OUT    
            MI|CO,    RO|II|CE,     HLT,        0,          0,          0,0,0,    // 1111 - HLT    
        };


}

