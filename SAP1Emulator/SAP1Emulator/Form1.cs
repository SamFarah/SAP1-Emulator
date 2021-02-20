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
            SAP1Bus.A.Data = 0x01;//test init
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
            SumRegLEDDisplay.DisplayData(SAP1Bus.Sum.Data);
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

        private void button6_Click(object sender, EventArgs e)
        {
            SAP1Bus.Sum .Load = !SAP1Bus.Sum.Load;
            if (SAP1Bus.Sum .Load) button6.BackColor = Color.Red;
            else button6.BackColor = SystemColors.Control;
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
    }
}
