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
            this.AssemblyTB = new System.Windows.Forms.TextBox();
            this.LoadASMBtn = new System.Windows.Forms.Button();
            this.LoadExample1Btn = new System.Windows.Forms.Button();
            this.LoadExample2Btn = new System.Windows.Forms.Button();
            this.LoadExample3Btn = new System.Windows.Forms.Button();
            this.LoadExample4Btn = new System.Windows.Forms.Button();
            this.NewProgramBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RandomizeBlanksCB = new System.Windows.Forms.CheckBox();
            this.CodeValidationResultTB = new System.Windows.Forms.TextBox();
            this.HideFormBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssemblyTB
            // 
            this.AssemblyTB.AcceptsTab = true;
            this.AssemblyTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssemblyTB.Location = new System.Drawing.Point(162, 51);
            this.AssemblyTB.Multiline = true;
            this.AssemblyTB.Name = "AssemblyTB";
            this.AssemblyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AssemblyTB.Size = new System.Drawing.Size(388, 326);
            this.AssemblyTB.TabIndex = 153;
            this.AssemblyTB.TextChanged += new System.EventHandler(this.AssemblyTB_TextChanged);
            // 
            // LoadASMBtn
            // 
            this.LoadASMBtn.Location = new System.Drawing.Point(470, 452);
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
            this.NewProgramBtn.Location = new System.Drawing.Point(6, 176);
            this.NewProgramBtn.Name = "NewProgramBtn";
            this.NewProgramBtn.Size = new System.Drawing.Size(150, 23);
            this.NewProgramBtn.TabIndex = 159;
            this.NewProgramBtn.Text = "New Program";
            this.NewProgramBtn.UseVisualStyleBackColor = true;
            this.NewProgramBtn.Click += new System.EventHandler(this.NewProgramBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 207);
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
            this.textBox2.Size = new System.Drawing.Size(135, 182);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 452);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 73);
            this.textBox1.TabIndex = 161;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(544, 33);
            this.textBox3.TabIndex = 163;
            this.textBox3.Text = "Please note that values are entered in Hexadecimal in the form of $00 ... $FF, fo" +
    "r example LDA $0F. they could also be variable or label names";
            // 
            // RandomizeBlanksCB
            // 
            this.RandomizeBlanksCB.AutoSize = true;
            this.RandomizeBlanksCB.Checked = true;
            this.RandomizeBlanksCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RandomizeBlanksCB.Location = new System.Drawing.Point(12, 210);
            this.RandomizeBlanksCB.Name = "RandomizeBlanksCB";
            this.RandomizeBlanksCB.Size = new System.Drawing.Size(114, 17);
            this.RandomizeBlanksCB.TabIndex = 164;
            this.RandomizeBlanksCB.Text = "Randomize Blanks";
            this.RandomizeBlanksCB.UseVisualStyleBackColor = true;
            // 
            // CodeValidationResultTB
            // 
            this.CodeValidationResultTB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeValidationResultTB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CodeValidationResultTB.Location = new System.Drawing.Point(162, 383);
            this.CodeValidationResultTB.Multiline = true;
            this.CodeValidationResultTB.Name = "CodeValidationResultTB";
            this.CodeValidationResultTB.ReadOnly = true;
            this.CodeValidationResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeValidationResultTB.Size = new System.Drawing.Size(388, 63);
            this.CodeValidationResultTB.TabIndex = 165;
            // 
            // HideFormBtn
            // 
            this.HideFormBtn.Location = new System.Drawing.Point(470, 499);
            this.HideFormBtn.Name = "HideFormBtn";
            this.HideFormBtn.Size = new System.Drawing.Size(80, 26);
            this.HideFormBtn.TabIndex = 166;
            this.HideFormBtn.Text = "Hide";
            this.HideFormBtn.UseVisualStyleBackColor = true;
            this.HideFormBtn.Click += new System.EventHandler(this.HideFormBtn_Click);
            // 
            // AssemblyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 531);
            this.Controls.Add(this.HideFormBtn);
            this.Controls.Add(this.CodeValidationResultTB);
            this.Controls.Add(this.RandomizeBlanksCB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.NewProgramBtn);
            this.Controls.Add(this.LoadExample4Btn);
            this.Controls.Add(this.LoadExample3Btn);
            this.Controls.Add(this.LoadExample2Btn);
            this.Controls.Add(this.LoadExample1Btn);
            this.Controls.Add(this.LoadASMBtn);
            this.Controls.Add(this.AssemblyTB);
            this.MaximizeBox = false;
            this.Name = "AssemblyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assembly";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox RandomizeBlanksCB;
        private System.Windows.Forms.TextBox CodeValidationResultTB;
        private System.Windows.Forms.Button HideFormBtn;
    }
}