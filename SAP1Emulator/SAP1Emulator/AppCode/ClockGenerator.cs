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
    public bool OutputInverse { get { return !Output; } }

    private Thread thread { get; set; }
    public ClockGenerator()
    {
        thread = new Thread(Toggle);
        ClockMode = ClockModes.SignleStep;
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
        switch (thread.ThreadState)
        {
            case ThreadState.Running: break;
            case ThreadState.Suspended: thread.Resume(); break;
            case ThreadState.Stopped: thread.Start(); break;
            case ThreadState.Unstarted: thread.Start(); break;
        }

    }

    public void Stop()
    {
        if (thread.ThreadState == ThreadState.Running || thread.ThreadState == ThreadState.WaitSleepJoin) thread.Suspend();

    }
    public void Step()
    { Output = !Output; }
}

