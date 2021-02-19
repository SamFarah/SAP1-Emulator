namespace SAP1Emulator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ClockModeBtn = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.FreqLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StepClockBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.led2 = new SAP1Emulator.AppCode.Visual.LED();
            this.led1 = new SAP1Emulator.AppCode.Visual.LED();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockModeBtn
            // 
            this.ClockModeBtn.BackColor = System.Drawing.Color.Red;
            this.ClockModeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClockModeBtn.Location = new System.Drawing.Point(243, 49);
            this.ClockModeBtn.Name = "ClockModeBtn";
            this.ClockModeBtn.Size = new System.Drawing.Size(75, 23);
            this.ClockModeBtn.TabIndex = 0;
            this.ClockModeBtn.Text = "Stopped";
            this.ClockModeBtn.UseVisualStyleBackColor = false;
            this.ClockModeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // FreqLbl
            // 
            this.FreqLbl.AutoSize = true;
            this.FreqLbl.Location = new System.Drawing.Point(337, 36);
            this.FreqLbl.Name = "FreqLbl";
            this.FreqLbl.Size = new System.Drawing.Size(82, 13);
            this.FreqLbl.TabIndex = 4;
            this.FreqLbl.Text = "Frequency: 1Hz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Output LED:";
            // 
            // StepClockBtn
            // 
            this.StepClockBtn.Location = new System.Drawing.Point(243, 78);
            this.StepClockBtn.Name = "StepClockBtn";
            this.StepClockBtn.Size = new System.Drawing.Size(75, 23);
            this.StepClockBtn.TabIndex = 5;
            this.StepClockBtn.Text = "Step";
            this.StepClockBtn.UseVisualStyleBackColor = true;
            this.StepClockBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(324, 52);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(151, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // led2
            // 
            this.led2.LEDColor = System.Drawing.Color.Lime;
            this.led2.Location = new System.Drawing.Point(559, 50);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(11, 11);
            this.led2.TabIndex = 6;
            // 
            // led1
            // 
            this.led1.Location = new System.Drawing.Point(547, 50);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(11, 11);
            this.led1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.StepClockBtn);
            this.Controls.Add(this.FreqLbl);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClockModeBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClockModeBtn;
        private System.Windows.Forms.Timer MainTimer;
        private AppCode.Visual.LED led1;
        private System.Windows.Forms.Label FreqLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StepClockBtn;
        private AppCode.Visual.LED led2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

