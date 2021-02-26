namespace SAP1Emulator
{
    partial class AssemblyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AssemblyTB = new System.Windows.Forms.TextBox();
            this.LoadASMBtn = new System.Windows.Forms.Button();
            this.LoadExample1Btn = new System.Windows.Forms.Button();
            this.LoadExample2Btn = new System.Windows.Forms.Button();
            this.LoadExample3Btn = new System.Windows.Forms.Button();
            this.LoadExample4Btn = new System.Windows.Forms.Button();
            this.NewProgramBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssemblyTB
            // 
            this.AssemblyTB.AcceptsTab = true;
            this.AssemblyTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssemblyTB.Location = new System.Drawing.Point(158, 12);
            this.AssemblyTB.Multiline = true;
            this.AssemblyTB.Name = "AssemblyTB";
            this.AssemblyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AssemblyTB.Size = new System.Drawing.Size(398, 395);
            this.AssemblyTB.TabIndex = 153;
            // 
            // LoadASMBtn
            // 
            this.LoadASMBtn.Location = new System.Drawing.Point(481, 413);
            this.LoadASMBtn.Name = "LoadASMBtn";
            this.LoadASMBtn.Size = new System.Drawing.Size(75, 62);
            this.LoadASMBtn.TabIndex = 154;
            this.LoadASMBtn.Text = "Load Code into RAM";
            this.LoadASMBtn.UseVisualStyleBackColor = true;
            this.LoadASMBtn.Click += new System.EventHandler(this.LoadASMBtn_Click);
            // 
            // LoadExample1Btn
            // 
            this.LoadExample1Btn.Location = new System.Drawing.Point(12, 12);
            this.LoadExample1Btn.Name = "LoadExample1Btn";
            this.LoadExample1Btn.Size = new System.Drawing.Size(94, 23);
            this.LoadExample1Btn.TabIndex = 155;
            this.LoadExample1Btn.Text = "Example 1";
            this.LoadExample1Btn.UseVisualStyleBackColor = true;
            this.LoadExample1Btn.Click += new System.EventHandler(this.LoadExample1Btn_Click);
            // 
            // LoadExample2Btn
            // 
            this.LoadExample2Btn.Location = new System.Drawing.Point(12, 41);
            this.LoadExample2Btn.Name = "LoadExample2Btn";
            this.LoadExample2Btn.Size = new System.Drawing.Size(94, 23);
            this.LoadExample2Btn.TabIndex = 156;
            this.LoadExample2Btn.Text = "Example 2";
            this.LoadExample2Btn.UseVisualStyleBackColor = true;
            this.LoadExample2Btn.Click += new System.EventHandler(this.LoadExample2Btn_Click);
            // 
            // LoadExample3Btn
            // 
            this.LoadExample3Btn.Location = new System.Drawing.Point(13, 70);
            this.LoadExample3Btn.Name = "LoadExample3Btn";
            this.LoadExample3Btn.Size = new System.Drawing.Size(94, 23);
            this.LoadExample3Btn.TabIndex = 157;
            this.LoadExample3Btn.Text = "Example 3";
            this.LoadExample3Btn.UseVisualStyleBackColor = true;
            this.LoadExample3Btn.Click += new System.EventHandler(this.LoadExample3Btn_Click);
            // 
            // LoadExample4Btn
            // 
            this.LoadExample4Btn.Location = new System.Drawing.Point(13, 99);
            this.LoadExample4Btn.Name = "LoadExample4Btn";
            this.LoadExample4Btn.Size = new System.Drawing.Size(94, 23);
            this.LoadExample4Btn.TabIndex = 158;
            this.LoadExample4Btn.Text = "Example 4";
            this.LoadExample4Btn.UseVisualStyleBackColor = true;
            this.LoadExample4Btn.Click += new System.EventHandler(this.LoadExample4Btn_Click);
            // 
            // NewProgramBtn
            // 
            this.NewProgramBtn.Location = new System.Drawing.Point(12, 152);
            this.NewProgramBtn.Name = "NewProgramBtn";
            this.NewProgramBtn.Size = new System.Drawing.Size(94, 23);
            this.NewProgramBtn.TabIndex = 159;
            this.NewProgramBtn.Text = "New Program";
            this.NewProgramBtn.UseVisualStyleBackColor = true;
            this.NewProgramBtn.Click += new System.EventHandler(this.NewProgramBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 165);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruction Cheatsheet";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(137, 136);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "LDA: Load A; MEM->A\r\nADD: (A+B)->A \r\nSUB: (A-B)->A\r\nSTA: Store A; A->MEM\r\nLDI: Lo" +
    "ad Immediate\r\nJMP: Jump to label\r\n JC: Jmp if CF=1\r\n JZ: Jmp if ZF=1\r\nOUT: A->Ou" +
    "tput\r\nHLT: Stop Clock";
            // 
            // AssemblyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.NewProgramBtn);
            this.Controls.Add(this.LoadExample4Btn);
            this.Controls.Add(this.LoadExample3Btn);
            this.Controls.Add(this.LoadExample2Btn);
            this.Controls.Add(this.LoadExample1Btn);
            this.Controls.Add(this.LoadASMBtn);
            this.Controls.Add(this.AssemblyTB);
            this.Name = "AssemblyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssemblyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssemblyForm_FormClosing);
            this.Shown += new System.EventHandler(this.AssemblyForm_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AssemblyTB;
        private System.Windows.Forms.Button LoadASMBtn;
        private System.Windows.Forms.Button LoadExample1Btn;
        private System.Windows.Forms.Button LoadExample2Btn;
        private System.Windows.Forms.Button LoadExample3Btn;
        private System.Windows.Forms.Button LoadExample4Btn;
        private System.Windows.Forms.Button NewProgramBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}