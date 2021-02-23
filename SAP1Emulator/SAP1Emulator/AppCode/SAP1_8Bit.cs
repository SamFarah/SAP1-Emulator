using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SAP1_8Bit
{
    public SAP1_8Bit()
    {
        Clock = new ClockGenerator(RisingEdge, FallingEdge);
        Bus = new Bus();
        Flags = new Register(0x03) { Enable = true };//always enabled 
        CL = new ControlLogic(Bus.Inst, Flags);
        ControlWord = CL.GetControlWord(true);
    }

    public ClockGenerator Clock { get; set; }
    public Bus Bus { get; set; }
    public ControlLogic CL { get; set; }

    public Register Flags { get; set; }

    public UInt16 ControlWord
    {
        get
        {
            return (UInt16)(((Clock.Hault ? 1 : 0) << 15) |
                            ((Bus.MAR.Load ? 1 : 0) << 14) |
                            ((Bus.RAM.Load ? 1 : 0) << 13) |
                            ((Bus.RAM.Enable ? 1 : 0) << 12) |
                            ((Bus.Inst.Enable ? 1 : 0) << 11) |
                            ((Bus.Inst.Load ? 1 : 0) << 10) |
                            ((Bus.A.Load ? 1 : 0) << 9) |
                            ((Bus.A.Enable ? 1 : 0) << 8) |
                            ((Bus.Sum.Enable ? 1 : 0) << 7) |
                            ((Bus.Sum.Subtract ? 1 : 0) << 6) |
                            ((Bus.B.Load ? 1 : 0) << 5) |
                            ((Bus.Output.Load ? 1 : 0) << 4) |
                            ((Bus.PC.Count ? 1 : 0) << 3) |
                            ((Bus.PC.Enable ? 1 : 0) << 2) |
                            ((Bus.PC.Load ? 1 : 0) << 1) |
                            ((Flags.Load ? 1 : 0) << 0)) ;

        }
        set
        {
            Clock.Hault = (value & 0x8000) > 0;
            Bus.MAR.Load = (value & 0x4000) > 0;
            Bus.RAM.Load = (value & 0x2000) > 0;
            Bus.RAM.Enable = (value & 0x1000) > 0;
            Bus.Inst.Enable = (value & 0x0800) > 0;
            Bus.Inst.Load = (value & 0x0400) > 0;
            Bus.A.Load = (value & 0x0200) > 0;
            Bus.A.Enable = (value & 0x0100) > 0;
            Bus.Sum.Enable = (value & 0x0080) > 0;
            Bus.Sum.Subtract = (value & 0x0040) > 0;
            Bus.B.Load = (value & 0x0020) > 0;
            Bus.Output.Load = (value & 0x0010) > 0;
            Bus.PC.Count = (value & 0x0008) > 0;
            Bus.PC.Enable = (value & 0x0004) > 0;
            Bus.PC.Load = (value & 0x0002) > 0;
            Flags.Load = (value & 0x0001) > 0;
        }
    }


    private void RisingEdge()
    {      
        Bus.PulseDevices();

        //update flags;        
        Flags.Read((byte)(((Bus.Sum.CarryOut ? 1 : 0) << 1) | ((Bus.Sum.IsZero ? 1 : 0) << 0))); //>LOAD CF ZF               
    }

    private void FallingEdge()
    {        
        ControlWord = CL.GetControlWord();        
    }

    public void Reset()
    {
        Clock.Stop();        
        Clock.Hault = false;
        Bus.Reset();
        Flags.Reset();
        CL.Reset();
        if (Clock.ClockMode == ClockGenerator.ClockModes.Auto) Clock.Start();
    }  
}

