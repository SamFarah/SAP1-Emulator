using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SAP2Modules;

namespace SAPEmulator
{
    public partial class ClockToNextInstructionBtn : Form
    {
        public SAP2_8Bit Computer { get; set; }
        private uint Frames = 0;
        bool updateRAMViewFlag = false, NotPrevCPUOutput = false;
        bool finalupdate = false;
        System.Diagnostics.Stopwatch SW;
        Sap2AssemblyForm assemblyForm;
        List<string> RAMUpdateCommands;
        public ClockToNextInstructionBtn()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
            //  Application.Idle += HandleApplicationIdle;
            assemblyForm = new Sap2AssemblyForm(this);

            // Set up the comnputer
            Computer = new SAP2_8Bit(FrequencyAdjust.Value, ClockGenerator.ClockModes.SingleStep); //Create an instance of the computer       

            SW = new System.Diagnostics.Stopwatch();
            RAMUpdateCommands = new List<string> { "STA", "STA Ind", "STI", "PHA", "CALL" };
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
            if (Computer.Clock.ClockMode == ClockGenerator.ClockModes.Auto && !Computer.Clock.Halt)
            {
                if (!SW.IsRunning) { SW.Reset(); SW.Start(); }
            }
            else
            {
                SW.Stop();
            }

            //Update LED Arrays            
            BusLEDDisplay.DisplayData(Computer.Bus.Data);
            ARegLEDDisplay.DisplayData(Computer.A.Data);
            BRegLEDDisplay.DisplayData(Computer.B.Data);
            InstRegLEDDisplay.DisplayData(Computer.IR.Data);
            SumRegLEDDisplay.DisplayData(Computer.Alu.Data);
            MARLEDDisplay.DisplayData(Computer.MAR.Data);
            RAMLEDDisplay.DisplayData(Computer.RAM.Data);
            PCLEDDisplay.DisplayData(Computer.PC.Data);
            SRLEDDisplay.DisplayData(Computer.SR.Data);
            OutputRegLEDDisplay.DisplayData(Computer.Output1.Data);
            SumFlagsLEDDisplay.DisplayData((UInt32)(((Computer.Alu.CarryOut ? 1 : 0) << 2) | (Computer.Alu.IsZero ? 1 : 0) << 1 | (Computer.Alu.IsMinus ? 1 : 0)));
            FlagRegLEDDisplay.DisplayData(Computer.Flags.Data, true);
            MICounterLEDDisplay.DisplayData(Computer.CL.StepCounter.Data, true);
            CLDecodedLEDDisplay.DisplayData(Computer.CL.Decoder, true);
            StatusLEDDsiaply1.DisplayData((UInt32)(Computer.ControlWord >> 18));
            StatusLEDDsiaply2.DisplayData((UInt32)(Computer.ControlWord));
            //StatusLEDDsiaply3.DisplayData((UInt32)(Computer.ControlWord));            

            MDRLEDDisplay.DisplayData(Computer.MDR.Data);
            TempRegLEDDisplay.DisplayData(Computer.Temp.Data);
            CRegLEDDisplay.DisplayData(Computer.C.Data);
            ClkCounterLBL.Text = $"Cycles: { Computer.Clock.Counter.ToString()}";
            SWLbl.Text = new TimeSpan(SW.ElapsedTicks).ToString();
            //ALUModeSelect.DisplayData((byte)((Computer.Alu.ModeSelect << 2) | ((Computer.Alu.M ? 1 : 0)<<1) | (Computer.Alu.CarryIn?1:0)));


            //Update Value labels
            BusValLbl.Text = $"0x{Computer.Bus.Data.ToString("X4")}";
            ARegValLbl.Text = $"0x{Computer.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{Computer.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{Computer.IR.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{Computer.Alu.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{Computer.MAR.Data.ToString("X4")}";
            RAMRegValLbl.Text = $"0x{Computer.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{Computer.PC.Data.ToString("X4")}";
            SRRegValLbl.Text = $"0x{Computer.SR.Data.ToString("X4")}";
            OutputRegValLbl.Text = $"0x{Computer.Output1.Data.ToString("X2")}";

            MDRRegValLbl.Text = $"0x{Computer.MDR.Data.ToString("X4")}";
            TempRegValLbl.Text = $"0x{Computer.Temp.Data.ToString("X2")}";
            CRegValLbl.Text = $"0x{Computer.C.Data.ToString("X2")}";
            InstructionLBL.Text = ((ControlSequencer.Instructions)Computer.IR.Data).ToString().Replace("__", ",").Replace("_", " ");
            // Update Group Colors according to control signals
            PCGroup.ForeColor = GetGroupColour(Computer.PC);
            SRGroup.ForeColor = GetGroupColour(Computer.SR);
            ARegGroup.ForeColor = GetGroupColour(Computer.A);
            SumGroup.ForeColor = GetGroupColour(Computer.Alu);
            BRegGroup.ForeColor = GetGroupColour(Computer.B);
            OutputGroup.ForeColor = GetGroupColour(Computer.Output1);
            InstGroup.ForeColor = GetGroupColour(Computer.IR);
            RAMGroup.ForeColor = GetGroupColour(Computer.RAM);
            MARGroup.ForeColor = GetGroupColour(Computer.MAR);
            FlagsGroup.ForeColor = GetGroupColour(Computer.Flags, true);
            TempRegGroup.ForeColor = GetGroupColour(Computer.Temp);

            CRegGroup.ForeColor = GetGroupColour(Computer.C);


            //Update IN Arrows according to "Load" signals
            PCArrow.ChangeState(GetArrowDirection(Computer.PC, true));
            SRArrow.ChangeState(GetArrowDirection(Computer.SR, true));
            ARegArrow.ChangeState(GetArrowDirection(Computer.A));
            BRegArrow.ChangeState(GetArrowDirection(Computer.B));
            CRegArrow.ChangeState(GetArrowDirection(Computer.C));

            RAMArrow.ChangeState(GetArrowDirection(Computer.RAM, true));
            MDRArrow.ChangeState(GetArrowDirection(Computer.MDR, true));


            OutputRegArrowIn.ChangeState(Computer.Output1.Load);
            //MARArrowIn.ChangeState(Computer.MAR.Load);

            MARArrow.ChangeState(GetArrowDirection(Computer.MAR, true));

            InstArrowIn.ChangeState(Computer.IR.Load);
            //TempRegArrowIn.ChangeState(Computer.Temp.Load);
            TempRegArrow.ChangeState(GetArrowDirection(Computer.Temp));
            FlagRegArrowIn.ChangeState(Computer.Flags.Load);
            SUMArrowOut.ChangeState(Computer.Alu.Enable);




            //Update signle LEDs
            PCIncLED.ChangeState(Computer.PC.Count);
            SRIncLED.ChangeState(Computer.SR.Inc);
            SRDecLED.ChangeState(Computer.SR.Dec);
            //SubLED.ChangeState(Computer.Alu.Subtract);
            ClkLed.ChangeState(Computer.Clock.Output);


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
            if (UpdateRAMViewCB.Checked) UpdateRamSelectedByte();
            if (updateRAMViewFlag || Frames % 10000 == 0)
            {
                if (RAMUpdateCommands.Contains(InstructionLBL.Text) && UpdateRAMViewCB.Checked) UpdateRamView();
                updateRAMViewFlag = false;
            }

            if (Computer.Clock.Output != NotPrevCPUOutput)
            {
                updateRAMViewFlag = true;
                NotPrevCPUOutput = Computer.Clock.Output;
            }
            Frames++;


            if (Computer.Clock.Halt)
            {
                if (!finalupdate)
                {
                    UpdateRamView();
                    finalupdate = true;
                }
            }
            else
            {
                finalupdate = false;
            }

        }
        AppCode.Visual.DoubleEndedArrow.Direction GetArrowDirection(Register Reg, bool flipped = false)
        {

            return (AppCode.Visual.DoubleEndedArrow.Direction)((Reg.Load ? 1 : 0) << (flipped ? 0 : 1) | ((Reg.Enable ? 1 : 0) << (flipped ? 1 : 0)));

        }
        Color GetGroupColour(Register Reg, bool AlwaysEnabled = false) { return (!AlwaysEnabled && Reg.Enable) ? Color.DarkGreen : Reg.Load ? Color.Red : Color.Black; }
        public void UpdateRamView()
        {
            DataList MemoryMap = new DataList();

            for (int i = 0; i < 4096; i++)
            {
                DataLine dataLine = new DataLine() { LineAddress = (i * 16).ToString("X4"), LineVals = new List<int>() };
                for (int j = 0; j < 16; j++) dataLine.LineVals.Add(Computer.RAM.MEM[(i * 16) + j]);
                MemoryMap.Add(dataLine);
            }
            RAMGridView.DataSource = MemoryMap;
            RAMGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RAMGridView.Columns[0].Width = 38;
            RAMGridView.Columns[0].HeaderText = string.Empty;
            RAMGridView.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 1; i < 17; i++)
            {
                RAMGridView.Columns[i].HeaderText = (i - 1).ToString("X");
                RAMGridView.Columns[i].DefaultCellStyle.Format = "X2";
                RAMGridView.Columns[i].Width = 19;
                RAMGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            RAMGridView.Columns[8].Width = 27;
            RAMGridView.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            RAMGridView.Columns[17].HeaderText = string.Empty;
            if (UpdateRAMViewCB.Checked) UpdateRamSelectedByte();


        }

        public void UpdateRamSelectedByte()
        {
            int x = (int)(Computer.MAR.Data % 16.0 + 1);
            int y = (int)(Computer.MAR.Data / 16.0);
            if (x == 0 && y == 0) return;
            RAMGridView.CurrentCell = RAMGridView[x, y];
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

        private void WipeRAMBtn_Click(object sender, EventArgs e) { for (int i = 0; i < 64 * 1024; i++) Computer.RAM.MEM[i] = 0xFF; UpdateRamView(); }
        private void RandomizeRAMBtn_Click(object sender, EventArgs e) { Utilities.RadomizeArray(Computer.RAM.MEM); UpdateRamView(); }

        private void ScreenUpdateTimer_Tick(object sender, EventArgs e)
        {
            updateScreen();
        }
        /*
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
        private void MDRLoadBtn_Click(object sender, EventArgs e) { Computer.MDR.Load = BtnClick(sender, Computer.MDR.Load); }
        private void RAMEnableBtn_Click(object sender, EventArgs e) { Computer.RAM.Enable = BtnClick(sender, Computer.RAM.Enable); }
        private void RAMLoadBtn_Click(object sender, EventArgs e) { Computer.RAM.Load = BtnClick(sender, Computer.RAM.Load); }
        private void ShiftMDRBtn_Click(object sender, EventArgs e) { Computer.MDR.Shift = BtnClick(sender, Computer.MDR.Shift); }
        private void MDREnableBtn_Click(object sender, EventArgs e) { Computer.MDR.Enable = BtnClick(sender, Computer.MDR.Enable); }
        private void InstEnableBtn_Click(object sender, EventArgs e) { Computer.IR.Enable = BtnClick(sender, Computer.IR.Enable); }
        private void InstLoadBtn_Click(object sender, EventArgs e) { Computer.IR.Load = BtnClick(sender, Computer.IR.Load); }
        private void ResetStepCounter_Click(object sender, EventArgs e) { Computer.CL.StepCounter.sReset = BtnClick(sender, Computer.CL.StepCounter.sReset); }
        */

        private void RefreshRamView_Click(object sender, EventArgs e)
        {
            UpdateRamView();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public class DataLine
        {
            public string LineAddress { get; set; }
            public List<int> LineVals { get; set; }
            public string LineAscii
            {
                get
                {
                    return $"|{string.Join("", LineVals.Select(x => (!(x < 0x20 || x > 126) ? (char)x : '.')))}|";
                }
            }
        }





        class DataList : List<DataLine>, ITypedList
        {

            public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
            {
                var origProps = TypeDescriptor.GetProperties(typeof(DataLine));
                List<PropertyDescriptor> newProps = new List<PropertyDescriptor>(origProps.Count);
                //PropertyDescriptor doThisLast = null;
                foreach (PropertyDescriptor prop in origProps)
                {

                    if (prop.Name == "LineVals")
                    {
                        var max = (from dataLine in this
                                   let lineVals = dataLine.LineVals
                                   where lineVals != null
                                   select (int?)lineVals.Count).Max() ?? 0;
                        if (max > 0)
                        {
                            // want it nullable to account for jagged arrays
                            Type propType = typeof(int?); // could also figure this out from List<T> in
                                                          // the general case, but make it nullable
                            for (int i = 0; i < max; i++)
                            {
                                newProps.Add(new ListItemDescriptor(prop, i, propType));
                            }
                        }
                    }
                    // doThisLast = prop;
                    else newProps.Add(prop);
                }
                //if (doThisLast != null)

                return new PropertyDescriptorCollection(newProps.ToArray());
            }

            public string GetListName(PropertyDescriptor[] listAccessors)
            {
                return "";
            }
        }
        class ListItemDescriptor : PropertyDescriptor
        {
            private static readonly Attribute[] nix = new Attribute[0];
            private readonly PropertyDescriptor tail;
            private readonly Type type;
            private readonly int index;
            public ListItemDescriptor(PropertyDescriptor tail, int index, Type type) : base(tail.Name + "[" + index + "]", nix)
            {
                this.tail = tail;
                this.type = type;
                this.index = index;
            }
            public override object GetValue(object component)
            {
                IList list = tail.GetValue(component) as IList;
                return (list == null || list.Count <= index) ? null : list[index];
            }
            public override Type PropertyType
            {
                get { return type; }
            }
            public override bool IsReadOnly
            {
                get { return true; }
            }
            public override void SetValue(object component, object value)
            {
                throw new NotSupportedException();
            }
            public override void ResetValue(object component)
            {
                throw new NotSupportedException();
            }
            public override bool CanResetValue(object component)
            {
                return false;
            }
            public override Type ComponentType
            {
                get { return tail.ComponentType; }
            }
            public override bool ShouldSerializeValue(object component)
            {
                return false;
            }
        }

        private void AnimationCB_CheckedChanged(object sender, EventArgs e)
        {
            ScreenUpdateTimer.Enabled = AnimationCB.Checked;
        }

        private void LoadBinFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    using (BinaryReader br = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
                        while (br.BaseStream.Position != br.BaseStream.Length) Computer.RAM.MEM[br.BaseStream.Position] = br.ReadByte();

                    UpdateRamView();
                }

            }
        }

        private void ClkToNextInstBtn_Click(object sender, EventArgs e)
        {
            while (!Computer.ControlWord.RT )
            { Computer.Clock.Step(); Computer.Clock.Step(); if (Computer.ControlWord.HLT) break; }
            Computer.Clock.Step(); Computer.Clock.Step();
            UpdateRamView();
        }

        private void OpenAssemblerBtn_Click(object sender, EventArgs e)
        {

            assemblyForm.Show();
        }


        // Testing assembler functionality



    }
}
