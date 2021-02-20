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
            SAP1Bus.Write();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTimer.Start(); // for visual effects
            UpdateRamView();
            DisplayLbl.Parent = DisplayShadowLbl;
            DisplayLbl.Location = new Point(0, 0);

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

            sbyte outputSigned = (sbyte)SAP1Bus.Output.Data;
            DisplayLbl.Text = $"{(outputSigned >= 0 ? " " :  "") }{outputSigned.ToString("000")}";


            if (clock.Output) //slow down the refresh rate of memory view
            {
                UpdateRamView();
            }


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
        private void StepClockBtn_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            SAP1Bus.A.Load = !SAP1Bus.A.Load;
            if (SAP1Bus.A.Load) button1.BackColor = Color.Red;
            else button1.BackColor = SystemColors.Control;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SAP1Bus.B.Load = !SAP1Bus.B.Load;
            if (SAP1Bus.B.Load) button4.BackColor = Color.Red;
            else button4.BackColor = SystemColors.Control;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            SAP1Bus.A.Enable = !SAP1Bus.A.Enable;
            if (SAP1Bus.A.Enable) button2.BackColor = Color.Red;
            else button2.BackColor = SystemColors.Control;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SAP1Bus.B.Enable = !SAP1Bus.B.Enable;
            if (SAP1Bus.B.Enable) button3.BackColor = Color.Red;
            else button3.BackColor = SystemColors.Control;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SAP1Bus.Sum.Enable = !SAP1Bus.Sum.Enable;
            if (SAP1Bus.Sum.Enable) button5.BackColor = Color.Red;
            else button5.BackColor = SystemColors.Control;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SAP1Bus.Sum.Subtract = !SAP1Bus.Sum.Subtract;
            if (SAP1Bus.Sum.Subtract) button7.Text = "Subtracting";
            else button7.Text = "Adding";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SAP1Bus.Data = (byte)Convert.ToInt64(textBox1.Text, 16);
            }
            catch (Exception)
            {


            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            SAP1Bus.Inst.Enable = !SAP1Bus.Inst.Enable;
            if (SAP1Bus.Inst.Enable) button6.BackColor = Color.Red;
            else button6.BackColor = SystemColors.Control;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SAP1Bus.Inst.Load = !SAP1Bus.Inst.Load;
            if (SAP1Bus.Inst.Load) button9.BackColor = Color.Red;
            else button9.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SAP1Bus.Sum.CarryIn = checkBox1.Checked;
        }



        private void button13_Click(object sender, EventArgs e)
        {
            SAP1Bus.MAR.Load = !SAP1Bus.MAR.Load;
            if (SAP1Bus.MAR.Load) button13.BackColor = Color.Red;
            else button13.BackColor = SystemColors.Control;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SAP1Bus.RAM.Load = !SAP1Bus.RAM.Load;
            if (SAP1Bus.RAM.Load) button11.BackColor = Color.Red;
            else button11.BackColor = SystemColors.Control;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SAP1Bus.RAM.Enable = !SAP1Bus.RAM.Enable;
            if (SAP1Bus.RAM.Enable) button10.BackColor = Color.Red;
            else button10.BackColor = SystemColors.Control;
        }

        private void ProGramBtn_Click(object sender, EventArgs e)
        {
            byte Address = (byte)Convert.ToInt64(ProgRAMAddrTB.Text.Trim(), 16);
            byte Data = (byte)Convert.ToInt64(ProgRamDataTB.Text.Trim(), 16);
            SAP1Bus.RAM.MEM[Address] = Data;
            UpdateRamView();
            ProgRAMAddrTB.Text = "0x";
            ProgRamDataTB.Text = "0x";
            ProgRAMAddrTB.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SAP1Bus.PC.Load = !SAP1Bus.PC.Load;
            if (SAP1Bus.PC.Load) button12.BackColor = Color.Red;
            else button12.BackColor = SystemColors.Control;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SAP1Bus.PC.Enable = !SAP1Bus.PC.Enable;
            if (SAP1Bus.PC.Enable) button14.BackColor = Color.Red;
            else button14.BackColor = SystemColors.Control;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SAP1Bus.PC.Inc();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SAP1Bus.Output.Load = !SAP1Bus.Output.Load;
            if (SAP1Bus.Output.Load) button17.BackColor = Color.Red;
            else button17.BackColor = SystemColors.Control;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SAP1Bus.Output.Enable = !SAP1Bus.Output.Enable;
            if (SAP1Bus.Output.Enable) button16.BackColor = Color.Red;
            else button16.BackColor = SystemColors.Control;
        }
    }
}
