using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP1Emulator
{
    public partial class MainForm : Form
    {
        ClockGenerator clock;
        Bus SAP1Bus;



        void TestRisingPulseFunction()
        {
            //do all the things at each positive clock pulse 
            SAP1Bus.Read();
            //SAP1Bus.Write();
        }

        void TestFallingPulseFunction()
        {

        }

        public MainForm()
        {
            InitializeComponent();
            clock = new ClockGenerator(TestRisingPulseFunction, TestFallingPulseFunction);
            SAP1Bus = new Bus();
            clock.Frequency = trackBar1.Value;
        }


        private class ButtonInfo
        {
            public Button Btn { get; set; }
            public bool Signal { get; set; }
            public bool ActiveState { get { return false; } }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTimer.Start(); // for visual effects
            UpdateRamView();
            DisplayLbl.Parent = DisplayShadowLbl;
            DisplayLbl.Location = new Point(0, 0);

            List<ButtonInfo> ControlButtons = new List<ButtonInfo>
            {
                new ButtonInfo { Btn= AInBtn,       Signal= SAP1Bus.A.Load         },
                new ButtonInfo { Btn= BInBtn,       Signal= SAP1Bus.B.Load         },
                new ButtonInfo { Btn= AOutBtn,      Signal= SAP1Bus.A.Enable       },
                new ButtonInfo { Btn= BOutBtn,      Signal= SAP1Bus.B.Enable,      },
                new ButtonInfo { Btn= SumOutBtn,    Signal= SAP1Bus.Sum.Enable     },
                new ButtonInfo { Btn= SumSubBtn,    Signal= SAP1Bus.Sum.Subtract   },
                new ButtonInfo { Btn= InstOutBtn,   Signal= SAP1Bus.Inst.Enable    },
                new ButtonInfo { Btn= InstInBtn,    Signal= SAP1Bus.Inst.Load      },
                new ButtonInfo { Btn= MARInBtn,     Signal= SAP1Bus.MAR.Load       },
                new ButtonInfo { Btn= RAMInBtn,     Signal= SAP1Bus.RAM.Load       },
                new ButtonInfo { Btn= RAMOutBtn,    Signal= SAP1Bus.RAM.Enable     },
                new ButtonInfo { Btn= PCInBtn,      Signal= SAP1Bus.PC.Load        },
                new ButtonInfo { Btn= PCOutBtn,     Signal= SAP1Bus.PC.Enable      },
                new ButtonInfo { Btn= OutputInBtn,  Signal= SAP1Bus.Output.Load    },
                new ButtonInfo { Btn= ClkHltBtn,    Signal= clock.Hault            },
                new ButtonInfo { Btn= PCECBtn,      Signal= SAP1Bus.PC.Count       }
            };

            for (int i = 0; i < 15; i++)
            {

                if (ControlButtons[i].Signal != ControlButtons[i].ActiveState) ControlButtons[i].Btn.BackColor = Color.Red;
                else ControlButtons[i].Btn.BackColor = SystemColors.Control;

                // BtnClick(ControlButtons[i], ControlSignals[i], ActiveState[i]);
            }


        }

        private void ClockModeBtn_Click(object sender, EventArgs e)
        {
            if (clock.ClockMode == ClockGenerator.ClockModes.Auto)
            {
                ClockModeBtn.Text = "Stopped";
                ClockModeBtn.BackColor = Color.Red;
                clock.ClockMode = ClockGenerator.ClockModes.SignleStep;
                clock.Stop();
                StepClockBtn.Enabled = true;
            }
            else
            {
                ClockModeBtn.Text = "Running";
                ClockModeBtn.BackColor = Color.LightGreen;
                clock.ClockMode = ClockGenerator.ClockModes.Auto;
                clock.Run();
                StepClockBtn.Enabled = false;
            }
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {

            //update LEDS and visual stuff
            ledDisplay2.DisplayData((clock.Output ? 1 : 0) << 1 | (clock.OutputInverse ? 1 : 0));




            BusLEDDisplay.DisplayData(SAP1Bus.Data);
            ARegLEDDisplay.DisplayData(SAP1Bus.A.Data);
            BRegLEDDisplay.DisplayData(SAP1Bus.B.Data);
            InstRegLEDDisplay.DisplayData(SAP1Bus.Inst.Data);
            SumRegLEDDisplay.DisplayData(SAP1Bus.Sum.Data);
            CarryOutLED.ChangeState(SAP1Bus.Sum.CarryOut);
            MARLEDDisplay.DisplayData(SAP1Bus.MAR.Data);
            RAMLEDDisplay.DisplayData(SAP1Bus.RAM.Data);
            PCLEDDisplay.DisplayData(SAP1Bus.PC.Data);
            OutputRegLEDDisplay.DisplayData(SAP1Bus.Output.Data);

            BusValLbl.Text = $"0x{SAP1Bus.Data.ToString("X2")}";
            ARegValLbl.Text = $"0x{SAP1Bus.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{SAP1Bus.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{SAP1Bus.Inst.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{SAP1Bus.Sum.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{SAP1Bus.MAR.Data.ToString("X2")}";
            RAMRegValLbl.Text = $"0x{SAP1Bus.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{SAP1Bus.PC.Data.ToString("X2")}";
            OutputRegValLbl.Text = $"0x{SAP1Bus.Output.Data.ToString("X2")}";

            if (DisplaySignedCB.Checked)
            {
                sbyte outputSigned = (sbyte)SAP1Bus.Output.Data;
                DisplayLbl.Text = $"{(outputSigned >= 0 ? " " : "") }{outputSigned.ToString("000")}";
            }
            else
            {

                DisplayLbl.Text = SAP1Bus.Output.Data.ToString(" 000");
            }






            if (clock.Output) //slow down the refresh rate of memory view
            {
                UpdateRamView();
            }
            UInt16 StatusBar = (UInt16)(((clock.Hault ? 1 : 0) << 14) |
                                        ((SAP1Bus.MAR.Load ? 1 : 0) << 13) |
                                        ((SAP1Bus.RAM.Load ? 1 : 0) << 12) |
                                        ((SAP1Bus.RAM.Enable ? 1 : 0) << 11) |
                                        ((SAP1Bus.Inst.Enable ? 1 : 0) << 10) |
                                        ((SAP1Bus.Inst.Load ? 1 : 0) << 9) |
                                        ((SAP1Bus.A.Load ? 1 : 0) << 8) |
                                        ((SAP1Bus.A.Enable ? 1 : 0) << 7) |
                                        ((SAP1Bus.Sum.Enable ? 1 : 0) << 6) |
                                        ((SAP1Bus.Sum.Subtract ? 1 : 0) << 5) |
                                        ((SAP1Bus.B.Load ? 1 : 0) << 4) |
                                        ((SAP1Bus.Output.Load ? 1 : 0) << 3) |
                                        ((SAP1Bus.PC.Count ? 1 : 0) << 2) |
                                        ((SAP1Bus.PC.Enable ? 1 : 0) << 1) |
                                        ((SAP1Bus.PC.Load ? 1 : 0) << 0)
                                        );
            StatusLEDDsiaply.DisplayData(StatusBar);
            StatusRegLBl.Text = $"0x{StatusBar.ToString("X4")}";

        }
        private void UpdateRamView()
        {
            RAMView.Items.Clear();
            for (int i = 0; i < 16; i++)
            {
                string line = $"0x{(i * 1).ToString("X")}:\t";
                for (int j = 0; j < 1; j++) line += $"{SAP1Bus.RAM.MEM[(i * 1) + j].ToString("X2")}  ";

                RAMView.Items.Add(line);
            }
            RAMView.SelectedIndex = SAP1Bus.MAR.Data;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            clock.Frequency = trackBar1.Value;
            FreqLbl.Text = "Frequency: " + clock.Frequency.ToString() + "Hz";
        }

        private void StepClockBtn_MouseDown(object sender, MouseEventArgs e)
        {
            clock.Step();
        }

        private void StepClockBtn_MouseUp(object sender, MouseEventArgs e)
        {
            clock.Step();
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

        private void AInBtn_Click(object sender, EventArgs e) { SAP1Bus.A.Load = BtnClick(sender, SAP1Bus.A.Load); }
        private void AOutBtn_Click(object sender, EventArgs e) { SAP1Bus.A.Enable = BtnClick(sender, SAP1Bus.A.Enable); }
        private void BInBtn_Click(object sender, EventArgs e) { SAP1Bus.B.Load = BtnClick(sender, SAP1Bus.B.Load); }
        private void BOutBtn_Click(object sender, EventArgs e) { SAP1Bus.B.Enable = BtnClick(sender, SAP1Bus.B.Enable); }
        private void SumOutBtn_Click(object sender, EventArgs e) { SAP1Bus.Sum.Enable = BtnClick(sender, SAP1Bus.Sum.Enable); }
        private void SumSubBtn_Click(object sender, EventArgs e) { SAP1Bus.Sum.Subtract = BtnClick(sender, SAP1Bus.Sum.Subtract, "Adding", "Subtracting",true); }
        private void InstInBtn_Click(object sender, EventArgs e) { SAP1Bus.Inst.Load = BtnClick(sender, SAP1Bus.Inst.Load); }
        private void InstOutBtn_Click(object sender, EventArgs e) { SAP1Bus.Inst.Enable = BtnClick(sender, SAP1Bus.Inst.Enable); }
        private void MARInBtn_Click(object sender, EventArgs e) { SAP1Bus.MAR.Load = BtnClick(sender, SAP1Bus.MAR.Load); }
        private void RAMInBtn_Click(object sender, EventArgs e) { SAP1Bus.RAM.Load = BtnClick(sender, SAP1Bus.RAM.Load); }
        private void RAMOutBtn_Click(object sender, EventArgs e) { SAP1Bus.RAM.Enable = BtnClick(sender, SAP1Bus.RAM.Enable); }
        private void PCInBtn_Click(object sender, EventArgs e) { SAP1Bus.PC.Load = BtnClick(sender, SAP1Bus.PC.Load); }
        private void PCOutBtn_Click(object sender, EventArgs e) { SAP1Bus.PC.Enable = BtnClick(sender, SAP1Bus.PC.Enable); }
        private void OutputInBtn_Click(object sender, EventArgs e) { SAP1Bus.Output.Load = BtnClick(sender, SAP1Bus.Output.Load); }
        private void ClkHltBtn_Click(object sender, EventArgs e) { clock.Hault = BtnClick(sender, clock.Hault); }
        private void PCECBtn_Click(object sender, EventArgs e) { SAP1Bus.PC.Count = BtnClick(sender, SAP1Bus.PC.Count); }


        private void button8_Click(object sender, EventArgs e)
        {
            try { SAP1Bus.Data = (byte)Convert.ToInt64(textBox1.Text, 16); }
            catch (Exception) { }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SAP1Bus.Sum.CarryIn = checkBox1.Checked;
        }



        private void ProGramBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte Address = (byte)Convert.ToInt64(ProgRAMAddrTB.Text.Trim(), 16);
                byte Data = (byte)Convert.ToInt64(ProgRamDataTB.Text.Trim(), 16);
                SAP1Bus.RAM.MEM[Address] = Data;
                UpdateRamView();
                ProgRAMAddrTB.Text = $"0x{((Address + 1) & 0x0F).ToString("X2")}";
                ProgRamDataTB.Text = "0x";
                ProgRamDataTB.Focus();
                ProgRamDataTB.Select(ProgRamDataTB.Text.Length, 0);

            }
            catch (Exception)
            {
                
            }

           
        }


    }
}
