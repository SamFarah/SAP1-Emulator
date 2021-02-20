using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SRAM
{
    public byte[] MEM { get; set; }

    public bool Load { get; set; } //if active will read from bus (active high)
    public bool Enable { get; set; } //if active will write to bus (active high)

    private Register MAR { get; set; }

    public byte Data
    {
        get
        {
            return MEM[MAR.Data & 0x0F];
        }
    }

    public SRAM(Register mar)
    {
        MEM = new byte[16]; //16 Byte memory
        //randomize memory values (to simulate "garbage memory")
        Random r=new Random((int)DateTime.Now.Ticks );
        for (int i = 0; i < 16; i++) MEM[i] =(byte) r.Next(0, 0xFF);
        MAR = mar;
    }


    public void Read(byte address,byte data) { if (Load) MEM[address] = data; }
    public virtual byte? Write(byte address) { if (Enable) return MEM[address]; return null; }
}

