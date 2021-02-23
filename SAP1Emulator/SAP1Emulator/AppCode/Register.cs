using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Register
{
    public Register(byte maskIn = 0xFF,byte maskOut=0xFF)
    {
        MaskIn = maskIn; 
        MaskOut = maskOut;
        Load = false;
        Enable = false;
    }
    public virtual bool Load { get; set; } //if active will read from bus (active HIHG)
    public bool Enable { get; set; } //if active will write to bus (active HIHG)
    protected byte MaskIn { get; set; } //represents connections from Bus into device, Defaults to 0xFF (8bits)
    protected byte MaskOut { get; set; }//represents connections from device into bus, Defaults to 0xFF (8bits)

    public virtual byte Data { get; set; }

    public virtual void Read(byte data) { if (Load) Data = (byte)(data & MaskIn); }
    public virtual byte Write() { if (Enable) return (byte)(Data & MaskOut); return 0x00; }
    public void Reset()
    {
        Data = 0x00;
        Load = false;
        Enable = false;
    }
}


