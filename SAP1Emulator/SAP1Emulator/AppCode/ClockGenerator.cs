using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class ClockGenerator
{



    public enum ClockModes
    {
        Auto,
        SignleStep
    }

    public decimal Frequency { get; set; }
    public ClockModes ClockMode { get; set; }
    public bool Output { get; set; }

    private Thread thread { get; set; }
    public ClockGenerator()
    {
        thread = new Thread(Toggle);        
    }


    private void Toggle()
    {
        while (true)
        {
            Output = !Output;
            Thread.Sleep((int)(1000 / Frequency));
        }
    }
    public void Run()
    {
        thread.Start();
    }
    public void Step()
    { }
}

