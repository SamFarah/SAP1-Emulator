namespace SAP1Modules
{
    class Register
    {

        //Control signals and outputs
        public virtual bool Load { get; set; } //if active will read from bus (active HIHG)
        public bool Enable { get; set; } //if active will write to bus (active HIHG)
        protected byte MaskIn { get; set; } //represents connections from Bus into device, Defaults to 0xFF (8bits)
        protected byte MaskOut { get; set; }//represents connections from device into bus, Defaults to 0xFF (8bits)
        public virtual byte Data { get; set; }

        public Register(byte maskIn = 0xFF, byte maskOut = 0xFF)
        {
            MaskIn = maskIn;
            MaskOut = maskOut;
            Load = false;
            Enable = false;
        }

        /// <summary>
        /// Input - Updates it's data value from an external input (for example from BUS) only if 
        /// its control signal "Load" is active
        /// </summary>
        /// <param name="data">Data In</param>
        public virtual void SetData(byte data) { if (Load) Data = (byte)(data & MaskIn); }

        /// <summary>
        /// Output - Only gets the data value if control signal "Enable" is active
        /// </summary>
        /// <returns>Returns its data if control signal "Enable" is active. otherwise returns null (tri-state)</returns>
        public virtual byte? GetData() { if (Enable) return (byte)(Data & MaskOut); return null; }
        public void Reset()
        {
            Data = 0x00;
            Load = false;
            Enable = false;
        }
    }
}


