

using System.Collections.Generic;

namespace SAP2Modules
{
    public class SAP2_8Bit
    {
        //The CPU has the following modules
        public ClockGenerator Clock { get; set; }   // A clock signal generator to synchronize  all devices together 
        public Bus Bus { get; set; }                // A bus that acts has a "data highway" to allow data transfer from one device to another
        public Register A { get; set; }             // Accumilator "A" Register
        public Register B { get; set; }             // "B" Register
        public Register C { get; set; }             // "C" Register
        public Register Temp { get; set; }          // "Temporary" Register
        public Register IR { get; set; }          // Instruction Register
        public Register MAR { get; set; }           // Memory Address Register
        public Register Output1 { get; set; }        // Output 2 Register Connected to display
        public Register Output2 { get; set; }        // Output 1 Register
        public Buffer MDR { get; set; }           // MEMORY DATA REGISTER

        public Register Input1 { get; set; }        // 
        public Register Input2 { get; set; }        // 

        public ALU Alu { get; set; }                // Adder / Subtracter 
        public SRAM RAM { get; set; }               // Random Access Memory
        public Counter PC { get; set; }             // Program Counter
        public StackRegister SR { get; set; }       // Stack Register
        public ControlSequencer CL { get; set; }    // Generates control word depending on instructions to enable/load devices on the bus.
        public FlagsRegister Flags { get; set; }    // A register to hold flags after an operation


        //Constructor: takes frequency and an optional clock mode
        public SAP2_8Bit(int frequency = 1000, ClockGenerator.ClockModes clockMode = ClockGenerator.ClockModes.Auto)
        {
            Flags = new FlagsRegister(0x07); // Create a 2-bit flag register

            // Create the devices and configure how many bits they connect with other devices.
            A = new Register(0x00FF); //Create an 8-bit register (no mask provided defualts to 8-bit)
            B = new Register(0x00FF); //Create an 8-bit register
            C = new Register(0x00FF); //Create an 8-bit register
            Temp = new Register(0x00FF); //Create an 8-bit register
            IR = new Register(maskOut: 0x00FF); //Instruction Register only connects to bus with 8 LSB, thus the maskOut=0x0F, defaults to 8-bit into the Bus
            MAR = new Register(maskIn: 0xFFFF); // MAR gets a 0x0F mask since it's only a 4 bit register, no need to set maskOut since it never puts on BUS
            MDR = new Buffer(0xFFFF); //Create an 8-bit register
            Output1 = new Register(0x00FF); //Create an 8-bit register
            Output2 = new Register(0x00FF); //Create an 8-bit register
            Input1 = new Register(0x00FF); //Create an 8-bit register
            Input2 = new Register(0x00FF); //Create an 8-bit register
            Alu = new ALU(A, Temp, Flags); // Connect A Reg and B Reg as operands and the Flags Register to the ALU, 1st Op is also the accumilator
            RAM = new SRAM(MAR); // Connect MAR as the address pointer to the RAM  
            PC = new Counter(mask: 0xFFFF);   //PC is a 16 Bit counter so gets a 16bit mask
            SR = new StackRegister(mask: 0xFFFF);   //SR is a 8 Bit counter so gets a 8bit mask

            //Initialize the Bus and connect the devices to it as shown in the figure above.
            Bus = new Bus(new List<Register> { A, B, C, Temp, IR, MAR, Output1, Output2, Alu, RAM, PC, MDR, Input1, Input2, SR });

            CL = new ControlSequencer(IR, Flags); // Control logic is directly connected to the instruction register and flags register.
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
                //return;
                // Update device control signals
                Clock.Halt = value.HLT;
                MAR.Load = value.MI;
                MAR.Enable = value.MO;
                RAM.Load = value.RI;
                RAM.Enable = value.RO;
                IR.Load = value.II;
                A.Load = value.AI;
                A.Enable = value.AO;
                Alu.Enable = value.SO;
                Alu.M = value.M;
                Alu.ModeSelect = (ALU.ModeSelectField)value.ALUModeSelect;
                Alu.CarryIn = value.CRI;
                B.Load = value.BI;
                Output1.Load = value.OI;
                PC.Count = value.CE;
                PC.Enable = value.PCO;
                PC.Load = value.JMP;
                Flags.Load = value.FI;
                CL.StepCounter.sReset = value.RT;
                MDR.Load = value.MDI;
                MDR.Enable = value.MDO;
                MDR.ShiftLeft = value.MDL;
                MDR.ShiftRight = value.MDR;
                Temp.Load = value.TI;
                Temp.Enable = value.TO;
                B.Enable = value.BO;
                C.Enable = value.CO;
                C.Load = value.CI;
                Alu.WithCarry = value.AC;
                SR.Enable = value.SRO;
                SR.Load = value.SRI;
                SR.Inc = value.SRA;
                SR.Dec = value.SRS;
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
            Clock.Halt = false;
            Clock.Counter = 0;
            Bus.Reset();
            Flags.Reset();
            CL.Reset();
            ControlWord = CL.GetControlWord(true);
            if (Clock.ClockMode == ClockGenerator.ClockModes.Auto) Clock.Start();
        }
    }

}

