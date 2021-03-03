using System;

namespace SAP2Modules
{
    public class SRAM : Register
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
        public override UInt16 Data { get { return MEM[MAR.Data & 0xFFFF]; } }

        //Constructor
        public SRAM(Register mar)
        {
            MEM = new byte[65536]; // Create the memory array
            MAR = mar; //Connected the MAR to it
            Load = false;
            Enable = false;
            Utilities.RadomizeArray(MEM);  //randomize memory values (to simulate "garbage memory")
        }
        public override void SetData(UInt16 data) { if (Load) MEM[MAR.Data] = (byte)data; } //Update the data at MAR location.
        public override UInt16? GetData() { if (Enable) return (byte)MEM[MAR.Data]; return null; } //Get the data at MAR location
    }
}
