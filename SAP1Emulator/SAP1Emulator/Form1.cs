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
        public MainForm()
        {
            InitializeComponent();
            clock = new ClockGenerator();
            clock.Frequency = trackBar1.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
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
            led1.ChangeState(clock.Output);
            led2.ChangeState(clock.OutputInverse);
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            clock.Step();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            clock.Frequency = trackBar1.Value;
            FreqLbl.Text = "Frequency: " + clock.Frequency.ToString() + "Hz";
        }

      
    }
}
