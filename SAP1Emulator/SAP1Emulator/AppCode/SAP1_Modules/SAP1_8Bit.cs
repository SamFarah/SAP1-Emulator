using System.Collections.Generic;

namespace SAP1Modules
{
    public class SAP1_8Bit
    {
        /*
                                Inside the SAP1 8Bit CPU
             +------------------------------------------------------------------+
             |                          .                                       |
             |                         / \                                      |
             |                        /   \                                     |
             |                        |   |                                     |
             |     +---------+        |BUS|      4 +--------+                   |
             |     |   CLK   |        |   | <====> |   PC   |                   |   
             |     +---------+        |   | 4      +--------+                   |
             |                        |   |                                     |
             |       +-------+ 4      |   |      8 +---------+                  |
             |       |  MAR  | <===== |   | <====> |  A Reg  |                  |     
             |       +-------+        |   | 8      +---------+                  |
             |           |            |   |            |                        |    
             |           v            |   |            v                        |    
             |       +-------+ 8      |   |        +---------+     +---------+  |      
             |       |  RAM  | <====> |   | <===== |   SUM   | ==> |  Flags  |  |      
             |       +-------+      8 |BUS| 8      +---------+     +---------+  |      
             |                        |   |            ^                        |    
             |  +------------+ 8      |   |            |                        |    
             |  |  Inst Reg  | <====> |   |      8 +---------+                  | 
             |  +------------+      4 |   | =====> |  B Reg  |                  |
             |          |             |   |        +---------+                  |
             |          v             |   |                                     |
             |  +------------+        |   |      8 +----------+                 |
             |  | Control Sq |        |   | =====> |  Output  |                 |
             |  +------------+        |BUS|        +----------+                 |
             |          |             |   |                                     |
             |          v             \   /                                     |
             |  (Control Word)         \ /                                      |
             |                          '                                       |
             +------------------------------------------------------------------+   
        */

        //The CPU has the following modules
        public ClockGenerator Clock { get; set; }   // A clock signal generator to synchronize  all devices together 
        public Bus Bus { get; set; }                // A bus that acts has a "data highway" to allow data transfer from one device to another
        public Register A { get; set; }             // Accumilator "A" Register
        public Register B { get; set; }             // "B" Register
        public Register Inst { get; set; }          // Instruction Register
        public Register MAR { get; set; }           // Memory Address Register
        public Register Output { get; set; }        // Output Register
        public ALU Sum { get; set; }                // Adder / Subtracter 
        public SRAM RAM { get; set; }               // Random Access Memory
        public Counter PC { get; set; }             // Program Counter
        public ControlSequencer CL { get; set; }        // Generates control word depending on instructions to enable/load devices on the bus.
        public FlagsRegister Flags { get; set; }    // A register to hold flags after an operation



        //Constructor: takes frequency and an optional clock mode
        public SAP1_8Bit(int frequency = 1000, ClockGenerator.ClockModes clockMode = ClockGenerator.ClockModes.Auto)
        {
            Flags = new FlagsRegister(0x03); // Create a 2-bit flag register

            // Create the devices and configure how many bits they connect with other devices.
            A = new Register(); //Create an 8-bit register (no mask provided defualts to 8-bit)
            B = new Register(); //Create an 8-bit register
            Inst = new Register(maskOut: 0x0F); //Instruction Register only connects to bus with 4 LSB, thus the maskOut=0x0F, defaults to 8-bit into the Bus
            MAR = new Register(maskIn: 0x0F); // MAR gets a 0x0F mask since it's only a 4 bit register, no need to set maskOut since it never puts on BUS
            Output = new Register(); //Create an 8-bit register
            Sum = new ALU(A, B, Flags); // Connect A Reg and B Reg as operands and the Flags Register to the ALU, 1st Op is also the accumilator
            RAM = new SRAM(MAR); // Connect MAR as the address pointer to the RAM  
            PC = new Counter(mask: 0x0F);   //PC is a 4 Bit counter so gets a 4bit mask

            //Initialize the Bus and connect the devices to it as shown in the figure above.
            Bus = new Bus(new List<Register> { A, B, Inst, MAR, Output, Sum, RAM, PC });

            CL = new ControlSequencer(Inst, Flags); // Control logic is directly connected to the instruction register and flags register.
            Clock = new ClockGenerator(frequency, RisingEdge, FallingEdge, clockMode); // Initialize the clock and tell it what to do on rising edge and faling edge.
            Reset();// Reset everything at creation        
        }


        // Setting ControlWord property will automatically set all the control signals of each device
        // getting the control signal is only used for display purposes (not operationa critical)
        private ControlSequencer.ControlWordBitField mControlWord { get; set; }
        public ControlSequencer.ControlWordBitField ControlWord
        {
            set
            {
                mControlWord = value; //store it for display purposes, to reduce overhead on getting device status every display update

                // Update device control signals
                Clock.Hault = value.HLT;
                MAR.Load = value.MI;
                RAM.Load = value.RI;
                RAM.Enable = value.RO;
                Inst.Enable = value.IO;
                Inst.Load = value.II;
                A.Load = value.AI;
                A.Enable = value.AO;
                Sum.Enable = value.SO;
                Sum.Subtract = value.SUB;
                B.Load = value.BI;
                Output.Load = value.OI;
                PC.Count = value.CE;
                PC.Enable = value.CO;
                PC.Load = value.JMP;
                Flags.Load = value.FI;
            }

            // Create control word (for display purposes) from device control signals
            get { return mControlWord; }
        }

        //At rising edge of clock cycle, any device on the bus will "update" its value from what is on the bus              
        private void RisingEdge() { Bus.UpdateDevices(); }

        //At falling edge of clock cycle it will update the control word
        private void FallingEdge() { ControlWord = CL.GetControlWord(); }

        //Reset the computer
        public void Reset()
        {            
            Clock.Stop();
            Clock.Hault = false;
            Bus.Reset();
            Flags.Reset();
            CL.Reset();
            ControlWord = CL.GetControlWord(true);
            if (Clock.ClockMode == ClockGenerator.ClockModes.Auto) Clock.Start();
        }
    }
}
