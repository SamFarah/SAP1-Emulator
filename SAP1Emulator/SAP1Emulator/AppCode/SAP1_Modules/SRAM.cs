namespace SAP1Modules
{
    class SRAM : Register
    {
        /*
                   RAM Block Diagram
             +----------------------------+
             |                            |
             |   +---------+              |       
             |   |   MAR   |              |
             |   +---------+              |
             |        |                   |
             |        v (4)               |
             |   +---------+              |
             |   |   RAM   | ==> (Data)   |
             |   |  (16x8) |              |
             |   +---------+              |
             |                            |
             +----------------------------+  
        */

        //Connected Devices as shown in the figure above 
        private Register MAR { get; set; } //Points at the "active" memory location    
        public byte[] MEM { get; set; } // Memory Array where data is stored

        // When getting data, read the data at the current MAR value.
        public override byte Data { get { return MEM[MAR.Data & 0x0F]; } }

        //Constructor
        public SRAM(Register mar)
        {
            MEM = new byte[16]; // Create the memory array
            MAR = mar; //Connected the MAR to it
            Load = false;
            Enable = false;
            Utilities.RadomizeArray(MEM);  //randomize memory values (to simulate "garbage memory")
        }
        public override void SetData(byte data) { if (Load) MEM[MAR.Data] = data; } //Update the data at MAR location.
        public override byte? GetData() { if (Enable) return MEM[MAR.Data]; return null; } //Get the data at MAR location
    }
}
