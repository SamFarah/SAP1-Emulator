using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SAP1Modules;

namespace SAP1Emulator
{
    public partial class SimulationForm : Form
    {
        SAP1_8Bit Computer { get; set; }
        private uint Frames = 0;
        bool updateRAMViewFlag = false, NotPrevCPUOutput = false;
        public SimulationForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
            Application.Idle += HandleApplicationIdle;

            // Set up the comnputer
            Computer = new SAP1_8Bit(FrequencyAdjust.Value, ClockGenerator.ClockModes.SignleStep); //Create an instance of the computer            
        }

        bool IsApplicationIdle()
        {
            Utilities.NativeMessage result;
            return Utilities.PeekMessage(out result, IntPtr.Zero, 0, 0, 0) == 0;
        }
        void HandleApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle()) updateScreen();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayLbl.Parent = DisplayShadowLbl;
            DisplayLbl.Location = new Point(0, 0);
        }

        private void ClockModeBtn_Click(object sender, EventArgs e)
        {
            if (Computer.Clock.ClockMode == ClockGenerator.ClockModes.Auto)
            {
                ClockModeBtn.Text = "Stopped";
                ClockModeBtn.BackColor = Color.Red;
                Computer.Clock.ClockMode = ClockGenerator.ClockModes.SignleStep;
                Computer.Clock.Stop();
                StepClockBtn.Enabled = true;
            }
            else
            {
                ClockModeBtn.Text = "Running";
                ClockModeBtn.BackColor = Color.LightGreen;
                Computer.Clock.ClockMode = ClockGenerator.ClockModes.Auto;
                Computer.Clock.Start();
                StepClockBtn.Enabled = false;
            }
        }
        void updateScreen()
        {
            //Update LED Arrays            
            BusLEDDisplay.DisplayData(Computer.Bus.Data);
            ARegLEDDisplay.DisplayData(Computer.A.Data);
            BRegLEDDisplay.DisplayData(Computer.B.Data);
            InstRegLEDDisplay.DisplayData(Computer.Inst.Data);
            SumRegLEDDisplay.DisplayData(Computer.Sum.Data);
            MARLEDDisplay.DisplayData(Computer.MAR.Data);
            RAMLEDDisplay.DisplayData(Computer.RAM.Data);
            PCLEDDisplay.DisplayData(Computer.PC.Data);
            OutputRegLEDDisplay.DisplayData(Computer.Output.Data);
            SumFlagsLEDDisplay.DisplayData(((Computer.Sum.CarryOut ? 1 : 0) << 1) | (Computer.Sum.IsZero ? 1 : 0));
            FlagRegLEDDisplay.DisplayData(Computer.Flags.Data, true);
            MICounterLEDDisplay.DisplayData(Computer.CL.StepCounter.Data, true);
            CLDecodedLEDDisplay.DisplayData(Computer.CL.Decoder, true);
            StatusLEDDsiaply.DisplayData(Computer.ControlWord);


            //Update Value labels
            BusValLbl.Text = $"0x{Computer.Bus.Data.ToString("X2")}";
            ARegValLbl.Text = $"0x{Computer.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{Computer.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{Computer.Inst.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{Computer.Sum.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{Computer.MAR.Data.ToString("X2")}";
            RAMRegValLbl.Text = $"0x{Computer.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{Computer.PC.Data.ToString("X2")}";
            OutputRegValLbl.Text = $"0x{Computer.Output.Data.ToString("X2")}";


            // Update Group Colors according to control signals
            PCGroup.ForeColor = GetGroupColour(Computer.PC);
            ARegGroup.ForeColor = GetGroupColour(Computer.A);
            SumGroup.ForeColor = GetGroupColour(Computer.Sum);
            BRegGroup.ForeColor = GetGroupColour(Computer.B);
            OutputGroup.ForeColor = GetGroupColour(Computer.Output);
            InstGroup.ForeColor = GetGroupColour(Computer.Inst);
            RAMGroup.ForeColor = GetGroupColour(Computer.RAM);
            MARGroup.ForeColor = GetGroupColour(Computer.MAR);
            FlagsGroup.ForeColor = GetGroupColour(Computer.Flags, true);


            //Update IN Arrows according to "Load" signals
            PCArrowIn.ChangeState(Computer.PC.Load);
            ARegArrowIn.ChangeState(Computer.A.Load);
            BRegArrowIn.ChangeState(Computer.B.Load);
            OutputRegArrowIn.ChangeState(Computer.Output.Load);
            MARArrowIn.ChangeState(Computer.MAR.Load);
            RAMArrowIn.ChangeState(Computer.RAM.Load);
            InstArrowIn.ChangeState(Computer.Inst.Load);


            //Update OUT Arrows according to "Enable" signals
            PCArrowOut.ChangeState(Computer.PC.Enable);
            ARegArrowOut.ChangeState(Computer.A.Enable);
            SUMArrowOut.ChangeState(Computer.Sum.Enable);
            RAMArrowOut.ChangeState(Computer.RAM.Enable);
            InstArrowOut.ChangeState(Computer.Inst.Enable);


            //Update signle LEDs
            IncLED.ChangeState(Computer.PC.Count);
            SubLED.ChangeState(Computer.Sum.Subtract);
            ClkLed.ChangeState(Computer.Clock.Output);


            //Update 7-Segment Display
            if (DisplaySignedCB.Checked)
            {
                sbyte outputSigned = (sbyte)Computer.Output.Data;
                DisplayLbl.Text = $"{(outputSigned >= 0 ? " " : "") }{outputSigned.ToString("000")}";
            }
            else
            {
                DisplayLbl.Text = Computer.Output.Data.ToString(" 000");
            }

            //Update RAM content viewer slowing it down abit to reduce flicker
            if (updateRAMViewFlag || Frames % 10000 == 0)
            {
                UpdateRamView();
                updateRAMViewFlag = false;
            }

            if (Computer.Clock.Output != NotPrevCPUOutput)
            {
                updateRAMViewFlag = true;
                NotPrevCPUOutput = Computer.Clock.Output;
            }
            Frames++;
        }
        Color GetGroupColour(Register Reg, bool AlwaysEnabled = false) { return (!AlwaysEnabled && Reg.Enable) ? Color.DarkGreen : Reg.Load ? Color.Red : Color.Black; }
        private void UpdateRamView()
        {
            RAMView.Items.Clear();

            for (int i = 0; i < 16; i++)
            {
                string line = $"0x{(i * 1).ToString("X")}:\t";
                for (int j = 0; j < 1; j++) line += $"{Computer.RAM.MEM[(i * 1) + j].ToString("X2")}  ";
                RAMView.Items.Add(line);
            }
            RAMView.SelectedIndex = Computer.MAR.Data;

        }
        private void FrequencyAdjust_Scroll(object sender, EventArgs e)
        {
            Computer.Clock.Frequency = FrequencyAdjust.Value;
            FreqLbl.Text = "Frequency: " + Computer.Clock.Frequency.ToString() + "Hz";
        }

        // Step Clock Button Handlers
        private void StepClockBtn_MouseDown(object sender, MouseEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_MouseUp(object sender, MouseEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_Click(object sender, EventArgs e) { UpdateRamView(); }
        private void StepClockBtn_KeyDown(object sender, KeyEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_KeyUp(object sender, KeyEventArgs e) { Computer.Clock.Step(); }

        private void CarryInCB_CheckedChanged(object sender, EventArgs e) { Computer.Sum.CarryIn = CarryInCB.Checked; }
        private void ProgramBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte Address = (byte)Convert.ToInt64(ProgRAMAddrTB.Text.Trim(), 16);
                byte Data = (byte)Convert.ToInt64(ProgRamDataTB.Text.Trim(), 16);
                Computer.RAM.MEM[Address] = Data;
                UpdateRamView();
                ProgRAMAddrTB.Text = $"0x{((Address + 1) & 0x0F).ToString("X2")}";
                ProgRamDataTB.Text = "0x";
                ProgRamDataTB.Focus();
                ProgRamDataTB.Select(ProgRamDataTB.Text.Length, 0);

            }
            catch (Exception) { }
        }
        private void ResetBtn_Click(object sender, EventArgs e) { Computer.Reset(); }

        private void WipeRAMBtn_Click(object sender, EventArgs e) { for (int i = 0; i < 16; i++) Computer.RAM.MEM[i] = 0xFF; UpdateRamView(); }
        private void RandomizeRAMBtn_Click(object sender, EventArgs e) { Utilities.RadomizeArray(Computer.RAM.MEM); UpdateRamView(); }


        // Testing assembler functionality
        private void button1_Click(object sender, EventArgs e)
        {

            Assembler t = new Assembler();

            t.GenerateCommands(textBox4.Lines);
            if (t.isValid)
            {
                //MessageBox.Show(string.Join(Environment.NewLine, new List<Byte>(t.GetMachineCode()).Select(x => $"0x{x.ToString("X2")}")));
                Computer.RAM.MEM = t.GetMachineCode();
                UpdateRamView();
            }
            else
                MessageBox.Show("Invalid Code");

            //Label1: lda 0x0E; 0x1E
            //Label: SUB 0x0C; comment here
            //Label: JC  0x06; 0x76
            //Label: LDA 0x0D; 0x1D
            //Label: OUT; 0xE0
            //Label: HLT; 0xF0
            //Label: STA 0x0E; 0x4E
            //Label: LDA 0x0C; 0x1D
            //Label: ADD 0x0E; 0x2F
            //Label: STA 0x0D; 0x4D
            //Label: JMP 0x00; 0x60


        }

        private void LoadExampleIntoRAMBtn_Click(object sender, EventArgs e)
        {
            Computer.RAM.MEM[0x00] = 0x1e;
            Computer.RAM.MEM[0x01] = 0x3c;
            Computer.RAM.MEM[0x02] = 0x76;
            Computer.RAM.MEM[0x03] = 0x1d;
            Computer.RAM.MEM[0x04] = 0xe0;
            Computer.RAM.MEM[0x05] = 0xf0;
            Computer.RAM.MEM[0x06] = 0x4e;
            Computer.RAM.MEM[0x07] = 0x1d;
            Computer.RAM.MEM[0x08] = 0x2f;
            Computer.RAM.MEM[0x09] = 0x4d;
            Computer.RAM.MEM[0x0A] = 0x60;
            Computer.RAM.MEM[0x0B] = 0x00;
            Computer.RAM.MEM[0x0C] = 0x01;
            Computer.RAM.MEM[0x0D] = 0x00;
            Computer.RAM.MEM[0x0E] = 0x03;
            Computer.RAM.MEM[0x0F] = 0x05;
            UpdateRamView();
        }
    }
}
