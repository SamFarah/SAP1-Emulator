﻿using System;
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
    public bool Hault { get; set; }

    private Thread thread { get; set; }

    public delegate void PulseFunctionDel();
    public PulseFunctionDel RisingEdge;
    public PulseFunctionDel FallingEdge;

    public ClockGenerator(PulseFunctionDel RisingEdgeHandler, PulseFunctionDel FallingEdgeHandler)
    {
        thread = new Thread(Pulse);
        ClockMode = ClockModes.SignleStep;
        RisingEdge = RisingEdgeHandler;
        FallingEdge = FallingEdgeHandler;
    }


    private void Pulse()
    {
        while (true)
        {
            if (!Hault)
            {
                Output = !Output;
                if (Output) RisingEdge();
                else FallingEdge();
            }
            Thread.Sleep((int)(1000 / Frequency / 2));


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
        Output = false;

    }
    public void Step()
    {
        if (!Hault)
        {
            Output = !Output;
            if (Output) RisingEdge();
            else FallingEdge();
        }
    }
}

