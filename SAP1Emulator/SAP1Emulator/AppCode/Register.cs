using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Register
{
    public Register()
    { }    
    public bool ClockSignal { get; set; }
    public bool Load { get; set; } //if active will read from bus (active high)
    public bool Enable { get; set; } //if active will write to bus (active high)
    
    public virtual byte Data { get; set; }

    public void Read(byte data)
    {
        if (Load) Data = data;
    }
    public virtual byte? Write()
    {
        if (Enable) return Data;
        return null;
    }
}

