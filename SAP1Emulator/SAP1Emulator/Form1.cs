using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP1Emulator
{
    public partial class MainForm : Form
    {

        SAP1_8Bit CPU1;
        uint Frames = 0;
        bool updateRAMViewFlag = false, NotPrevCPUOutput = false;
        public MainForm()
        {
            InitializeComponent();
            CPU1 = new SAP1_8Bit();
            CPU1.Clock.Frequency = trackBar1.Value;

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;

        }

        bool IsApplicationIdle()
        {
            Utilities.NativeMessage result;
            return Utilities.PeekMessage(out result, IntPtr.Zero, (uint)0, (uint)0, (uint)0) == 0;
        }
        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {

                updateDisplay(); //label9.Text = DateTime.Now.ToString();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            DisplayLbl.Parent = DisplayShadowLbl;
            DisplayLbl.Location = new Point(0, 0);
        }

        private void ClockModeBtn_Click(object sender, EventArgs e)
        {
            if (CPU1.Clock.ClockMode == ClockGenerator.ClockModes.Auto)
            {
                ClockModeBtn.Text = "Stopped";
                ClockModeBtn.BackColor = Color.Red;
                CPU1.Clock.ClockMode = ClockGenerator.ClockModes.SignleStep;
                CPU1.Clock.Stop();
                StepClockBtn.Enabled = true;
            }
            else
            {
                ClockModeBtn.Text = "Running";
                ClockModeBtn.BackColor = Color.LightGreen;
                CPU1.Clock.ClockMode = ClockGenerator.ClockModes.Auto;
                CPU1.Clock.Start();
                StepClockBtn.Enabled = false;
            }
        }
        void updateDisplay()
        {
            //update LEDS and visual stuff
            ledDisplay2.DisplayData(CPU1.Clock.Output ? 1 : 0);
            BusLEDDisplay.DisplayData(CPU1.Bus.Data);
            ARegLEDDisplay.DisplayData(CPU1.Bus.A.Data);
            BRegLEDDisplay.DisplayData(CPU1.Bus.B.Data);
            InstRegLEDDisplay.DisplayData(CPU1.Bus.Inst.Data);
            SumRegLEDDisplay.DisplayData(CPU1.Bus.Sum.Data);
            MARLEDDisplay.DisplayData(CPU1.Bus.MAR.Data);
            RAMLEDDisplay.DisplayData(CPU1.Bus.RAM.Data);
            PCLEDDisplay.DisplayData(CPU1.Bus.PC.Data);
            OutputRegLEDDisplay.DisplayData(CPU1.Bus.Output.Data);

            SumFlagsLEDDisplay.DisplayData(((CPU1.Bus.Sum.CarryOut ? 1 : 0) << 1) | (CPU1.Bus.Sum.IsZero ? 1 : 0));
            FlagRegLEDDisplay.DisplayData(CPU1.Flags.Data);

            MICounterLEDDisplay.DisplayData(CPU1.CL.MicroCounter.Data, true);
            CLDecodedLEDDisplay.DisplayData(CPU1.CL.Decoder, true);

            BusValLbl.Text = $"0x{CPU1.Bus.Data.ToString("X2")}";
            ARegValLbl.Text = $"0x{CPU1.Bus.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{CPU1.Bus.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{CPU1.Bus.Inst.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{CPU1.Bus.Sum.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{CPU1.Bus.MAR.Data.ToString("X2")}";
            RAMRegValLbl.Text = $"0x{CPU1.Bus.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{CPU1.Bus.PC.Data.ToString("X2")}";
            OutputRegValLbl.Text = $"0x{CPU1.Bus.Output.Data.ToString("X2")}";
            FlagsValLbl.Text = $"0x{CPU1.Flags.Data.ToString("X2")}";



            if (DisplaySignedCB.Checked)
            {
                sbyte outputSigned = (sbyte)CPU1.Bus.Output.Data;
                DisplayLbl.Text = $"{(outputSigned >= 0 ? " " : "") }{outputSigned.ToString("000")}";
            }
            else
            {
                DisplayLbl.Text = CPU1.Bus.Output.Data.ToString(" 000");
            }

            if (updateRAMViewFlag || Frames % 10000 == 0)
            {
                UpdateRamView();
                updateRAMViewFlag = false;
            }

            if (CPU1.Clock.Output != NotPrevCPUOutput)
            {
                updateRAMViewFlag = true;
                NotPrevCPUOutput = CPU1.Clock.Output;
            }
            Frames++;
            StatusLEDDsiaply.DisplayData(CPU1.ControlWord);
        }
        private void UpdateRamView()
        {
            RAMView.Items.Clear();

            for (int i = 0; i < 16; i++)
            {
                string line = $"0x{(i * 1).ToString("X")}:\t";
                for (int j = 0; j < 1; j++) line += $"{CPU1.Bus.RAM.MEM[(i * 1) + j].ToString("X2")}  ";
                RAMView.Items.Add(line);
            }
            RAMView.SelectedIndex = CPU1.Bus.MAR.Data;

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CPU1.Clock.Frequency = trackBar1.Value;
            FreqLbl.Text = "Frequency: " + CPU1.Clock.Frequency.ToString() + "Hz";
        }

        private void StepClockBtn_MouseDown(object sender, MouseEventArgs e) { CPU1.Clock.Step(); }
        private void StepClockBtn_MouseUp(object sender, MouseEventArgs e) { CPU1.Clock.Step(); }
        private void CarryInCB_CheckedChanged(object sender, EventArgs e) { CPU1.Bus.Sum.CarryIn = CarryInCB.Checked; }
        private void ProGramBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte Address = (byte)Convert.ToInt64(ProgRAMAddrTB.Text.Trim(), 16);
                byte Data = (byte)Convert.ToInt64(ProgRamDataTB.Text.Trim(), 16);
                CPU1.Bus.RAM.MEM[Address] = Data;
                UpdateRamView();
                ProgRAMAddrTB.Text = $"0x{((Address + 1) & 0x0F).ToString("X2")}";
                ProgRamDataTB.Text = "0x";
                ProgRamDataTB.Focus();
                ProgRamDataTB.Select(ProgRamDataTB.Text.Length, 0);

            }
            catch (Exception) { }
        }
        private void ResetBtn_Click(object sender, EventArgs e) { CPU1.Reset(); }
        private void StepClockBtn_Click(object sender, EventArgs e) { UpdateRamView(); }
        private void WipeRAMBtn_Click(object sender, EventArgs e) { for (int i = 0; i < 16; i++) CPU1.Bus.RAM.MEM[i] = 0xFF; }
        private void RandomizeRAMBtn_Click(object sender, EventArgs e) { CPU1.Bus.RAM.Radomize(); }
        private void LoadExampleIntoRAMBtn_Click(object sender, EventArgs e)
        {
            CPU1.Bus.RAM.MEM[0x00] = 0x1e;
            CPU1.Bus.RAM.MEM[0x01] = 0x3c;
            CPU1.Bus.RAM.MEM[0x02] = 0x76;
            CPU1.Bus.RAM.MEM[0x03] = 0x1d;
            CPU1.Bus.RAM.MEM[0x04] = 0xe0;
            CPU1.Bus.RAM.MEM[0x05] = 0xf0;
            CPU1.Bus.RAM.MEM[0x06] = 0x4e;
            CPU1.Bus.RAM.MEM[0x07] = 0x1d;
            CPU1.Bus.RAM.MEM[0x08] = 0x2f;
            CPU1.Bus.RAM.MEM[0x09] = 0x4d;
            CPU1.Bus.RAM.MEM[0x0A] = 0x60;
            CPU1.Bus.RAM.MEM[0x0B] = 0x00;
            CPU1.Bus.RAM.MEM[0x0C] = 0x01;
            CPU1.Bus.RAM.MEM[0x0D] = 0x00;
            CPU1.Bus.RAM.MEM[0x0E] = 0x03;
            CPU1.Bus.RAM.MEM[0x0F] = 0x05;
        }
    }
}
