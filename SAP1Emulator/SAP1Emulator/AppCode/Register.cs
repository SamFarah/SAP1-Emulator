using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Register
{
    public Register(byte mask = 0xFF) {
        Mask = mask;
        Load = false ;
        Enable = false;
    }
    public virtual bool Load { get; set; } //if active will read from bus (active HIHG)
    public bool Enable { get; set; } //if active will write to bus (active HIHG)
    protected byte Mask { get; set; }

    public virtual byte Data { get; set; }

    public virtual void Read(byte data) { if (Load) Data = (byte)(data & Mask); }
    public virtual byte? Write() { if (Enable) return (byte)(Data & Mask); return null; }    
    public void Reset()
    {
        Data = 0x00;
    }
}



