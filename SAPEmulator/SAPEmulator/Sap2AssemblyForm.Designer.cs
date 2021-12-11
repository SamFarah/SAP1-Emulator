namespace SAPEmulator
{
    partial class Sap2AssemblyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sap2AssemblyForm));
            this.LoadASMBtn = new System.Windows.Forms.Button();
            this.LoadExample1Btn = new System.Windows.Forms.Button();
            this.LoadExample2Btn = new System.Windows.Forms.Button();
            this.LoadExample3Btn = new System.Windows.Forms.Button();
            this.LoadExample4Btn = new System.Windows.Forms.Button();
            this.NewProgramBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CMDOutTB = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.WipeMemoryCB = new System.Windows.Forms.CheckBox();
            this.HideFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AssemblyTB = new SyntaxHighlightingTextBox();
            this.LoadExample5Btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LoadASMBtn
            // 
            this.LoadASMBtn.Location = new System.Drawing.Point(624, 489);
            this.LoadASMBtn.Name = "LoadASMBtn";
            this.LoadASMBtn.Size = new System.Drawing.Size(80, 41);
            this.LoadASMBtn.TabIndex = 154;
            this.LoadASMBtn.Text = "Load Code into RAM";
            this.LoadASMBtn.UseVisualStyleBackColor = true;
            this.LoadASMBtn.Click += new System.EventHandler(this.LoadASMBtn_Click);
            // 
            // LoadExample1Btn
            // 
            this.LoadExample1Btn.Location = new System.Drawing.Point(6, 51);
            this.LoadExample1Btn.Name = "LoadExample1Btn";
            this.LoadExample1Btn.Size = new System.Drawing.Size(150, 23);
            this.LoadExample1Btn.TabIndex = 155;
            this.LoadExample1Btn.Text = "Example 1";
            this.LoadExample1Btn.UseVisualStyleBackColor = true;
            this.LoadExample1Btn.Click += new System.EventHandler(this.LoadExample1Btn_Click);
            // 
            // LoadExample2Btn
            // 
            this.LoadExample2Btn.Location = new System.Drawing.Point(6, 80);
            this.LoadExample2Btn.Name = "LoadExample2Btn";
            this.LoadExample2Btn.Size = new System.Drawing.Size(150, 23);
            this.LoadExample2Btn.TabIndex = 156;
            this.LoadExample2Btn.Text = "Example 2";
            this.LoadExample2Btn.UseVisualStyleBackColor = true;
            this.LoadExample2Btn.Click += new System.EventHandler(this.LoadExample2Btn_Click);
            // 
            // LoadExample3Btn
            // 
            this.LoadExample3Btn.Location = new System.Drawing.Point(7, 109);
            this.LoadExample3Btn.Name = "LoadExample3Btn";
            this.LoadExample3Btn.Size = new System.Drawing.Size(150, 23);
            this.LoadExample3Btn.TabIndex = 157;
            this.LoadExample3Btn.Text = "Example 3";
            this.LoadExample3Btn.UseVisualStyleBackColor = true;
            this.LoadExample3Btn.Click += new System.EventHandler(this.LoadExample3Btn_Click);
            // 
            // LoadExample4Btn
            // 
            this.LoadExample4Btn.Location = new System.Drawing.Point(7, 138);
            this.LoadExample4Btn.Name = "LoadExample4Btn";
            this.LoadExample4Btn.Size = new System.Drawing.Size(150, 23);
            this.LoadExample4Btn.TabIndex = 158;
            this.LoadExample4Btn.Text = "Example 4";
            this.LoadExample4Btn.UseVisualStyleBackColor = true;
            this.LoadExample4Btn.Click += new System.EventHandler(this.LoadExample4Btn_Click);
            // 
            // NewProgramBtn
            // 
            this.NewProgramBtn.Location = new System.Drawing.Point(6, 198);
            this.NewProgramBtn.Name = "NewProgramBtn";
            this.NewProgramBtn.Size = new System.Drawing.Size(150, 23);
            this.NewProgramBtn.TabIndex = 159;
            this.NewProgramBtn.Text = "New Program";
            this.NewProgramBtn.UseVisualStyleBackColor = true;
            this.NewProgramBtn.Click += new System.EventHandler(this.NewProgramBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 233);
            this.groupBox3.TabIndex = 160;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruction Cheatsheet";
            // 
            // CMDOutTB
            // 
            this.CMDOutTB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CMDOutTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMDOutTB.ForeColor = System.Drawing.Color.LimeGreen;
            this.CMDOutTB.Location = new System.Drawing.Point(6, 489);
            this.CMDOutTB.Multiline = true;
            this.CMDOutTB.Name = "CMDOutTB";
            this.CMDOutTB.ReadOnly = true;
            this.CMDOutTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CMDOutTB.Size = new System.Drawing.Size(612, 177);
            this.CMDOutTB.TabIndex = 161;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(698, 33);
            this.textBox3.TabIndex = 163;
            this.textBox3.Text = "Please note that values are entered in Hexadecimal in the form of 0x00 ... 0xFF, " +
    "for example LDA 0x0F. they could also be variable or label names, binary 0b01001" +
    ", and decimal 255";
            // 
            // WipeMemoryCB
            // 
            this.WipeMemoryCB.AutoSize = true;
            this.WipeMemoryCB.Location = new System.Drawing.Point(7, 227);
            this.WipeMemoryCB.Name = "WipeMemoryCB";
            this.WipeMemoryCB.Size = new System.Drawing.Size(91, 17);
            this.WipeMemoryCB.TabIndex = 164;
            this.WipeMemoryCB.Text = "Wipe Memory";
            this.WipeMemoryCB.UseVisualStyleBackColor = true;
            // 
            // HideFormBtn
            // 
            this.HideFormBtn.Location = new System.Drawing.Point(624, 536);
            this.HideFormBtn.Name = "HideFormBtn";
            this.HideFormBtn.Size = new System.Drawing.Size(80, 26);
            this.HideFormBtn.TabIndex = 166;
            this.HideFormBtn.Text = "Hide";
            this.HideFormBtn.UseVisualStyleBackColor = true;
            this.HideFormBtn.Click += new System.EventHandler(this.HideFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "label1";
            // 
            // AssemblyTB
            // 
            this.AssemblyTB.AcceptsTab = true;
            this.AssemblyTB.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssemblyTB.Location = new System.Drawing.Point(162, 51);
            this.AssemblyTB.MaxUndoRedoSteps = 500;
            this.AssemblyTB.Name = "AssemblyTB";
            this.AssemblyTB.Size = new System.Drawing.Size(542, 432);
            this.AssemblyTB.TabIndex = 167;
            this.AssemblyTB.Text = "";
            this.AssemblyTB.TextChanged += new System.EventHandler(this.AssemblyTB_TextChanged);
            // 
            // LoadExample5Btn
            // 
            this.LoadExample5Btn.Location = new System.Drawing.Point(6, 167);
            this.LoadExample5Btn.Name = "LoadExample5Btn";
            this.LoadExample5Btn.Size = new System.Drawing.Size(150, 23);
            this.LoadExample5Btn.TabIndex = 170;
            this.LoadExample5Btn.Text = "Example 5";
            this.LoadExample5Btn.UseVisualStyleBackColor = true;
            this.LoadExample5Btn.Click += new System.EventHandler(this.LoadExample5Btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(7, 672);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(698, 31);
            this.richTextBox1.TabIndex = 171;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Sap2AssemblyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 715);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LoadExample5Btn);
            this.Controls.Add(this.AssemblyTB);
            this.Controls.Add(this.HideFormBtn);
            this.Controls.Add(this.WipeMemoryCB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CMDOutTB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.NewProgramBtn);
            this.Controls.Add(this.LoadExample4Btn);
            this.Controls.Add(this.LoadExample3Btn);
            this.Controls.Add(this.LoadExample2Btn);
            this.Controls.Add(this.LoadExample1Btn);
            this.Controls.Add(this.LoadASMBtn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Sap2AssemblyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP 2 Assembly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssemblyForm_FormClosing);
            this.Shown += new System.EventHandler(this.AssemblyForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadASMBtn;
        private System.Windows.Forms.Button LoadExample1Btn;
        private System.Windows.Forms.Button LoadExample2Btn;
        private System.Windows.Forms.Button LoadExample3Btn;
        private System.Windows.Forms.Button LoadExample4Btn;
        private System.Windows.Forms.Button NewProgramBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CMDOutTB;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox WipeMemoryCB;
        private System.Windows.Forms.Button HideFormBtn;
        private SyntaxHighlightingTextBox AssemblyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadExample5Btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}