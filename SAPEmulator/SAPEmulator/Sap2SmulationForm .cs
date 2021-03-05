using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SAP2Modules;

namespace SAPEmulator
{
    public partial class Sap2SimulationForm : Form
    {
        public SAP2_8Bit Computer { get; set; }
        private uint Frames = 0;
        bool updateRAMViewFlag = false, NotPrevCPUOutput = false;
        Sap2AssemblyForm assemblyForm;
        public Sap2SimulationForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
            //  Application.Idle += HandleApplicationIdle;
            assemblyForm = new Sap2AssemblyForm(this);

            // Set up the comnputer
            Computer = new SAP2_8Bit(FrequencyAdjust.Value, ClockGenerator.ClockModes.SingleStep); //Create an instance of the computer       

            UpdateRamView();


        }

        //bool IsApplicationIdle()
        //{
        //    Utilities.NativeMessage result;
        //    return Utilities.PeekMessage(out result, IntPtr.Zero, 0, 0, 0) == 0;
        //}
        //void HandleApplicationIdle(object sender, EventArgs e)
        //{
        //    while (IsApplicationIdle()) updateScreen();
        //}
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
                Computer.Clock.ClockMode = ClockGenerator.ClockModes.SingleStep;
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
            InstRegLEDDisplay.DisplayData(Computer.IR.Data);
            SumRegLEDDisplay.DisplayData(Computer.Alu.Data);
            MARLEDDisplay.DisplayData(Computer.MAR.Data);
            RAMLEDDisplay.DisplayData(Computer.RAM.Data);
            PCLEDDisplay.DisplayData(Computer.PC.Data);
            OutputRegLEDDisplay.DisplayData(Computer.Output1.Data);
            SumFlagsLEDDisplay.DisplayData((UInt32)(((Computer.Alu.CarryOut ? 1 : 0) << 1) | (Computer.Alu.IsZero ? 1 : 0)));
            FlagRegLEDDisplay.DisplayData(Computer.Flags.Data, true);
            MICounterLEDDisplay.DisplayData(Computer.CL.StepCounter.Data, true);
            CLDecodedLEDDisplay.DisplayData(Computer.CL.Decoder, true);
            StatusLEDDsiaply1.DisplayData((UInt16)(Computer.ControlWord>>16));
            StatusLEDDsiaply2.DisplayData((UInt16)(Computer.ControlWord));

            MDRLEDDisplay.DisplayData(Computer.MDR.Data);
            TempRegLEDDisplay.DisplayData(Computer.Temp.Data);
            CRegLEDDisplay.DisplayData(Computer.C.Data);
            ALUModeSelect.DisplayData((byte)((Computer.Alu.ModeSelect<<1) | (Computer.Alu.M?1:0) ));


            //Update Value labels
            BusValLbl.Text = $"0x{Computer.Bus.Data.ToString("X4")}";
            ARegValLbl.Text = $"0x{Computer.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{Computer.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{Computer.IR.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{Computer.Alu.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{Computer.MAR.Data.ToString("X4")}";
            RAMRegValLbl.Text = $"0x{Computer.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{Computer.PC.Data.ToString("X4")}";
            OutputRegValLbl.Text = $"0x{Computer.Output1.Data.ToString("X2")}";

            MDRRegValLbl.Text = $"0x{Computer.MDR.Data.ToString("X4")}";            
            TempRegValLbl.Text= $"0x{Computer.Temp.Data.ToString("X2")}";
            CRegValLbl .Text= $"0x{Computer.C.Data.ToString("X2")}";

            // Update Group Colors according to control signals
            PCGroup.ForeColor = GetGroupColour(Computer.PC);
            ARegGroup.ForeColor = GetGroupColour(Computer.A);
            SumGroup.ForeColor = GetGroupColour(Computer.Alu);
            BRegGroup.ForeColor = GetGroupColour(Computer.B);
            OutputGroup.ForeColor = GetGroupColour(Computer.Output1);
            InstGroup.ForeColor = GetGroupColour(Computer.IR);
            RAMGroup.ForeColor = GetGroupColour(Computer.RAM);
            MARGroup.ForeColor = GetGroupColour(Computer.MAR);
            FlagsGroup.ForeColor = GetGroupColour(Computer.Flags, true);

            CRegGroup.ForeColor = GetGroupColour(Computer.C);


            //Update IN Arrows according to "Load" signals
            PCArrowIn.ChangeState(Computer.PC.Load);
            ARegArrowIn.ChangeState(Computer.A.Load);
            BRegArrowIn.ChangeState(Computer.B.Load);
            OutputRegArrowIn.ChangeState(Computer.Output1.Load);
            MARArrowIn.ChangeState(Computer.MAR.Load);
            RAMArrowIn.ChangeState(Computer.RAM.Load);
            InstArrowIn.ChangeState(Computer.IR.Load);

            MDRArrowIn.ChangeState(Computer.MDR.Load);
            MDRArrowOut.ChangeState(Computer.MDR.Enable );

            TempRegArrowIn.ChangeState(Computer.Temp.Load);

            BRegArrowOut.ChangeState(Computer.B.Enable);


            //Update OUT Arrows according to "Enable" signals
            PCArrowOut.ChangeState(Computer.PC.Enable);
            ARegArrowOut.ChangeState(Computer.A.Enable);
            SUMArrowOut.ChangeState(Computer.Alu.Enable);
            RAMArrowOut.ChangeState(Computer.RAM.Enable);
            InstArrowOut.ChangeState(Computer.IR.Enable);


            //Update signle LEDs
            IncLED.ChangeState(Computer.PC.Count);
            //SubLED.ChangeState(Computer.Alu.Subtract);
            ClkLed.ChangeState(Computer.Clock.Output);
            CarryInLED.ChangeState(Computer.Alu.CarryIn);


            //Update 7-Segment Display
            if (DisplaySignedCB.Checked)
            {
                sbyte outputSigned = (sbyte)Computer.Output1.Data;
                DisplayLbl.Text = $"{(outputSigned >= 0 ? " " : "") }{outputSigned.ToString("000")}";
            }
            else
            {
                DisplayLbl.Text = Computer.Output1.Data.ToString(" 000");
            }

            //Update RAM content viewer slowing it down abit to reduce flicker
            if (updateRAMViewFlag || Frames % 10000 == 0)
            {
               // UpdateRamView();
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
        public void UpdateRamView()
        {
            RAMView.Items.Clear();

            for (int i = 0; i < 4096; i++)
            {
                string line = $"{(i * 16).ToString("X4")}  ";
                for (int j = 0; j < 16; j++) line += $"{Computer.RAM.MEM[(i * 16) + j].ToString("X2")}{(j==8?"  ":" ")}";

                line += '|';

                for (int j = 0; j < 16; j++) line += $"{(isPrintable( (char) Computer.RAM.MEM[(i * 16) + j])? (char)Computer.RAM.MEM[(i * 16) + j]: '.')}";
                line += '|';
                RAMView.Items.Add(line);
            }
            //   RAMView.SelectedIndex = Computer.MAR.Data;

        }

        bool isPrintable(char ch)
        {            
            return !(ch < 0x20 || ch > 126);
        }

        private void FrequencyAdjust_Scroll(object sender, EventArgs e)
        {
            Computer.Clock.Frequency = FrequencyAdjust.Value;
            FreqLbl.Text = "Frequency: " + Computer.Clock.Frequency.ToString() + "Hz";
        }

        // Step Clock Button Handlers
        private void StepClockBtn_MouseDown(object sender, MouseEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_MouseUp(object sender, MouseEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_Click(object sender, EventArgs e) { }//UpdateRamView(); }
        private void StepClockBtn_KeyDown(object sender, KeyEventArgs e) { Computer.Clock.Step(); }
        private void StepClockBtn_KeyUp(object sender, KeyEventArgs e) { Computer.Clock.Step(); }

        //private void CarryInCB_CheckedChanged(object sender, EventArgs e) { Computer.Alu.CarryIn = CarryInCB.Checked; }
        private void ProgramBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UInt16 Address = (UInt16)Convert.ToInt64(ProgRAMAddrTB.Text.Trim(), 16);
                byte Data = (byte)Convert.ToInt64(ProgRamDataTB.Text.Trim(), 16);
                Computer.RAM.MEM[Address] = Data;
                UpdateRamView();
                ProgRAMAddrTB.Text = $"0x{((Address + 1) & 0xFFFF).ToString("X4")}";
                ProgRamDataTB.Text = "0x";
                ProgRamDataTB.Focus();
                ProgRamDataTB.Select(ProgRamDataTB.Text.Length, 0);

            }
            catch (Exception) { }
        }
        private void ResetBtn_Click(object sender, EventArgs e) { Computer.Reset(); }

        private void WipeRAMBtn_Click(object sender, EventArgs e) { for (int i = 0; i < 64*1024; i++) Computer.RAM.MEM[i] = 0xFF; UpdateRamView(); }
        private void RandomizeRAMBtn_Click(object sender, EventArgs e) { Utilities.RadomizeArray(Computer.RAM.MEM); UpdateRamView(); }

        private void ScreenUpdateTimer_Tick(object sender, EventArgs e)
        {
            updateScreen();
        }

        private bool BtnClick(object sender, bool StateFlag, bool activeLow = false)
        {
            StateFlag = !StateFlag;
            Button btn = (Button)sender;
            if (StateFlag != activeLow) btn.BackColor = Color.Red;
            else btn.BackColor = SystemColors.Control;
            return StateFlag;
        }

        private bool BtnClick(object sender, bool StateFlag, string OnText, string OffText, bool activeLow = false)
        {
            StateFlag = !StateFlag;
            Button btn = (Button)sender;
            if (StateFlag != activeLow) btn.Text = OnText;
            else btn.Text = OffText;
            return StateFlag;
        }

        private void PCOutBtn_Click(object sender, EventArgs e) { Computer.PC.Enable = BtnClick(sender, Computer.PC.Enable); }
        private void PCInBtn_Click(object sender, EventArgs e) { Computer.PC.Load = BtnClick(sender, Computer.PC.Load); }
        private void PCEnBtn_Click(object sender, EventArgs e) { Computer.PC.Count = BtnClick(sender, Computer.PC.Count); }        
        private void MARLoadBtn_Click(object sender, EventArgs e) { Computer.MAR.Load = BtnClick(sender, Computer.MAR.Load); }

        private void MDRLoadBtn_Click(object sender, EventArgs e)
        {
            Computer.MDR.Load = BtnClick(sender, Computer.MDR.Load);
        }

        private void RAMEnableBtn_Click(object sender, EventArgs e)
        {
            Computer.RAM.Enable = BtnClick(sender, Computer.RAM.Enable);
        }
        private void RAMLoadBtn_Click(object sender, EventArgs e)
        {
            Computer.RAM.Load = BtnClick(sender, Computer.RAM.Load);        
        }

        private void ShiftMDRBtn_Click(object sender, EventArgs e)
        {
            Computer.MDR.Shift = BtnClick(sender, Computer.MDR.Shift);
        }

        private void MDREnableBtn_Click(object sender, EventArgs e)
        {
            Computer.MDR.Enable = BtnClick(sender, Computer.MDR.Enable);
        }

        private void InstEnableBtn_Click(object sender, EventArgs e)
        {
            Computer.IR.Enable = BtnClick(sender, Computer.IR.Enable);
        }

        private void InstLoadBtn_Click(object sender, EventArgs e)
        {
            Computer.IR.Load = BtnClick(sender, Computer.IR.Load);
        }

        private void RefreshRamView_Click(object sender, EventArgs e)
        {
            UpdateRamView();
        }

        private void ResetStepCounter_Click(object sender, EventArgs e)
        {
            Computer.CL.StepCounter.sReset = BtnClick(sender, Computer.CL.StepCounter.sReset);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void OpenAssemblerBtn_Click(object sender, EventArgs e)
        {

            assemblyForm.Show();
        }


        // Testing assembler functionality



    }
}
