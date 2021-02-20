using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Counter : Register
{
    public Counter() : base(0x0F) { Data = 0x00; }

    public void Inc()
    {
        Data = (byte)((Data + 1) & 0X0f);
    }


}

