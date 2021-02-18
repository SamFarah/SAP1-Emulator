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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock= new  ClockGenerator ();
            clock.Frequency = numericUpDown1.Value;
            clock.Run();
            MainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {         
            led1.ChangeState(clock.Output);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            clock.Frequency = numericUpDown1.Value;
        }

       
    }
}
