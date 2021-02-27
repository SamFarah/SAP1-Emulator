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
        private SimulationForm mainForm = null;
        public AssemblyForm(Form callingForm)
        {
            mainForm = callingForm as SimulationForm;
            InitializeComponent();
        }
        private void AssemblyForm_Shown(object sender, EventArgs e)
        {
            NewProgramBtn_Click(sender, e);
            AssemblyTB.Focus();
            AssemblyTB.Select(AssemblyTB.Text.Length, 0);
        }

        private void LoadASMBtn_Click(object sender, EventArgs e)
        {
            Assembler assembler = new Assembler();

            assembler.GenerateCommands(AssemblyTB.Lines);
            if (assembler.Errors.Count == 0)
            {
                mainForm.Computer.RAM.MEM = assembler.GetMachineCode(RandomizeBlanksCB.Checked);
                mainForm.UpdateRamView();
                mainForm.LoadedProgramTB.Text = string.Empty;
                foreach (string line in AssemblyTB.Lines)
                {
                    string strippedline = line;
                    int index = strippedline.IndexOf(";");
                    if (index >= 0) strippedline = strippedline.Substring(0, index);
                    if (string.IsNullOrEmpty(strippedline.Trim())) continue;
                    mainForm.LoadedProgramTB.Text += strippedline + Environment.NewLine;

                }
                CodeValidationResultTB.Text = "Successfully Loaded Into RAM";
                CodeValidationResultTB.BackColor = SystemColors.Control;
                CodeValidationResultTB.ForeColor = Color.Green;
            }
            else
            {
                CodeValidationResultTB.Text = $"{assembler.Errors.Count} errors found:{Environment.NewLine}\t{ string.Join($"{Environment.NewLine}\t", assembler.Errors)}";
                CodeValidationResultTB.BackColor = SystemColors.Control;
                CodeValidationResultTB.ForeColor = Color.Red;

            }
        }

        private void LoadExample1Btn_Click(object sender, EventArgs e) { AssemblyTB.Text = "; Example 1\r\n; This program adds 2 variables together \r\n; https://youtu.be/dHWFpkGsxOs?t=1669\r\n\r\n.CODE\r\n\tLDA var1\t; Load A with the value of var1\r\n\tADD var2 \t; Add A with the value of var2\r\n\tOUT\t\t; Output the value in register A\r\n\tHLT\t\t; Halt the Computer\r\n\r\n.DATA\r\n\tvar1 $0E\t; Var1 initialized with 14 (DEC)\r\n\tvar2 $1C\t; Var2 initialized with 28 (DEC)"; }
        private void LoadExample2Btn_Click(object sender, EventArgs e) { AssemblyTB.Text = "; Example 2\r\n; This program counts in threes\r\n; https://youtu.be/FCscQGBIL-Y?t=558\r\n\r\n.CODE\r\n\tLDI $03\t\t; Load immediate value 3 to A\r\n\tSTA $0F\t\t; Store reg A value into memory 0F\r\n\tLDI $00\t\t; Load immediate value 0 to A\r\nLOOP:\tADD $0F\t\t; Add content of memory 0F to A\r\n\tOUT\t\t; Output Reg A to display\r\n\tJMP LOOP\t; Jump to loop"; }
        private void LoadExample3Btn_Click(object sender, EventArgs e) { AssemblyTB.Text = "; Example 3\r\n; This program counts from 0 to 255 then back to 0, repeats\r\n; https://youtu.be/Zg1NdPKoosU?t=1710\r\n\r\n.CODE\r\nSTART:\tOUT\t\t; Output Reg A\r\n\tADD var1\t; Add var1 value to Reg A\r\n\tJC LOOP\t\t; Jump to LOOP if cary =1\r\n\tJMP START\t; Jump to Start\r\nLOOP:\tSUB var1\t; Subtract var1 value from Reg A\r\n\tOUT\t\t; Output Reg A\r\n\tJZ START\t; Jump to start if ZF=0\r\n\tJMP LOOP\t; Jump to loop\r\n\r\n\r\n.DATA\r\n\tvar1 $01\t; Define inc/dev val"; }
        private void LoadExample4Btn_Click(object sender, EventArgs e) { AssemblyTB.Text = "; Example 4\r\n; This program that multiplies x and y.\r\n; https://youtu.be/Zg1NdPKoosU?t=2298\r\n\r\n.CODE\r\ntop:\t  LDA x\t\t; Load value of Op1 into A\r\n\t  SUB i\t\t; subtract value of i from A\r\n\t  JC  Continue:\t; jump to Cont if carry\r\n\t  LDA product\t; Load value of Res in A\r\n\t  OUT\t\t; Output result\r\n\t  HLT\t\t; Hault Computer\r\nContinue: STA x\t\t; Store value of A in Op1\r\n\t  LDA product\t; Load value of Res in A\r\n\t  ADD y\t\t; Add value of Op2 into A\r\n\t  STA product\t; Sore value of A in Res\r\n\t  JMP top:\t; Jump to Start\r\n\r\n\r\n.DATA\r\n\ti  \t$01\t; Decrement variable\r\n\tx   \t$03\t; First operand variable\r\n\ty \t$05\t; Second operand variable\r\n\tproduct\t$00\t; Result variable"; }
        private void NewProgramBtn_Click(object sender, EventArgs e) { AssemblyTB.Text = "\r\n.CODE\r\n\r\n\r\n\r\n.DATA"; }

        //prevent form from being disposed of and not able to open again
        private void AssemblyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void AssemblyTB_TextChanged(object sender, EventArgs e) { CodeValidationResultTB.Text = string.Empty; }
        private void HideFormBtn_Click(object sender, EventArgs e) { this.Hide(); }
    }
}
