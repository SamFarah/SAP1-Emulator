using SAP1Modules;
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
    public partial class AssemblyForm : Form
    {
        public AssemblyForm()
        {
            InitializeComponent();
        }
        private SimulationForm  mainForm = null;
        public AssemblyForm(Form callingForm)
        {
            mainForm = callingForm as SimulationForm;
            InitializeComponent();
        }

        private void LoadASMBtn_Click(object sender, EventArgs e)
        {
            Assembler t = new Assembler();

            t.GenerateCommands(AssemblyTB .Lines);
            if (t.isValid)
            {
                //MessageBox.Show(string.Join(Environment.NewLine, new List<Byte>(t.GetMachineCode()).Select(x => $"0x{x.ToString("X2")}")));
                mainForm. Computer.RAM.MEM = t.GetMachineCode();
                mainForm.UpdateRamView();
                mainForm.LoadedProgramTB.Text = string.Empty;
                foreach(string line in AssemblyTB .Lines)
                {
                    string strippedline= line;
                    int index = strippedline.IndexOf(";");
                    if (index >= 0) strippedline = strippedline.Substring(0, index);
                    if (string.IsNullOrEmpty(strippedline.Trim())) continue;
                    mainForm.LoadedProgramTB.Text +=strippedline + Environment.NewLine ;
                    
                }                               
            }
            else
                MessageBox.Show("Invalid Code");
        }

       
        private void LoadExample1Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text = "; A program that multiplies x and y and outputs the result into the display. Ben Eater used this example in the end of his video \"Conditional jump instructions\" https://youtu.be/Zg1NdPKoosU?t=2298\r\n\r\n.CODE\r\ntop:\t  LDA x\t\t; Load value of Op1 into A\r\n\t  SUB i\t\t; subtract value of i from A\r\n\t  JC  Continue:\t; jump to Cont if carry\r\n\t  LDA product\t; Load value of Res in A\r\n\t  OUT\t\t; Output result\r\n\t  HLT\t\t; Hault Computer\r\nContinue: STA x\t\t; Store value of A in Op1\r\n\t  LDA product\t; Load value of Res in A\r\n\t  ADD y\t\t; Add value of Op2 into A\r\n\t  STA product\t; Sore value of A in Res\r\n\t  JMP top:\t; Jump to Start\r\n\r\n\r\n.DATA\r\n\ti  \t$01\t; Decrement variable\r\n\tx   \t$03\t; First operand variable\r\n\ty \t$05\t; Second operand variable\r\n\tproduct\t$00\t; Result variable";
        }

        private void LoadExample2Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text = ".CODE\r\n\tLDI $03\t\t; Load immediate value 3 to A\r\n\tSTA $0F\t\t; Store reg A value into memory 0F\r\n\tLDI $00\t\t; Load immediate value 0 to A\r\nLOOP:\tADD $0F\t\t; Add content of memory 0F to A\r\n\tOUT\t\t; Output Reg A to display\r\n\tJMP LOOP\t; Jump to loop";            
        }

        private void LoadExample3Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text = ".CODE\r\nSTART:\tOUT\t\t; Output Reg A\r\n\tADD var1\t; Add var1 value to Reg A\r\n\tJC LOOP\t\t; Jump to LOOP if cary =1\r\n\tJMP START\t; Jump to Start\r\nLOOP:\tSUB var1\t; Subtract var1 value from Reg A\r\n\tOUT\t\t; Output Reg A\r\n\tJZ START\t; Jump to start if ZF=0\r\n\tJMP LOOP\t; Jump to loop\r\n\r\n\r\n.DATA\r\n\tvar1 $01\t; Define inc/dev val";
        }

        private void LoadExample4Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text = ".CODE\r\n\tLDA var1 \r\n\tADD var2 \r\n\tOUT\r\n\tHLT\r\n\r\n.DATA\r\n\tvar1 $0E\r\n\tvar2 $1C";
        }
        private void NewProgramBtn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text = "\r\n.CODE\r\n\r\n\r\n\r\n.DATA";
        }
        private void AssemblyForm_Shown(object sender, EventArgs e)
        {
            LoadExample1Btn_Click(sender, e);
            AssemblyTB.Focus();
            AssemblyTB.Select(AssemblyTB.Text.Length, 0);
        }

        
    }
}
