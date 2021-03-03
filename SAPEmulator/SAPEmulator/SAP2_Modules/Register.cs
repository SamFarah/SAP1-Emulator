using System;

namespace SAP2Modules
{
    public class Register
    {

        //Control signals and outputs
        public virtual bool Load { get; set; } //if active will read from bus (active HIHG)
        public bool Enable { get; set; } //if active will write to bus (active HIHG)
        protected UInt16 MaskIn { get; set; } //represents connections from Bus into device, Defaults to 0xFF (8bits)
        protected UInt16 MaskOut { get; set; }//represents connections from device into bus, Defaults to 0xFF (8bits)
        public virtual UInt16 Data { get; set; }

        public Register(UInt16 maskIn = 0xFFFF, UInt16 maskOut = 0xFFFF)
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
        public virtual void SetData(UInt16 data) { if (Load) Data = (UInt16)(data & MaskIn); }

        /// <summary>
        /// Output - Only gets the data value if control signal "Enable" is active
        /// </summary>
        /// <returns>Returns its data if control signal "Enable" is active. otherwise returns null (tri-state)</returns>
        public virtual UInt16? GetData() { if (Enable) return (UInt16)(Data & MaskOut); return null; }
        public void Reset()
        {
            Data = 0x0000;
            Load = false;
            Enable = false;
        }
    }
}


