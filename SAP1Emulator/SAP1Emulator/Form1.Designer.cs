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
            this.FreqLbl = new System.Windows.Forms.Label();
            this.StepClockBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SumRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led35 = new SAP1Emulator.AppCode.Visual.LED();
            this.led36 = new SAP1Emulator.AppCode.Visual.LED();
            this.led37 = new SAP1Emulator.AppCode.Visual.LED();
            this.led38 = new SAP1Emulator.AppCode.Visual.LED();
            this.led39 = new SAP1Emulator.AppCode.Visual.LED();
            this.led40 = new SAP1Emulator.AppCode.Visual.LED();
            this.led41 = new SAP1Emulator.AppCode.Visual.LED();
            this.led42 = new SAP1Emulator.AppCode.Visual.LED();
            this.BRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led27 = new SAP1Emulator.AppCode.Visual.LED();
            this.led28 = new SAP1Emulator.AppCode.Visual.LED();
            this.led29 = new SAP1Emulator.AppCode.Visual.LED();
            this.led30 = new SAP1Emulator.AppCode.Visual.LED();
            this.led31 = new SAP1Emulator.AppCode.Visual.LED();
            this.led32 = new SAP1Emulator.AppCode.Visual.LED();
            this.led33 = new SAP1Emulator.AppCode.Visual.LED();
            this.led34 = new SAP1Emulator.AppCode.Visual.LED();
            this.ARegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led19 = new SAP1Emulator.AppCode.Visual.LED();
            this.led20 = new SAP1Emulator.AppCode.Visual.LED();
            this.led21 = new SAP1Emulator.AppCode.Visual.LED();
            this.led22 = new SAP1Emulator.AppCode.Visual.LED();
            this.led23 = new SAP1Emulator.AppCode.Visual.LED();
            this.led24 = new SAP1Emulator.AppCode.Visual.LED();
            this.led25 = new SAP1Emulator.AppCode.Visual.LED();
            this.led26 = new SAP1Emulator.AppCode.Visual.LED();
            this.BusLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led11 = new SAP1Emulator.AppCode.Visual.LED();
            this.led12 = new SAP1Emulator.AppCode.Visual.LED();
            this.led13 = new SAP1Emulator.AppCode.Visual.LED();
            this.led14 = new SAP1Emulator.AppCode.Visual.LED();
            this.led15 = new SAP1Emulator.AppCode.Visual.LED();
            this.led16 = new SAP1Emulator.AppCode.Visual.LED();
            this.led17 = new SAP1Emulator.AppCode.Visual.LED();
            this.led18 = new SAP1Emulator.AppCode.Visual.LED();
            this.ledDisplay2 = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led1 = new SAP1Emulator.AppCode.Visual.LED();
            this.led2 = new SAP1Emulator.AppCode.Visual.LED();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SumRegLEDDisplay.SuspendLayout();
            this.BRegLEDDisplay.SuspendLayout();
            this.ARegLEDDisplay.SuspendLayout();
            this.BusLEDDisplay.SuspendLayout();
            this.ledDisplay2.SuspendLayout();
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
            this.ClockModeBtn.Click += new System.EventHandler(this.ClockModeBtn_Click);
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
            // StepClockBtn
            // 
            this.StepClockBtn.Location = new System.Drawing.Point(243, 78);
            this.StepClockBtn.Name = "StepClockBtn";
            this.StepClockBtn.Size = new System.Drawing.Size(75, 23);
            this.StepClockBtn.TabIndex = 5;
            this.StepClockBtn.Text = "Step";
            this.StepClockBtn.UseVisualStyleBackColor = true;
            this.StepClockBtn.Click += new System.EventHandler(this.StepClockBtn_Click);
            this.StepClockBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StepClockBtn_MouseDown);
            this.StepClockBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StepClockBtn_MouseUp);
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
            // MainTimer
            // 
            this.MainTimer.Interval = 1;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "A Reg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "B Reg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sum Reg:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Load Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Enable Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Enable Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(604, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Load Test";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(695, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Enable Test";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(604, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Load Test";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SumRegLEDDisplay
            // 
            this.SumRegLEDDisplay.Controls.Add(this.led35);
            this.SumRegLEDDisplay.Controls.Add(this.led36);
            this.SumRegLEDDisplay.Controls.Add(this.led37);
            this.SumRegLEDDisplay.Controls.Add(this.led38);
            this.SumRegLEDDisplay.Controls.Add(this.led39);
            this.SumRegLEDDisplay.Controls.Add(this.led40);
            this.SumRegLEDDisplay.Controls.Add(this.led41);
            this.SumRegLEDDisplay.Controls.Add(this.led42);
            this.SumRegLEDDisplay.LEDs.Add(this.led35);
            this.SumRegLEDDisplay.LEDs.Add(this.led36);
            this.SumRegLEDDisplay.LEDs.Add(this.led37);
            this.SumRegLEDDisplay.LEDs.Add(this.led38);
            this.SumRegLEDDisplay.LEDs.Add(this.led39);
            this.SumRegLEDDisplay.LEDs.Add(this.led40);
            this.SumRegLEDDisplay.LEDs.Add(this.led41);
            this.SumRegLEDDisplay.LEDs.Add(this.led42);
            this.SumRegLEDDisplay.Location = new System.Drawing.Point(480, 207);
            this.SumRegLEDDisplay.Name = "SumRegLEDDisplay";
            this.SumRegLEDDisplay.Size = new System.Drawing.Size(102, 16);
            this.SumRegLEDDisplay.TabIndex = 19;
            // 
            // led35
            // 
            this.led35.LEDColor = System.Drawing.Color.Red;
            this.led35.Location = new System.Drawing.Point(3, 3);
            this.led35.Name = "led35";
            this.led35.Size = new System.Drawing.Size(11, 11);
            this.led35.TabIndex = 0;
            // 
            // led36
            // 
            this.led36.LEDColor = System.Drawing.Color.Red;
            this.led36.Location = new System.Drawing.Point(15, 3);
            this.led36.Name = "led36";
            this.led36.Size = new System.Drawing.Size(11, 11);
            this.led36.TabIndex = 1;
            // 
            // led37
            // 
            this.led37.LEDColor = System.Drawing.Color.Red;
            this.led37.Location = new System.Drawing.Point(27, 3);
            this.led37.Name = "led37";
            this.led37.Size = new System.Drawing.Size(11, 11);
            this.led37.TabIndex = 2;
            // 
            // led38
            // 
            this.led38.LEDColor = System.Drawing.Color.Red;
            this.led38.Location = new System.Drawing.Point(39, 3);
            this.led38.Name = "led38";
            this.led38.Size = new System.Drawing.Size(11, 11);
            this.led38.TabIndex = 3;
            // 
            // led39
            // 
            this.led39.LEDColor = System.Drawing.Color.Red;
            this.led39.Location = new System.Drawing.Point(51, 3);
            this.led39.Name = "led39";
            this.led39.Size = new System.Drawing.Size(11, 11);
            this.led39.TabIndex = 4;
            // 
            // led40
            // 
            this.led40.LEDColor = System.Drawing.Color.Red;
            this.led40.Location = new System.Drawing.Point(63, 3);
            this.led40.Name = "led40";
            this.led40.Size = new System.Drawing.Size(11, 11);
            this.led40.TabIndex = 5;
            // 
            // led41
            // 
            this.led41.LEDColor = System.Drawing.Color.Red;
            this.led41.Location = new System.Drawing.Point(75, 3);
            this.led41.Name = "led41";
            this.led41.Size = new System.Drawing.Size(11, 11);
            this.led41.TabIndex = 6;
            // 
            // led42
            // 
            this.led42.LEDColor = System.Drawing.Color.Red;
            this.led42.Location = new System.Drawing.Point(87, 3);
            this.led42.Name = "led42";
            this.led42.Size = new System.Drawing.Size(11, 11);
            this.led42.TabIndex = 7;
            // 
            // BRegLEDDisplay
            // 
            this.BRegLEDDisplay.Controls.Add(this.led27);
            this.BRegLEDDisplay.Controls.Add(this.led28);
            this.BRegLEDDisplay.Controls.Add(this.led29);
            this.BRegLEDDisplay.Controls.Add(this.led30);
            this.BRegLEDDisplay.Controls.Add(this.led31);
            this.BRegLEDDisplay.Controls.Add(this.led32);
            this.BRegLEDDisplay.Controls.Add(this.led33);
            this.BRegLEDDisplay.Controls.Add(this.led34);
            this.BRegLEDDisplay.LEDs.Add(this.led27);
            this.BRegLEDDisplay.LEDs.Add(this.led28);
            this.BRegLEDDisplay.LEDs.Add(this.led29);
            this.BRegLEDDisplay.LEDs.Add(this.led30);
            this.BRegLEDDisplay.LEDs.Add(this.led31);
            this.BRegLEDDisplay.LEDs.Add(this.led32);
            this.BRegLEDDisplay.LEDs.Add(this.led33);
            this.BRegLEDDisplay.LEDs.Add(this.led34);
            this.BRegLEDDisplay.Location = new System.Drawing.Point(480, 257);
            this.BRegLEDDisplay.Name = "BRegLEDDisplay";
            this.BRegLEDDisplay.Size = new System.Drawing.Size(102, 16);
            this.BRegLEDDisplay.TabIndex = 17;
            // 
            // led27
            // 
            this.led27.LEDColor = System.Drawing.Color.Red;
            this.led27.Location = new System.Drawing.Point(3, 3);
            this.led27.Name = "led27";
            this.led27.Size = new System.Drawing.Size(11, 11);
            this.led27.TabIndex = 0;
            // 
            // led28
            // 
            this.led28.LEDColor = System.Drawing.Color.Red;
            this.led28.Location = new System.Drawing.Point(15, 3);
            this.led28.Name = "led28";
            this.led28.Size = new System.Drawing.Size(11, 11);
            this.led28.TabIndex = 1;
            // 
            // led29
            // 
            this.led29.LEDColor = System.Drawing.Color.Red;
            this.led29.Location = new System.Drawing.Point(27, 3);
            this.led29.Name = "led29";
            this.led29.Size = new System.Drawing.Size(11, 11);
            this.led29.TabIndex = 2;
            // 
            // led30
            // 
            this.led30.LEDColor = System.Drawing.Color.Red;
            this.led30.Location = new System.Drawing.Point(39, 3);
            this.led30.Name = "led30";
            this.led30.Size = new System.Drawing.Size(11, 11);
            this.led30.TabIndex = 3;
            // 
            // led31
            // 
            this.led31.LEDColor = System.Drawing.Color.Red;
            this.led31.Location = new System.Drawing.Point(51, 3);
            this.led31.Name = "led31";
            this.led31.Size = new System.Drawing.Size(11, 11);
            this.led31.TabIndex = 4;
            // 
            // led32
            // 
            this.led32.LEDColor = System.Drawing.Color.Red;
            this.led32.Location = new System.Drawing.Point(63, 3);
            this.led32.Name = "led32";
            this.led32.Size = new System.Drawing.Size(11, 11);
            this.led32.TabIndex = 5;
            // 
            // led33
            // 
            this.led33.LEDColor = System.Drawing.Color.Red;
            this.led33.Location = new System.Drawing.Point(75, 3);
            this.led33.Name = "led33";
            this.led33.Size = new System.Drawing.Size(11, 11);
            this.led33.TabIndex = 6;
            // 
            // led34
            // 
            this.led34.LEDColor = System.Drawing.Color.Red;
            this.led34.Location = new System.Drawing.Point(87, 3);
            this.led34.Name = "led34";
            this.led34.Size = new System.Drawing.Size(11, 11);
            this.led34.TabIndex = 7;
            // 
            // ARegLEDDisplay
            // 
            this.ARegLEDDisplay.Controls.Add(this.led19);
            this.ARegLEDDisplay.Controls.Add(this.led20);
            this.ARegLEDDisplay.Controls.Add(this.led21);
            this.ARegLEDDisplay.Controls.Add(this.led22);
            this.ARegLEDDisplay.Controls.Add(this.led23);
            this.ARegLEDDisplay.Controls.Add(this.led24);
            this.ARegLEDDisplay.Controls.Add(this.led25);
            this.ARegLEDDisplay.Controls.Add(this.led26);
            this.ARegLEDDisplay.LEDs.Add(this.led19);
            this.ARegLEDDisplay.LEDs.Add(this.led20);
            this.ARegLEDDisplay.LEDs.Add(this.led21);
            this.ARegLEDDisplay.LEDs.Add(this.led22);
            this.ARegLEDDisplay.LEDs.Add(this.led23);
            this.ARegLEDDisplay.LEDs.Add(this.led24);
            this.ARegLEDDisplay.LEDs.Add(this.led25);
            this.ARegLEDDisplay.LEDs.Add(this.led26);
            this.ARegLEDDisplay.Location = new System.Drawing.Point(480, 162);
            this.ARegLEDDisplay.Name = "ARegLEDDisplay";
            this.ARegLEDDisplay.Size = new System.Drawing.Size(102, 16);
            this.ARegLEDDisplay.TabIndex = 15;
            // 
            // led19
            // 
            this.led19.LEDColor = System.Drawing.Color.Red;
            this.led19.Location = new System.Drawing.Point(3, 3);
            this.led19.Name = "led19";
            this.led19.Size = new System.Drawing.Size(11, 11);
            this.led19.TabIndex = 0;
            // 
            // led20
            // 
            this.led20.LEDColor = System.Drawing.Color.Red;
            this.led20.Location = new System.Drawing.Point(15, 3);
            this.led20.Name = "led20";
            this.led20.Size = new System.Drawing.Size(11, 11);
            this.led20.TabIndex = 1;
            // 
            // led21
            // 
            this.led21.LEDColor = System.Drawing.Color.Red;
            this.led21.Location = new System.Drawing.Point(27, 3);
            this.led21.Name = "led21";
            this.led21.Size = new System.Drawing.Size(11, 11);
            this.led21.TabIndex = 2;
            // 
            // led22
            // 
            this.led22.LEDColor = System.Drawing.Color.Red;
            this.led22.Location = new System.Drawing.Point(39, 3);
            this.led22.Name = "led22";
            this.led22.Size = new System.Drawing.Size(11, 11);
            this.led22.TabIndex = 3;
            // 
            // led23
            // 
            this.led23.LEDColor = System.Drawing.Color.Red;
            this.led23.Location = new System.Drawing.Point(51, 3);
            this.led23.Name = "led23";
            this.led23.Size = new System.Drawing.Size(11, 11);
            this.led23.TabIndex = 4;
            // 
            // led24
            // 
            this.led24.LEDColor = System.Drawing.Color.Red;
            this.led24.Location = new System.Drawing.Point(63, 3);
            this.led24.Name = "led24";
            this.led24.Size = new System.Drawing.Size(11, 11);
            this.led24.TabIndex = 5;
            // 
            // led25
            // 
            this.led25.LEDColor = System.Drawing.Color.Red;
            this.led25.Location = new System.Drawing.Point(75, 3);
            this.led25.Name = "led25";
            this.led25.Size = new System.Drawing.Size(11, 11);
            this.led25.TabIndex = 6;
            // 
            // led26
            // 
            this.led26.LEDColor = System.Drawing.Color.Red;
            this.led26.Location = new System.Drawing.Point(87, 3);
            this.led26.Name = "led26";
            this.led26.Size = new System.Drawing.Size(11, 11);
            this.led26.TabIndex = 7;
            // 
            // BusLEDDisplay
            // 
            this.BusLEDDisplay.Controls.Add(this.led11);
            this.BusLEDDisplay.Controls.Add(this.led12);
            this.BusLEDDisplay.Controls.Add(this.led13);
            this.BusLEDDisplay.Controls.Add(this.led14);
            this.BusLEDDisplay.Controls.Add(this.led15);
            this.BusLEDDisplay.Controls.Add(this.led16);
            this.BusLEDDisplay.Controls.Add(this.led17);
            this.BusLEDDisplay.Controls.Add(this.led18);
            this.BusLEDDisplay.LEDs.Add(this.led11);
            this.BusLEDDisplay.LEDs.Add(this.led12);
            this.BusLEDDisplay.LEDs.Add(this.led13);
            this.BusLEDDisplay.LEDs.Add(this.led14);
            this.BusLEDDisplay.LEDs.Add(this.led15);
            this.BusLEDDisplay.LEDs.Add(this.led16);
            this.BusLEDDisplay.LEDs.Add(this.led17);
            this.BusLEDDisplay.LEDs.Add(this.led18);
            this.BusLEDDisplay.Location = new System.Drawing.Point(372, 118);
            this.BusLEDDisplay.Name = "BusLEDDisplay";
            this.BusLEDDisplay.Size = new System.Drawing.Size(102, 16);
            this.BusLEDDisplay.TabIndex = 13;
            // 
            // led11
            // 
            this.led11.LEDColor = System.Drawing.Color.Red;
            this.led11.Location = new System.Drawing.Point(3, 3);
            this.led11.Name = "led11";
            this.led11.Size = new System.Drawing.Size(11, 11);
            this.led11.TabIndex = 0;
            // 
            // led12
            // 
            this.led12.LEDColor = System.Drawing.Color.Red;
            this.led12.Location = new System.Drawing.Point(15, 3);
            this.led12.Name = "led12";
            this.led12.Size = new System.Drawing.Size(11, 11);
            this.led12.TabIndex = 1;
            // 
            // led13
            // 
            this.led13.LEDColor = System.Drawing.Color.Red;
            this.led13.Location = new System.Drawing.Point(27, 3);
            this.led13.Name = "led13";
            this.led13.Size = new System.Drawing.Size(11, 11);
            this.led13.TabIndex = 2;
            // 
            // led14
            // 
            this.led14.LEDColor = System.Drawing.Color.Red;
            this.led14.Location = new System.Drawing.Point(39, 3);
            this.led14.Name = "led14";
            this.led14.Size = new System.Drawing.Size(11, 11);
            this.led14.TabIndex = 3;
            // 
            // led15
            // 
            this.led15.LEDColor = System.Drawing.Color.Red;
            this.led15.Location = new System.Drawing.Point(51, 3);
            this.led15.Name = "led15";
            this.led15.Size = new System.Drawing.Size(11, 11);
            this.led15.TabIndex = 4;
            // 
            // led16
            // 
            this.led16.LEDColor = System.Drawing.Color.Red;
            this.led16.Location = new System.Drawing.Point(63, 3);
            this.led16.Name = "led16";
            this.led16.Size = new System.Drawing.Size(11, 11);
            this.led16.TabIndex = 5;
            // 
            // led17
            // 
            this.led17.LEDColor = System.Drawing.Color.Red;
            this.led17.Location = new System.Drawing.Point(75, 3);
            this.led17.Name = "led17";
            this.led17.Size = new System.Drawing.Size(11, 11);
            this.led17.TabIndex = 6;
            // 
            // led18
            // 
            this.led18.LEDColor = System.Drawing.Color.Red;
            this.led18.Location = new System.Drawing.Point(87, 3);
            this.led18.Name = "led18";
            this.led18.Size = new System.Drawing.Size(11, 11);
            this.led18.TabIndex = 7;
            // 
            // ledDisplay2
            // 
            this.ledDisplay2.Controls.Add(this.led1);
            this.ledDisplay2.Controls.Add(this.led2);
            this.ledDisplay2.LEDs.Add(this.led1);
            this.ledDisplay2.LEDs.Add(this.led2);
            this.ledDisplay2.Location = new System.Drawing.Point(554, 49);
            this.ledDisplay2.Name = "ledDisplay2";
            this.ledDisplay2.Size = new System.Drawing.Size(30, 16);
            this.ledDisplay2.TabIndex = 11;
            // 
            // led1
            // 
            this.led1.LEDColor = System.Drawing.Color.Lime;
            this.led1.Location = new System.Drawing.Point(3, 3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(11, 11);
            this.led1.TabIndex = 0;
            // 
            // led2
            // 
            this.led2.LEDColor = System.Drawing.Color.Red;
            this.led2.Location = new System.Drawing.Point(15, 3);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(11, 11);
            this.led2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Read from BUS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(701, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Put on Bus";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SumRegLEDDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BRegLEDDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ARegLEDDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BusLEDDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ledDisplay2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.StepClockBtn);
            this.Controls.Add(this.FreqLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClockModeBtn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.SumRegLEDDisplay.ResumeLayout(false);
            this.BRegLEDDisplay.ResumeLayout(false);
            this.ARegLEDDisplay.ResumeLayout(false);
            this.BusLEDDisplay.ResumeLayout(false);
            this.ledDisplay2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClockModeBtn;
        private System.Windows.Forms.Label FreqLbl;
        private System.Windows.Forms.Button StepClockBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label label1;
        private AppCode.Visual.LEDDisplay ledDisplay2;
        private AppCode.Visual.LED led1;
        private AppCode.Visual.LED led2;
        private System.Windows.Forms.Label label3;
        private AppCode.Visual.LEDDisplay BusLEDDisplay;
        private AppCode.Visual.LED led11;
        private AppCode.Visual.LED led12;
        private AppCode.Visual.LED led13;
        private AppCode.Visual.LED led14;
        private AppCode.Visual.LED led15;
        private AppCode.Visual.LED led16;
        private AppCode.Visual.LED led17;
        private AppCode.Visual.LED led18;
        private AppCode.Visual.LEDDisplay ARegLEDDisplay;
        private AppCode.Visual.LED led19;
        private AppCode.Visual.LED led20;
        private AppCode.Visual.LED led21;
        private AppCode.Visual.LED led22;
        private AppCode.Visual.LED led23;
        private AppCode.Visual.LED led24;
        private AppCode.Visual.LED led25;
        private AppCode.Visual.LED led26;
        private System.Windows.Forms.Label label4;
        private AppCode.Visual.LEDDisplay BRegLEDDisplay;
        private AppCode.Visual.LED led27;
        private AppCode.Visual.LED led28;
        private AppCode.Visual.LED led29;
        private AppCode.Visual.LED led30;
        private AppCode.Visual.LED led31;
        private AppCode.Visual.LED led32;
        private AppCode.Visual.LED led33;
        private AppCode.Visual.LED led34;
        private System.Windows.Forms.Label label5;
        private AppCode.Visual.LEDDisplay SumRegLEDDisplay;
        private AppCode.Visual.LED led35;
        private AppCode.Visual.LED led36;
        private AppCode.Visual.LED led37;
        private AppCode.Visual.LED led38;
        private AppCode.Visual.LED led39;
        private AppCode.Visual.LED led40;
        private AppCode.Visual.LED led41;
        private AppCode.Visual.LED led42;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

