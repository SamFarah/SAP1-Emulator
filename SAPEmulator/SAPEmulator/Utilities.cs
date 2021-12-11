using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public static void arrayCopy16(UInt16[,] Source, UInt16[,,] Dest)
    {
        for (int Flags = 0; Flags < Dest.GetLength(0); Flags++)
            for (int Instruction = 0; Instruction < Dest.GetLength(1); Instruction++)
                for (int Step = 0; Step < Dest.GetLength(2); Step++)
                    Dest[Flags, Instruction, Step] = Source[Instruction, Step];
    }

    public static void arrayCopy32(UInt32[,] Source, UInt32[,,] Dest)
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
    public static void RadomizeArray(byte[] MEM)
    {
        Random r = new Random(Guid.NewGuid().GetHashCode());
        for (int i = 0; i < MEM.Length; i++) MEM[i] = (byte)r.Next(0, 0xFF);
    }
}


/// <summary>
/// A textbox the does syntax highlighting.
/// </summary>
public class SyntaxHighlightingTextBox : RichTextBox
{
    #region Members            
    private bool mParsing = false;
    public System.Windows.Forms.Label theLabel;

    //Undo/Redo members
    private ArrayList mUndoList = new ArrayList();
    private Stack mRedoStack = new Stack();
    private bool mIsUndo = false;
    private UndoRedoInfo mLastInfo = new UndoRedoInfo("", 0);
    private int mMaxUndoRedoSteps = 50;

    #endregion

    #region Properties
    /// <summary>
    /// Set the maximum amount of Undo/Redo steps.
    /// </summary>
    [Category("Behavior")]
    public int MaxUndoRedoSteps
    {
        get { return mMaxUndoRedoSteps; }
        set { mMaxUndoRedoSteps = value; }
    }
    #endregion

    #region Overriden methods
    public void BeginUpdate()
    {
        SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)0, IntPtr.Zero);
    }
    public void EndUpdate()
    {
        SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
        this.Invalidate();
    }
    [DllImport("user32.dll")]
    private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    private const int WM_SETREDRAW = 0x0b;
    /// <summary>
    /// The on text changed overrided. Here we parse the text into RTF for the highlighting.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnTextChanged(EventArgs e)
    {
        if (mParsing) return;
        mParsing = true;
        base.OnTextChanged(e);

        if (!mIsUndo)
        {
            mRedoStack.Clear();
            mUndoList.Insert(0, mLastInfo);
            this.LimitUndo();
            mLastInfo = new UndoRedoInfo(Text, SelectionStart);
        }

        /*
         * Credit:
         * Patrik :https://stackoverflow.com/users/116249/patrick
         * Source: https://stackoverflow.com/a/7924069/14953410             
         */

        // getting keywords/functions
        string keywords = @"\b(add|adi|ana|ani|call|cma|dcr|hlt|in|inr|jm|jc|jmp|jnz|jz|lda|mov|mvi|nop|ora|ori|out|ral|rar|ret|sta|sti|sub|sbi|xra|xri|pha|pla)\b";
        MatchCollection keywordMatches = Regex.Matches(Text, keywords, RegexOptions.IgnoreCase);



        // getting comments (inline or multiline)
        string comments = @"(\;.+?$)";
        MatchCollection commentMatches = Regex.Matches(Text, comments, RegexOptions.Multiline);

        // getting strings
        string strings = "\".+?\"";
        MatchCollection stringMatches = Regex.Matches(Text, strings);

        string numbers = @"\b((0x(\d|[abcdef])+)|\d+|(0b([01]+)))\b";
        MatchCollection numberMatches = Regex.Matches(Text, numbers, RegexOptions.IgnoreCase);

        string labels = @"^( |\t)*(\w+:)";
        MatchCollection labelMatches = Regex.Matches(Text, labels,RegexOptions.Multiline );

        string compiler = @"(#\w+)";
        MatchCollection compilerMatches = Regex.Matches(Text, compiler);


        // saving the original caret position + forecolor
        int originalIndex = SelectionStart;
        int originalLength = SelectionLength;
        Color originalColor = Color.Black;
        Font originalFont = Font;

        theLabel.Focus();

        // removes any previous highlighting (so modified words won't remain highlighted)
        SelectionStart = 0;
        SelectionLength = Text.Length;
        SelectionColor = originalColor;
        SelectionFont = originalFont;

        // scanning...
        foreach (Match m in keywordMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Blue;
        }

        foreach (Match m in compilerMatches )
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.DarkCyan;
        }

        foreach (Match m in numberMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Orange;
        }

        List<string> Labels = new List<string>();
        foreach (Match m in labelMatches)
        {
            Labels.Add(m.Value.Replace(":", ""));
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Maroon;
            SelectionFont = new Font(SelectionFont, FontStyle.Bold);
        }

        foreach (Match m in commentMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Green;
        }

        foreach (Match m in stringMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Brown;
        }

        //color every label in code with maroon (but not bold)
        string inCodeLabels = $"\\b({string.Join("|", Labels)})\\b";
        MatchCollection inCodeLabelMatches = Regex.Matches(Text, inCodeLabels);
        foreach (Match m in inCodeLabelMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Maroon;
        }

        foreach (Match m in commentMatches)
        {
            SelectionStart = m.Index;
            SelectionLength = m.Length;
            SelectionColor = Color.Green;
        }

        // restoring the original colors, for further writing
        SelectionStart = originalIndex;
        SelectionLength = originalLength;
        SelectionColor = originalColor;
        SelectionFont = originalFont;
        mParsing = false;
        Focus();
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == Win32.WM_KEYDOWN)
        {
            if (((Keys)(int)m.WParam == Keys.Z) &&
               ((Win32.GetKeyState(Win32.VK_CONTROL) & Win32.KS_KEYDOWN) != 0))
            {
                Undo();
                return;
            }
            else if (((Keys)(int)m.WParam == Keys.Y) &&
                ((Win32.GetKeyState(Win32.VK_CONTROL) & Win32.KS_KEYDOWN) != 0))
            {
                Redo();
                return;
            }
        }
        base.WndProc(ref m);
    }
    #endregion

    #region Undo/Redo Code
    public new bool CanUndo
    {
        get { return mUndoList.Count > 0; }
    }
    public new bool CanRedo
    {
        get { return mRedoStack.Count > 0; }
    }

    private void LimitUndo()
    {
        while (mUndoList.Count > mMaxUndoRedoSteps) mUndoList.RemoveAt(mMaxUndoRedoSteps);
    }

    public new void Undo()
    {
        if (!CanUndo) return;

        theLabel.Focus();
        mIsUndo = true;
        mRedoStack.Push(new UndoRedoInfo(Text, SelectionStart));
        UndoRedoInfo info = (UndoRedoInfo)mUndoList[0];
        mUndoList.RemoveAt(0);        
        Text = info.Text;
        SelectionStart = info.CursorLocation;
        //SetScrollPos(info.ScrollPos);
        mLastInfo = info;
        mIsUndo = false;

        Focus();
    }
    public new void Redo()
    {
        if (!CanRedo) return;
        theLabel.Focus();
        mIsUndo = true;
        mUndoList.Insert(0, new UndoRedoInfo(Text, SelectionStart));
        LimitUndo();
        UndoRedoInfo info = (UndoRedoInfo)mRedoStack.Pop();
        Text = info.Text;
        SelectionStart = info.CursorLocation;        
        mIsUndo = false;
        Focus();
    }

    private class UndoRedoInfo
    {
        public UndoRedoInfo(string text, int cursorLoc)
        {
            Text = text;            
            CursorLocation = cursorLoc;
        }
        public readonly int CursorLocation;
        public readonly string Text;
    }
    #endregion
}

public class Win32
{  
    public const int WM_KEYDOWN = 0x100;    
    public const int VK_CONTROL = 0x11;   
    public const short KS_KEYDOWN = 0x80;    
    [DllImport("user32")] public static extern short GetKeyState(int nVirtKey);    
}