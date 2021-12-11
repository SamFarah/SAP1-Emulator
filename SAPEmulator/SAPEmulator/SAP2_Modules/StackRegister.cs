using SAP2Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP2Modules
{
    public class StackRegister : Register
    {
        //Control Signals
        public bool Inc { get; set; } // If enabled the counter will increment on each read.
        public bool Dec { get; set; } // If enabled the counter will dec on each read.
        public bool sReset { get; set; }
        //Constructor
        public StackRegister(UInt16 mask = 0xFFFF) : base(mask, mask) { Data = 0x0000; }

        public override UInt16 Data {
            get => (UInt16)(0xFD00 | (base.Data & 0x00FF)); // Stack location in Memory is between 0xFD00 and 0xFDFF (256 locations)
            set => base.Data = value;
        }

        //update its value
        public override void SetData(UInt16 data = 0x00)
        {
            base.SetData(data);
            if (Inc) Data = (UInt16)(Data + 1); //Increament the Program Counter if CE is enabled
            if (Dec) Data = (UInt16)(Data - 1); //Increament the Program Counter if CE is enabled
        }
    }
}
