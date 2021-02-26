namespace SAP1Modules
{
    class Counter : Register
    {
        //Control Signals
        public bool Count { get; set; } // If enabled the counter will increment on each read.

        //Constructor
        public Counter(byte mask = 0xFF) : base(mask, mask) { Data = 0x00; }

        //update its value
        public override void SetData(byte data = 0x00)
        {
            base.SetData(data);
            if (Count) Data = (byte)(Data + 1); //Increament the Program Counter if CE is enabled
        }


    }
}

