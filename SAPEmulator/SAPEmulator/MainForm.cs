using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPEmulator
{
    public partial class MainForm : Form
    {

        
        public MainForm()
        {
            InitializeComponent();            
        }

        private void OpenSap1Btn_Click(object sender, EventArgs e)
        {
            new Sap1SimulationForm().Show();
        }

        private void OpenSap2Btn_Click(object sender, EventArgs e)
        {
            new Sap2SimulationForm().Show();
        }
    }
}
