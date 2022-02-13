using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAP2Modules
{
    public class Buffer : Register
    {

        public bool ShiftLeft { get; set; } 
        public bool ShiftRight { get; set; }

        public Buffer(UInt16 maskIn = 0xFFFF, UInt16 maskOut = 0xFFFF) : base(maskIn, maskOut) { }


        public override void SetData(UInt16 data)
        {
            if (Load)
            {
                if (ShiftLeft) Data = (UInt16)((((data) << 8) & 0xFF00) | (Data & 0x00FF));
                else if(ShiftRight) Data = (UInt16 )(data>>8);
                else Data =(UInt16)(Data & 0xFF00 | (data & 0x00FF));

            }
        }

    }
}
