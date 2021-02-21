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

        SAP1_8Bit CPU1;
        uint Frames = 0;
        public MainForm()
        {
            InitializeComponent();
            CPU1 = new SAP1_8Bit();
            CPU1.Clock.Frequency = trackBar1.Value;

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.DoubleBuffered = true;

        }

        #region TestButtons

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

            //List<ButtonInfo> ControlButtons = new List<ButtonInfo>
            //{
            //    new ButtonInfo { Btn= AInBtn,       Signal= CPU1.Bus.A.Load         },
            //    new ButtonInfo { Btn= BInBtn,       Signal= CPU1.Bus.B.Load         },
            //    new ButtonInfo { Btn= AOutBtn,      Signal= CPU1.Bus.A.Enable       },
            //    new ButtonInfo { Btn= BOutBtn,      Signal= CPU1.Bus.B.Enable,      },
            //    new ButtonInfo { Btn= SumOutBtn,    Signal= CPU1.Bus.Sum.Enable     },
            //    new ButtonInfo { Btn= SumSubBtn,    Signal= CPU1.Bus.Sum.Subtract   },
            //    new ButtonInfo { Btn= InstOutBtn,   Signal= CPU1.Bus.Inst.Enable    },
            //    new ButtonInfo { Btn= InstInBtn,    Signal= CPU1.Bus.Inst.Load      },
            //    new ButtonInfo { Btn= MARInBtn,     Signal= CPU1.Bus.MAR.Load       },
            //    new ButtonInfo { Btn= RAMInBtn,     Signal= CPU1.Bus.RAM.Load       },
            //    new ButtonInfo { Btn= RAMOutBtn,    Signal= CPU1.Bus.RAM.Enable     },
            //    new ButtonInfo { Btn= PCInBtn,      Signal= CPU1.Bus.PC.Load        },
            //    new ButtonInfo { Btn= PCOutBtn,     Signal= CPU1.Bus.PC.Enable      },
            //    new ButtonInfo { Btn= OutputInBtn,  Signal= CPU1.Bus.Output.Load    },
            //    new ButtonInfo { Btn= ClkHltBtn,    Signal= CPU1. Clock.Hault       },
            //    new ButtonInfo { Btn= PCECBtn,      Signal= CPU1.Bus.PC.Count       }
            //};

            //for (int i = 0; i < 15; i++)
            //{

            //    if (ControlButtons[i].Signal != ControlButtons[i].ActiveState) ControlButtons[i].Btn.BackColor = Color.Red;
            //    else ControlButtons[i].Btn.BackColor = SystemColors.Control;

            //    // BtnClick(ControlButtons[i], ControlSignals[i], ActiveState[i]);
            //}


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

        private void AInBtn_Click(object sender, EventArgs e) { CPU1.Bus.A.Load = BtnClick(sender, CPU1.Bus.A.Load); }
        private void AOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.A.Enable = BtnClick(sender, CPU1.Bus.A.Enable); }
        private void BInBtn_Click(object sender, EventArgs e) { CPU1.Bus.B.Load = BtnClick(sender, CPU1.Bus.B.Load); }
        private void BOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.B.Enable = BtnClick(sender, CPU1.Bus.B.Enable); }
        private void SumOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.Sum.Enable = BtnClick(sender, CPU1.Bus.Sum.Enable); }
        private void SumSubBtn_Click(object sender, EventArgs e) { CPU1.Bus.Sum.Subtract = BtnClick(sender, CPU1.Bus.Sum.Subtract, "Adding", "Subtracting", true); }
        private void InstInBtn_Click(object sender, EventArgs e) { CPU1.Bus.Inst.Load = BtnClick(sender, CPU1.Bus.Inst.Load); }
        private void InstOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.Inst.Enable = BtnClick(sender, CPU1.Bus.Inst.Enable); }
        private void MARInBtn_Click(object sender, EventArgs e) { CPU1.Bus.MAR.Load = BtnClick(sender, CPU1.Bus.MAR.Load); }
        private void RAMInBtn_Click(object sender, EventArgs e) { CPU1.Bus.RAM.Load = BtnClick(sender, CPU1.Bus.RAM.Load); }
        private void RAMOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.RAM.Enable = BtnClick(sender, CPU1.Bus.RAM.Enable); }
        private void PCInBtn_Click(object sender, EventArgs e) { CPU1.Bus.PC.Load = BtnClick(sender, CPU1.Bus.PC.Load); }
        private void PCOutBtn_Click(object sender, EventArgs e) { CPU1.Bus.PC.Enable = BtnClick(sender, CPU1.Bus.PC.Enable); }
        private void OutputInBtn_Click(object sender, EventArgs e) { CPU1.Bus.Output.Load = BtnClick(sender, CPU1.Bus.Output.Load); }
        private void ClkHltBtn_Click(object sender, EventArgs e) { CPU1.Clock.Hault = BtnClick(sender, CPU1.Clock.Hault); }
        private void PCECBtn_Click(object sender, EventArgs e) { CPU1.Bus.PC.Count = BtnClick(sender, CPU1.Bus.PC.Count); }
        #endregion

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
                CPU1.Clock.Run();
                StepClockBtn.Enabled = false;
            }
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {

            //update LEDS and visual stuff
            ledDisplay2.DisplayData(CPU1.Clock.Output ? 1 : 0);
            BusLEDDisplay.DisplayData(CPU1.Bus.GetData());
            ARegLEDDisplay.DisplayData(CPU1.Bus.A.Data);
            BRegLEDDisplay.DisplayData(CPU1.Bus.B.Data);
            InstRegLEDDisplay.DisplayData(CPU1.Bus.Inst.Data);
            SumRegLEDDisplay.DisplayData(CPU1.Bus.Sum.Data);
            CarryOutLED.ChangeState(CPU1.Bus.Sum.CarryOut);
            MARLEDDisplay.DisplayData(CPU1.Bus.MAR.Data);
            RAMLEDDisplay.DisplayData(CPU1.Bus.RAM.Data);
            PCLEDDisplay.DisplayData(CPU1.Bus.PC.Data);
            OutputRegLEDDisplay.DisplayData(CPU1.Bus.Output.Data);

            MICounterLEDDisplay.DisplayData(CPU1.CL.MicroCounter.Data, true);
            CLDecodedLEDDisplay.DisplayData(CPU1.CL.Decoder, true);

            BusValLbl.Text = $"0x{CPU1.Bus.GetData().ToString("X2")}";
            ARegValLbl.Text = $"0x{CPU1.Bus.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{CPU1.Bus.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{CPU1.Bus.Inst.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{CPU1.Bus.Sum.Data.ToString("X2")}";
            MARRegValLbl.Text = $"0x{CPU1.Bus.MAR.Data.ToString("X2")}";
            RAMRegValLbl.Text = $"0x{CPU1.Bus.RAM.Data.ToString("X2")}";
            PCRegValLbl.Text = $"0x{CPU1.Bus.PC.Data.ToString("X2")}";
            OutputRegValLbl.Text = $"0x{CPU1.Bus.Output.Data.ToString("X2")}";

            if (DisplaySignedCB.Checked)
            {
                sbyte outputSigned = (sbyte)CPU1.Bus.Output.Data;
                DisplayLbl.Text = $"{(outputSigned >= 0 ? " " : "") }{outputSigned.ToString("000")}";
            }
            else
            {
                DisplayLbl.Text = CPU1.Bus.Output.Data.ToString(" 000");
            }

           if (CPU1.Clock.Output || Frames % 20==0) UpdateRamView(); //update memory view every clock cycle or every 20 frames

           
            Frames++;
            StatusLEDDsiaply.DisplayData(CPU1.ControlWord);
            StatusRegLBl.Text = $"0x{CPU1.ControlWord.ToString("X4")}";

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
            


            //listView1.Enabled = false;
            //listView1.Items.Clear();
            //for (int i = 0; i < 16; i++)
            //{
            //    string line = $"0x{(i * 1).ToString("X")}:\t";
            //    for (int j = 0; j < 1; j++) line += $"{CPU1.Bus.RAM.MEM[(i * 1) + j].ToString("X2")}  ";

            //    listView1.Items.Add(line);
            //}
            ////listView1.SelectedIndex = CPU1.Bus.MAR.Data;
            //listView1.Enabled = true;



        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CPU1.Clock.Frequency = trackBar1.Value;
            FreqLbl.Text = "Frequency: " + CPU1.Clock.Frequency.ToString() + "Hz";
        }

        private void StepClockBtn_MouseDown(object sender, MouseEventArgs e)
        {
            CPU1.Clock.Step();
        }

        private void StepClockBtn_MouseUp(object sender, MouseEventArgs e)
        {
            CPU1.Clock.Step();
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CPU1.Bus.Sum.CarryIn = checkBox1.Checked;
        }



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
            catch (Exception)
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 128; i++)
            {
                textBox1.Text += $"/* 0b{ Convert.ToString(i, 2).PadLeft(8, '0')} */\t0x0000,\r\n";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            CPU1.Reset();
        }

        private void StepClockBtn_Click(object sender, EventArgs e)
        {
            UpdateRamView();
        }
    }
}
