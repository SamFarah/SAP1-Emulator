using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Counter : Register
{
    public Counter(byte mask = 0xFF) : base(mask, mask) { Data = 0x00; }

    public bool Count { get; set; }


    public void Inc()
    {
        if (Count) Data = (byte)(((Data + 1) & 0X0f) % MaskOut);
    }


}

