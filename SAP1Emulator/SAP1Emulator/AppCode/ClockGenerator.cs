using System.Threading;

public class ClockGenerator
{
    public enum ClockModes
    {
        Auto,
        SignleStep
    }

    public int Frequency { get; set; }
    public ClockModes ClockMode { get; set; }
    public bool Output { get; set; }
    public bool Halt { get; set; }

    private Thread thread { get; set; }

    public delegate void PulseFunctionDel();
    public PulseFunctionDel RisingEdge;
    public PulseFunctionDel FallingEdge;

    public ClockGenerator(int frequency, PulseFunctionDel RisingEdgeHandler, PulseFunctionDel FallingEdgeHandler,ClockModes clockMode)
    {
        thread = new Thread(Pulse);
        ClockMode = clockMode;
        RisingEdge = RisingEdgeHandler;
        FallingEdge = FallingEdgeHandler;
        Frequency = frequency; //Hz
    }

    public void Step()
    {
        if (!Halt)
        {
            Output = !Output;
            if (Output) RisingEdge();
            else FallingEdge();
        }
    }

    private void Pulse()
    {
        while (true)
        {
            Step();
            Utilities.NOP(1.0 / Frequency / 2.0); //delay half the frequency cycle
        }
    }

    public void Start()
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
        if (thread.ThreadState == ThreadState.Running || thread.ThreadState == ThreadState.WaitSleepJoin)
        {
            thread.Suspend();
            while ((thread.ThreadState & ThreadState.SuspendRequested) > 0) ;//wait until it is suspended
        }
        Output = false;
    }

}

