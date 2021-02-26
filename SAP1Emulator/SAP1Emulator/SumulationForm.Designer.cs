namespace SAP1Emulator
{
    partial class SimulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.ClockModeBtn = new System.Windows.Forms.Button();
            this.FreqLbl = new System.Windows.Forms.Label();
            this.StepClockBtn = new System.Windows.Forms.Button();
            this.FrequencyAdjust = new System.Windows.Forms.TrackBar();
            this.BusValLbl = new System.Windows.Forms.Label();
            this.ARegValLbl = new System.Windows.Forms.Label();
            this.SumRegValLbl = new System.Windows.Forms.Label();
            this.BRegValLbl = new System.Windows.Forms.Label();
            this.InstRegValLbl = new System.Windows.Forms.Label();
            this.RAMRegValLbl = new System.Windows.Forms.Label();
            this.MARRegValLbl = new System.Windows.Forms.Label();
            this.RAMView = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ProgRAMAddrTB = new System.Windows.Forms.TextBox();
            this.ProgRamDataTB = new System.Windows.Forms.TextBox();
            this.ProramBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RandomizeRAMBtn = new System.Windows.Forms.Button();
            this.WipeRAMBtn = new System.Windows.Forms.Button();
            this.PCRegValLbl = new System.Windows.Forms.Label();
            this.OutputRegValLbl = new System.Windows.Forms.Label();
            this.DisplayLbl = new System.Windows.Forms.Label();
            this.DisplayShadowLbl = new System.Windows.Forms.Label();
            this.DisplaySignedCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadExampleIntoRAMBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PCGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ARegGroup = new System.Windows.Forms.GroupBox();
            this.SumGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CarryInCB = new System.Windows.Forms.CheckBox();
            this.FlagsGroup = new System.Windows.Forms.GroupBox();
            this.BRegGroup = new System.Windows.Forms.GroupBox();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.MARGroup = new System.Windows.Forms.GroupBox();
            this.RAMGroup = new System.Windows.Forms.GroupBox();
            this.InstGroup = new System.Windows.Forms.GroupBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.InstArrowOut = new SAP1Emulator.AppCode.Visual.Arrow();
            this.RAMArrowOut = new SAP1Emulator.AppCode.Visual.Arrow();
            this.InstArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.RAMArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.MARArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.SUMArrowOut = new SAP1Emulator.AppCode.Visual.Arrow();
            this.ARegArrowOut = new SAP1Emulator.AppCode.Visual.Arrow();
            this.PCArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.PCArrowOut = new SAP1Emulator.AppCode.Visual.Arrow();
            this.ARegArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.OutputRegArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.BRegArrowIn = new SAP1Emulator.AppCode.Visual.Arrow();
            this.CLDecodedLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led85 = new SAP1Emulator.AppCode.Visual.LED();
            this.led86 = new SAP1Emulator.AppCode.Visual.LED();
            this.led87 = new SAP1Emulator.AppCode.Visual.LED();
            this.led88 = new SAP1Emulator.AppCode.Visual.LED();
            this.led89 = new SAP1Emulator.AppCode.Visual.LED();
            this.rLabel16 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel17 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel19 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel18 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel21 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.MICounterLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led82 = new SAP1Emulator.AppCode.Visual.LED();
            this.led83 = new SAP1Emulator.AppCode.Visual.LED();
            this.led84 = new SAP1Emulator.AppCode.Visual.LED();
            this.InstRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led3 = new SAP1Emulator.AppCode.Visual.LED();
            this.led4 = new SAP1Emulator.AppCode.Visual.LED();
            this.led5 = new SAP1Emulator.AppCode.Visual.LED();
            this.led6 = new SAP1Emulator.AppCode.Visual.LED();
            this.led7 = new SAP1Emulator.AppCode.Visual.LED();
            this.led8 = new SAP1Emulator.AppCode.Visual.LED();
            this.led9 = new SAP1Emulator.AppCode.Visual.LED();
            this.led10 = new SAP1Emulator.AppCode.Visual.LED();
            this.RAMLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led43 = new SAP1Emulator.AppCode.Visual.LED();
            this.led44 = new SAP1Emulator.AppCode.Visual.LED();
            this.led45 = new SAP1Emulator.AppCode.Visual.LED();
            this.led46 = new SAP1Emulator.AppCode.Visual.LED();
            this.led47 = new SAP1Emulator.AppCode.Visual.LED();
            this.led48 = new SAP1Emulator.AppCode.Visual.LED();
            this.led49 = new SAP1Emulator.AppCode.Visual.LED();
            this.led50 = new SAP1Emulator.AppCode.Visual.LED();
            this.MARLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led51 = new SAP1Emulator.AppCode.Visual.LED();
            this.led52 = new SAP1Emulator.AppCode.Visual.LED();
            this.led53 = new SAP1Emulator.AppCode.Visual.LED();
            this.led54 = new SAP1Emulator.AppCode.Visual.LED();
            this.StatusLEDDsiaply = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led67 = new SAP1Emulator.AppCode.Visual.LED();
            this.led68 = new SAP1Emulator.AppCode.Visual.LED();
            this.led69 = new SAP1Emulator.AppCode.Visual.LED();
            this.led70 = new SAP1Emulator.AppCode.Visual.LED();
            this.led71 = new SAP1Emulator.AppCode.Visual.LED();
            this.led72 = new SAP1Emulator.AppCode.Visual.LED();
            this.led73 = new SAP1Emulator.AppCode.Visual.LED();
            this.led74 = new SAP1Emulator.AppCode.Visual.LED();
            this.led75 = new SAP1Emulator.AppCode.Visual.LED();
            this.led76 = new SAP1Emulator.AppCode.Visual.LED();
            this.led77 = new SAP1Emulator.AppCode.Visual.LED();
            this.led78 = new SAP1Emulator.AppCode.Visual.LED();
            this.led79 = new SAP1Emulator.AppCode.Visual.LED();
            this.led80 = new SAP1Emulator.AppCode.Visual.LED();
            this.led81 = new SAP1Emulator.AppCode.Visual.LED();
            this.led94 = new SAP1Emulator.AppCode.Visual.LED();
            this.rLabel1 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel2 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel3 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel4 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel5 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel6 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel7 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel8 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel9 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel10 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel25 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel12 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel11 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel13 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel14 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel15 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.OutputRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led59 = new SAP1Emulator.AppCode.Visual.LED();
            this.led60 = new SAP1Emulator.AppCode.Visual.LED();
            this.led61 = new SAP1Emulator.AppCode.Visual.LED();
            this.led62 = new SAP1Emulator.AppCode.Visual.LED();
            this.led63 = new SAP1Emulator.AppCode.Visual.LED();
            this.led64 = new SAP1Emulator.AppCode.Visual.LED();
            this.led65 = new SAP1Emulator.AppCode.Visual.LED();
            this.led66 = new SAP1Emulator.AppCode.Visual.LED();
            this.BRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led27 = new SAP1Emulator.AppCode.Visual.LED();
            this.led28 = new SAP1Emulator.AppCode.Visual.LED();
            this.led29 = new SAP1Emulator.AppCode.Visual.LED();
            this.led30 = new SAP1Emulator.AppCode.Visual.LED();
            this.led31 = new SAP1Emulator.AppCode.Visual.LED();
            this.led32 = new SAP1Emulator.AppCode.Visual.LED();
            this.led33 = new SAP1Emulator.AppCode.Visual.LED();
            this.led34 = new SAP1Emulator.AppCode.Visual.LED();
            this.FlagRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led92 = new SAP1Emulator.AppCode.Visual.LED();
            this.led93 = new SAP1Emulator.AppCode.Visual.LED();
            this.rLabel24 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.rLabel23 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.SubLED = new SAP1Emulator.AppCode.Visual.LED();
            this.SumRegLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led35 = new SAP1Emulator.AppCode.Visual.LED();
            this.led36 = new SAP1Emulator.AppCode.Visual.LED();
            this.led37 = new SAP1Emulator.AppCode.Visual.LED();
            this.led38 = new SAP1Emulator.AppCode.Visual.LED();
            this.led39 = new SAP1Emulator.AppCode.Visual.LED();
            this.led40 = new SAP1Emulator.AppCode.Visual.LED();
            this.led41 = new SAP1Emulator.AppCode.Visual.LED();
            this.led42 = new SAP1Emulator.AppCode.Visual.LED();
            this.rLabel22 = new SAP1Emulator.AppCode.Visual.RLabel();
            this.SumFlagsLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led90 = new SAP1Emulator.AppCode.Visual.LED();
            this.led91 = new SAP1Emulator.AppCode.Visual.LED();
            this.rLabel20 = new SAP1Emulator.AppCode.Visual.RLabel();
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
            this.IncLED = new SAP1Emulator.AppCode.Visual.LED();
            this.PCLEDDisplay = new SAP1Emulator.AppCode.Visual.LEDDisplay();
            this.led55 = new SAP1Emulator.AppCode.Visual.LED();
            this.led56 = new SAP1Emulator.AppCode.Visual.LED();
            this.led57 = new SAP1Emulator.AppCode.Visual.LED();
            this.led58 = new SAP1Emulator.AppCode.Visual.LED();
            this.ClkLed = new SAP1Emulator.AppCode.Visual.LED();
            this.led2 = new SAP1Emulator.AppCode.Visual.LED();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyAdjust)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PCGroup.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.ARegGroup.SuspendLayout();
            this.SumGroup.SuspendLayout();
            this.FlagsGroup.SuspendLayout();
            this.BRegGroup.SuspendLayout();
            this.OutputGroup.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.MARGroup.SuspendLayout();
            this.RAMGroup.SuspendLayout();
            this.InstGroup.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CLDecodedLEDDisplay.SuspendLayout();
            this.MICounterLEDDisplay.SuspendLayout();
            this.InstRegLEDDisplay.SuspendLayout();
            this.RAMLEDDisplay.SuspendLayout();
            this.MARLEDDisplay.SuspendLayout();
            this.StatusLEDDsiaply.SuspendLayout();
            this.OutputRegLEDDisplay.SuspendLayout();
            this.BRegLEDDisplay.SuspendLayout();
            this.FlagRegLEDDisplay.SuspendLayout();
            this.SumRegLEDDisplay.SuspendLayout();
            this.SumFlagsLEDDisplay.SuspendLayout();
            this.ARegLEDDisplay.SuspendLayout();
            this.BusLEDDisplay.SuspendLayout();
            this.PCLEDDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockModeBtn
            // 
            this.ClockModeBtn.BackColor = System.Drawing.Color.Red;
            this.ClockModeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClockModeBtn.Location = new System.Drawing.Point(8, 68);
            this.ClockModeBtn.Name = "ClockModeBtn";
            this.ClockModeBtn.Size = new System.Drawing.Size(65, 23);
            this.ClockModeBtn.TabIndex = 0;
            this.ClockModeBtn.Text = "Stopped";
            this.ClockModeBtn.UseVisualStyleBackColor = false;
            this.ClockModeBtn.Click += new System.EventHandler(this.ClockModeBtn_Click);
            // 
            // FreqLbl
            // 
            this.FreqLbl.AutoSize = true;
            this.FreqLbl.Location = new System.Drawing.Point(15, 16);
            this.FreqLbl.Name = "FreqLbl";
            this.FreqLbl.Size = new System.Drawing.Size(82, 13);
            this.FreqLbl.TabIndex = 4;
            this.FreqLbl.Text = "Frequency: 1Hz";
            // 
            // StepClockBtn
            // 
            this.StepClockBtn.Location = new System.Drawing.Point(79, 68);
            this.StepClockBtn.Name = "StepClockBtn";
            this.StepClockBtn.Size = new System.Drawing.Size(65, 23);
            this.StepClockBtn.TabIndex = 5;
            this.StepClockBtn.Text = "Signle";
            this.StepClockBtn.UseVisualStyleBackColor = true;
            this.StepClockBtn.Click += new System.EventHandler(this.StepClockBtn_Click);
            this.StepClockBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StepClockBtn_KeyDown);
            this.StepClockBtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StepClockBtn_KeyUp);
            this.StepClockBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StepClockBtn_MouseDown);
            this.StepClockBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StepClockBtn_MouseUp);
            // 
            // FrequencyAdjust
            // 
            this.FrequencyAdjust.AutoSize = false;
            this.FrequencyAdjust.LargeChange = 10;
            this.FrequencyAdjust.Location = new System.Drawing.Point(2, 31);
            this.FrequencyAdjust.Maximum = 1000;
            this.FrequencyAdjust.Minimum = 1;
            this.FrequencyAdjust.Name = "FrequencyAdjust";
            this.FrequencyAdjust.Size = new System.Drawing.Size(173, 25);
            this.FrequencyAdjust.TabIndex = 7;
            this.FrequencyAdjust.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FrequencyAdjust.Value = 1;
            this.FrequencyAdjust.Scroll += new System.EventHandler(this.FrequencyAdjust_Scroll);
            // 
            // BusValLbl
            // 
            this.BusValLbl.AutoSize = true;
            this.BusValLbl.Location = new System.Drawing.Point(116, 22);
            this.BusValLbl.Name = "BusValLbl";
            this.BusValLbl.Size = new System.Drawing.Size(40, 13);
            this.BusValLbl.TabIndex = 29;
            this.BusValLbl.Text = "BusVal";
            // 
            // ARegValLbl
            // 
            this.ARegValLbl.AutoSize = true;
            this.ARegValLbl.Location = new System.Drawing.Point(116, 22);
            this.ARegValLbl.Name = "ARegValLbl";
            this.ARegValLbl.Size = new System.Drawing.Size(29, 13);
            this.ARegValLbl.TabIndex = 30;
            this.ARegValLbl.Text = "AVal";
            // 
            // SumRegValLbl
            // 
            this.SumRegValLbl.AutoSize = true;
            this.SumRegValLbl.Location = new System.Drawing.Point(116, 22);
            this.SumRegValLbl.Name = "SumRegValLbl";
            this.SumRegValLbl.Size = new System.Drawing.Size(43, 13);
            this.SumRegValLbl.TabIndex = 31;
            this.SumRegValLbl.Text = "SumVal";
            // 
            // BRegValLbl
            // 
            this.BRegValLbl.AutoSize = true;
            this.BRegValLbl.Location = new System.Drawing.Point(119, 22);
            this.BRegValLbl.Name = "BRegValLbl";
            this.BRegValLbl.Size = new System.Drawing.Size(29, 13);
            this.BRegValLbl.TabIndex = 32;
            this.BRegValLbl.Text = "BVal";
            // 
            // InstRegValLbl
            // 
            this.InstRegValLbl.AutoSize = true;
            this.InstRegValLbl.Location = new System.Drawing.Point(116, 22);
            this.InstRegValLbl.Name = "InstRegValLbl";
            this.InstRegValLbl.Size = new System.Drawing.Size(24, 13);
            this.InstRegValLbl.TabIndex = 38;
            this.InstRegValLbl.Text = "Ival";
            // 
            // RAMRegValLbl
            // 
            this.RAMRegValLbl.AutoSize = true;
            this.RAMRegValLbl.Location = new System.Drawing.Point(116, 20);
            this.RAMRegValLbl.Name = "RAMRegValLbl";
            this.RAMRegValLbl.Size = new System.Drawing.Size(29, 13);
            this.RAMRegValLbl.TabIndex = 48;
            this.RAMRegValLbl.Text = "Rval";
            // 
            // MARRegValLbl
            // 
            this.MARRegValLbl.AutoSize = true;
            this.MARRegValLbl.Location = new System.Drawing.Point(116, 23);
            this.MARRegValLbl.Name = "MARRegValLbl";
            this.MARRegValLbl.Size = new System.Drawing.Size(30, 13);
            this.MARRegValLbl.TabIndex = 55;
            this.MARRegValLbl.Text = "Mval";
            // 
            // RAMView
            // 
            this.RAMView.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMView.FormattingEnabled = true;
            this.RAMView.Location = new System.Drawing.Point(120, 19);
            this.RAMView.Name = "RAMView";
            this.RAMView.Size = new System.Drawing.Size(102, 212);
            this.RAMView.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "RAM Address:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "Data:";
            // 
            // ProgRAMAddrTB
            // 
            this.ProgRAMAddrTB.Location = new System.Drawing.Point(14, 37);
            this.ProgRAMAddrTB.Name = "ProgRAMAddrTB";
            this.ProgRAMAddrTB.Size = new System.Drawing.Size(100, 20);
            this.ProgRAMAddrTB.TabIndex = 61;
            this.ProgRAMAddrTB.Text = "0x00";
            // 
            // ProgRamDataTB
            // 
            this.ProgRamDataTB.Location = new System.Drawing.Point(14, 86);
            this.ProgRamDataTB.Name = "ProgRamDataTB";
            this.ProgRamDataTB.Size = new System.Drawing.Size(100, 20);
            this.ProgRamDataTB.TabIndex = 62;
            this.ProgRamDataTB.Text = "0x";
            // 
            // ProramBtn
            // 
            this.ProramBtn.Location = new System.Drawing.Point(39, 112);
            this.ProramBtn.Name = "ProramBtn";
            this.ProramBtn.Size = new System.Drawing.Size(75, 23);
            this.ProramBtn.TabIndex = 63;
            this.ProramBtn.Text = "Clock In";
            this.ProramBtn.UseVisualStyleBackColor = true;
            this.ProramBtn.Click += new System.EventHandler(this.ProgramBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RandomizeRAMBtn);
            this.groupBox2.Controls.Add(this.WipeRAMBtn);
            this.groupBox2.Controls.Add(this.RAMView);
            this.groupBox2.Controls.Add(this.ProramBtn);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.ProgRamDataTB);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.ProgRAMAddrTB);
            this.groupBox2.Location = new System.Drawing.Point(9, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 241);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Debug";
            // 
            // RandomizeRAMBtn
            // 
            this.RandomizeRAMBtn.Location = new System.Drawing.Point(39, 175);
            this.RandomizeRAMBtn.Name = "RandomizeRAMBtn";
            this.RandomizeRAMBtn.Size = new System.Drawing.Size(75, 23);
            this.RandomizeRAMBtn.TabIndex = 65;
            this.RandomizeRAMBtn.Text = "Randomize";
            this.RandomizeRAMBtn.UseVisualStyleBackColor = true;
            this.RandomizeRAMBtn.Click += new System.EventHandler(this.RandomizeRAMBtn_Click);
            // 
            // WipeRAMBtn
            // 
            this.WipeRAMBtn.Location = new System.Drawing.Point(39, 205);
            this.WipeRAMBtn.Name = "WipeRAMBtn";
            this.WipeRAMBtn.Size = new System.Drawing.Size(75, 23);
            this.WipeRAMBtn.TabIndex = 64;
            this.WipeRAMBtn.Text = "Wipe RAM";
            this.WipeRAMBtn.UseVisualStyleBackColor = true;
            this.WipeRAMBtn.Click += new System.EventHandler(this.WipeRAMBtn_Click);
            // 
            // PCRegValLbl
            // 
            this.PCRegValLbl.AutoSize = true;
            this.PCRegValLbl.Location = new System.Drawing.Point(69, 19);
            this.PCRegValLbl.Name = "PCRegValLbl";
            this.PCRegValLbl.Size = new System.Drawing.Size(35, 13);
            this.PCRegValLbl.TabIndex = 68;
            this.PCRegValLbl.Text = "PCval";
            // 
            // OutputRegValLbl
            // 
            this.OutputRegValLbl.AutoSize = true;
            this.OutputRegValLbl.Location = new System.Drawing.Point(116, 20);
            this.OutputRegValLbl.Name = "OutputRegValLbl";
            this.OutputRegValLbl.Size = new System.Drawing.Size(42, 13);
            this.OutputRegValLbl.TabIndex = 77;
            this.OutputRegValLbl.Text = "OtptVal";
            // 
            // DisplayLbl
            // 
            this.DisplayLbl.AutoSize = true;
            this.DisplayLbl.BackColor = System.Drawing.Color.Transparent;
            this.DisplayLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayLbl.Font = new System.Drawing.Font("Digital-7 Mono", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLbl.ForeColor = System.Drawing.Color.Red;
            this.DisplayLbl.Location = new System.Drawing.Point(10, 67);
            this.DisplayLbl.Name = "DisplayLbl";
            this.DisplayLbl.Size = new System.Drawing.Size(137, 63);
            this.DisplayLbl.TabIndex = 78;
            this.DisplayLbl.Text = "0000";
            // 
            // DisplayShadowLbl
            // 
            this.DisplayShadowLbl.AutoSize = true;
            this.DisplayShadowLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisplayShadowLbl.Font = new System.Drawing.Font("Digital-7 Mono", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayShadowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DisplayShadowLbl.Location = new System.Drawing.Point(11, 67);
            this.DisplayShadowLbl.Name = "DisplayShadowLbl";
            this.DisplayShadowLbl.Size = new System.Drawing.Size(135, 61);
            this.DisplayShadowLbl.TabIndex = 79;
            this.DisplayShadowLbl.Text = "8888";
            // 
            // DisplaySignedCB
            // 
            this.DisplaySignedCB.AutoSize = true;
            this.DisplaySignedCB.Location = new System.Drawing.Point(21, 47);
            this.DisplaySignedCB.Name = "DisplaySignedCB";
            this.DisplaySignedCB.Size = new System.Drawing.Size(59, 17);
            this.DisplaySignedCB.TabIndex = 80;
            this.DisplaySignedCB.Text = "Signed";
            this.DisplaySignedCB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(9, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 165);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruction Values";
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
            this.textBox2.Text = "LDA: 0x1; MEM->A\r\nADD: 0x2; (A+B)->A \r\nSUB: 0x3; (A-B)->A\r\nSTA: 0x4; A->MEM\r\nLDI:" +
    " 0x5; {val}->A\r\nJMP: 0x6; Jump\r\n JC: 0x7; Jmp if CF=1\r\n JZ: 0x8; Jmp if ZF=1\r\nOU" +
    "T: 0xE; A->Output\r\nHLT: 0xF; Stop Clock";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(149, 68);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(43, 23);
            this.ResetBtn.TabIndex = 111;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadExampleIntoRAMBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(245, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 241);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample Program";
            // 
            // LoadExampleIntoRAMBtn
            // 
            this.LoadExampleIntoRAMBtn.Location = new System.Drawing.Point(156, 26);
            this.LoadExampleIntoRAMBtn.Name = "LoadExampleIntoRAMBtn";
            this.LoadExampleIntoRAMBtn.Size = new System.Drawing.Size(83, 51);
            this.LoadExampleIntoRAMBtn.TabIndex = 1;
            this.LoadExampleIntoRAMBtn.Text = "Load Into RAM";
            this.LoadExampleIntoRAMBtn.UseVisualStyleBackColor = true;
            this.LoadExampleIntoRAMBtn.Click += new System.EventHandler(this.LoadExampleIntoRAMBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(239, 216);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClkLed);
            this.groupBox4.Controls.Add(this.FreqLbl);
            this.groupBox4.Controls.Add(this.FrequencyAdjust);
            this.groupBox4.Controls.Add(this.ClockModeBtn);
            this.groupBox4.Controls.Add(this.StepClockBtn);
            this.groupBox4.Controls.Add(this.ResetBtn);
            this.groupBox4.Location = new System.Drawing.Point(112, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 104);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clock";
            // 
            // PCGroup
            // 
            this.PCGroup.Controls.Add(this.label1);
            this.PCGroup.Controls.Add(this.IncLED);
            this.PCGroup.Controls.Add(this.PCRegValLbl);
            this.PCGroup.Controls.Add(this.PCLEDDisplay);
            this.PCGroup.Location = new System.Drawing.Point(502, 70);
            this.PCGroup.Name = "PCGroup";
            this.PCGroup.Size = new System.Drawing.Size(158, 43);
            this.PCGroup.TabIndex = 124;
            this.PCGroup.TabStop = false;
            this.PCGroup.Text = "Program Counter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Inc";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BusLEDDisplay);
            this.groupBox6.Controls.Add(this.BusValLbl);
            this.groupBox6.Location = new System.Drawing.Point(330, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(166, 51);
            this.groupBox6.TabIndex = 125;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BUS";
            // 
            // ARegGroup
            // 
            this.ARegGroup.Controls.Add(this.ARegLEDDisplay);
            this.ARegGroup.Controls.Add(this.ARegValLbl);
            this.ARegGroup.Location = new System.Drawing.Point(502, 119);
            this.ARegGroup.Name = "ARegGroup";
            this.ARegGroup.Size = new System.Drawing.Size(157, 45);
            this.ARegGroup.TabIndex = 126;
            this.ARegGroup.TabStop = false;
            this.ARegGroup.Text = "\"A\" Register";
            // 
            // SumGroup
            // 
            this.SumGroup.Controls.Add(this.label2);
            this.SumGroup.Controls.Add(this.SubLED);
            this.SumGroup.Controls.Add(this.CarryInCB);
            this.SumGroup.Controls.Add(this.SumRegLEDDisplay);
            this.SumGroup.Controls.Add(this.SumRegValLbl);
            this.SumGroup.Controls.Add(this.rLabel22);
            this.SumGroup.Controls.Add(this.SumFlagsLEDDisplay);
            this.SumGroup.Controls.Add(this.rLabel20);
            this.SumGroup.Location = new System.Drawing.Point(502, 170);
            this.SumGroup.Name = "SumGroup";
            this.SumGroup.Size = new System.Drawing.Size(157, 77);
            this.SumGroup.TabIndex = 127;
            this.SumGroup.TabStop = false;
            this.SumGroup.Text = "Sum Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Sub";
            // 
            // CarryInCB
            // 
            this.CarryInCB.AutoSize = true;
            this.CarryInCB.Location = new System.Drawing.Point(56, 47);
            this.CarryInCB.Name = "CarryInCB";
            this.CarryInCB.Size = new System.Drawing.Size(62, 17);
            this.CarryInCB.TabIndex = 130;
            this.CarryInCB.Text = "Carry In";
            this.CarryInCB.UseVisualStyleBackColor = true;
            this.CarryInCB.CheckedChanged += new System.EventHandler(this.CarryInCB_CheckedChanged);
            // 
            // FlagsGroup
            // 
            this.FlagsGroup.Controls.Add(this.FlagRegLEDDisplay);
            this.FlagsGroup.Controls.Add(this.rLabel24);
            this.FlagsGroup.Controls.Add(this.rLabel23);
            this.FlagsGroup.Location = new System.Drawing.Point(667, 184);
            this.FlagsGroup.Name = "FlagsGroup";
            this.FlagsGroup.Size = new System.Drawing.Size(53, 55);
            this.FlagsGroup.TabIndex = 128;
            this.FlagsGroup.TabStop = false;
            this.FlagsGroup.Text = "Flags";
            // 
            // BRegGroup
            // 
            this.BRegGroup.Controls.Add(this.BRegValLbl);
            this.BRegGroup.Controls.Add(this.BRegLEDDisplay);
            this.BRegGroup.Location = new System.Drawing.Point(502, 254);
            this.BRegGroup.Name = "BRegGroup";
            this.BRegGroup.Size = new System.Drawing.Size(157, 45);
            this.BRegGroup.TabIndex = 129;
            this.BRegGroup.TabStop = false;
            this.BRegGroup.Text = "\"B\" Register";
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.DisplayShadowLbl);
            this.OutputGroup.Controls.Add(this.DisplayLbl);
            this.OutputGroup.Controls.Add(this.DisplaySignedCB);
            this.OutputGroup.Controls.Add(this.OutputRegValLbl);
            this.OutputGroup.Controls.Add(this.OutputRegLEDDisplay);
            this.OutputGroup.Location = new System.Drawing.Point(502, 305);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(157, 134);
            this.OutputGroup.TabIndex = 130;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Output";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.StatusLEDDsiaply);
            this.groupBox12.Controls.Add(this.rLabel1);
            this.groupBox12.Controls.Add(this.rLabel2);
            this.groupBox12.Controls.Add(this.rLabel3);
            this.groupBox12.Controls.Add(this.rLabel4);
            this.groupBox12.Controls.Add(this.rLabel5);
            this.groupBox12.Controls.Add(this.rLabel6);
            this.groupBox12.Controls.Add(this.rLabel7);
            this.groupBox12.Controls.Add(this.rLabel8);
            this.groupBox12.Controls.Add(this.rLabel9);
            this.groupBox12.Controls.Add(this.rLabel10);
            this.groupBox12.Controls.Add(this.rLabel25);
            this.groupBox12.Controls.Add(this.rLabel12);
            this.groupBox12.Controls.Add(this.rLabel11);
            this.groupBox12.Controls.Add(this.rLabel13);
            this.groupBox12.Controls.Add(this.rLabel14);
            this.groupBox12.Controls.Add(this.rLabel15);
            this.groupBox12.Location = new System.Drawing.Point(502, 445);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(240, 74);
            this.groupBox12.TabIndex = 131;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Control Word";
            // 
            // MARGroup
            // 
            this.MARGroup.Controls.Add(this.MARLEDDisplay);
            this.MARGroup.Controls.Add(this.MARRegValLbl);
            this.MARGroup.Location = new System.Drawing.Point(164, 119);
            this.MARGroup.Name = "MARGroup";
            this.MARGroup.Size = new System.Drawing.Size(152, 48);
            this.MARGroup.TabIndex = 132;
            this.MARGroup.TabStop = false;
            this.MARGroup.Text = "Memory Address";
            // 
            // RAMGroup
            // 
            this.RAMGroup.Controls.Add(this.RAMLEDDisplay);
            this.RAMGroup.Controls.Add(this.RAMRegValLbl);
            this.RAMGroup.Location = new System.Drawing.Point(164, 173);
            this.RAMGroup.Name = "RAMGroup";
            this.RAMGroup.Size = new System.Drawing.Size(152, 44);
            this.RAMGroup.TabIndex = 133;
            this.RAMGroup.TabStop = false;
            this.RAMGroup.Text = "Memory Contents";
            // 
            // InstGroup
            // 
            this.InstGroup.Controls.Add(this.InstRegLEDDisplay);
            this.InstGroup.Controls.Add(this.InstRegValLbl);
            this.InstGroup.Location = new System.Drawing.Point(164, 223);
            this.InstGroup.Name = "InstGroup";
            this.InstGroup.Size = new System.Drawing.Size(152, 47);
            this.InstGroup.TabIndex = 134;
            this.InstGroup.TabStop = false;
            this.InstGroup.Text = "Instruction Register";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.CLDecodedLEDDisplay);
            this.groupBox16.Controls.Add(this.rLabel16);
            this.groupBox16.Controls.Add(this.rLabel17);
            this.groupBox16.Controls.Add(this.rLabel19);
            this.groupBox16.Controls.Add(this.rLabel18);
            this.groupBox16.Controls.Add(this.rLabel21);
            this.groupBox16.Controls.Add(this.MICounterLEDDisplay);
            this.groupBox16.Location = new System.Drawing.Point(164, 276);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(152, 54);
            this.groupBox16.TabIndex = 135;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Instruction Step";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(315, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 279);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(502, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(240, 60);
            this.textBox3.TabIndex = 137;
            this.textBox3.Text = "8 Bit SAP1 architecture. Based on Ben Eater\'s breadboard build.\r\n\r\nSam Farah - 20" +
    "21-02-01";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1127, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 151;
            this.button1.Text = "Load Code into RAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.AcceptsTab = true;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(759, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(443, 395);
            this.textBox4.TabIndex = 152;
            this.textBox4.Text = resources.GetString("textBox4.Text");
            // 
            // InstArrowOut
            // 
            this.InstArrowOut.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.InstArrowOut.ArrowLength = 51;
            this.InstArrowOut.CapNumber = '4';
            this.InstArrowOut.Location = new System.Drawing.Point(316, 248);
            this.InstArrowOut.Name = "InstArrowOut";
            this.InstArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.InstArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.InstArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.InstArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.InstArrowOut.Size = new System.Drawing.Size(70, 19);
            this.InstArrowOut.TabIndex = 150;
            // 
            // RAMArrowOut
            // 
            this.RAMArrowOut.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.RAMArrowOut.ArrowLength = 51;
            this.RAMArrowOut.CapNumber = '8';
            this.RAMArrowOut.Location = new System.Drawing.Point(316, 195);
            this.RAMArrowOut.Name = "RAMArrowOut";
            this.RAMArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RAMArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.RAMArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.RAMArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.RAMArrowOut.Size = new System.Drawing.Size(70, 19);
            this.RAMArrowOut.TabIndex = 149;
            // 
            // InstArrowIn
            // 
            this.InstArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.InstArrowIn.ArrowLength = 51;
            this.InstArrowIn.CapNumber = '8';
            this.InstArrowIn.Location = new System.Drawing.Point(316, 229);
            this.InstArrowIn.Name = "InstArrowIn";
            this.InstArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.InstArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.InstArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.InstArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InstArrowIn.Size = new System.Drawing.Size(70, 19);
            this.InstArrowIn.TabIndex = 148;
            // 
            // RAMArrowIn
            // 
            this.RAMArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.RAMArrowIn.ArrowLength = 51;
            this.RAMArrowIn.CapNumber = '8';
            this.RAMArrowIn.Location = new System.Drawing.Point(316, 176);
            this.RAMArrowIn.Name = "RAMArrowIn";
            this.RAMArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RAMArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.RAMArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.RAMArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RAMArrowIn.Size = new System.Drawing.Size(70, 19);
            this.RAMArrowIn.TabIndex = 147;
            // 
            // MARArrowIn
            // 
            this.MARArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.MARArrowIn.ArrowLength = 51;
            this.MARArrowIn.CapNumber = '4';
            this.MARArrowIn.Location = new System.Drawing.Point(316, 139);
            this.MARArrowIn.Name = "MARArrowIn";
            this.MARArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MARArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MARArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.MARArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MARArrowIn.Size = new System.Drawing.Size(70, 19);
            this.MARArrowIn.TabIndex = 146;
            // 
            // SUMArrowOut
            // 
            this.SUMArrowOut.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.SUMArrowOut.ArrowLength = 54;
            this.SUMArrowOut.CapNumber = '8';
            this.SUMArrowOut.Location = new System.Drawing.Point(429, 197);
            this.SUMArrowOut.Name = "SUMArrowOut";
            this.SUMArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SUMArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.SUMArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.SUMArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.SUMArrowOut.Size = new System.Drawing.Size(73, 19);
            this.SUMArrowOut.TabIndex = 145;
            // 
            // ARegArrowOut
            // 
            this.ARegArrowOut.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.ARegArrowOut.ArrowLength = 54;
            this.ARegArrowOut.CapNumber = '8';
            this.ARegArrowOut.Location = new System.Drawing.Point(429, 141);
            this.ARegArrowOut.Name = "ARegArrowOut";
            this.ARegArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ARegArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ARegArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.ARegArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.ARegArrowOut.Size = new System.Drawing.Size(73, 19);
            this.ARegArrowOut.TabIndex = 144;
            // 
            // PCArrowIn
            // 
            this.PCArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.PCArrowIn.ArrowLength = 54;
            this.PCArrowIn.CapNumber = '4';
            this.PCArrowIn.Location = new System.Drawing.Point(429, 72);
            this.PCArrowIn.Name = "PCArrowIn";
            this.PCArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PCArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PCArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.PCArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PCArrowIn.Size = new System.Drawing.Size(73, 19);
            this.PCArrowIn.TabIndex = 142;
            // 
            // PCArrowOut
            // 
            this.PCArrowOut.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Left;
            this.PCArrowOut.ArrowLength = 54;
            this.PCArrowOut.CapNumber = '4';
            this.PCArrowOut.Location = new System.Drawing.Point(429, 91);
            this.PCArrowOut.Name = "PCArrowOut";
            this.PCArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PCArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PCArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.PCArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.PCArrowOut.Size = new System.Drawing.Size(73, 19);
            this.PCArrowOut.TabIndex = 143;
            // 
            // ARegArrowIn
            // 
            this.ARegArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.ARegArrowIn.ArrowLength = 54;
            this.ARegArrowIn.CapNumber = '8';
            this.ARegArrowIn.Location = new System.Drawing.Point(429, 122);
            this.ARegArrowIn.Name = "ARegArrowIn";
            this.ARegArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ARegArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ARegArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.ARegArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ARegArrowIn.Size = new System.Drawing.Size(73, 19);
            this.ARegArrowIn.TabIndex = 141;
            // 
            // OutputRegArrowIn
            // 
            this.OutputRegArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.OutputRegArrowIn.ArrowLength = 54;
            this.OutputRegArrowIn.CapNumber = '8';
            this.OutputRegArrowIn.Location = new System.Drawing.Point(429, 312);
            this.OutputRegArrowIn.Name = "OutputRegArrowIn";
            this.OutputRegArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OutputRegArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.OutputRegArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.OutputRegArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OutputRegArrowIn.Size = new System.Drawing.Size(73, 19);
            this.OutputRegArrowIn.TabIndex = 140;
            // 
            // BRegArrowIn
            // 
            this.BRegArrowIn.ArrowDirection = SAP1Emulator.AppCode.Visual.Arrow.Direction.Right;
            this.BRegArrowIn.ArrowLength = 54;
            this.BRegArrowIn.CapNumber = '8';
            this.BRegArrowIn.Location = new System.Drawing.Point(429, 267);
            this.BRegArrowIn.Name = "BRegArrowIn";
            this.BRegArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BRegArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BRegArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.BRegArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegArrowIn.Size = new System.Drawing.Size(73, 19);
            this.BRegArrowIn.TabIndex = 139;
            // 
            // CLDecodedLEDDisplay
            // 
            this.CLDecodedLEDDisplay.Controls.Add(this.led85);
            this.CLDecodedLEDDisplay.Controls.Add(this.led86);
            this.CLDecodedLEDDisplay.Controls.Add(this.led87);
            this.CLDecodedLEDDisplay.Controls.Add(this.led88);
            this.CLDecodedLEDDisplay.Controls.Add(this.led89);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led85);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led86);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led87);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led88);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led89);
            this.CLDecodedLEDDisplay.LEDSpacing = 5;
            this.CLDecodedLEDDisplay.Location = new System.Drawing.Point(64, 28);
            this.CLDecodedLEDDisplay.Name = "CLDecodedLEDDisplay";
            this.CLDecodedLEDDisplay.NibbleSpacing = 0;
            this.CLDecodedLEDDisplay.Size = new System.Drawing.Size(81, 16);
            this.CLDecodedLEDDisplay.TabIndex = 103;
            // 
            // led85
            // 
            this.led85.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led85.Location = new System.Drawing.Point(3, 3);
            this.led85.Name = "led85";
            this.led85.Size = new System.Drawing.Size(11, 11);
            this.led85.TabIndex = 0;
            // 
            // led86
            // 
            this.led86.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led86.Location = new System.Drawing.Point(18, 3);
            this.led86.Name = "led86";
            this.led86.Size = new System.Drawing.Size(11, 11);
            this.led86.TabIndex = 1;
            // 
            // led87
            // 
            this.led87.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led87.Location = new System.Drawing.Point(33, 3);
            this.led87.Name = "led87";
            this.led87.Size = new System.Drawing.Size(11, 11);
            this.led87.TabIndex = 2;
            // 
            // led88
            // 
            this.led88.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led88.Location = new System.Drawing.Point(48, 3);
            this.led88.Name = "led88";
            this.led88.Size = new System.Drawing.Size(11, 11);
            this.led88.TabIndex = 3;
            // 
            // led89
            // 
            this.led89.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led89.Location = new System.Drawing.Point(63, 3);
            this.led89.Name = "led89";
            this.led89.Size = new System.Drawing.Size(11, 11);
            this.led89.TabIndex = 4;
            // 
            // rLabel16
            // 
            this.rLabel16.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel16.Location = new System.Drawing.Point(64, 16);
            this.rLabel16.Name = "rLabel16";
            this.rLabel16.RotationAngle = 0D;
            this.rLabel16.Size = new System.Drawing.Size(14, 16);
            this.rLabel16.TabIndex = 104;
            this.rLabel16.Text = "T0";
            this.rLabel16.TopLine = true;
            // 
            // rLabel17
            // 
            this.rLabel17.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel17.Location = new System.Drawing.Point(80, 16);
            this.rLabel17.Name = "rLabel17";
            this.rLabel17.RotationAngle = 0D;
            this.rLabel17.Size = new System.Drawing.Size(14, 16);
            this.rLabel17.TabIndex = 105;
            this.rLabel17.Text = "T1";
            this.rLabel17.TopLine = true;
            // 
            // rLabel19
            // 
            this.rLabel19.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel19.Location = new System.Drawing.Point(96, 16);
            this.rLabel19.Name = "rLabel19";
            this.rLabel19.RotationAngle = 0D;
            this.rLabel19.Size = new System.Drawing.Size(14, 16);
            this.rLabel19.TabIndex = 106;
            this.rLabel19.Text = "T2";
            this.rLabel19.TopLine = true;
            // 
            // rLabel18
            // 
            this.rLabel18.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel18.Location = new System.Drawing.Point(112, 16);
            this.rLabel18.Name = "rLabel18";
            this.rLabel18.RotationAngle = 0D;
            this.rLabel18.Size = new System.Drawing.Size(14, 16);
            this.rLabel18.TabIndex = 107;
            this.rLabel18.Text = "T3";
            this.rLabel18.TopLine = true;
            // 
            // rLabel21
            // 
            this.rLabel21.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel21.Location = new System.Drawing.Point(128, 16);
            this.rLabel21.Name = "rLabel21";
            this.rLabel21.RotationAngle = 0D;
            this.rLabel21.Size = new System.Drawing.Size(14, 16);
            this.rLabel21.TabIndex = 108;
            this.rLabel21.Text = "T4";
            this.rLabel21.TopLine = true;
            // 
            // MICounterLEDDisplay
            // 
            this.MICounterLEDDisplay.Controls.Add(this.led82);
            this.MICounterLEDDisplay.Controls.Add(this.led83);
            this.MICounterLEDDisplay.Controls.Add(this.led84);
            this.MICounterLEDDisplay.LEDs.Add(this.led82);
            this.MICounterLEDDisplay.LEDs.Add(this.led83);
            this.MICounterLEDDisplay.LEDs.Add(this.led84);
            this.MICounterLEDDisplay.LEDSpacing = 2;
            this.MICounterLEDDisplay.Location = new System.Drawing.Point(9, 28);
            this.MICounterLEDDisplay.Name = "MICounterLEDDisplay";
            this.MICounterLEDDisplay.NibbleSpacing = 2;
            this.MICounterLEDDisplay.Size = new System.Drawing.Size(40, 16);
            this.MICounterLEDDisplay.TabIndex = 102;
            // 
            // led82
            // 
            this.led82.LEDColor = System.Drawing.Color.Red;
            this.led82.Location = new System.Drawing.Point(3, 3);
            this.led82.Name = "led82";
            this.led82.Size = new System.Drawing.Size(11, 11);
            this.led82.TabIndex = 0;
            // 
            // led83
            // 
            this.led83.LEDColor = System.Drawing.Color.Red;
            this.led83.Location = new System.Drawing.Point(15, 3);
            this.led83.Name = "led83";
            this.led83.Size = new System.Drawing.Size(11, 11);
            this.led83.TabIndex = 1;
            // 
            // led84
            // 
            this.led84.LEDColor = System.Drawing.Color.Red;
            this.led84.Location = new System.Drawing.Point(27, 3);
            this.led84.Name = "led84";
            this.led84.Size = new System.Drawing.Size(11, 11);
            this.led84.TabIndex = 2;
            // 
            // InstRegLEDDisplay
            // 
            this.InstRegLEDDisplay.Controls.Add(this.led3);
            this.InstRegLEDDisplay.Controls.Add(this.led4);
            this.InstRegLEDDisplay.Controls.Add(this.led5);
            this.InstRegLEDDisplay.Controls.Add(this.led6);
            this.InstRegLEDDisplay.Controls.Add(this.led7);
            this.InstRegLEDDisplay.Controls.Add(this.led8);
            this.InstRegLEDDisplay.Controls.Add(this.led9);
            this.InstRegLEDDisplay.Controls.Add(this.led10);
            this.InstRegLEDDisplay.LEDs.Add(this.led3);
            this.InstRegLEDDisplay.LEDs.Add(this.led4);
            this.InstRegLEDDisplay.LEDs.Add(this.led5);
            this.InstRegLEDDisplay.LEDs.Add(this.led6);
            this.InstRegLEDDisplay.LEDs.Add(this.led7);
            this.InstRegLEDDisplay.LEDs.Add(this.led8);
            this.InstRegLEDDisplay.LEDs.Add(this.led9);
            this.InstRegLEDDisplay.LEDs.Add(this.led10);
            this.InstRegLEDDisplay.LEDSpacing = 2;
            this.InstRegLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.InstRegLEDDisplay.Name = "InstRegLEDDisplay";
            this.InstRegLEDDisplay.NibbleSpacing = 2;
            this.InstRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
            this.InstRegLEDDisplay.TabIndex = 35;
            // 
            // led3
            // 
            this.led3.LEDColor = System.Drawing.Color.Blue;
            this.led3.Location = new System.Drawing.Point(3, 3);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(11, 11);
            this.led3.TabIndex = 0;
            // 
            // led4
            // 
            this.led4.LEDColor = System.Drawing.Color.Blue;
            this.led4.Location = new System.Drawing.Point(15, 3);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(11, 11);
            this.led4.TabIndex = 1;
            // 
            // led5
            // 
            this.led5.LEDColor = System.Drawing.Color.Blue;
            this.led5.Location = new System.Drawing.Point(27, 3);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(11, 11);
            this.led5.TabIndex = 2;
            // 
            // led6
            // 
            this.led6.LEDColor = System.Drawing.Color.Blue;
            this.led6.Location = new System.Drawing.Point(39, 3);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(11, 11);
            this.led6.TabIndex = 3;
            // 
            // led7
            // 
            this.led7.LEDColor = System.Drawing.Color.Gold;
            this.led7.Location = new System.Drawing.Point(53, 3);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(11, 11);
            this.led7.TabIndex = 4;
            // 
            // led8
            // 
            this.led8.LEDColor = System.Drawing.Color.Gold;
            this.led8.Location = new System.Drawing.Point(65, 3);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(11, 11);
            this.led8.TabIndex = 5;
            // 
            // led9
            // 
            this.led9.LEDColor = System.Drawing.Color.Gold;
            this.led9.Location = new System.Drawing.Point(77, 3);
            this.led9.Name = "led9";
            this.led9.Size = new System.Drawing.Size(11, 11);
            this.led9.TabIndex = 6;
            // 
            // led10
            // 
            this.led10.LEDColor = System.Drawing.Color.Gold;
            this.led10.Location = new System.Drawing.Point(89, 3);
            this.led10.Name = "led10";
            this.led10.Size = new System.Drawing.Size(11, 11);
            this.led10.TabIndex = 7;
            // 
            // RAMLEDDisplay
            // 
            this.RAMLEDDisplay.Controls.Add(this.led43);
            this.RAMLEDDisplay.Controls.Add(this.led44);
            this.RAMLEDDisplay.Controls.Add(this.led45);
            this.RAMLEDDisplay.Controls.Add(this.led46);
            this.RAMLEDDisplay.Controls.Add(this.led47);
            this.RAMLEDDisplay.Controls.Add(this.led48);
            this.RAMLEDDisplay.Controls.Add(this.led49);
            this.RAMLEDDisplay.Controls.Add(this.led50);
            this.RAMLEDDisplay.LEDs.Add(this.led43);
            this.RAMLEDDisplay.LEDs.Add(this.led44);
            this.RAMLEDDisplay.LEDs.Add(this.led45);
            this.RAMLEDDisplay.LEDs.Add(this.led46);
            this.RAMLEDDisplay.LEDs.Add(this.led47);
            this.RAMLEDDisplay.LEDs.Add(this.led48);
            this.RAMLEDDisplay.LEDs.Add(this.led49);
            this.RAMLEDDisplay.LEDs.Add(this.led50);
            this.RAMLEDDisplay.LEDSpacing = 2;
            this.RAMLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.RAMLEDDisplay.Name = "RAMLEDDisplay";
            this.RAMLEDDisplay.NibbleSpacing = 2;
            this.RAMLEDDisplay.Size = new System.Drawing.Size(104, 16);
            this.RAMLEDDisplay.TabIndex = 45;
            // 
            // led43
            // 
            this.led43.LEDColor = System.Drawing.Color.Red;
            this.led43.Location = new System.Drawing.Point(3, 3);
            this.led43.Name = "led43";
            this.led43.Size = new System.Drawing.Size(11, 11);
            this.led43.TabIndex = 0;
            // 
            // led44
            // 
            this.led44.LEDColor = System.Drawing.Color.Red;
            this.led44.Location = new System.Drawing.Point(15, 3);
            this.led44.Name = "led44";
            this.led44.Size = new System.Drawing.Size(11, 11);
            this.led44.TabIndex = 1;
            // 
            // led45
            // 
            this.led45.LEDColor = System.Drawing.Color.Red;
            this.led45.Location = new System.Drawing.Point(27, 3);
            this.led45.Name = "led45";
            this.led45.Size = new System.Drawing.Size(11, 11);
            this.led45.TabIndex = 2;
            // 
            // led46
            // 
            this.led46.LEDColor = System.Drawing.Color.Red;
            this.led46.Location = new System.Drawing.Point(39, 3);
            this.led46.Name = "led46";
            this.led46.Size = new System.Drawing.Size(11, 11);
            this.led46.TabIndex = 3;
            // 
            // led47
            // 
            this.led47.LEDColor = System.Drawing.Color.Red;
            this.led47.Location = new System.Drawing.Point(53, 3);
            this.led47.Name = "led47";
            this.led47.Size = new System.Drawing.Size(11, 11);
            this.led47.TabIndex = 4;
            // 
            // led48
            // 
            this.led48.LEDColor = System.Drawing.Color.Red;
            this.led48.Location = new System.Drawing.Point(65, 3);
            this.led48.Name = "led48";
            this.led48.Size = new System.Drawing.Size(11, 11);
            this.led48.TabIndex = 5;
            // 
            // led49
            // 
            this.led49.LEDColor = System.Drawing.Color.Red;
            this.led49.Location = new System.Drawing.Point(77, 3);
            this.led49.Name = "led49";
            this.led49.Size = new System.Drawing.Size(11, 11);
            this.led49.TabIndex = 6;
            // 
            // led50
            // 
            this.led50.LEDColor = System.Drawing.Color.Red;
            this.led50.Location = new System.Drawing.Point(89, 3);
            this.led50.Name = "led50";
            this.led50.Size = new System.Drawing.Size(11, 11);
            this.led50.TabIndex = 7;
            // 
            // MARLEDDisplay
            // 
            this.MARLEDDisplay.Controls.Add(this.led51);
            this.MARLEDDisplay.Controls.Add(this.led52);
            this.MARLEDDisplay.Controls.Add(this.led53);
            this.MARLEDDisplay.Controls.Add(this.led54);
            this.MARLEDDisplay.LEDs.Add(this.led51);
            this.MARLEDDisplay.LEDs.Add(this.led52);
            this.MARLEDDisplay.LEDs.Add(this.led53);
            this.MARLEDDisplay.LEDs.Add(this.led54);
            this.MARLEDDisplay.LEDSpacing = 2;
            this.MARLEDDisplay.Location = new System.Drawing.Point(56, 22);
            this.MARLEDDisplay.Name = "MARLEDDisplay";
            this.MARLEDDisplay.NibbleSpacing = 2;
            this.MARLEDDisplay.Size = new System.Drawing.Size(54, 16);
            this.MARLEDDisplay.TabIndex = 52;
            // 
            // led51
            // 
            this.led51.LEDColor = System.Drawing.Color.Gold;
            this.led51.Location = new System.Drawing.Point(3, 3);
            this.led51.Name = "led51";
            this.led51.Size = new System.Drawing.Size(11, 11);
            this.led51.TabIndex = 0;
            // 
            // led52
            // 
            this.led52.LEDColor = System.Drawing.Color.Gold;
            this.led52.Location = new System.Drawing.Point(15, 3);
            this.led52.Name = "led52";
            this.led52.Size = new System.Drawing.Size(11, 11);
            this.led52.TabIndex = 1;
            // 
            // led53
            // 
            this.led53.LEDColor = System.Drawing.Color.Gold;
            this.led53.Location = new System.Drawing.Point(27, 3);
            this.led53.Name = "led53";
            this.led53.Size = new System.Drawing.Size(11, 11);
            this.led53.TabIndex = 2;
            // 
            // led54
            // 
            this.led54.LEDColor = System.Drawing.Color.Gold;
            this.led54.Location = new System.Drawing.Point(39, 3);
            this.led54.Name = "led54";
            this.led54.Size = new System.Drawing.Size(11, 11);
            this.led54.TabIndex = 3;
            // 
            // StatusLEDDsiaply
            // 
            this.StatusLEDDsiaply.Controls.Add(this.led67);
            this.StatusLEDDsiaply.Controls.Add(this.led68);
            this.StatusLEDDsiaply.Controls.Add(this.led69);
            this.StatusLEDDsiaply.Controls.Add(this.led70);
            this.StatusLEDDsiaply.Controls.Add(this.led71);
            this.StatusLEDDsiaply.Controls.Add(this.led72);
            this.StatusLEDDsiaply.Controls.Add(this.led73);
            this.StatusLEDDsiaply.Controls.Add(this.led74);
            this.StatusLEDDsiaply.Controls.Add(this.led75);
            this.StatusLEDDsiaply.Controls.Add(this.led76);
            this.StatusLEDDsiaply.Controls.Add(this.led77);
            this.StatusLEDDsiaply.Controls.Add(this.led78);
            this.StatusLEDDsiaply.Controls.Add(this.led79);
            this.StatusLEDDsiaply.Controls.Add(this.led80);
            this.StatusLEDDsiaply.Controls.Add(this.led81);
            this.StatusLEDDsiaply.Controls.Add(this.led94);
            this.StatusLEDDsiaply.LEDs.Add(this.led67);
            this.StatusLEDDsiaply.LEDs.Add(this.led68);
            this.StatusLEDDsiaply.LEDs.Add(this.led69);
            this.StatusLEDDsiaply.LEDs.Add(this.led70);
            this.StatusLEDDsiaply.LEDs.Add(this.led71);
            this.StatusLEDDsiaply.LEDs.Add(this.led72);
            this.StatusLEDDsiaply.LEDs.Add(this.led73);
            this.StatusLEDDsiaply.LEDs.Add(this.led74);
            this.StatusLEDDsiaply.LEDs.Add(this.led75);
            this.StatusLEDDsiaply.LEDs.Add(this.led76);
            this.StatusLEDDsiaply.LEDs.Add(this.led77);
            this.StatusLEDDsiaply.LEDs.Add(this.led78);
            this.StatusLEDDsiaply.LEDs.Add(this.led79);
            this.StatusLEDDsiaply.LEDs.Add(this.led80);
            this.StatusLEDDsiaply.LEDs.Add(this.led81);
            this.StatusLEDDsiaply.LEDs.Add(this.led94);
            this.StatusLEDDsiaply.LEDSpacing = 4;
            this.StatusLEDDsiaply.Location = new System.Drawing.Point(6, 46);
            this.StatusLEDDsiaply.Name = "StatusLEDDsiaply";
            this.StatusLEDDsiaply.NibbleSpacing = 0;
            this.StatusLEDDsiaply.Size = new System.Drawing.Size(230, 16);
            this.StatusLEDDsiaply.TabIndex = 83;
            // 
            // led67
            // 
            this.led67.LEDColor = System.Drawing.Color.Blue;
            this.led67.Location = new System.Drawing.Point(3, 3);
            this.led67.Name = "led67";
            this.led67.Size = new System.Drawing.Size(11, 11);
            this.led67.TabIndex = 0;
            // 
            // led68
            // 
            this.led68.LEDColor = System.Drawing.Color.Blue;
            this.led68.Location = new System.Drawing.Point(17, 3);
            this.led68.Name = "led68";
            this.led68.Size = new System.Drawing.Size(11, 11);
            this.led68.TabIndex = 1;
            // 
            // led69
            // 
            this.led69.LEDColor = System.Drawing.Color.Blue;
            this.led69.Location = new System.Drawing.Point(31, 3);
            this.led69.Name = "led69";
            this.led69.Size = new System.Drawing.Size(11, 11);
            this.led69.TabIndex = 2;
            // 
            // led70
            // 
            this.led70.LEDColor = System.Drawing.Color.Blue;
            this.led70.Location = new System.Drawing.Point(45, 3);
            this.led70.Name = "led70";
            this.led70.Size = new System.Drawing.Size(11, 11);
            this.led70.TabIndex = 3;
            // 
            // led71
            // 
            this.led71.LEDColor = System.Drawing.Color.Blue;
            this.led71.Location = new System.Drawing.Point(59, 3);
            this.led71.Name = "led71";
            this.led71.Size = new System.Drawing.Size(11, 11);
            this.led71.TabIndex = 4;
            // 
            // led72
            // 
            this.led72.LEDColor = System.Drawing.Color.Blue;
            this.led72.Location = new System.Drawing.Point(73, 3);
            this.led72.Name = "led72";
            this.led72.Size = new System.Drawing.Size(11, 11);
            this.led72.TabIndex = 5;
            // 
            // led73
            // 
            this.led73.LEDColor = System.Drawing.Color.Blue;
            this.led73.Location = new System.Drawing.Point(87, 3);
            this.led73.Name = "led73";
            this.led73.Size = new System.Drawing.Size(11, 11);
            this.led73.TabIndex = 6;
            // 
            // led74
            // 
            this.led74.LEDColor = System.Drawing.Color.Blue;
            this.led74.Location = new System.Drawing.Point(101, 3);
            this.led74.Name = "led74";
            this.led74.Size = new System.Drawing.Size(11, 11);
            this.led74.TabIndex = 7;
            // 
            // led75
            // 
            this.led75.LEDColor = System.Drawing.Color.Blue;
            this.led75.Location = new System.Drawing.Point(115, 3);
            this.led75.Name = "led75";
            this.led75.Size = new System.Drawing.Size(11, 11);
            this.led75.TabIndex = 8;
            // 
            // led76
            // 
            this.led76.LEDColor = System.Drawing.Color.Blue;
            this.led76.Location = new System.Drawing.Point(129, 3);
            this.led76.Name = "led76";
            this.led76.Size = new System.Drawing.Size(11, 11);
            this.led76.TabIndex = 9;
            // 
            // led77
            // 
            this.led77.LEDColor = System.Drawing.Color.Blue;
            this.led77.Location = new System.Drawing.Point(143, 3);
            this.led77.Name = "led77";
            this.led77.Size = new System.Drawing.Size(11, 11);
            this.led77.TabIndex = 10;
            // 
            // led78
            // 
            this.led78.LEDColor = System.Drawing.Color.Blue;
            this.led78.Location = new System.Drawing.Point(157, 3);
            this.led78.Name = "led78";
            this.led78.Size = new System.Drawing.Size(11, 11);
            this.led78.TabIndex = 11;
            // 
            // led79
            // 
            this.led79.LEDColor = System.Drawing.Color.Blue;
            this.led79.Location = new System.Drawing.Point(171, 3);
            this.led79.Name = "led79";
            this.led79.Size = new System.Drawing.Size(11, 11);
            this.led79.TabIndex = 12;
            // 
            // led80
            // 
            this.led80.LEDColor = System.Drawing.Color.Blue;
            this.led80.Location = new System.Drawing.Point(185, 3);
            this.led80.Name = "led80";
            this.led80.Size = new System.Drawing.Size(11, 11);
            this.led80.TabIndex = 13;
            // 
            // led81
            // 
            this.led81.LEDColor = System.Drawing.Color.Blue;
            this.led81.Location = new System.Drawing.Point(199, 3);
            this.led81.Name = "led81";
            this.led81.Size = new System.Drawing.Size(11, 11);
            this.led81.TabIndex = 14;
            // 
            // led94
            // 
            this.led94.LEDColor = System.Drawing.Color.Blue;
            this.led94.Location = new System.Drawing.Point(213, 3);
            this.led94.Name = "led94";
            this.led94.Size = new System.Drawing.Size(11, 11);
            this.led94.TabIndex = 15;
            // 
            // rLabel1
            // 
            this.rLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel1.Location = new System.Drawing.Point(6, 18);
            this.rLabel1.Name = "rLabel1";
            this.rLabel1.RotationAngle = 90D;
            this.rLabel1.Size = new System.Drawing.Size(15, 25);
            this.rLabel1.TabIndex = 84;
            this.rLabel1.Text = "HLT";
            this.rLabel1.TopLine = false;
            // 
            // rLabel2
            // 
            this.rLabel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel2.Location = new System.Drawing.Point(20, 27);
            this.rLabel2.Name = "rLabel2";
            this.rLabel2.RotationAngle = 90D;
            this.rLabel2.Size = new System.Drawing.Size(14, 16);
            this.rLabel2.TabIndex = 86;
            this.rLabel2.Text = "MI";
            this.rLabel2.TopLine = false;
            // 
            // rLabel3
            // 
            this.rLabel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel3.Location = new System.Drawing.Point(34, 27);
            this.rLabel3.Name = "rLabel3";
            this.rLabel3.RotationAngle = 90D;
            this.rLabel3.Size = new System.Drawing.Size(14, 16);
            this.rLabel3.TabIndex = 87;
            this.rLabel3.Text = "RI";
            this.rLabel3.TopLine = false;
            // 
            // rLabel4
            // 
            this.rLabel4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel4.Location = new System.Drawing.Point(48, 27);
            this.rLabel4.Name = "rLabel4";
            this.rLabel4.RotationAngle = 90D;
            this.rLabel4.Size = new System.Drawing.Size(14, 16);
            this.rLabel4.TabIndex = 88;
            this.rLabel4.Text = "RO";
            this.rLabel4.TopLine = false;
            // 
            // rLabel5
            // 
            this.rLabel5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel5.Location = new System.Drawing.Point(62, 27);
            this.rLabel5.Name = "rLabel5";
            this.rLabel5.RotationAngle = 90D;
            this.rLabel5.Size = new System.Drawing.Size(14, 16);
            this.rLabel5.TabIndex = 89;
            this.rLabel5.Text = "IO";
            this.rLabel5.TopLine = false;
            // 
            // rLabel6
            // 
            this.rLabel6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel6.Location = new System.Drawing.Point(76, 27);
            this.rLabel6.Name = "rLabel6";
            this.rLabel6.RotationAngle = 90D;
            this.rLabel6.Size = new System.Drawing.Size(14, 16);
            this.rLabel6.TabIndex = 90;
            this.rLabel6.Text = "II";
            this.rLabel6.TopLine = false;
            // 
            // rLabel7
            // 
            this.rLabel7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel7.Location = new System.Drawing.Point(91, 27);
            this.rLabel7.Name = "rLabel7";
            this.rLabel7.RotationAngle = 90D;
            this.rLabel7.Size = new System.Drawing.Size(14, 16);
            this.rLabel7.TabIndex = 91;
            this.rLabel7.Text = "AI";
            this.rLabel7.TopLine = false;
            // 
            // rLabel8
            // 
            this.rLabel8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel8.Location = new System.Drawing.Point(105, 27);
            this.rLabel8.Name = "rLabel8";
            this.rLabel8.RotationAngle = 90D;
            this.rLabel8.Size = new System.Drawing.Size(14, 16);
            this.rLabel8.TabIndex = 92;
            this.rLabel8.Text = "AO";
            this.rLabel8.TopLine = false;
            // 
            // rLabel9
            // 
            this.rLabel9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel9.Location = new System.Drawing.Point(118, 27);
            this.rLabel9.Name = "rLabel9";
            this.rLabel9.RotationAngle = 90D;
            this.rLabel9.Size = new System.Drawing.Size(14, 16);
            this.rLabel9.TabIndex = 93;
            this.rLabel9.Text = "SO";
            this.rLabel9.TopLine = false;
            // 
            // rLabel10
            // 
            this.rLabel10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel10.Location = new System.Drawing.Point(132, 19);
            this.rLabel10.Name = "rLabel10";
            this.rLabel10.RotationAngle = 90D;
            this.rLabel10.Size = new System.Drawing.Size(14, 25);
            this.rLabel10.TabIndex = 94;
            this.rLabel10.Text = "SUB";
            this.rLabel10.TopLine = false;
            // 
            // rLabel25
            // 
            this.rLabel25.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel25.Location = new System.Drawing.Point(216, 27);
            this.rLabel25.Name = "rLabel25";
            this.rLabel25.RotationAngle = 90D;
            this.rLabel25.Size = new System.Drawing.Size(14, 16);
            this.rLabel25.TabIndex = 121;
            this.rLabel25.Text = "FI";
            this.rLabel25.TopLine = false;
            // 
            // rLabel12
            // 
            this.rLabel12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel12.Location = new System.Drawing.Point(146, 27);
            this.rLabel12.Name = "rLabel12";
            this.rLabel12.RotationAngle = 90D;
            this.rLabel12.Size = new System.Drawing.Size(14, 16);
            this.rLabel12.TabIndex = 95;
            this.rLabel12.Text = "BI";
            this.rLabel12.TopLine = false;
            // 
            // rLabel11
            // 
            this.rLabel11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel11.Location = new System.Drawing.Point(160, 27);
            this.rLabel11.Name = "rLabel11";
            this.rLabel11.RotationAngle = 90D;
            this.rLabel11.Size = new System.Drawing.Size(14, 16);
            this.rLabel11.TabIndex = 96;
            this.rLabel11.Text = "OI";
            this.rLabel11.TopLine = false;
            // 
            // rLabel13
            // 
            this.rLabel13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel13.Location = new System.Drawing.Point(174, 28);
            this.rLabel13.Name = "rLabel13";
            this.rLabel13.RotationAngle = 90D;
            this.rLabel13.Size = new System.Drawing.Size(14, 16);
            this.rLabel13.TabIndex = 97;
            this.rLabel13.Text = "CE";
            this.rLabel13.TopLine = false;
            // 
            // rLabel14
            // 
            this.rLabel14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel14.Location = new System.Drawing.Point(188, 27);
            this.rLabel14.Name = "rLabel14";
            this.rLabel14.RotationAngle = 90D;
            this.rLabel14.Size = new System.Drawing.Size(14, 16);
            this.rLabel14.TabIndex = 98;
            this.rLabel14.Text = "CO";
            this.rLabel14.TopLine = false;
            // 
            // rLabel15
            // 
            this.rLabel15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel15.Location = new System.Drawing.Point(202, 18);
            this.rLabel15.Name = "rLabel15";
            this.rLabel15.RotationAngle = 90D;
            this.rLabel15.Size = new System.Drawing.Size(14, 25);
            this.rLabel15.TabIndex = 99;
            this.rLabel15.Text = "JMP";
            this.rLabel15.TopLine = false;
            // 
            // OutputRegLEDDisplay
            // 
            this.OutputRegLEDDisplay.Controls.Add(this.led59);
            this.OutputRegLEDDisplay.Controls.Add(this.led60);
            this.OutputRegLEDDisplay.Controls.Add(this.led61);
            this.OutputRegLEDDisplay.Controls.Add(this.led62);
            this.OutputRegLEDDisplay.Controls.Add(this.led63);
            this.OutputRegLEDDisplay.Controls.Add(this.led64);
            this.OutputRegLEDDisplay.Controls.Add(this.led65);
            this.OutputRegLEDDisplay.Controls.Add(this.led66);
            this.OutputRegLEDDisplay.LEDs.Add(this.led59);
            this.OutputRegLEDDisplay.LEDs.Add(this.led60);
            this.OutputRegLEDDisplay.LEDs.Add(this.led61);
            this.OutputRegLEDDisplay.LEDs.Add(this.led62);
            this.OutputRegLEDDisplay.LEDs.Add(this.led63);
            this.OutputRegLEDDisplay.LEDs.Add(this.led64);
            this.OutputRegLEDDisplay.LEDs.Add(this.led65);
            this.OutputRegLEDDisplay.LEDs.Add(this.led66);
            this.OutputRegLEDDisplay.LEDSpacing = 2;
            this.OutputRegLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.OutputRegLEDDisplay.Name = "OutputRegLEDDisplay";
            this.OutputRegLEDDisplay.NibbleSpacing = 2;
            this.OutputRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
            this.OutputRegLEDDisplay.TabIndex = 74;
            // 
            // led59
            // 
            this.led59.LEDColor = System.Drawing.Color.Red;
            this.led59.Location = new System.Drawing.Point(3, 3);
            this.led59.Name = "led59";
            this.led59.Size = new System.Drawing.Size(11, 11);
            this.led59.TabIndex = 0;
            // 
            // led60
            // 
            this.led60.LEDColor = System.Drawing.Color.Red;
            this.led60.Location = new System.Drawing.Point(15, 3);
            this.led60.Name = "led60";
            this.led60.Size = new System.Drawing.Size(11, 11);
            this.led60.TabIndex = 1;
            // 
            // led61
            // 
            this.led61.LEDColor = System.Drawing.Color.Red;
            this.led61.Location = new System.Drawing.Point(27, 3);
            this.led61.Name = "led61";
            this.led61.Size = new System.Drawing.Size(11, 11);
            this.led61.TabIndex = 2;
            // 
            // led62
            // 
            this.led62.LEDColor = System.Drawing.Color.Red;
            this.led62.Location = new System.Drawing.Point(39, 3);
            this.led62.Name = "led62";
            this.led62.Size = new System.Drawing.Size(11, 11);
            this.led62.TabIndex = 3;
            // 
            // led63
            // 
            this.led63.LEDColor = System.Drawing.Color.Red;
            this.led63.Location = new System.Drawing.Point(53, 3);
            this.led63.Name = "led63";
            this.led63.Size = new System.Drawing.Size(11, 11);
            this.led63.TabIndex = 4;
            // 
            // led64
            // 
            this.led64.LEDColor = System.Drawing.Color.Red;
            this.led64.Location = new System.Drawing.Point(65, 3);
            this.led64.Name = "led64";
            this.led64.Size = new System.Drawing.Size(11, 11);
            this.led64.TabIndex = 5;
            // 
            // led65
            // 
            this.led65.LEDColor = System.Drawing.Color.Red;
            this.led65.Location = new System.Drawing.Point(77, 3);
            this.led65.Name = "led65";
            this.led65.Size = new System.Drawing.Size(11, 11);
            this.led65.TabIndex = 6;
            // 
            // led66
            // 
            this.led66.LEDColor = System.Drawing.Color.Red;
            this.led66.Location = new System.Drawing.Point(89, 3);
            this.led66.Name = "led66";
            this.led66.Size = new System.Drawing.Size(11, 11);
            this.led66.TabIndex = 7;
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
            this.BRegLEDDisplay.LEDSpacing = 2;
            this.BRegLEDDisplay.Location = new System.Drawing.Point(9, 19);
            this.BRegLEDDisplay.Name = "BRegLEDDisplay";
            this.BRegLEDDisplay.NibbleSpacing = 2;
            this.BRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
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
            this.led31.Location = new System.Drawing.Point(53, 3);
            this.led31.Name = "led31";
            this.led31.Size = new System.Drawing.Size(11, 11);
            this.led31.TabIndex = 4;
            // 
            // led32
            // 
            this.led32.LEDColor = System.Drawing.Color.Red;
            this.led32.Location = new System.Drawing.Point(65, 3);
            this.led32.Name = "led32";
            this.led32.Size = new System.Drawing.Size(11, 11);
            this.led32.TabIndex = 5;
            // 
            // led33
            // 
            this.led33.LEDColor = System.Drawing.Color.Red;
            this.led33.Location = new System.Drawing.Point(77, 3);
            this.led33.Name = "led33";
            this.led33.Size = new System.Drawing.Size(11, 11);
            this.led33.TabIndex = 6;
            // 
            // led34
            // 
            this.led34.LEDColor = System.Drawing.Color.Red;
            this.led34.Location = new System.Drawing.Point(89, 3);
            this.led34.Name = "led34";
            this.led34.Size = new System.Drawing.Size(11, 11);
            this.led34.TabIndex = 7;
            // 
            // FlagRegLEDDisplay
            // 
            this.FlagRegLEDDisplay.Controls.Add(this.led92);
            this.FlagRegLEDDisplay.Controls.Add(this.led93);
            this.FlagRegLEDDisplay.LEDs.Add(this.led92);
            this.FlagRegLEDDisplay.LEDs.Add(this.led93);
            this.FlagRegLEDDisplay.LEDSpacing = 4;
            this.FlagRegLEDDisplay.Location = new System.Drawing.Point(7, 31);
            this.FlagRegLEDDisplay.Name = "FlagRegLEDDisplay";
            this.FlagRegLEDDisplay.NibbleSpacing = 0;
            this.FlagRegLEDDisplay.Size = new System.Drawing.Size(34, 16);
            this.FlagRegLEDDisplay.TabIndex = 116;
            // 
            // led92
            // 
            this.led92.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led92.Location = new System.Drawing.Point(3, 3);
            this.led92.Name = "led92";
            this.led92.Size = new System.Drawing.Size(11, 11);
            this.led92.TabIndex = 0;
            // 
            // led93
            // 
            this.led93.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led93.Location = new System.Drawing.Point(17, 3);
            this.led93.Name = "led93";
            this.led93.Size = new System.Drawing.Size(11, 11);
            this.led93.TabIndex = 1;
            // 
            // rLabel24
            // 
            this.rLabel24.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel24.Location = new System.Drawing.Point(10, 15);
            this.rLabel24.Name = "rLabel24";
            this.rLabel24.RotationAngle = 90D;
            this.rLabel24.Size = new System.Drawing.Size(14, 16);
            this.rLabel24.TabIndex = 117;
            this.rLabel24.Text = "CF";
            this.rLabel24.TopLine = false;
            // 
            // rLabel23
            // 
            this.rLabel23.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel23.Location = new System.Drawing.Point(22, 15);
            this.rLabel23.Name = "rLabel23";
            this.rLabel23.RotationAngle = 90D;
            this.rLabel23.Size = new System.Drawing.Size(14, 16);
            this.rLabel23.TabIndex = 118;
            this.rLabel23.Text = "ZF";
            this.rLabel23.TopLine = false;
            // 
            // SubLED
            // 
            this.SubLED.LEDColor = System.Drawing.Color.Blue;
            this.SubLED.Location = new System.Drawing.Point(135, 58);
            this.SubLED.Name = "SubLED";
            this.SubLED.Size = new System.Drawing.Size(11, 11);
            this.SubLED.TabIndex = 71;
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
            this.SumRegLEDDisplay.LEDSpacing = 2;
            this.SumRegLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.SumRegLEDDisplay.Name = "SumRegLEDDisplay";
            this.SumRegLEDDisplay.NibbleSpacing = 2;
            this.SumRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
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
            this.led39.Location = new System.Drawing.Point(53, 3);
            this.led39.Name = "led39";
            this.led39.Size = new System.Drawing.Size(11, 11);
            this.led39.TabIndex = 4;
            // 
            // led40
            // 
            this.led40.LEDColor = System.Drawing.Color.Red;
            this.led40.Location = new System.Drawing.Point(65, 3);
            this.led40.Name = "led40";
            this.led40.Size = new System.Drawing.Size(11, 11);
            this.led40.TabIndex = 5;
            // 
            // led41
            // 
            this.led41.LEDColor = System.Drawing.Color.Red;
            this.led41.Location = new System.Drawing.Point(77, 3);
            this.led41.Name = "led41";
            this.led41.Size = new System.Drawing.Size(11, 11);
            this.led41.TabIndex = 6;
            // 
            // led42
            // 
            this.led42.LEDColor = System.Drawing.Color.Red;
            this.led42.Location = new System.Drawing.Point(89, 3);
            this.led42.Name = "led42";
            this.led42.Size = new System.Drawing.Size(11, 11);
            this.led42.TabIndex = 7;
            // 
            // rLabel22
            // 
            this.rLabel22.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel22.Location = new System.Drawing.Point(30, 42);
            this.rLabel22.Name = "rLabel22";
            this.rLabel22.RotationAngle = 0D;
            this.rLabel22.Size = new System.Drawing.Size(12, 10);
            this.rLabel22.TabIndex = 115;
            this.rLabel22.Text = "Z";
            this.rLabel22.TopLine = false;
            // 
            // SumFlagsLEDDisplay
            // 
            this.SumFlagsLEDDisplay.Controls.Add(this.led90);
            this.SumFlagsLEDDisplay.Controls.Add(this.led91);
            this.SumFlagsLEDDisplay.LEDs.Add(this.led90);
            this.SumFlagsLEDDisplay.LEDs.Add(this.led91);
            this.SumFlagsLEDDisplay.LEDSpacing = 5;
            this.SumFlagsLEDDisplay.Location = new System.Drawing.Point(12, 50);
            this.SumFlagsLEDDisplay.Name = "SumFlagsLEDDisplay";
            this.SumFlagsLEDDisplay.NibbleSpacing = 0;
            this.SumFlagsLEDDisplay.Size = new System.Drawing.Size(36, 16);
            this.SumFlagsLEDDisplay.TabIndex = 113;
            // 
            // led90
            // 
            this.led90.LEDColor = System.Drawing.Color.Blue;
            this.led90.Location = new System.Drawing.Point(3, 3);
            this.led90.Name = "led90";
            this.led90.Size = new System.Drawing.Size(11, 11);
            this.led90.TabIndex = 0;
            // 
            // led91
            // 
            this.led91.LEDColor = System.Drawing.Color.Blue;
            this.led91.Location = new System.Drawing.Point(18, 3);
            this.led91.Name = "led91";
            this.led91.Size = new System.Drawing.Size(11, 11);
            this.led91.TabIndex = 1;
            // 
            // rLabel20
            // 
            this.rLabel20.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel20.Location = new System.Drawing.Point(15, 42);
            this.rLabel20.Name = "rLabel20";
            this.rLabel20.RotationAngle = 0D;
            this.rLabel20.Size = new System.Drawing.Size(12, 10);
            this.rLabel20.TabIndex = 114;
            this.rLabel20.Text = "C";
            this.rLabel20.TopLine = false;
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
            this.ARegLEDDisplay.LEDSpacing = 2;
            this.ARegLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.ARegLEDDisplay.Name = "ARegLEDDisplay";
            this.ARegLEDDisplay.NibbleSpacing = 2;
            this.ARegLEDDisplay.Size = new System.Drawing.Size(104, 16);
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
            this.led23.Location = new System.Drawing.Point(53, 3);
            this.led23.Name = "led23";
            this.led23.Size = new System.Drawing.Size(11, 11);
            this.led23.TabIndex = 4;
            // 
            // led24
            // 
            this.led24.LEDColor = System.Drawing.Color.Red;
            this.led24.Location = new System.Drawing.Point(65, 3);
            this.led24.Name = "led24";
            this.led24.Size = new System.Drawing.Size(11, 11);
            this.led24.TabIndex = 5;
            // 
            // led25
            // 
            this.led25.LEDColor = System.Drawing.Color.Red;
            this.led25.Location = new System.Drawing.Point(77, 3);
            this.led25.Name = "led25";
            this.led25.Size = new System.Drawing.Size(11, 11);
            this.led25.TabIndex = 6;
            // 
            // led26
            // 
            this.led26.LEDColor = System.Drawing.Color.Red;
            this.led26.Location = new System.Drawing.Point(89, 3);
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
            this.BusLEDDisplay.LEDSpacing = 2;
            this.BusLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.BusLEDDisplay.Name = "BusLEDDisplay";
            this.BusLEDDisplay.NibbleSpacing = 2;
            this.BusLEDDisplay.Size = new System.Drawing.Size(104, 16);
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
            this.led15.Location = new System.Drawing.Point(53, 3);
            this.led15.Name = "led15";
            this.led15.Size = new System.Drawing.Size(11, 11);
            this.led15.TabIndex = 4;
            // 
            // led16
            // 
            this.led16.LEDColor = System.Drawing.Color.Red;
            this.led16.Location = new System.Drawing.Point(65, 3);
            this.led16.Name = "led16";
            this.led16.Size = new System.Drawing.Size(11, 11);
            this.led16.TabIndex = 5;
            // 
            // led17
            // 
            this.led17.LEDColor = System.Drawing.Color.Red;
            this.led17.Location = new System.Drawing.Point(77, 3);
            this.led17.Name = "led17";
            this.led17.Size = new System.Drawing.Size(11, 11);
            this.led17.TabIndex = 6;
            // 
            // led18
            // 
            this.led18.LEDColor = System.Drawing.Color.Red;
            this.led18.Location = new System.Drawing.Point(89, 3);
            this.led18.Name = "led18";
            this.led18.Size = new System.Drawing.Size(11, 11);
            this.led18.TabIndex = 7;
            // 
            // IncLED
            // 
            this.IncLED.LEDColor = System.Drawing.Color.Blue;
            this.IncLED.Location = new System.Drawing.Point(132, 26);
            this.IncLED.Name = "IncLED";
            this.IncLED.Size = new System.Drawing.Size(11, 11);
            this.IncLED.TabIndex = 69;
            // 
            // PCLEDDisplay
            // 
            this.PCLEDDisplay.Controls.Add(this.led55);
            this.PCLEDDisplay.Controls.Add(this.led56);
            this.PCLEDDisplay.Controls.Add(this.led57);
            this.PCLEDDisplay.Controls.Add(this.led58);
            this.PCLEDDisplay.LEDs.Add(this.led55);
            this.PCLEDDisplay.LEDs.Add(this.led56);
            this.PCLEDDisplay.LEDs.Add(this.led57);
            this.PCLEDDisplay.LEDs.Add(this.led58);
            this.PCLEDDisplay.LEDSpacing = 2;
            this.PCLEDDisplay.Location = new System.Drawing.Point(9, 16);
            this.PCLEDDisplay.Name = "PCLEDDisplay";
            this.PCLEDDisplay.NibbleSpacing = 2;
            this.PCLEDDisplay.Size = new System.Drawing.Size(54, 16);
            this.PCLEDDisplay.TabIndex = 66;
            // 
            // led55
            // 
            this.led55.LEDColor = System.Drawing.Color.LimeGreen;
            this.led55.Location = new System.Drawing.Point(3, 3);
            this.led55.Name = "led55";
            this.led55.Size = new System.Drawing.Size(11, 11);
            this.led55.TabIndex = 0;
            // 
            // led56
            // 
            this.led56.LEDColor = System.Drawing.Color.LimeGreen;
            this.led56.Location = new System.Drawing.Point(15, 3);
            this.led56.Name = "led56";
            this.led56.Size = new System.Drawing.Size(11, 11);
            this.led56.TabIndex = 1;
            // 
            // led57
            // 
            this.led57.LEDColor = System.Drawing.Color.LimeGreen;
            this.led57.Location = new System.Drawing.Point(27, 3);
            this.led57.Name = "led57";
            this.led57.Size = new System.Drawing.Size(11, 11);
            this.led57.TabIndex = 2;
            // 
            // led58
            // 
            this.led58.LEDColor = System.Drawing.Color.LimeGreen;
            this.led58.Location = new System.Drawing.Point(39, 3);
            this.led58.Name = "led58";
            this.led58.Size = new System.Drawing.Size(11, 11);
            this.led58.TabIndex = 3;
            // 
            // ClkLed
            // 
            this.ClkLed.LEDColor = System.Drawing.Color.Fuchsia;
            this.ClkLed.Location = new System.Drawing.Point(179, 31);
            this.ClkLed.Name = "ClkLed";
            this.ClkLed.Size = new System.Drawing.Size(11, 11);
            this.ClkLed.TabIndex = 112;
            // 
            // led2
            // 
            this.led2.LEDColor = System.Drawing.Color.Red;
            this.led2.Location = new System.Drawing.Point(213, 3);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(11, 11);
            this.led2.TabIndex = 15;
            this.led2.Visible = false;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 585);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InstArrowOut);
            this.Controls.Add(this.RAMArrowOut);
            this.Controls.Add(this.InstArrowIn);
            this.Controls.Add(this.RAMArrowIn);
            this.Controls.Add(this.MARArrowIn);
            this.Controls.Add(this.SUMArrowOut);
            this.Controls.Add(this.ARegArrowOut);
            this.Controls.Add(this.PCArrowIn);
            this.Controls.Add(this.PCArrowOut);
            this.Controls.Add(this.ARegArrowIn);
            this.Controls.Add(this.OutputRegArrowIn);
            this.Controls.Add(this.BRegArrowIn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.InstGroup);
            this.Controls.Add(this.RAMGroup);
            this.Controls.Add(this.MARGroup);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.OutputGroup);
            this.Controls.Add(this.BRegGroup);
            this.Controls.Add(this.FlagsGroup);
            this.Controls.Add(this.SumGroup);
            this.Controls.Add(this.ARegGroup);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.PCGroup);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP1 Computer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyAdjust)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PCGroup.ResumeLayout(false);
            this.PCGroup.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ARegGroup.ResumeLayout(false);
            this.ARegGroup.PerformLayout();
            this.SumGroup.ResumeLayout(false);
            this.SumGroup.PerformLayout();
            this.FlagsGroup.ResumeLayout(false);
            this.BRegGroup.ResumeLayout(false);
            this.BRegGroup.PerformLayout();
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.MARGroup.ResumeLayout(false);
            this.MARGroup.PerformLayout();
            this.RAMGroup.ResumeLayout(false);
            this.RAMGroup.PerformLayout();
            this.InstGroup.ResumeLayout(false);
            this.InstGroup.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CLDecodedLEDDisplay.ResumeLayout(false);
            this.MICounterLEDDisplay.ResumeLayout(false);
            this.InstRegLEDDisplay.ResumeLayout(false);
            this.RAMLEDDisplay.ResumeLayout(false);
            this.MARLEDDisplay.ResumeLayout(false);
            this.StatusLEDDsiaply.ResumeLayout(false);
            this.OutputRegLEDDisplay.ResumeLayout(false);
            this.BRegLEDDisplay.ResumeLayout(false);
            this.FlagRegLEDDisplay.ResumeLayout(false);
            this.SumRegLEDDisplay.ResumeLayout(false);
            this.SumFlagsLEDDisplay.ResumeLayout(false);
            this.ARegLEDDisplay.ResumeLayout(false);
            this.BusLEDDisplay.ResumeLayout(false);
            this.PCLEDDisplay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClockModeBtn;
        private System.Windows.Forms.Label FreqLbl;
        private System.Windows.Forms.Button StepClockBtn;
        private System.Windows.Forms.TrackBar FrequencyAdjust;
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
        private AppCode.Visual.LEDDisplay BRegLEDDisplay;
        private AppCode.Visual.LED led27;
        private AppCode.Visual.LED led28;
        private AppCode.Visual.LED led29;
        private AppCode.Visual.LED led30;
        private AppCode.Visual.LED led31;
        private AppCode.Visual.LED led32;
        private AppCode.Visual.LED led33;
        private AppCode.Visual.LED led34;
        private AppCode.Visual.LEDDisplay SumRegLEDDisplay;
        private AppCode.Visual.LED led35;
        private AppCode.Visual.LED led36;
        private AppCode.Visual.LED led37;
        private AppCode.Visual.LED led38;
        private AppCode.Visual.LED led39;
        private AppCode.Visual.LED led40;
        private AppCode.Visual.LED led41;
        private AppCode.Visual.LED led42;
        private System.Windows.Forms.Label BusValLbl;
        private System.Windows.Forms.Label ARegValLbl;
        private System.Windows.Forms.Label SumRegValLbl;
        private System.Windows.Forms.Label BRegValLbl;
        private System.Windows.Forms.Label InstRegValLbl;
        private AppCode.Visual.LEDDisplay InstRegLEDDisplay;
        private AppCode.Visual.LED led3;
        private AppCode.Visual.LED led4;
        private AppCode.Visual.LED led5;
        private AppCode.Visual.LED led6;
        private AppCode.Visual.LED led7;
        private AppCode.Visual.LED led8;
        private AppCode.Visual.LED led9;
        private AppCode.Visual.LED led10;
        private System.Windows.Forms.Label RAMRegValLbl;
        private AppCode.Visual.LEDDisplay RAMLEDDisplay;
        private AppCode.Visual.LED led43;
        private AppCode.Visual.LED led44;
        private AppCode.Visual.LED led45;
        private AppCode.Visual.LED led46;
        private AppCode.Visual.LED led47;
        private AppCode.Visual.LED led48;
        private AppCode.Visual.LED led49;
        private AppCode.Visual.LED led50;
        private System.Windows.Forms.Label MARRegValLbl;
        private AppCode.Visual.LEDDisplay MARLEDDisplay;
        private AppCode.Visual.LED led51;
        private AppCode.Visual.LED led52;
        private AppCode.Visual.LED led53;
        private AppCode.Visual.LED led54;
        private System.Windows.Forms.ListBox RAMView;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ProgRAMAddrTB;
        private System.Windows.Forms.TextBox ProgRamDataTB;
        private System.Windows.Forms.Button ProramBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PCRegValLbl;
        private AppCode.Visual.LEDDisplay PCLEDDisplay;
        private AppCode.Visual.LED led55;
        private AppCode.Visual.LED led56;
        private AppCode.Visual.LED led57;
        private AppCode.Visual.LED led58;
        private System.Windows.Forms.Label OutputRegValLbl;
        private AppCode.Visual.LEDDisplay OutputRegLEDDisplay;
        private AppCode.Visual.LED led59;
        private AppCode.Visual.LED led60;
        private AppCode.Visual.LED led61;
        private AppCode.Visual.LED led62;
        private AppCode.Visual.LED led63;
        private AppCode.Visual.LED led64;
        private AppCode.Visual.LED led65;
        private AppCode.Visual.LED led66;
        private System.Windows.Forms.Label DisplayLbl;
        private System.Windows.Forms.Label DisplayShadowLbl;
        private System.Windows.Forms.CheckBox DisplaySignedCB;
        private AppCode.Visual.LEDDisplay StatusLEDDsiaply;
        private AppCode.Visual.LED led67;
        private AppCode.Visual.LED led68;
        private AppCode.Visual.LED led69;
        private AppCode.Visual.LED led70;
        private AppCode.Visual.RLabel rLabel1;
        private AppCode.Visual.LED led71;
        private AppCode.Visual.LED led72;
        private AppCode.Visual.LED led73;
        private AppCode.Visual.LED led74;
        private AppCode.Visual.LED led75;
        private AppCode.Visual.LED led76;
        private AppCode.Visual.LED led77;
        private AppCode.Visual.RLabel rLabel2;
        private AppCode.Visual.RLabel rLabel3;
        private AppCode.Visual.RLabel rLabel4;
        private AppCode.Visual.LED led78;
        private AppCode.Visual.LED led79;
        private AppCode.Visual.LED led80;
        private AppCode.Visual.LED led81;
        private AppCode.Visual.RLabel rLabel5;
        private AppCode.Visual.RLabel rLabel6;
        private AppCode.Visual.RLabel rLabel7;
        private AppCode.Visual.RLabel rLabel8;
        private AppCode.Visual.RLabel rLabel9;
        private AppCode.Visual.RLabel rLabel10;
        private AppCode.Visual.RLabel rLabel11;
        private AppCode.Visual.RLabel rLabel12;
        private AppCode.Visual.RLabel rLabel13;
        private AppCode.Visual.RLabel rLabel14;
        private AppCode.Visual.RLabel rLabel15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private AppCode.Visual.LEDDisplay MICounterLEDDisplay;
        private AppCode.Visual.LED led82;
        private AppCode.Visual.LED led83;
        private AppCode.Visual.LED led84;
        private AppCode.Visual.LEDDisplay CLDecodedLEDDisplay;
        private AppCode.Visual.LED led85;
        private AppCode.Visual.LED led86;
        private AppCode.Visual.LED led87;
        private AppCode.Visual.LED led88;
        private AppCode.Visual.LED led89;
        private AppCode.Visual.RLabel rLabel16;
        private AppCode.Visual.RLabel rLabel17;
        private AppCode.Visual.RLabel rLabel18;
        private AppCode.Visual.RLabel rLabel19;
        private AppCode.Visual.RLabel rLabel21;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button WipeRAMBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RandomizeRAMBtn;
        private AppCode.Visual.LEDDisplay SumFlagsLEDDisplay;
        private AppCode.Visual.LED led90;
        private AppCode.Visual.LED led91;
        private AppCode.Visual.RLabel rLabel20;
        private AppCode.Visual.RLabel rLabel22;
        private AppCode.Visual.LEDDisplay FlagRegLEDDisplay;
        private AppCode.Visual.LED led92;
        private AppCode.Visual.LED led93;
        private AppCode.Visual.RLabel rLabel23;
        private AppCode.Visual.RLabel rLabel24;
        private AppCode.Visual.LED led94;
        private AppCode.Visual.LED led2;
        private AppCode.Visual.RLabel rLabel25;
        private System.Windows.Forms.Button LoadExampleIntoRAMBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox PCGroup;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox ARegGroup;
        private System.Windows.Forms.GroupBox SumGroup;
        private System.Windows.Forms.GroupBox FlagsGroup;
        private System.Windows.Forms.GroupBox BRegGroup;
        private System.Windows.Forms.CheckBox CarryInCB;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox MARGroup;
        private System.Windows.Forms.GroupBox RAMGroup;
        private System.Windows.Forms.GroupBox InstGroup;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
        private AppCode.Visual.Arrow BRegArrowIn;
        private AppCode.Visual.Arrow OutputRegArrowIn;
        private AppCode.Visual.Arrow ARegArrowIn;
        private AppCode.Visual.Arrow PCArrowIn;
        private AppCode.Visual.Arrow PCArrowOut;
        private AppCode.Visual.Arrow ARegArrowOut;
        private AppCode.Visual.Arrow SUMArrowOut;
        private AppCode.Visual.Arrow MARArrowIn;
        private AppCode.Visual.Arrow RAMArrowIn;
        private AppCode.Visual.Arrow InstArrowIn;
        private AppCode.Visual.Arrow RAMArrowOut;
        private AppCode.Visual.Arrow InstArrowOut;
        private System.Windows.Forms.Label label1;
        private AppCode.Visual.LED IncLED;
        private System.Windows.Forms.Label label2;
        private AppCode.Visual.LED SubLED;
        private AppCode.Visual.LED ClkLed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

