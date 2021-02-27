using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public static class Utilities
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeMessage
    {
        public IntPtr Handle;
        public uint Message;
        public IntPtr WParameter;
        public IntPtr LParameter;
        public uint Time;
        public Point Location;
    }

    [DllImport("user32.dll")]
    public static extern int PeekMessage(out NativeMessage message, IntPtr window, uint filterMin, uint filterMax, uint remove);
    public static void NOP(double durationSeconds)
    {
        var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
        var sw = Stopwatch.StartNew();

        while (sw.ElapsedTicks < durationTicks)
        {

        }
    }

    /// <summary>
    /// Copies Source Array into Dest Array "Copies" times
    /// </summary>
    /// <param name="Source"></param>
    /// <param name="Dest"></param>
    /// <param name="copies"></param>
    public static void arrayCopy(UInt16[,] Source, UInt16[,,] Dest)
    {
        for (int Flags = 0; Flags < Dest.GetLength(0); Flags++)
            for (int Instruction = 0; Instruction < Dest.GetLength(1); Instruction++)
                for (int Step = 0; Step < Dest.GetLength(2); Step++)
                    Dest[Flags, Instruction, Step] = Source[Instruction, Step];
    }

    /// <summary>
    /// Randomizes the array conent
    /// </summary>
    /// <param name="MEM">The array to randomize</param>
    public  static void RadomizeArray(byte[] MEM)
    {
        Random r = new Random(Guid.NewGuid().GetHashCode());
        for (int i = 0; i < MEM.Length; i++) MEM[i] = (byte)r.Next(0, 0xFF);
    }
}
