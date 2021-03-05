using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP2Modules
{
    public class Buffer : Register
    {

        public bool Shift { get; set; }

        public Buffer(UInt16 maskIn = 0xFFFF, UInt16 maskOut = 0xFFFF) : base(maskIn, maskOut) { }


        public override void SetData(UInt16 data)
        {
            if (Load)
            {
                if (Shift) Data |= (UInt16)(data << 8);
                else Data = (UInt16)(data & MaskIn);

            }
        }

    }
}
