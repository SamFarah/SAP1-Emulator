using System;
using BitField;

namespace SAP1Modules
{
    class ControlSequencer
    {

        /*
             A Control Squencer is connected directly to 4bits of the 
             instruction register and the Flags Register          

             +------------------------------------------------------------+
             |                                                            |
             |                   +-------+    +-----------------+         |
             |                   | Flags |    | Instruction Reg |         |
             |                   +-------+    +-----------------+         |
             |                         |        |                         |
             |                         v (2)    v (4)                     |
             |  +--------------+     +------------+     +--------------+  |
             |  | uCode EEPROM | ==> | Control Sq | <== | Step Counter |  |
             |  +--------------+     +------------+     +--------------+  |            
             |                             |                              |
             |                             v                              |      
             |                      (Control Word)                        |      
             |                                                            |
             +------------------------------------------------------------+   
        */

        // Connected Devices as shown in the figure above
        private Register InstructionRegister { get; set; }
        private Register FlagsRegister { get; set; }
        public Counter StepCounter { get; set; }
        private UInt16[,,] uCode { get; set; } //Internal EEPROM that holds all the uCode sequences

        public ControlSequencer(Register instructionRegister, Register flags)
        {
            StepCounter = new Counter(); //not connected to bus no need to set up masks.
            StepCounter.Count = true; //always counting 

            //connect the devices to the control sequencer 
            InstructionRegister = instructionRegister;
            FlagsRegister = flags;

            InitUCode(); //generate "ROM" of microinstructions
        }

        public ControlWordBitField GetControlWord()
        {
            //uCode address is defined by [FlagValue][InstructionValue][StepValue]
            //Get the uCode address
            byte FlagValue = (byte)(FlagsRegister.Data & 0x03);
            byte InstructionValue = (byte)((InstructionRegister.Data & 0xF0) >> 4);
            byte StepValue = (byte)(StepCounter.Data & 0x07);

            StepCounter.SetData(); // Increment Step counter by setting its value to 0x0000. It doesnt not affect its data "Load" signal is inactive
            return (ControlWordBitField)uCode[FlagValue, InstructionValue, StepValue]; //return uCode
        }

        // Mostly used for display purposes. however it also resets the stepcounter.
        // this is to reflect Ben Eater's implementation by reseting the step counter using the output of the decoder
        public byte Decoder
        {
            get
            {
                byte Decoded = (byte)~(byte)Math.Pow(2, (StepCounter.Data & 0x07)); //inverse the outpuer (Active LOW)
                if ((Decoded & 0x20) == 0) StepCounter.Reset(); // if the decoded output is 0x00100000 then it reached step 6 and needs to reset
                return Decoded;
            }
        }

        // Resetting the Control Sequencer 
        public void Reset() { StepCounter.Reset(); }



        #region uCode EEPROM (Simulation)

        /*****************************************************************************************************************************************
        * 
        * Title: Microcode Eeprom With Flags
        * Author: Ben Eater
        * Date: Apr 21, 2018    
        * Availability: https://github.com/beneater/eeprom-programmer/blob/master/microcode-eeprom-with-flags/microcode-eeprom-with-flags.ino
        * Note: This is not the exact code Ben Eater wrote, since this is doesn't actually program an EEPROM. It just stores 
        *       values in an array which acts as the EEPROM. In other words, We could just directly store the final static content 
        *       of the EEPROM array as values. However, doing it this way follows Ben Eater's idea of keeping it readable and easy
        *       to update in the future if needed.
        * 
        *****************************************************************************************************************************************/

        //Control Signals
        const UInt16 HLT = 0b1000000000000000;      // Hault Clock...........................(Stop the Clock)
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

        const byte FLASGS_Z0C0 = 0;
        const byte FLASGS_Z0C1 = 1;
        const byte FLASGS_Z1C0 = 2;
        const byte FLASGS_Z1C1 = 3;
        const byte JZ = 0x08;
        const byte JC = 0x07;


        //Micro instructions Set template
        private static readonly UInt16[,] uCodeTmeplate =
            {            
/*            T0 -FETCH- T1           T2          T3          T4            Unused      OpCode  INST
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
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1001 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1010 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1011 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1100 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     0,          0,          0,              0,0,0},    // 1101 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     AO|OI,      0,          0,              0,0,0},    // 1110 - OUT    
            {MI|CO,    RO|II|CE,     HLT,        0,          0,              0,0,0},    // 1111 - HLT            
    };

        void InitUCode()
        {
            uCode = new UInt16[4, 16, 8];
            Utilities.arrayCopy(uCodeTmeplate, uCode);

            // ZF = 0, CF = 0 No change

            // ZF = 0, CF = 1        
            uCode[FLASGS_Z0C1, JC, 2] = IO | JMP;

            // ZF = 1, CF = 0        
            uCode[FLASGS_Z1C0, JZ, 2] = IO | JMP;

            // ZF = 1, CF = 1        
            uCode[FLASGS_Z1C1, JC, 2] = IO | JMP;
            uCode[FLASGS_Z1C1, JZ, 2] = IO | JMP;
        }
        #endregion

        //Bit Field Definition
        [BitFieldNumberOfBits(16)]
        public struct ControlWordBitField : IBitField
        {
            [BitFieldInfo(0x0F, 1)] public bool HLT { get; set; }
            [BitFieldInfo(0x0E, 1)] public bool MI { get; set; }
            [BitFieldInfo(0x0D, 1)] public bool RI { get; set; }
            [BitFieldInfo(0x0C, 1)] public bool RO { get; set; }
            [BitFieldInfo(0x0B, 1)] public bool IO { get; set; }
            [BitFieldInfo(0x0A, 1)] public bool II { get; set; }
            [BitFieldInfo(0x09, 1)] public bool AI { get; set; }
            [BitFieldInfo(0x08, 1)] public bool AO { get; set; }
            [BitFieldInfo(0x07, 1)] public bool SO { get; set; }
            [BitFieldInfo(0x06, 1)] public bool SUB { get; set; }
            [BitFieldInfo(0x05, 1)] public bool BI { get; set; }
            [BitFieldInfo(0x04, 1)] public bool OI { get; set; }
            [BitFieldInfo(0x03, 1)] public bool CE { get; set; }
            [BitFieldInfo(0x02, 1)] public bool CO { get; set; }
            [BitFieldInfo(0x01, 1)] public bool JMP { get; set; }
            [BitFieldInfo(0x00, 1)] public bool FI { get; set; }

            public static implicit operator UInt16(ControlWordBitField content) => (UInt16)content.ToUInt64();
            public static explicit operator ControlWordBitField(ulong content) => BitFieldExtensions.CreateBitField<ControlWordBitField>(content);
        }

    }
}
