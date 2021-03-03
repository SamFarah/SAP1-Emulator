using System;

namespace SAP2Modules
{
    public class Counter : Register
    {
        //Control Signals
        public bool Count { get; set; } // If enabled the counter will increment on each read.
        public bool sReset { get; set; }
        //Constructor
        public Counter(UInt16 mask = 0xFFFF) : base(mask, mask) { Data = 0x0000; }

        //update its value
        public override void SetData(UInt16 data = 0x00)
        {
            base.SetData(data);           
            if (Count) Data = (UInt16)(Data + 1); //Increament the Program Counter if CE is enabled
        }


    }
}

