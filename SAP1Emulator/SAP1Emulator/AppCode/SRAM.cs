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

    public void Radomize()
    {
        Random r = new Random((int)DateTime.Now.Ticks);
        for (int i = 0; i < 16; i++) MEM[i] = (byte)r.Next(0, 0xFF);
    }

    public SRAM(Register mar)
    {
        MEM = new byte[16];// { 0x1F,0x2E,0x3D, 0xE0, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x06,0x05}; //16 Byte memory
                          
        Radomize();  //randomize memory values (to simulate "garbage memory")



         MAR = mar;
        Load = false;
        Enable = false;
    }


    public void Read(byte data) { if (Load) MEM[MAR.Data & 0x0F] = data; }
    public virtual byte? Write() { if (Enable) return MEM[MAR.Data & 0x0F]; return null; }
}

