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


        void TestPulseFunction()
        {
            //do all the things at each positive clock pulse 




            SAP1Bus.Read();
            SAP1Bus.Write();







        }
        public MainForm()
        {
            InitializeComponent();
            clock = new ClockGenerator(TestPulseFunction);
            SAP1Bus = new Bus();
            clock.Frequency = trackBar1.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTimer.Start(); // for visual effects

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
            InstRegLEDDisplay.DisplayData(SAP1Bus.InstReg.Data);
            SumRegLEDDisplay.DisplayData(SAP1Bus.Sum.Data);
            CarryOutLED.ChangeState(SAP1Bus.Sum.CarryOut);

            BusValLbl.Text = $"0x{SAP1Bus.Data.ToString("X2")}";
            ARegValLbl.Text = $"0x{SAP1Bus.A.Data.ToString("X2")}";
            BRegValLbl.Text = $"0x{SAP1Bus.B.Data.ToString("X2")}";
            InstRegValLbl.Text = $"0x{SAP1Bus.InstReg.Data.ToString("X2")}";
            SumRegValLbl.Text = $"0x{SAP1Bus.Sum.Data.ToString("X2")}";
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
            SAP1Bus.InstReg .Enable = !SAP1Bus.InstReg.Enable;
            if (SAP1Bus.InstReg.Enable) button6.BackColor = Color.Red;
            else button6.BackColor = SystemColors.Control;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SAP1Bus.InstReg.Load = !SAP1Bus.InstReg.Load;
            if (SAP1Bus.InstReg.Load) button9.BackColor = Color.Red;
            else button9.BackColor = SystemColors.Control;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SAP1Bus.Sum.CarryIn = checkBox1.Checked;
        }
    }
}
