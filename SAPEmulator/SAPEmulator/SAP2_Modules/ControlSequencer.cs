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
            if ((Decoder & 0x40000) == 0 || StepCounter.sReset) StepCounter.Reset(); // if the decoded output is 0x00100000 then it reached step 5 and needs to reset
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
        const UInt32 AC = 0b00001000000000000000000000000000;       // Add with Carry
        const UInt32 II = 0b00000100000000000000000000000000;       // Instruction Register..........In......(Read from Bus)
        const UInt32 AI = 0b00000010000000000000000000000000;       // Accumilator A Register........In......(Read from Bus)
        const UInt32 AO = 0b00000001000000000000000000000000;       // Accumilator A Register........Out.....(Write to Bus)
        const UInt32 EO = 0b00000000100000000000000000000000;       // SUM ALu.......................Out.....(Write to Bus)
        const UInt32 BO = 0b00000000010000000000000000000000;       // B Out -------------------------------------------
        const UInt32 BI = 0b00000000001000000000000000000000;       // Accumilator B Register........In......(Read from Bus)
        const UInt32 OI = 0b00000000000100000000000000000000;       // Output Register...............In......(Read From Bus)
        const UInt32 CE = 0b00000000000010000000000000000000;       // Program Counter Enable................(Increment PC)
        const UInt32 PCO = 0b00000000000001000000000000000000;      // Program Counter...............Out.....(Write to Bus)
        const UInt32 JMP = 0b00000000000000100000000000000000;      // Program Counter...............In......(Read from Bus)
        const UInt32 FI = 0b00000000000000010000000000000000;       // Flags Register................In......(Read flags from Sum ALU)
        const UInt32 RT = 0b00000000000000001000000000000000;       // Reset Step Counter
        const UInt32 MDI = 0b00000000000000000100000000000000;      // MDR In
        const UInt32 MDO = 0b00000000000000000010000000000000;      // MDR out
        const UInt32 MDS = 0b00000000000000000001000000000000;      // MDR Shift
        const UInt32 TI = 0b00000000000000000000100000000000;       // Temp Reg In
        const UInt32 MO = 0b00000000000000000000010000000000;       // Memory Address Register.......Out......(Write to Bus)
        const UInt32 CO = 0b00000000000000000000001000000000;       // C out
        const UInt32 CI = 0b00000000000000000000000100000000;       // C In
        const UInt32 M = 0b00000000000000000000000010000000;        // ALU M In
        const UInt32 S3 = 0b00000000000000000000000001000000;       // ALU Mode Select 3 In
        const UInt32 S2 = 0b00000000000000000000000000100000;       // ALU Mode Select 2 In
        const UInt32 S1 = 0b00000000000000000000000000010000;       // ALU Mode Select 1 In
        const UInt32 S0 = 0b00000000000000000000000000001000;       // ALU Mode Select 0 In
        const UInt32 CRI = 0b00000000000000000000000000000100;      // Carry In In
        const UInt32 TO =  0b00000000000000000000000000000010;      // Temp Reg Out





        const byte FLASGS_Z0C0 = 0;
        const byte FLASGS_Z0C1 = 1;
        const byte FLASGS_Z1C0 = 2;
        const byte FLASGS_Z1C1 = 3;
        const byte JM = 0xFA;
        const byte JNZ = 0xC2;
        const byte JZ = 0xCA;

        /*
            +-------------------+---------+-------------+-----------+---------------+-------+-------------------------------------------------------+-------------------+
            |    Instruction	| Op Code |	 T States	|   Flags   |   Addressing 	| Bytes	|                     Description						|       Type        |
            +-------------------+---------+-------------+-----------+---------------+-------+-------------------------------------------------------+-------------------+
         x  |   ADD B			|    80   |     4	    |	S, Z	|   Register    |   1   |   A = A + B											|   Arithmetic      |
         x  |   ADD C			|    81   |     4	    |	S, Z	|   Register    |   1   |   A = A + C											|   Arithmetic      |
         x  |   ANA B			|    A0   |     4	    |	S, Z	|   Register    |   1   |   A = A . B											|   Logical         |
         x  |   ANA C			|    A1   |     4	    |	S, Z	|   Register    |   1   |   A = A . C											|   Logical         |
         x  |   ANI byte		|    E6   |     5	    |	S, Z	|   Immediate   |   2   |   A = A . (1 byte immediate data)						|   Logical         |
            |   CALL address	|    CD   |     ??	    |	None	|   Immediate   |   3   |   Call subrotine 										|   Branching       |
         x  |   CMA				|    2F   |     4	    |	None	|   Implied     |   1   |   A = A’												|   Logical         |
         x  |   DCR A			|    3D   |     4	    |	S, Z	|   Register    |   1   |   A = A - 1											|   Arithmetic      |
         x  |   DCR B			|    05   |     4	    |	S, Z	|   Register    |   1   |   B = B - 1											|   Arithmetic      |
         x  |   DCR C			|    0D   |     4	    |	S, Z	|   Register    |   1   |   C = C - 1											|   Arithmetic      |
         x  |   HLT 			|    76   |     3	    |	None 	|   -		    |   1   |   Terminate program									|   -               |
            |   IN byte			|    DB   |     ??	    |	None 	|   Direct	    |   2   |   Transfer the Data from Input port to Accumulator	|   Data Transfer   |
         x  |   INR A			|    3C   |     4	    |	S, Z 	|   Register    |   1   |   A = A + 1											|   Arithmetic      |
         x  |   INR B			|    04   |     4	    |	S, Z 	|   Register    |   1   |   B = B + 1											|   Arithmetic      |
         x  |   INR C			|    0C   |     4	    |	S, Z 	|   Register    |   1   |   C = C + 1											|   Arithmetic      |
         x  |   JM address		|    FA   |     7       |	None 	|   Immediate   |   3   |   Jump on minus to specified Address					|   Branching       |
         x  |   JMP address		|    C3   |     7	    |	None 	|   Immediate   |   3   |   Jump to specified Address							|   Branching       |
         x  |   JNZ address		|    C2   |     7       |	None 	|   Immediate   |   3   |   Jump on Not Zero to specified Address				|   Branching       |
         x  |   JZ address		|    CA   |     7       |	None 	|   Immediate   |   3   |   Jump on zero to specified Address					|   Branching       |
         x  |   LDA address		|    3A   |     8	    |	None 	|   Direct	    |   3   |   Load A with value in specified address				|   Data Transfer   |
         x  |   MOV A,B			|    78   |     3	    |	None 	|   Register    |   1   |   Copy the content of B to A 							|   Data Transfer   |
         x  |   MOV A,C			|    79   |     3	    |	None 	|   Register    |   1   |   Copy the content of C to A 							|   Data Transfer   |
         x  |   MOV B,A			|    47   |     3	    |	None 	|   Register    |   1   |   Copy the content of A to B 							|   Data Transfer   |
         x  |   MOV B,C			|    41   |     3	    |	None 	|   Register    |   1   |   Copy the content of C to B 							|   Data Transfer   |
         x  |   MOV C,A			|    4F   |     3	    |	None 	|   Register    |   1   |   Copy the content of A to C 							|   Data Transfer   |
         x  |   MOV C,B			|    48   |     3	    |	None 	|   Register    |   1   |   Copy the content of B to C 							|   Data Transfer   |
         x  |   MVI A,byte		|    3E   |     5	    |	None 	|   Immediate   |   2   |   Load 1 byte immediate data to accumulator			|   Data Transfer   |
         x  |   MVI B,byte		|    06   |     5	    |	None 	|   Immediate   |   2   |   Load 1 byte immediate data to B Regster				|   Data Transfer   |
         x  |   MVI C,byte		|    0E   |     5	    |	None 	|   Immediate   |   2   |   Load 1 byte immediate data to C register			|   Data Transfer   |
         x  |   NOP 			|    00   |     3	    |	None 	|   -		    |   1   |   No Operation 										|   -               |
         x  |   ORA B 			|    B0   |     4	    |	S, Z 	|   Register    |   1   |   A = A or B											|   Logical         |
         x  |   ORA C 			|    B1   |     4	    |	S, Z 	|   Register    |   1   |   A = A or C											|   Logical         |
         x  |   ORI byte 		|    F6   |     5	    |	S, Z 	|   Immediate   |   2   |   A = A  or (1 byte immediate data)					|   Logical         |
         ?  |   OUT byte 		|    D3   |     ??	    |	None 	|   Direct	    |   2   |   Transfer content of Accumulator to output port		|   Data Transfer   |
         x  |   RAL 			|    17   |     4	    |	None 	|   Implied	    |   1   |   Rotate left Accumulator content						|   Logical         |
         x  |   RAR 			|    1F   |     10	    |	None 	|   Implied	    |   1   |   Rotate Right Accumulator content					|   Logical         |
            |   RET 			|    C9   |     ??	    |	None 	|   Implied	    |   1   |   Return												|   Branching       |
         x  |   STA address 	|    32   |     8	    |	None 	|   Direct	    |   3   |   Store Accumulator content to memory					|   Data Transfer   |
         x  |   SUB B 			|    90   |     5	    |	S, Z 	|   Register    |   1   |   A = A - B											|   Arithmetic      |
         x  |   SUB C 			|    91   |     5	    |	S, Z 	|   Register    |   1   |   A = A - C 											|   Arithmetic      |
         x  |   XRA B 			|    A8   |     4	    |	S, Z 	|   Register    |   1   |   A = A xor B											|   Logical         |
         x  |   XRA C 			|    A9   |     4	    |	S, Z 	|   Register    |   1   |   A = A xor C											|   Logical         |
         x  |   XRI byte 		|    EE   |     5	    |	S, Z 	|   Immediate   |   2   |   A = A xor (1 byte immediate data)					|   Logical         |
         x  |   STA [address]   |    01   |     15	    |	None	|   Indirect    |   3   |   Store Accumulator content to memory at valof address|   Logical         |
            +-------------------+---------+-------------+-----------+---------------+-------+-------------------------------------------------------+-------------------+


             */


        //Micro instructions Set template
        private static readonly UInt32[,] uCodeTmeplate =
            {            
/*            T0 -FETCH- T1           T2          T3                       T4                           T5                  T6                  T7                  T8                  T9                        Unused               OpCode INST
            -----     --------      -----       -----                     -----                         ----               -----               -----               ----                ----                       ------              ------  ----  */
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 00 - NOP
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,     PCO|TI, MDO|MI ,RO|MDI,              MO|JMP|CE, PCO|MI    ,RO|MDI|MDS,TO|JMP, MDO|MI,AO|RI|RT,0,0,0},    // 01 - STA [Address] (Indirect)
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 02 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 03 - 
            {MI|PCO,    RO|II|CE,     BO|TI,      CRI|FI|EO|BI|RT,          0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 04 - INR B
            {MI|PCO,    RO|II|CE,     BO|TI,      S0|S1|S2|S3|FI|EO|BI|RT,  0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 05 - DCR B
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MDO|BI|RT,                  0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 06 - MVI B,byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 07 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 08 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 09 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0B - 
            {MI|PCO,    RO|II|CE,     CO|TI,      CRI|FI|EO|CI|RT,          0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0C - INR C
            {MI|PCO,    RO|II|CE,     CO|TI,      S0|S1|S2|S3|EO|FI|CI|RT,  0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0D - DCR C
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MDO|CI|RT,                  0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0E - MVI C,byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 0F - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 10 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 11 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 12 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 13 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 14 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 15 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 16 - 
            {MI|PCO,    RO|II|CE,     AO|TI,      S3|S2|EO|AI|RT|AC,        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 17 - RAL
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 18 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 19 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 1A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 1B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 1C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 1D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 1E - 
            {MI|PCO,    RO|II|CE,     AO|TI,      S3|S2|EO|TI|AC,           S3|S2|EO|TI|AC,             S3|S2|EO|TI|AC,     S3|S2|EO|TI|AC,     S3|S2|EO|TI|AC,     S3|S2|EO|TI|AC,     S3|S2|EO|AI|RT|AC,      0,0,0,0,0,0,0,0},    // 1F - RAR (rotates left 7 times, ugly but works)
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 20 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 21 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 22 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 23 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 24 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 25 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 26 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 27 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 28 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 29 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2E - 
            {MI|PCO,    RO|II|CE,     AO|TI,      EO|AI|M|RT,               0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 2F - CMA
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 30 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 31 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      MDO|MI,             AO|RI|RT,           0,                  0,                      0,0,0,0,0,0,0,0},    // 32 - STA address
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 33 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 34 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 35 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 36 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 37 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 38 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 39 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      MDO|MI,             RO|AI|RT,           0,                  0,                      0,0,0,0,0,0,0,0},    // 3A - LDA, Address
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 3B - 
            {MI|PCO,    RO|II|CE,     AO|TI,      CRI|FI|EO|AI|RT,          0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 3C - INR A
            {MI|PCO,    RO|II|CE,     AO|TI,      S0|S1|S2|S3|EO|FI|AI|RT,  0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 3D - DCR A
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MDO|AI|RT,                  0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 3E - MVI A,byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 3F - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 40 - 
            {MI|PCO,    RO|II|CE,     BI|CO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 41 - MOV B,C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 42 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 43 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 44 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 45 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 46 - 
            {MI|PCO,    RO|II|CE,     BI|AO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 47 - MOV B,A
            {MI|PCO,    RO|II|CE,     CI|BO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 48 - MOV C,B
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 49 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4E - 
            {MI|PCO,    RO|II|CE,     CI|AO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 4F - MOV C,A
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 50 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 51 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 52 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 53 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 54 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 55 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 56 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 57 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 58 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 59 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5E - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 5F - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 60 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 61 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 62 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 63 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 64 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 65 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 66 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 67 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 68 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 69 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6E - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 6F - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 70 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 71 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 72 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 73 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 74 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 75 - 
            {MI|PCO,    RO|II|CE,     HLT,        0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 76 - HLT
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 77 - 
            {MI|PCO,    RO|II|CE,     AI|BO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 78 - MOV A,B
            {MI|PCO,    RO|II|CE,     AI|CO|RT,   0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 79 - MOV A,C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7E - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 7F - 
            {MI|PCO,    RO|II|CE,     BO|TI,      EO|AI|S3|S0|FI|RT,        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 80 - ADD B
            {MI|PCO,    RO|II|CE,     CO|TI,      EO|AI|S3|S0|FI|RT,        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 81 - ADD C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 82 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 83 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 84 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 85 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 86 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 87 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 88 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 89 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8E - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 8F - 
            {MI|PCO,    RO|II|CE,     AO|TI,      BO|AI,                    EO|AI|FI|CRI|S2|S1|FI|RT,   0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 90 - SUB B
            {MI|PCO,    RO|II|CE,     AO|TI,      CO|AI,                    EO|AI|FI|CRI|S2|S1|FI|RT,   0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 91 - SUB C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 92 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 93 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 94 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 95 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 96 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 97 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 98 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 99 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9A - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9B - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9C - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9D - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9E - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // 9F - 
            {MI|PCO,    RO|II|CE,     BO|TI,      EO|AI|FI|S3|S1|S0|FI|M|RT,0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A0 - ANA B
            {MI|PCO,    RO|II|CE,     CO|TI,      EO|AI|FI|S3|S1|S0|FI|M|RT,0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A1 - ANA C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A2 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A3 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A5 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A6 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A7 - 
            {MI|PCO,    RO|II|CE,     BO|TI,      EO|AI|FI|S2|S1|FI|M|RT,   0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A8 - XRA B
            {MI|PCO,    RO|II|CE,     CO|TI,      EO|AI|FI|S2|S1|FI|M|RT,   0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // A9 - XRA C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AA - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AB - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AD - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AE - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // AF - 
            {MI|PCO,    RO|II|CE,     BO|TI,      EO|AI|FI|S3|S2|S1|FI|M|RT,0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B0 - ORA B
            {MI|PCO,    RO|II|CE,     CO|TI,      EO|AI|FI|S3|S2|S1|FI|M|RT,0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B1 - ORA C
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B2 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B3 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B5 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B6 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B7 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B8 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // B9 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BA - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BB - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BD - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BE - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // BF - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C0 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C1 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      RT,                 0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C2 - JNZ address
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      MDO|JMP|RT,         0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C3 - JMP address
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C5 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C6 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C7 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C8 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // C9 - <-
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      RT,                 0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CA - JZ address
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CB - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CD - <-
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CE - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // CF - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D0 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D1 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D2 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                AO|OI|RT,                   0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D3 - OUT - not finished <testing>
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D5 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D6 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D7 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D8 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // D9 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DA - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DB - <-
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DD - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DE - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // DF - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E0 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E1 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E2 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E3 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E5 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|TI,                    EO|AI|FI|S3|S1|S0|FI|M|RT,  0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E6 - ANI byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E7 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E8 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // E9 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // EA - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // EB - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // EC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // ED - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|TI,                    EO|AI|FI|S2|S1|FI|M|RT,     0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // EE - XRI byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // EF - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F0 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F1 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F2 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F3 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F4 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F5 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|TI,                    EO|AI|FI|S3|S2|S1|FI|M|RT,  0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F6 - ORI byte
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F7 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F8 - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // F9 - 
            {MI|PCO,    RO|II|CE,     MI|PCO,     RO|MDI|CE,                MI|PCO,                     RO|MDI|MDS|CE,      RT,                 0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FA - JM address
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FB - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FC - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FD - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FE - 
            {MI|PCO,    RO|II|CE,     RT,         0,                        0,                          0,                  0,                  0,                  0,                  0,                      0,0,0,0,0,0,0,0},    // FF - 
    };

        void InitUCode()
        {
            uCode = new UInt32[4, 256, 18];
            Utilities.arrayCopy32(uCodeTmeplate, uCode);

            // ZF = 0, CF = 0 No change
            uCode[FLASGS_Z0C0, JNZ, 6] = MDO | JMP | RT;

            // ZF = 0, CF = 1        
            uCode[FLASGS_Z0C1, JM, 6] = MDO | JMP | RT;

            // ZF = 1, CF = 0        
            uCode[FLASGS_Z1C0, JZ, 6] = MDO | JMP | RT;

            // ZF = 1, CF = 1        
            uCode[FLASGS_Z1C1, JM, 6] = MDO | JMP | RT;
            uCode[FLASGS_Z1C1, JZ, 6] = MDO | JMP | RT;
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
            [BitFieldInfo(0x1B, 1)] public bool AC { get; set; }
            [BitFieldInfo(0x1A, 1)] public bool II { get; set; }
            [BitFieldInfo(0x19, 1)] public bool AI { get; set; }
            [BitFieldInfo(0x18, 1)] public bool AO { get; set; }
            [BitFieldInfo(0x17, 1)] public bool SO { get; set; }
            [BitFieldInfo(0x16, 1)] public bool BO { get; set; }
            [BitFieldInfo(0x15, 1)] public bool BI { get; set; }
            [BitFieldInfo(0x14, 1)] public bool OI { get; set; }
            [BitFieldInfo(0x13, 1)] public bool CE { get; set; }
            [BitFieldInfo(0x12, 1)] public bool PCO { get; set; }
            [BitFieldInfo(0x11, 1)] public bool JMP { get; set; }
            [BitFieldInfo(0x10, 1)] public bool FI { get; set; }
            [BitFieldInfo(0x0F, 1)] public bool RT { get; set; }
            [BitFieldInfo(0x0E, 1)] public bool MDI { get; set; }
            [BitFieldInfo(0x0D, 1)] public bool MDO { get; set; }
            [BitFieldInfo(0x0C, 1)] public bool MDS { get; set; }
            [BitFieldInfo(0x0B, 1)] public bool TI { get; set; }
            [BitFieldInfo(0x0A, 1)] public bool MO { get; set; }
            [BitFieldInfo(0x09, 1)] public bool CO { get; set; }
            [BitFieldInfo(0x08, 1)] public bool CI { get; set; }
            [BitFieldInfo(0x07, 1)] public bool M { get; set; }
            [BitFieldInfo(0x03, 4)] public byte ALUModeSelect { get; set; }
            [BitFieldInfo(0x02, 1)] public bool CRI { get; set; }
            [BitFieldInfo(0x01, 1)] public bool TO { get; set; }
            [BitFieldInfo(0x00, 1)] public bool NAe { get; set; }


            public static implicit operator UInt32(ControlWordBitField content) => (UInt32)content.ToUInt64();
            public static explicit operator ControlWordBitField(ulong content) => BitFieldExtensions.CreateBitField<ControlWordBitField>(content);
        }
        public enum Instructions
        {
            STA_Ind         =   0x01,
            ADD_B			=   0x80,
            ADD_C			=   0x81,
            ANA_B			=   0xA0,
            ANA_C			=   0xA1,
            ANI     		=   0xE6,
            CALL        	=   0xCD,
            CMA				=   0x2F,
            DCR_A			=   0x3D,
            DCR_B			=   0x05,
            DCR_C			=   0x0D,
            HLT 			=   0x76,
            IN  			=   0xDB,
            INR_A			=   0x3C,
            INR_B			=   0x04,
            INR_C			=   0x0C,
            JM      		=   0xFA,
            JMP     		=   0xC3,
            JNZ     		=   0xC2,
            JZ      		=   0xCA,
            LDA     		=   0x3A,
            MOV_A__B			=   0x78,
            MOV_A__C 		=   0x79,
            MOV_B__A 		=   0x47,
            MOV_B__C		    =   0x41,
            MOV_C__A		    =   0x4F,
            MOV_C__B		    =   0x48,
            MVI_A   		=   0x3E,
            MVI_B   		=   0x06,
            MVI_C   		=   0x0E,
            NOP			    =   0x00,
            ORA_B			=   0xB0,
            ORA_C			=   0xB1,
            ORI     		=   0xF6,
            OUT     		=   0xD3,
            RAL 			=   0x17,
            RAR 			=   0x1F,
            RET 			=   0xC9,
            STA     	    =   0x32,
            SUB_B			=   0x90,
            SUB_C			=   0x91,
            XRA_B			=   0xA8,
            XRA_C			=   0xA9,
            XRI     		=   0xEE,
    }
    }
}
