using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Register
{
    public Register(byte mask = 0xFF) { Mask = mask; }
    public bool Load { get; set; } //if active will read from bus (active high)
    public bool Enable { get; set; } //if active will write to bus (active high)
    private byte Mask { get; set; }

    public virtual byte Data { get; set; }

    public void Read(byte data) { if (Load) Data = (byte)(data & Mask); }
    public virtual byte? Write() { if (Enable) return (byte)(Data & Mask); return null; }    
}

