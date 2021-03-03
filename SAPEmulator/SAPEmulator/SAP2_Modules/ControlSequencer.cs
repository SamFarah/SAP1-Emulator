using System;
using BitField;

namespace SAP2Modules
{
    public class ControlSequencer
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
        private UInt32[,,] uCode { get; set; } //Internal EEPROM that holds all the uCode sequences

        public ControlSequencer(Register instructionRegister, Register flags)
        {
            StepCounter = new Counter(); //not connected to bus no need to set up masks.
            StepCounter.Count = true; //always counting 

            //connect the devices to the control sequencer 
            InstructionRegister = instructionRegister;
            FlagsRegister = flags;

            InitUCode(); //generate "ROM" of microinstructions
        }

        public ControlWordBitField GetControlWord(bool init = false)
        {
            // when computer is reset it already has step 0 loaded. so next time it gets control word it will step to the next step, unless it is initializing
            if (!init) StepCounter.SetData(); // Increment Step counter by setting its value to 0x0000. It doesnt not affect its data "Load" signal is inactive            
            if ((Decoder & 0x40000) == 0 || StepCounter.sReset ) StepCounter.Reset(); // if the decoded output is 0x00100000 then it reached step 5 and needs to reset
                                                            //there are better ways, but this mirrors Ben Eater's implementation 

            //uCode address is defined by [FlagValue][InstructionValue][StepValue]
            //Get the uCode address
            byte FlagValue = (byte)(FlagsRegister.Data & 0x03);
            byte InstructionValue = (byte)((InstructionRegister.Data & 0xFF));
            byte StepValue = (byte)(StepCounter.Data & 0x1F);            
            return (ControlWordBitField)uCode[FlagValue, InstructionValue, StepValue]; //return uCode
        }

        // Mostly used for display purposes. however it also resets the stepcounter.
        // this is to reflect Ben Eater's implementation by reseting the step counter using the output of the decoder
        public UInt32 Decoder
        {
            get
            {
                UInt32 Decoded = (UInt32)~(UInt32)Math.Pow(2, StepCounter.Data); //inverse the output (Active LOW)                
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
        const UInt32 HLT = 0b10000000000000000000000000000000;      // Hault Clock...........................(Stop the Clock)
        const UInt32 MI = 0b01000000000000000000000000000000;       // Memory Address Register.......In......(Read from Bus)
        const UInt32 RI = 0b00100000000000000000000000000000;       // RAM (at current MAR value)....In......(Read from Bus)
        const UInt32 RO = 0b00010000000000000000000000000000;       // RAM (at current MAR value)....Out.....(Write to Bus)
        const UInt32 IO = 0b00001000000000000000000000000000;       // Instruction Register..........Out.....(Write to Bus)
        const UInt32 II = 0b00000100000000000000000000000000;       // Instruction Register..........In......(Read from Bus)
        const UInt32 AI = 0b00000010000000000000000000000000;       // Accumilator A Register........In......(Read from Bus)
        const UInt32 AO = 0b00000001000000000000000000000000;       // Accumilator A Register........Out.....(Write to Bus)
        const UInt32 EO = 0b00000000100000000000000000000000;       // SUM ALu.......................Out.....(Write to Bus)
        const UInt32 SU = 0b00000000010000000000000000000000;       // Subtract..............................(Changes ALU to subtract)
        const UInt32 BI = 0b00000000001000000000000000000000;       // Accumilator B Register........In......(Read from Bus)
        const UInt32 OI = 0b00000000000100000000000000000000;       // Output Register...............In......(Read From Bus)
        const UInt32 CE = 0b00000000000010000000000000000000;       // Program Counter Enable................(Increment PC)
        const UInt32 CO = 0b00000000000001000000000000000000;       // Program Counter...............Out.....(Write to Bus)
        const UInt32 JMP = 0b00000000000000100000000000000000;      // Program Counter...............In......(Read from Bus)
        const UInt32 FI = 0b00000000000000010000000000000000;       // Flags Register................In......(Read flags from Sum ALU)
        const UInt32 RT = 0b00000000000000001000000000000000;       // Reset Step Counter
        const UInt32 MDI =0b00000000000000000100000000000000;       // MDR In
        const UInt32 MDO =0b00000000000000000010000000000000;       // MDR out
        const UInt32 MDS =0b00000000000000000001000000000000;       // MDR Shift
        const UInt32 TI = 0b00000000000000000000100000000000;       // Temp Reg In
        const UInt32 TO = 0b00000000000000000000010000000000;       // Temp Reg Out
        const UInt32 BO = 0b00000000000000000000001000000000;       // B out


        const byte FLASGS_Z0C0 = 0;
        const byte FLASGS_Z0C1 = 1;
        const byte FLASGS_Z1C0 = 2;
        const byte FLASGS_Z1C1 = 3;
        const byte JZ = 0x08;
        const byte JC = 0x07;



        //Micro instructions Set template
        private static readonly UInt32[,] uCodeTmeplate =
            {            
/*            T0 -FETCH- T1           T2          T3          T4                    Unused                  OpCode  INST
            -----     --------      -----       -----       -----                   ------                  ------  ----  */
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 00 - NOP         -- OLD
            {MI|CO,    RO|II|CE,     IO|MI,      RO|AI,      RT,             0,0,0,0,0,0,0,0,0,0,0,0,0},    // 01 - LDA         -- OLD
            {MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI|FI,       0,0,0,0,0,0,0,0,0,0,0,0,0},    // 02 - ADD         -- OLD
            {MI|CO,    RO|II|CE,     IO|MI,      RO|BI,      EO|AI|SU|FI,    0,0,0,0,0,0,0,0,0,0,0,0,0},    // 03 - SUB         -- OLD
            {MI|CO,    RO|II|CE,     IO|MI,      AO|RI,      RT,             0,0,0,0,0,0,0,0,0,0,0,0,0},    // 04 - STA         -- OLD
            {MI|CO,    RO|II|CE,     IO|AI,      RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 05 - LDI         -- OLD
            {MI|CO,    RO|II|CE,     IO|JMP,     RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 06 - JMP         -- OLD
            {MI|CO,    RO|II|CE,     0,          RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 07 - JC          -- OLD
            {MI|CO,    RO|II|CE,     0,          RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 08 - JZ          -- OLD
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 09 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     AO|OI,      RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0E - OUT         -- OLD
            {MI|CO,    RO|II|CE,     HLT,        RT,         0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 0F - HLT         -- OLD              
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 10 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 11 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 12 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 13 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 14 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 15 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 16 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 17 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 18 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 19 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 1F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 20 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 21 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 22 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 23 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 24 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 25 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 26 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 27 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 28 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 29 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 2F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 30 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 31 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 32 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 33 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 34 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 35 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 36 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 37 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 38 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 39 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     MI|CO,      RO|MDI|CE,  MI|CO,    RO|MDI|MDS|CE,   MDO|MI,     RO|AI|RT,    0,0,0,0,0,0,0,0,0,0},    // 3A - LDA, Address
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 3B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 3C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 3D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 3E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 3F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 40 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 41 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 42 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 43 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 44 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 45 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 46 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 47 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 48 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 49 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 4F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 50 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 51 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 52 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 53 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 54 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 55 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 56 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 57 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 58 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 59 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 5F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 60 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 61 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 62 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 63 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 64 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 65 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 66 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 67 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 68 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 69 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 6F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 70 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 71 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 72 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 73 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 74 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 75 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     HLT,         RT,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 76 - HLT
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 77 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     AO|BI|RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 78 - MOV A,B
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 79 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 7F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     BO|TI,         EO|AI|FI|RT,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 80 - ADB
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 81 - ADC
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 82 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 83 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 84 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 85 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 86 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 87 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 88 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 89 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 8F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 90 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 91 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 92 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 93 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 94 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 95 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 96 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 97 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 98 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 99 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9A - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9B - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9C - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9D - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9E - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // 9F - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // A9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AD - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // AF - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // B9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BD - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // BF - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // C9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CD - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // CF - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // D9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DD - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // DF - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // E9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // EA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // EB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // EC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // ED - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // EE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // EF - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F0 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F1 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F2 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F3 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F4 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F5 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F6 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F7 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F8 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // F9 - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FA - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FB - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FC - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FD - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FE - <Available for Future Use>
            {MI|CO,    RO|II|CE,     RT,         0,          0,              0,0,0,0,0,0,0,0,0,0,0,0,0},    // FF - <Available for Future Use>
    };

        void InitUCode()
        {
            uCode = new UInt32[4, 256, 18];
            Utilities.arrayCopy32(uCodeTmeplate, uCode);

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
        [BitFieldNumberOfBits(32)]
        public struct ControlWordBitField : IBitField
        {
            [BitFieldInfo(0x1F, 1)] public bool HLT { get; set; }
            [BitFieldInfo(0x1E, 1)] public bool MI { get; set; }
            [BitFieldInfo(0x1D, 1)] public bool RI { get; set; }
            [BitFieldInfo(0x1C, 1)] public bool RO { get; set; }
            [BitFieldInfo(0x1B, 1)] public bool IO { get; set; }
            [BitFieldInfo(0x1A, 1)] public bool II { get; set; }
            [BitFieldInfo(0x19, 1)] public bool AI { get; set; }
            [BitFieldInfo(0x18, 1)] public bool AO { get; set; }
            [BitFieldInfo(0x17, 1)] public bool SO { get; set; }
            [BitFieldInfo(0x16, 1)] public bool SUB { get; set; }
            [BitFieldInfo(0x15, 1)] public bool BI { get; set; }
            [BitFieldInfo(0x14, 1)] public bool OI { get; set; }
            [BitFieldInfo(0x13, 1)] public bool CE { get; set; }
            [BitFieldInfo(0x12, 1)] public bool CO { get; set; }
            [BitFieldInfo(0x11, 1)] public bool JMP { get; set; }
            [BitFieldInfo(0x10, 1)] public bool FI { get; set; }
            [BitFieldInfo(0x0F, 1)] public bool RT { get; set; }
            [BitFieldInfo(0x0E, 1)] public bool MDI { get; set; }
            [BitFieldInfo(0x0D, 1)] public bool MDO { get; set; }
            [BitFieldInfo(0x0C, 1)] public bool MDS { get; set; }
            [BitFieldInfo(0x0B, 1)] public bool TI { get; set; }
            [BitFieldInfo(0x0A, 1)] public bool TO { get; set; }
            [BitFieldInfo(0x09, 1)] public bool BO { get; set; }
            [BitFieldInfo(0x08, 1)] public bool NA6 { get; set; }
            [BitFieldInfo(0x07, 1)] public bool NA7 { get; set; }
            [BitFieldInfo(0x06, 1)] public bool NA8 { get; set; }
            [BitFieldInfo(0x05, 1)] public bool NA9 { get; set; }
            [BitFieldInfo(0x04, 1)] public bool NAa { get; set; }
            [BitFieldInfo(0x03, 1)] public bool NAb { get; set; }
            [BitFieldInfo(0x02, 1)] public bool NAc { get; set; }
            [BitFieldInfo(0x01, 1)] public bool NAd { get; set; }
            [BitFieldInfo(0x00, 1)] public bool NAe { get; set; }


            public static implicit operator UInt32(ControlWordBitField content) => (UInt32)content.ToUInt64();
            public static explicit operator ControlWordBitField(ulong content) => BitFieldExtensions.CreateBitField<ControlWordBitField>(content);
        }

    }
}
