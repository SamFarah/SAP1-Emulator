using SAP2Modules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SAPEmulator
{
    public partial class Sap2AssemblyForm : Form
    {
        public Sap2AssemblyForm()
        {
            InitializeComponent();
            this.AssemblyTB.theLabel = label1;
        }
        private Sap2SimulationForm mainForm = null;
        public Sap2AssemblyForm(Form callingForm)
        {
            mainForm = callingForm as Sap2SimulationForm;
            InitializeComponent();
            this.AssemblyTB.theLabel = label1;
        }
        private void AssemblyForm_Shown(object sender, EventArgs e)
        {
            NewProgramBtn_Click(sender, e);
            AssemblyTB.Focus();
            AssemblyTB.Select(AssemblyTB.Text.Length, 0);
        }

        private void LoadASMBtn_Click(object sender, EventArgs e)
        {
            //Create a temp file

            string FileName = @"tempCodeFile.asm";

            try
            {
                using (FileStream fs = File.Create(FileName))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(@"
#ruledef
{
	add b			        => 0x80 
	add c			        => 0x81
    add [{address}]         => 0x82 @ le(address`16)
    adi {value}             => 0x83 @ value`8
	ana b			        => 0xA0
	ana c			        => 0xA1
	ani	{value}		        => 0xE6	@ value`8
	call {address}	        => 0xCD @ le(address`16)
	cma				        => 0x2F
	dcr a			        => 0x3D
	dcr b			        => 0x05
	dcr c			        => 0x0D
	hlt				        => 0x76
	in	{value}		        => 0xDB @ value`8
	inr a                   => 0x3C
	inr b                   => 0x04
	inr c                   => 0x0C
	jm {address}	        => 0xFA @ le(address`16)
    jc {address}	        => 0xFB @ le(address`16)
	jmp {address}	        => 0xC3	@ le(address`16)
	jnz {address}	        => 0xC2	@ le(address`16)
	jz	{address}  	        => 0xCA	@ le(address`16)
	lda {address} 	        => 0x3A	@ le(address`16)
    lda [{address}]	        => 0x3B	@ le(address`16)
	mov a, b		        => 0x78
	mov a, c		        => 0x79
	mov b, a		        => 0x47
	mov b, c		        => 0x41
	mov c, a		        => 0x4F
	mov c, b		        => 0x48
	mvi a, {value}	        => 0x3E @ value`8
	mvi b, {value}	        => 0x06 @ value`8
	mvi c, {value}	        => 0x0E @ value`8
	nop				        => 0x00
	ora b			        => 0xB0	
	ora c			        => 0xB1
	ori {value}		        => 0xF6 @ value`8
    out                     => 0xD2
	out	{value}		        => 0xD3 @ value`8	
    out [{address}]         => 0xD4 @ le(address`16)
	ral				        => 0x17
	rar				        => 0x1F
	ret				        => 0xC9
	sta {address}	        => 0x32	@ le(address`16)
	sta [{address}]	        => 0x01	@ le(address`16)        
    sti {address},{value}   => 0x33 @ le(address`16) @ value`8
	sub b			        => 0x90
	sub c			        => 0x91
    sub [{address}]         => 0x92 @ le(address`16)
    sbi {value}             => 0x93 @ value`8
	xra b			        => 0xA8	
	xra c			        => 0xA9
	xri	{value}		        => 0xEE	@ value`8
    pha                     => 0x60
    pla                     => 0x61
}	
" + AssemblyTB.Text);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {


            }


            //Create BIN file
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $@"/C customasm.exe {FileName}  -p -f hexstr -q ";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
            process.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF7;
            process.Start();
            string q = "";
            string error = "";
            string res = "";
            while (!process.HasExited)
            {
                q += process.StandardOutput.ReadToEnd();
                error += process.StandardError.ReadToEnd();
                res = q + (error.Replace('`', '\''));
            }
            File.Delete(FileName);
            string outga = @"(.*\d+m}*)(\d+:\d+:)?";
            res = Regex.Replace(res, outga, "");
            if (process.ExitCode == 0)
            {
                //success                
                res = "customasm v0.11.12 (2021-10-10, x86_64-pc-windows-gnu)\nassembling...\nSuccess: Program written to Memory";


                byte[] retVal = mainForm.Computer.RAM.MEM;
                int address = 0;
                if (WipeMemoryCB.Checked) for (int i = 0; i < 64 * 1024; i++) retVal[i] = 0xFF;
                for (int i = 0; i < q.Length - 1; i += 2)
                {
                    StringBuilder temp = new StringBuilder();
                    temp.Append(q[i]);
                    temp.Append(q[i + 1]);
                    retVal[address++] = byte.Parse(temp.ToString(), System.Globalization.NumberStyles.HexNumber);
                }

                mainForm.Computer.RAM.MEM = retVal;
                mainForm.UpdateRamView();
            }
            List<string> Q = res.Split(Environment.NewLine.ToCharArray()).ToList();
            CMDOutTB.Text = string.Empty;
            Application.DoEvents();
            foreach (string Line in Q)
            {
                CMDOutTB.AppendText(Line + '\r' + '\n');
                System.Threading.Thread.Sleep(10);
            }

            CMDOutTB.SelectionStart = CMDOutTB.Text.Length;
            CMDOutTB.ScrollToCaret();
        }

        private void LoadExample1Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 1:                                                 |
; 	| This program adds 2 variables together (var1 + var2)       |
;	+------------------------------------------------------------+

	STI var1, 0x0E ; var1 initialized with 14 (DEC = 0E Hex)
	STI var2, 28 ; var2 initialized with 28 (DEC)

	LDA var1	 ; Load A with the value of var1
	ADD [var2] 	 ; Add (Direct) A with the value of var2
	OUT		 ; Output the value in register A
	HLT		 ; Halt the Computer

; Variables
var1: #res 1		 ; define a mem location as a var reserve 1 byte
var2: #res 1		 ; define a mem location as a var reserve 1 byte";
        }
        private void LoadExample2Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 2:                                                 |
; 	| This program counts in fives                               |
;	+------------------------------------------------------------+

	MVI B,0b00000101	; cpy the value 5 (in binary) to Reg B
	MVI A,0		; Initialize Reg A with 0
LOOP:
	ADD B			; Add Reg B to Reg A and store in A
	OUT			; ouput the value of reg A
	JMP LOOP		; go back to loop
";
        }
        private void LoadExample3Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 3:                                                 |
; 	| This program counts from 0 to 255 then back to 0, repeats  |
;	+------------------------------------------------------------+

	MVI A, 0x00	; Initialize Reg A with 0
START:
	OUT		; Output contect of Reg A
	INR A		; Increment A
	JC Loop	; Jump to Loop if carry flag is active
	JMP START	; Jump to Start
Loop:
	DCR A		; Decrement A
	OUT		; Output contect of Reg A
	JZ START	; Jump to Start if Zero flag is active
	JMP Loop	; Jump to Loop";
        }
        private void LoadExample4Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 4:                                                 |
; 	| This program multiplies x by y and outputs the result      |
;	+------------------------------------------------------------+

; Constants
x= 0x03		; constant
y= 0x05		; constant

	STI prod,0x00	; initialize prod var with 0
	STI tmp1,x	; initialize tmp1 var with value of x	
loop:
	LDA prod	; Load value of prod into Reg A	
	ADI y		; Add (immediate) A = A + y 
	STA prod	; Store the value of Reg A into prod	
	LDA tmp1	; Load the value of tmp1 into Reg A
	DCR A		; Decrement Reg A
	STA tmp1	; Store the value of Reg A into tmp1
	jz finish	; Jump to finish if decrement was 0
	jmp loop	; Jump to loop
finish:
	out [prod]	; output the value of prod
	hlt		; hault the program
	
; Variables, will be stored right after the program
prod:	#res 1		; define a mem location as a var reserve 1 byte
tmp1:	#res 1		; define a mem location as a var reserve 1 byte";
        }

        private void LoadExample5Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 5:                                                 |
; 	| This program utilizes STA [address] to empty out its own   |
;	| memory right after its program                             |
;	+------------------------------------------------------------+

	STI CurAddrL, CurAddrH+1	; this will take the low part of the 
				     	; address of CurAddrH and add one to it 
				     	; (technically getting the address of 
					; the last line of the code) and store 
					; it in CurAddrL memory location
	STI CurAddrH, 0x00		; Initialize var to 0
LOOP:
	MVI A,0x00			; Initialize Reg A to 0
	STA [CurAddrL]		; Store 0 in the location of the value 
					; of CurAddrL|CurAddrH (think pointer)
	LDA CurAddrL			; Load value of CurAddrL to Reg A
	INR A				; Increment A
	JNZ A1				; If not 0 Jump to A1
	LDA CurAddrH			; Load value of CurAddrH to Reg A
	INR A				; Inrement A
	JZ Finish			; If 0 jump to finish (wrapped over)
	STA CurAddrH			; Store A into CurAddrH
	MVI A,0x00			; Reinit Reg A with 0
A1:
	STA CurAddrL			; Store A into CurAddrL
	JMP LOOP			; Jump to start
Finish:
	HLT				; Hault the program

;Variables
CurAddrL: #res 1	; Holds the low part of current address
CurAddrH: #res 1	; Holds the high part of current address";
        }
        private void LoadExample6Btn_Click(object sender, EventArgs e)
        {
            AssemblyTB.Text =
@";	+------------------------------------------------------------+
; 	| Example 6:                                                 |
; 	| This program does a bubble sort on an array, still WIP     |
;	+------------------------------------------------------------+

ArraySize = 10

	STI i, Array
	STI i+1, le(Array`16) 
	LDA [i]

Loop:	
	MOV B,A
	LDA i
	INR A
	STA i
	LDA [i]

	SUB B
	JM Swap	
	
Cont:	
	LDA i
	INR A
	JNZ A1
	LDA i+1
	INR A
	JZ Finish
	STA i+1
	MVI A,0x00	
A1:
	STA i
	LDA [i]
	JMP Loop
Finish: 
	HLT

Swap:
	LDA [i]
	STA temp
	LDA i
	DCR A
	STA i2
	LDA [i2]
	STA [i]
	LDA temp
	STA [i2]
	JMP Cont
	
;Variables
#addr 0x0100	; skip to address 0x0100 for variables
Array:	#res ArraySize
i:	#res 2
i2:	#res 2
j:	#res 1
temp:	#res 2";
        }
        private void NewProgramBtn_Click(object sender, EventArgs e) { AssemblyTB.Text = ""; }

        //prevent form from being disposed of and not able to open again
        private void AssemblyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void AssemblyTB_TextChanged(object sender, EventArgs e) { CMDOutTB.Text = string.Empty; }
        private void HideFormBtn_Click(object sender, EventArgs e) { this.Hide(); }

        
    }
}
