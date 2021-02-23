class Bus
{
    /*
         +-------------------------------------------------+
         |                         .                       |
         |                        / \                      |
         |                       /   \                     |
         |                       |   |                     |
         |                       |BUS|      4 +--------+   |
         |                       |   | <====> |   PC   |   |   
         |                       |   | 4      +--------+   |
         |                       |   |                     |
         |      +-------+ 4      |   |      8 +---------+  |
         |      |  MAR  | <===== |   | <====> |  A Reg  |  |     
         |      +-------+        |   | 8      +---------+  |
         |          |            |   |            |        |    
         |          v            |   |            v        |    
         |      +-------+ 8      |   |        +---------+  |      
         |      |  RAM  | <====> |   | <===== |   SUM   |  |      
         |      +-------+      8 |BUS| 8      +---------+  |      
         |                       |   |            ^        |    
         | +------------+ 8      |   |            |        |    
         | |  Inst Reg  | <====> |   |      8 +---------+  | 
         | +------------+      4 |   | =====> |  B Reg  |  |
         |                       |   |        +---------+  |
         |                       |   |                     |
         |                       |   |      8 +----------+ |
         |                       |   | =====> |  Output  | |
         |                       |BUS|        +----------+ |
         |                       |   |                     |
         |                       \   /                     |
         |                        \ /                      |
         |                         '                       |
         +-------------------------------------------------+   
    */

    //Connected Devices
    public Register A { get; set; }         // Accumilator "A" Register
    public Register B { get; set; }         // Accumilator "B" Register
    public Register Inst { get; set; }      // Instruction Register
    public Register MAR { get; set; }       // Memory Address Register
    public Register Output { get; set; }    // Output Register
    public ALU Sum { get; set; }            // Adder / Subtracter 
    public SRAM RAM { get; set; }           // Random Access Memory
    public Counter PC { get; set; }         // Program Counter

    // "Data" Reflects the "enabled" device's data, note that it is not "stored" anywhere, since the bus is not a device with memory it's a read only property
    public byte Data { get { return ReadDataFromConnectedDevices(); } }

    //Constructor
    public Bus()
    {
        //Connect the devices to the bus
        A = new Register();
        B = new Register();
        Inst = new Register(maskOut:0x0F); //Instruction Register only connects to bus with 4 LSB, thus the maskOut=0x0F
        MAR = new Register(maskIn: 0x0F); // MAR gets a 0x0F mask since it's only a 4 bit register, no need to set maskOut since it never puts on BUS
        Output = new Register();
        Sum = new ALU(A, B); // Connect A Reg and B Reg as operands to the ALU
        RAM = new SRAM(MAR); // Connect MAR as the address pointer to the RAM  
        PC = new Counter(mask: 0x0F);   //PC is a 4 Bit counter so gets a 4bit mask
    }

    //Reset everything connected to the BUS
    public void Reset()
    {
        A.Reset();
        B.Reset();
        Inst.Reset();
        Sum.Reset();
        MAR.Reset();
        PC.Reset();
        Output.Reset();
    }

    //Pulse Every device on the Bus and read/write from/to bus depending on each device's control signal
    public void PulseDevices()
    {
        byte dataOnBus = Data; //Store in local variable to prevent reading devices multiple times.

        //If a device's "Load" signal is active then it will take tha value, otherwise it will ignore it
        A.Read(dataOnBus);
        B.Read(dataOnBus);
        Inst.Read(dataOnBus);
        MAR.Read(dataOnBus);
        RAM.Read(dataOnBus);
        PC.Read(dataOnBus);
        Output.Read(dataOnBus);

        //Increament the Program Counter if CE is enabled
        PC.Inc();
    }

    // Get the enabled device's data
    private byte ReadDataFromConnectedDevices()
    {
        //As long as the control logic doesnt "Enable" more than one device on the bus then the 
        //output sum will be the value of the one enable device
        //if more than one device is enabled at once. the Bus value will be "unpredictable"
        return (byte)(PC.Write() + A.Write() + Sum.Write() + Inst.Write()  + RAM.Write());        
    }
}

