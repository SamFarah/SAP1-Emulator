using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SRAM
{
    public byte[] MEM { get; set; }

    public bool Load { get; set; } //if active will read from bus (active HIGH)
    public bool Enable { get; set; } //if active will write to bus (active HIGH)

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
        MEM = new byte[16] { 0x1E,0x2F,0xE0,0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1C,0x0E}; //16 Byte memory
        //randomize memory values (to simulate "garbage memory")
        Random r=new Random((int)DateTime.Now.Ticks );
        for (int i = 4; i < 14; i++) MEM[i] =(byte) r.Next(0, 0xFF);

       

        MAR = mar;
        Load = false;
        Enable = false;
    }


    public void Read(byte data) { if (Load) MEM[MAR.Data & 0x0F] = data; }
    public virtual byte? Write() { if (Enable) return MEM[MAR.Data & 0x0F]; return null; }
}

