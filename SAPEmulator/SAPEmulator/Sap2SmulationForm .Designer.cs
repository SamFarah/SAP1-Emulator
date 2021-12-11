namespace SAPEmulator
{
    partial class Sap2SimulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sap2SimulationForm));
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
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ProgRAMAddrTB = new System.Windows.Forms.TextBox();
            this.ProgRamDataTB = new System.Windows.Forms.TextBox();
            this.ProramBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OpenAssemblerBtn = new System.Windows.Forms.Button();
            this.LoadBinFileBtn = new System.Windows.Forms.Button();
            this.UpdateRAMViewCB = new System.Windows.Forms.CheckBox();
            this.RAMGridView = new System.Windows.Forms.DataGridView();
            this.RefreshRamView = new System.Windows.Forms.Button();
            this.RandomizeRAMBtn = new System.Windows.Forms.Button();
            this.WipeRAMBtn = new System.Windows.Forms.Button();
            this.PCRegValLbl = new System.Windows.Forms.Label();
            this.OutputRegValLbl = new System.Windows.Forms.Label();
            this.DisplayLbl = new System.Windows.Forms.Label();
            this.DisplayShadowLbl = new System.Windows.Forms.Label();
            this.DisplaySignedCB = new System.Windows.Forms.CheckBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AnimationCB = new System.Windows.Forms.CheckBox();
            this.SWLbl = new System.Windows.Forms.Label();
            this.ClkCounterLBL = new System.Windows.Forms.Label();
            this.PCGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ARegGroup = new System.Windows.Forms.GroupBox();
            this.SumGroup = new System.Windows.Forms.GroupBox();
            this.FlagsGroup = new System.Windows.Forms.GroupBox();
            this.BRegGroup = new System.Windows.Forms.GroupBox();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.MARGroup = new System.Windows.Forms.GroupBox();
            this.RAMGroup = new System.Windows.Forms.GroupBox();
            this.InstGroup = new System.Windows.Forms.GroupBox();
            this.InstructionLBL = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ScreenUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TempRegGroup = new System.Windows.Forms.GroupBox();
            this.TempRegValLbl = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.MDRRegValLbl = new System.Windows.Forms.Label();
            this.CRegGroup = new System.Windows.Forms.GroupBox();
            this.CRegValLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SRGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SRRegValLbl = new System.Windows.Forms.Label();
            this.SRIncLED = new SAPEmulator.AppCode.Visual.LED();
            this.SRDecLED = new SAPEmulator.AppCode.Visual.LED();
            this.SRLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led192 = new SAPEmulator.AppCode.Visual.LED();
            this.led194 = new SAPEmulator.AppCode.Visual.LED();
            this.led195 = new SAPEmulator.AppCode.Visual.LED();
            this.led196 = new SAPEmulator.AppCode.Visual.LED();
            this.led197 = new SAPEmulator.AppCode.Visual.LED();
            this.led198 = new SAPEmulator.AppCode.Visual.LED();
            this.led199 = new SAPEmulator.AppCode.Visual.LED();
            this.led200 = new SAPEmulator.AppCode.Visual.LED();
            this.led201 = new SAPEmulator.AppCode.Visual.LED();
            this.led202 = new SAPEmulator.AppCode.Visual.LED();
            this.led203 = new SAPEmulator.AppCode.Visual.LED();
            this.led204 = new SAPEmulator.AppCode.Visual.LED();
            this.led205 = new SAPEmulator.AppCode.Visual.LED();
            this.led206 = new SAPEmulator.AppCode.Visual.LED();
            this.led207 = new SAPEmulator.AppCode.Visual.LED();
            this.led208 = new SAPEmulator.AppCode.Visual.LED();
            this.TempRegArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.MARArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.MDRArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.RAMArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.PCArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.CRegArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.BRegArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.ARegArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.FlagRegArrowIn = new SAPEmulator.AppCode.Visual.Arrow();
            this.InstArrowIn = new SAPEmulator.AppCode.Visual.Arrow();
            this.SUMArrowOut = new SAPEmulator.AppCode.Visual.Arrow();
            this.OutputRegArrowIn = new SAPEmulator.AppCode.Visual.Arrow();
            this.CRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led181 = new SAPEmulator.AppCode.Visual.LED();
            this.led182 = new SAPEmulator.AppCode.Visual.LED();
            this.led183 = new SAPEmulator.AppCode.Visual.LED();
            this.led184 = new SAPEmulator.AppCode.Visual.LED();
            this.led185 = new SAPEmulator.AppCode.Visual.LED();
            this.led186 = new SAPEmulator.AppCode.Visual.LED();
            this.led187 = new SAPEmulator.AppCode.Visual.LED();
            this.led188 = new SAPEmulator.AppCode.Visual.LED();
            this.MDRLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led134 = new SAPEmulator.AppCode.Visual.LED();
            this.led135 = new SAPEmulator.AppCode.Visual.LED();
            this.led136 = new SAPEmulator.AppCode.Visual.LED();
            this.led137 = new SAPEmulator.AppCode.Visual.LED();
            this.led138 = new SAPEmulator.AppCode.Visual.LED();
            this.led139 = new SAPEmulator.AppCode.Visual.LED();
            this.led140 = new SAPEmulator.AppCode.Visual.LED();
            this.led141 = new SAPEmulator.AppCode.Visual.LED();
            this.led142 = new SAPEmulator.AppCode.Visual.LED();
            this.led143 = new SAPEmulator.AppCode.Visual.LED();
            this.led144 = new SAPEmulator.AppCode.Visual.LED();
            this.led145 = new SAPEmulator.AppCode.Visual.LED();
            this.led146 = new SAPEmulator.AppCode.Visual.LED();
            this.led147 = new SAPEmulator.AppCode.Visual.LED();
            this.led148 = new SAPEmulator.AppCode.Visual.LED();
            this.led149 = new SAPEmulator.AppCode.Visual.LED();
            this.TempRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led126 = new SAPEmulator.AppCode.Visual.LED();
            this.led127 = new SAPEmulator.AppCode.Visual.LED();
            this.led128 = new SAPEmulator.AppCode.Visual.LED();
            this.led129 = new SAPEmulator.AppCode.Visual.LED();
            this.led130 = new SAPEmulator.AppCode.Visual.LED();
            this.led131 = new SAPEmulator.AppCode.Visual.LED();
            this.led132 = new SAPEmulator.AppCode.Visual.LED();
            this.led133 = new SAPEmulator.AppCode.Visual.LED();
            this.CLDecodedLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led85 = new SAPEmulator.AppCode.Visual.LED();
            this.led86 = new SAPEmulator.AppCode.Visual.LED();
            this.led87 = new SAPEmulator.AppCode.Visual.LED();
            this.led88 = new SAPEmulator.AppCode.Visual.LED();
            this.led89 = new SAPEmulator.AppCode.Visual.LED();
            this.led166 = new SAPEmulator.AppCode.Visual.LED();
            this.led167 = new SAPEmulator.AppCode.Visual.LED();
            this.led168 = new SAPEmulator.AppCode.Visual.LED();
            this.led169 = new SAPEmulator.AppCode.Visual.LED();
            this.led170 = new SAPEmulator.AppCode.Visual.LED();
            this.led171 = new SAPEmulator.AppCode.Visual.LED();
            this.led172 = new SAPEmulator.AppCode.Visual.LED();
            this.led173 = new SAPEmulator.AppCode.Visual.LED();
            this.led174 = new SAPEmulator.AppCode.Visual.LED();
            this.led175 = new SAPEmulator.AppCode.Visual.LED();
            this.led176 = new SAPEmulator.AppCode.Visual.LED();
            this.led177 = new SAPEmulator.AppCode.Visual.LED();
            this.led178 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel54 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel52 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel47 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel53 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel48 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel49 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel50 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel51 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel16 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel57 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel17 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel58 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel19 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel59 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel18 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel21 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel60 = new SAPEmulator.AppCode.Visual.RLabel();
            this.MICounterLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led82 = new SAPEmulator.AppCode.Visual.LED();
            this.led83 = new SAPEmulator.AppCode.Visual.LED();
            this.led84 = new SAPEmulator.AppCode.Visual.LED();
            this.led179 = new SAPEmulator.AppCode.Visual.LED();
            this.led180 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel61 = new SAPEmulator.AppCode.Visual.RLabel();
            this.InstRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led3 = new SAPEmulator.AppCode.Visual.LED();
            this.led4 = new SAPEmulator.AppCode.Visual.LED();
            this.led5 = new SAPEmulator.AppCode.Visual.LED();
            this.led6 = new SAPEmulator.AppCode.Visual.LED();
            this.led7 = new SAPEmulator.AppCode.Visual.LED();
            this.led8 = new SAPEmulator.AppCode.Visual.LED();
            this.led9 = new SAPEmulator.AppCode.Visual.LED();
            this.led10 = new SAPEmulator.AppCode.Visual.LED();
            this.RAMLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led43 = new SAPEmulator.AppCode.Visual.LED();
            this.led44 = new SAPEmulator.AppCode.Visual.LED();
            this.led45 = new SAPEmulator.AppCode.Visual.LED();
            this.led46 = new SAPEmulator.AppCode.Visual.LED();
            this.led47 = new SAPEmulator.AppCode.Visual.LED();
            this.led48 = new SAPEmulator.AppCode.Visual.LED();
            this.led49 = new SAPEmulator.AppCode.Visual.LED();
            this.led50 = new SAPEmulator.AppCode.Visual.LED();
            this.MARLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led51 = new SAPEmulator.AppCode.Visual.LED();
            this.led52 = new SAPEmulator.AppCode.Visual.LED();
            this.led53 = new SAPEmulator.AppCode.Visual.LED();
            this.led54 = new SAPEmulator.AppCode.Visual.LED();
            this.led114 = new SAPEmulator.AppCode.Visual.LED();
            this.led115 = new SAPEmulator.AppCode.Visual.LED();
            this.led116 = new SAPEmulator.AppCode.Visual.LED();
            this.led117 = new SAPEmulator.AppCode.Visual.LED();
            this.led118 = new SAPEmulator.AppCode.Visual.LED();
            this.led119 = new SAPEmulator.AppCode.Visual.LED();
            this.led120 = new SAPEmulator.AppCode.Visual.LED();
            this.led121 = new SAPEmulator.AppCode.Visual.LED();
            this.led122 = new SAPEmulator.AppCode.Visual.LED();
            this.led123 = new SAPEmulator.AppCode.Visual.LED();
            this.led124 = new SAPEmulator.AppCode.Visual.LED();
            this.led125 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel55 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel56 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel46 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel45 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel44 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel36 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel41 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel35 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel10 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel28 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel29 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel30 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel31 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel32 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel33 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel34 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel37 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel38 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel39 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel40 = new SAPEmulator.AppCode.Visual.RLabel();
            this.StatusLEDDsiaply2 = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led150 = new SAPEmulator.AppCode.Visual.LED();
            this.led151 = new SAPEmulator.AppCode.Visual.LED();
            this.led152 = new SAPEmulator.AppCode.Visual.LED();
            this.led153 = new SAPEmulator.AppCode.Visual.LED();
            this.led154 = new SAPEmulator.AppCode.Visual.LED();
            this.led155 = new SAPEmulator.AppCode.Visual.LED();
            this.led156 = new SAPEmulator.AppCode.Visual.LED();
            this.led157 = new SAPEmulator.AppCode.Visual.LED();
            this.led158 = new SAPEmulator.AppCode.Visual.LED();
            this.led159 = new SAPEmulator.AppCode.Visual.LED();
            this.led160 = new SAPEmulator.AppCode.Visual.LED();
            this.led161 = new SAPEmulator.AppCode.Visual.LED();
            this.led162 = new SAPEmulator.AppCode.Visual.LED();
            this.led163 = new SAPEmulator.AppCode.Visual.LED();
            this.led164 = new SAPEmulator.AppCode.Visual.LED();
            this.led165 = new SAPEmulator.AppCode.Visual.LED();
            this.led67 = new SAPEmulator.AppCode.Visual.LED();
            this.led221 = new SAPEmulator.AppCode.Visual.LED();
            this.StatusLEDDsiaply1 = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led68 = new SAPEmulator.AppCode.Visual.LED();
            this.led69 = new SAPEmulator.AppCode.Visual.LED();
            this.led70 = new SAPEmulator.AppCode.Visual.LED();
            this.led71 = new SAPEmulator.AppCode.Visual.LED();
            this.led72 = new SAPEmulator.AppCode.Visual.LED();
            this.led73 = new SAPEmulator.AppCode.Visual.LED();
            this.led74 = new SAPEmulator.AppCode.Visual.LED();
            this.led75 = new SAPEmulator.AppCode.Visual.LED();
            this.led76 = new SAPEmulator.AppCode.Visual.LED();
            this.led77 = new SAPEmulator.AppCode.Visual.LED();
            this.led78 = new SAPEmulator.AppCode.Visual.LED();
            this.led79 = new SAPEmulator.AppCode.Visual.LED();
            this.led80 = new SAPEmulator.AppCode.Visual.LED();
            this.led81 = new SAPEmulator.AppCode.Visual.LED();
            this.led94 = new SAPEmulator.AppCode.Visual.LED();
            this.led211 = new SAPEmulator.AppCode.Visual.LED();
            this.led212 = new SAPEmulator.AppCode.Visual.LED();
            this.led213 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel1 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel2 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel3 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel4 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel5 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel6 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel7 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel8 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel9 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel25 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel12 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel11 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel13 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel14 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel15 = new SAPEmulator.AppCode.Visual.RLabel();
            this.OutputRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led59 = new SAPEmulator.AppCode.Visual.LED();
            this.led60 = new SAPEmulator.AppCode.Visual.LED();
            this.led61 = new SAPEmulator.AppCode.Visual.LED();
            this.led62 = new SAPEmulator.AppCode.Visual.LED();
            this.led63 = new SAPEmulator.AppCode.Visual.LED();
            this.led64 = new SAPEmulator.AppCode.Visual.LED();
            this.led65 = new SAPEmulator.AppCode.Visual.LED();
            this.led66 = new SAPEmulator.AppCode.Visual.LED();
            this.BRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led27 = new SAPEmulator.AppCode.Visual.LED();
            this.led28 = new SAPEmulator.AppCode.Visual.LED();
            this.led29 = new SAPEmulator.AppCode.Visual.LED();
            this.led30 = new SAPEmulator.AppCode.Visual.LED();
            this.led31 = new SAPEmulator.AppCode.Visual.LED();
            this.led32 = new SAPEmulator.AppCode.Visual.LED();
            this.led33 = new SAPEmulator.AppCode.Visual.LED();
            this.led34 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel43 = new SAPEmulator.AppCode.Visual.RLabel();
            this.FlagRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led92 = new SAPEmulator.AppCode.Visual.LED();
            this.led93 = new SAPEmulator.AppCode.Visual.LED();
            this.led190 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel24 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel23 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel42 = new SAPEmulator.AppCode.Visual.RLabel();
            this.SumRegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led35 = new SAPEmulator.AppCode.Visual.LED();
            this.led36 = new SAPEmulator.AppCode.Visual.LED();
            this.led37 = new SAPEmulator.AppCode.Visual.LED();
            this.led38 = new SAPEmulator.AppCode.Visual.LED();
            this.led39 = new SAPEmulator.AppCode.Visual.LED();
            this.led40 = new SAPEmulator.AppCode.Visual.LED();
            this.led41 = new SAPEmulator.AppCode.Visual.LED();
            this.led42 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel20 = new SAPEmulator.AppCode.Visual.RLabel();
            this.rLabel22 = new SAPEmulator.AppCode.Visual.RLabel();
            this.SumFlagsLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led90 = new SAPEmulator.AppCode.Visual.LED();
            this.led91 = new SAPEmulator.AppCode.Visual.LED();
            this.led189 = new SAPEmulator.AppCode.Visual.LED();
            this.ARegLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led19 = new SAPEmulator.AppCode.Visual.LED();
            this.led20 = new SAPEmulator.AppCode.Visual.LED();
            this.led21 = new SAPEmulator.AppCode.Visual.LED();
            this.led22 = new SAPEmulator.AppCode.Visual.LED();
            this.led23 = new SAPEmulator.AppCode.Visual.LED();
            this.led24 = new SAPEmulator.AppCode.Visual.LED();
            this.led25 = new SAPEmulator.AppCode.Visual.LED();
            this.led26 = new SAPEmulator.AppCode.Visual.LED();
            this.PCIncLED = new SAPEmulator.AppCode.Visual.LED();
            this.PCLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led55 = new SAPEmulator.AppCode.Visual.LED();
            this.led56 = new SAPEmulator.AppCode.Visual.LED();
            this.led57 = new SAPEmulator.AppCode.Visual.LED();
            this.led58 = new SAPEmulator.AppCode.Visual.LED();
            this.led1 = new SAPEmulator.AppCode.Visual.LED();
            this.led95 = new SAPEmulator.AppCode.Visual.LED();
            this.led96 = new SAPEmulator.AppCode.Visual.LED();
            this.led97 = new SAPEmulator.AppCode.Visual.LED();
            this.led98 = new SAPEmulator.AppCode.Visual.LED();
            this.led99 = new SAPEmulator.AppCode.Visual.LED();
            this.led100 = new SAPEmulator.AppCode.Visual.LED();
            this.led101 = new SAPEmulator.AppCode.Visual.LED();
            this.led102 = new SAPEmulator.AppCode.Visual.LED();
            this.led103 = new SAPEmulator.AppCode.Visual.LED();
            this.led104 = new SAPEmulator.AppCode.Visual.LED();
            this.led105 = new SAPEmulator.AppCode.Visual.LED();
            this.ClkLed = new SAPEmulator.AppCode.Visual.LED();
            this.BusLEDDisplay = new SAPEmulator.AppCode.Visual.LEDDisplay();
            this.led11 = new SAPEmulator.AppCode.Visual.LED();
            this.led12 = new SAPEmulator.AppCode.Visual.LED();
            this.led13 = new SAPEmulator.AppCode.Visual.LED();
            this.led14 = new SAPEmulator.AppCode.Visual.LED();
            this.led15 = new SAPEmulator.AppCode.Visual.LED();
            this.led16 = new SAPEmulator.AppCode.Visual.LED();
            this.led17 = new SAPEmulator.AppCode.Visual.LED();
            this.led18 = new SAPEmulator.AppCode.Visual.LED();
            this.led106 = new SAPEmulator.AppCode.Visual.LED();
            this.led107 = new SAPEmulator.AppCode.Visual.LED();
            this.led108 = new SAPEmulator.AppCode.Visual.LED();
            this.led109 = new SAPEmulator.AppCode.Visual.LED();
            this.led110 = new SAPEmulator.AppCode.Visual.LED();
            this.led111 = new SAPEmulator.AppCode.Visual.LED();
            this.led112 = new SAPEmulator.AppCode.Visual.LED();
            this.led113 = new SAPEmulator.AppCode.Visual.LED();
            this.SRArrow = new SAPEmulator.AppCode.Visual.DoubleEndedArrow();
            this.led2 = new SAPEmulator.AppCode.Visual.LED();
            this.led193 = new SAPEmulator.AppCode.Visual.LED();
            this.rLabel26 = new SAPEmulator.AppCode.Visual.RLabel();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyAdjust)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMGridView)).BeginInit();
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
            this.TempRegGroup.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.CRegGroup.SuspendLayout();
            this.SRGroup.SuspendLayout();
            this.SRLEDDisplay.SuspendLayout();
            this.CRegLEDDisplay.SuspendLayout();
            this.MDRLEDDisplay.SuspendLayout();
            this.TempRegLEDDisplay.SuspendLayout();
            this.CLDecodedLEDDisplay.SuspendLayout();
            this.MICounterLEDDisplay.SuspendLayout();
            this.InstRegLEDDisplay.SuspendLayout();
            this.RAMLEDDisplay.SuspendLayout();
            this.MARLEDDisplay.SuspendLayout();
            this.StatusLEDDsiaply2.SuspendLayout();
            this.StatusLEDDsiaply1.SuspendLayout();
            this.OutputRegLEDDisplay.SuspendLayout();
            this.BRegLEDDisplay.SuspendLayout();
            this.FlagRegLEDDisplay.SuspendLayout();
            this.SumRegLEDDisplay.SuspendLayout();
            this.SumFlagsLEDDisplay.SuspendLayout();
            this.ARegLEDDisplay.SuspendLayout();
            this.PCLEDDisplay.SuspendLayout();
            this.BusLEDDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockModeBtn
            // 
            this.ClockModeBtn.BackColor = System.Drawing.Color.Red;
            this.ClockModeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClockModeBtn.Location = new System.Drawing.Point(207, 15);
            this.ClockModeBtn.Name = "ClockModeBtn";
            this.ClockModeBtn.Size = new System.Drawing.Size(68, 23);
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
            this.StepClockBtn.Location = new System.Drawing.Point(207, 44);
            this.StepClockBtn.Name = "StepClockBtn";
            this.StepClockBtn.Size = new System.Drawing.Size(68, 23);
            this.StepClockBtn.TabIndex = 5;
            this.StepClockBtn.Text = "Single";
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
            this.FrequencyAdjust.Maximum = 10000;
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
            this.BusValLbl.Location = new System.Drawing.Point(215, 21);
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
            this.SumRegValLbl.Location = new System.Drawing.Point(116, 21);
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
            this.InstRegValLbl.Location = new System.Drawing.Point(171, 20);
            this.InstRegValLbl.Name = "InstRegValLbl";
            this.InstRegValLbl.Size = new System.Drawing.Size(24, 13);
            this.InstRegValLbl.TabIndex = 38;
            this.InstRegValLbl.Text = "Ival";
            // 
            // RAMRegValLbl
            // 
            this.RAMRegValLbl.AutoSize = true;
            this.RAMRegValLbl.Location = new System.Drawing.Point(117, 20);
            this.RAMRegValLbl.Name = "RAMRegValLbl";
            this.RAMRegValLbl.Size = new System.Drawing.Size(29, 13);
            this.RAMRegValLbl.TabIndex = 48;
            this.RAMRegValLbl.Text = "Rval";
            // 
            // MARRegValLbl
            // 
            this.MARRegValLbl.AutoSize = true;
            this.MARRegValLbl.Location = new System.Drawing.Point(212, 20);
            this.MARRegValLbl.Name = "MARRegValLbl";
            this.MARRegValLbl.Size = new System.Drawing.Size(30, 13);
            this.MARRegValLbl.TabIndex = 55;
            this.MARRegValLbl.Text = "Mval";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 59;
            this.label18.Text = "RAM Address:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "Data:";
            // 
            // ProgRAMAddrTB
            // 
            this.ProgRAMAddrTB.Location = new System.Drawing.Point(6, 37);
            this.ProgRAMAddrTB.Name = "ProgRAMAddrTB";
            this.ProgRAMAddrTB.Size = new System.Drawing.Size(108, 20);
            this.ProgRAMAddrTB.TabIndex = 61;
            this.ProgRAMAddrTB.Text = "0x0000";
            // 
            // ProgRamDataTB
            // 
            this.ProgRamDataTB.Location = new System.Drawing.Point(6, 86);
            this.ProgRamDataTB.Name = "ProgRamDataTB";
            this.ProgRamDataTB.Size = new System.Drawing.Size(108, 20);
            this.ProgRamDataTB.TabIndex = 62;
            this.ProgRamDataTB.Text = "0x";
            // 
            // ProramBtn
            // 
            this.ProramBtn.Location = new System.Drawing.Point(6, 112);
            this.ProramBtn.Name = "ProramBtn";
            this.ProramBtn.Size = new System.Drawing.Size(108, 23);
            this.ProramBtn.TabIndex = 63;
            this.ProramBtn.Text = "Clock In";
            this.ProramBtn.UseVisualStyleBackColor = true;
            this.ProramBtn.Click += new System.EventHandler(this.ProgramBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OpenAssemblerBtn);
            this.groupBox2.Controls.Add(this.LoadBinFileBtn);
            this.groupBox2.Controls.Add(this.UpdateRAMViewCB);
            this.groupBox2.Controls.Add(this.RAMGridView);
            this.groupBox2.Controls.Add(this.RefreshRamView);
            this.groupBox2.Controls.Add(this.RandomizeRAMBtn);
            this.groupBox2.Controls.Add(this.WipeRAMBtn);
            this.groupBox2.Controls.Add(this.ProramBtn);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.ProgRamDataTB);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.ProgRAMAddrTB);
            this.groupBox2.Location = new System.Drawing.Point(855, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 574);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Debug";
            // 
            // OpenAssemblerBtn
            // 
            this.OpenAssemblerBtn.Location = new System.Drawing.Point(6, 169);
            this.OpenAssemblerBtn.Name = "OpenAssemblerBtn";
            this.OpenAssemblerBtn.Size = new System.Drawing.Size(108, 23);
            this.OpenAssemblerBtn.TabIndex = 151;
            this.OpenAssemblerBtn.Text = "Open Assembler";
            this.OpenAssemblerBtn.UseVisualStyleBackColor = true;
            this.OpenAssemblerBtn.Click += new System.EventHandler(this.OpenAssemblerBtn_Click);
            // 
            // LoadBinFileBtn
            // 
            this.LoadBinFileBtn.Location = new System.Drawing.Point(6, 198);
            this.LoadBinFileBtn.Name = "LoadBinFileBtn";
            this.LoadBinFileBtn.Size = new System.Drawing.Size(108, 25);
            this.LoadBinFileBtn.TabIndex = 186;
            this.LoadBinFileBtn.Text = "Load .Bin File";
            this.LoadBinFileBtn.UseVisualStyleBackColor = true;
            this.LoadBinFileBtn.Click += new System.EventHandler(this.LoadBinFileBtn_Click);
            // 
            // UpdateRAMViewCB
            // 
            this.UpdateRAMViewCB.AutoSize = true;
            this.UpdateRAMViewCB.Checked = true;
            this.UpdateRAMViewCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpdateRAMViewCB.Location = new System.Drawing.Point(9, 466);
            this.UpdateRAMViewCB.Name = "UpdateRAMViewCB";
            this.UpdateRAMViewCB.Size = new System.Drawing.Size(95, 17);
            this.UpdateRAMViewCB.TabIndex = 184;
            this.UpdateRAMViewCB.Text = "Keep Updated";
            this.UpdateRAMViewCB.UseVisualStyleBackColor = true;
            // 
            // RAMGridView
            // 
            this.RAMGridView.AllowUserToAddRows = false;
            this.RAMGridView.AllowUserToDeleteRows = false;
            this.RAMGridView.AllowUserToOrderColumns = true;
            this.RAMGridView.AllowUserToResizeColumns = false;
            this.RAMGridView.AllowUserToResizeRows = false;
            this.RAMGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RAMGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RAMGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RAMGridView.EnableHeadersVisualStyles = false;
            this.RAMGridView.Location = new System.Drawing.Point(120, 15);
            this.RAMGridView.Name = "RAMGridView";
            this.RAMGridView.RowHeadersVisible = false;
            this.RAMGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMGridView.RowTemplate.Height = 12;
            this.RAMGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RAMGridView.Size = new System.Drawing.Size(485, 553);
            this.RAMGridView.TabIndex = 183;
            // 
            // RefreshRamView
            // 
            this.RefreshRamView.Location = new System.Drawing.Point(6, 437);
            this.RefreshRamView.Name = "RefreshRamView";
            this.RefreshRamView.Size = new System.Drawing.Size(108, 23);
            this.RefreshRamView.TabIndex = 66;
            this.RefreshRamView.Text = "Refresh";
            this.RefreshRamView.UseVisualStyleBackColor = true;
            this.RefreshRamView.Click += new System.EventHandler(this.RefreshRamView_Click);
            // 
            // RandomizeRAMBtn
            // 
            this.RandomizeRAMBtn.Location = new System.Drawing.Point(6, 516);
            this.RandomizeRAMBtn.Name = "RandomizeRAMBtn";
            this.RandomizeRAMBtn.Size = new System.Drawing.Size(108, 23);
            this.RandomizeRAMBtn.TabIndex = 65;
            this.RandomizeRAMBtn.Text = "Randomize";
            this.RandomizeRAMBtn.UseVisualStyleBackColor = true;
            this.RandomizeRAMBtn.Click += new System.EventHandler(this.RandomizeRAMBtn_Click);
            // 
            // WipeRAMBtn
            // 
            this.WipeRAMBtn.Location = new System.Drawing.Point(6, 545);
            this.WipeRAMBtn.Name = "WipeRAMBtn";
            this.WipeRAMBtn.Size = new System.Drawing.Size(108, 23);
            this.WipeRAMBtn.TabIndex = 64;
            this.WipeRAMBtn.Text = "Wipe RAM";
            this.WipeRAMBtn.UseVisualStyleBackColor = true;
            this.WipeRAMBtn.Click += new System.EventHandler(this.WipeRAMBtn_Click);
            // 
            // PCRegValLbl
            // 
            this.PCRegValLbl.AutoSize = true;
            this.PCRegValLbl.Location = new System.Drawing.Point(246, 20);
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
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(39, 61);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(110, 30);
            this.ResetBtn.TabIndex = 111;
            this.ResetBtn.Text = "Reset Computer";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AnimationCB);
            this.groupBox4.Controls.Add(this.SWLbl);
            this.groupBox4.Controls.Add(this.ClkCounterLBL);
            this.groupBox4.Controls.Add(this.ClkLed);
            this.groupBox4.Controls.Add(this.FreqLbl);
            this.groupBox4.Controls.Add(this.FrequencyAdjust);
            this.groupBox4.Controls.Add(this.ClockModeBtn);
            this.groupBox4.Controls.Add(this.StepClockBtn);
            this.groupBox4.Controls.Add(this.ResetBtn);
            this.groupBox4.Location = new System.Drawing.Point(381, 466);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 120);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Clock";
            // 
            // AnimationCB
            // 
            this.AnimationCB.AutoSize = true;
            this.AnimationCB.Checked = true;
            this.AnimationCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnimationCB.Location = new System.Drawing.Point(175, 96);
            this.AnimationCB.Name = "AnimationCB";
            this.AnimationCB.Size = new System.Drawing.Size(102, 17);
            this.AnimationCB.TabIndex = 185;
            this.AnimationCB.Text = "Show Animation";
            this.AnimationCB.UseVisualStyleBackColor = true;
            this.AnimationCB.CheckedChanged += new System.EventHandler(this.AnimationCB_CheckedChanged);
            // 
            // SWLbl
            // 
            this.SWLbl.AutoSize = true;
            this.SWLbl.Location = new System.Drawing.Point(41, 96);
            this.SWLbl.Name = "SWLbl";
            this.SWLbl.Size = new System.Drawing.Size(35, 13);
            this.SWLbl.TabIndex = 183;
            this.SWLbl.Text = "label2";
            // 
            // ClkCounterLBL
            // 
            this.ClkCounterLBL.AutoSize = true;
            this.ClkCounterLBL.Location = new System.Drawing.Point(155, 75);
            this.ClkCounterLBL.Name = "ClkCounterLBL";
            this.ClkCounterLBL.Size = new System.Drawing.Size(58, 13);
            this.ClkCounterLBL.TabIndex = 113;
            this.ClkCounterLBL.Text = "clkCounter";
            // 
            // PCGroup
            // 
            this.PCGroup.Controls.Add(this.label1);
            this.PCGroup.Controls.Add(this.PCIncLED);
            this.PCGroup.Controls.Add(this.PCRegValLbl);
            this.PCGroup.Controls.Add(this.PCLEDDisplay);
            this.PCGroup.Location = new System.Drawing.Point(28, 63);
            this.PCGroup.Name = "PCGroup";
            this.PCGroup.Size = new System.Drawing.Size(290, 45);
            this.PCGroup.TabIndex = 124;
            this.PCGroup.TabStop = false;
            this.PCGroup.Text = "Program Counter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Inc";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BusLEDDisplay);
            this.groupBox6.Controls.Add(this.BusValLbl);
            this.groupBox6.Location = new System.Drawing.Point(296, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 45);
            this.groupBox6.TabIndex = 125;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BUS";
            // 
            // ARegGroup
            // 
            this.ARegGroup.Controls.Add(this.ARegLEDDisplay);
            this.ARegGroup.Controls.Add(this.ARegValLbl);
            this.ARegGroup.Location = new System.Drawing.Point(508, 63);
            this.ARegGroup.Name = "ARegGroup";
            this.ARegGroup.Size = new System.Drawing.Size(157, 45);
            this.ARegGroup.TabIndex = 126;
            this.ARegGroup.TabStop = false;
            this.ARegGroup.Text = "Accumulator";
            // 
            // SumGroup
            // 
            this.SumGroup.Controls.Add(this.rLabel42);
            this.SumGroup.Controls.Add(this.SumRegLEDDisplay);
            this.SumGroup.Controls.Add(this.SumRegValLbl);
            this.SumGroup.Controls.Add(this.rLabel20);
            this.SumGroup.Controls.Add(this.rLabel22);
            this.SumGroup.Controls.Add(this.SumFlagsLEDDisplay);
            this.SumGroup.Location = new System.Drawing.Point(508, 114);
            this.SumGroup.Name = "SumGroup";
            this.SumGroup.Size = new System.Drawing.Size(224, 45);
            this.SumGroup.TabIndex = 127;
            this.SumGroup.TabStop = false;
            this.SumGroup.Text = "ALU";
            // 
            // FlagsGroup
            // 
            this.FlagsGroup.Controls.Add(this.rLabel43);
            this.FlagsGroup.Controls.Add(this.FlagRegLEDDisplay);
            this.FlagsGroup.Controls.Add(this.rLabel24);
            this.FlagsGroup.Controls.Add(this.rLabel23);
            this.FlagsGroup.Location = new System.Drawing.Point(777, 108);
            this.FlagsGroup.Name = "FlagsGroup";
            this.FlagsGroup.Size = new System.Drawing.Size(62, 56);
            this.FlagsGroup.TabIndex = 128;
            this.FlagsGroup.TabStop = false;
            this.FlagsGroup.Text = "Flags";
            // 
            // BRegGroup
            // 
            this.BRegGroup.Controls.Add(this.BRegValLbl);
            this.BRegGroup.Controls.Add(this.BRegLEDDisplay);
            this.BRegGroup.Location = new System.Drawing.Point(508, 216);
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
            this.OutputGroup.Location = new System.Drawing.Point(508, 318);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(157, 134);
            this.OutputGroup.TabIndex = 130;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Output";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rLabel26);
            this.groupBox12.Controls.Add(this.rLabel55);
            this.groupBox12.Controls.Add(this.rLabel56);
            this.groupBox12.Controls.Add(this.rLabel46);
            this.groupBox12.Controls.Add(this.rLabel45);
            this.groupBox12.Controls.Add(this.rLabel44);
            this.groupBox12.Controls.Add(this.rLabel36);
            this.groupBox12.Controls.Add(this.rLabel41);
            this.groupBox12.Controls.Add(this.rLabel35);
            this.groupBox12.Controls.Add(this.rLabel10);
            this.groupBox12.Controls.Add(this.rLabel28);
            this.groupBox12.Controls.Add(this.rLabel29);
            this.groupBox12.Controls.Add(this.rLabel30);
            this.groupBox12.Controls.Add(this.rLabel31);
            this.groupBox12.Controls.Add(this.rLabel32);
            this.groupBox12.Controls.Add(this.rLabel33);
            this.groupBox12.Controls.Add(this.rLabel34);
            this.groupBox12.Controls.Add(this.rLabel37);
            this.groupBox12.Controls.Add(this.rLabel38);
            this.groupBox12.Controls.Add(this.rLabel39);
            this.groupBox12.Controls.Add(this.rLabel40);
            this.groupBox12.Controls.Add(this.StatusLEDDsiaply2);
            this.groupBox12.Controls.Add(this.StatusLEDDsiaply1);
            this.groupBox12.Controls.Add(this.rLabel1);
            this.groupBox12.Controls.Add(this.rLabel2);
            this.groupBox12.Controls.Add(this.rLabel3);
            this.groupBox12.Controls.Add(this.rLabel4);
            this.groupBox12.Controls.Add(this.rLabel5);
            this.groupBox12.Controls.Add(this.rLabel6);
            this.groupBox12.Controls.Add(this.rLabel7);
            this.groupBox12.Controls.Add(this.rLabel8);
            this.groupBox12.Controls.Add(this.rLabel9);
            this.groupBox12.Controls.Add(this.rLabel25);
            this.groupBox12.Controls.Add(this.rLabel12);
            this.groupBox12.Controls.Add(this.rLabel11);
            this.groupBox12.Controls.Add(this.rLabel13);
            this.groupBox12.Controls.Add(this.rLabel14);
            this.groupBox12.Controls.Add(this.rLabel15);
            this.groupBox12.Location = new System.Drawing.Point(93, 438);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(274, 148);
            this.groupBox12.TabIndex = 131;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Control Word";
            // 
            // MARGroup
            // 
            this.MARGroup.Controls.Add(this.MARLEDDisplay);
            this.MARGroup.Controls.Add(this.MARRegValLbl);
            this.MARGroup.Location = new System.Drawing.Point(62, 114);
            this.MARGroup.Name = "MARGroup";
            this.MARGroup.Size = new System.Drawing.Size(256, 45);
            this.MARGroup.TabIndex = 132;
            this.MARGroup.TabStop = false;
            this.MARGroup.Text = "Memory Address";
            // 
            // RAMGroup
            // 
            this.RAMGroup.Controls.Add(this.RAMLEDDisplay);
            this.RAMGroup.Controls.Add(this.RAMRegValLbl);
            this.RAMGroup.Location = new System.Drawing.Point(157, 165);
            this.RAMGroup.Name = "RAMGroup";
            this.RAMGroup.Size = new System.Drawing.Size(161, 45);
            this.RAMGroup.TabIndex = 133;
            this.RAMGroup.TabStop = false;
            this.RAMGroup.Text = "Memory Contents";
            // 
            // InstGroup
            // 
            this.InstGroup.Controls.Add(this.InstructionLBL);
            this.InstGroup.Controls.Add(this.InstRegLEDDisplay);
            this.InstGroup.Controls.Add(this.InstRegValLbl);
            this.InstGroup.Location = new System.Drawing.Point(103, 267);
            this.InstGroup.Name = "InstGroup";
            this.InstGroup.Size = new System.Drawing.Size(215, 45);
            this.InstGroup.TabIndex = 134;
            this.InstGroup.TabStop = false;
            this.InstGroup.Text = "Instruction Register";
            // 
            // InstructionLBL
            // 
            this.InstructionLBL.AutoSize = true;
            this.InstructionLBL.Location = new System.Drawing.Point(6, 22);
            this.InstructionLBL.Name = "InstructionLBL";
            this.InstructionLBL.Size = new System.Drawing.Size(56, 13);
            this.InstructionLBL.TabIndex = 39;
            this.InstructionLBL.Text = "Instruction";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.CLDecodedLEDDisplay);
            this.groupBox16.Controls.Add(this.rLabel54);
            this.groupBox16.Controls.Add(this.rLabel52);
            this.groupBox16.Controls.Add(this.rLabel47);
            this.groupBox16.Controls.Add(this.rLabel53);
            this.groupBox16.Controls.Add(this.rLabel48);
            this.groupBox16.Controls.Add(this.rLabel49);
            this.groupBox16.Controls.Add(this.rLabel50);
            this.groupBox16.Controls.Add(this.rLabel51);
            this.groupBox16.Controls.Add(this.rLabel16);
            this.groupBox16.Controls.Add(this.rLabel57);
            this.groupBox16.Controls.Add(this.rLabel17);
            this.groupBox16.Controls.Add(this.rLabel58);
            this.groupBox16.Controls.Add(this.rLabel19);
            this.groupBox16.Controls.Add(this.rLabel59);
            this.groupBox16.Controls.Add(this.rLabel18);
            this.groupBox16.Controls.Add(this.rLabel21);
            this.groupBox16.Controls.Add(this.rLabel60);
            this.groupBox16.Controls.Add(this.MICounterLEDDisplay);
            this.groupBox16.Controls.Add(this.rLabel61);
            this.groupBox16.Location = new System.Drawing.Point(127, 378);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(375, 54);
            this.groupBox16.TabIndex = 135;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Instruction Step";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(320, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(690, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Sam Farah ©2021";
            // 
            // ScreenUpdateTimer
            // 
            this.ScreenUpdateTimer.Enabled = true;
            this.ScreenUpdateTimer.Interval = 1;
            this.ScreenUpdateTimer.Tick += new System.EventHandler(this.ScreenUpdateTimer_Tick);
            // 
            // TempRegGroup
            // 
            this.TempRegGroup.Controls.Add(this.TempRegLEDDisplay);
            this.TempRegGroup.Controls.Add(this.TempRegValLbl);
            this.TempRegGroup.Location = new System.Drawing.Point(508, 165);
            this.TempRegGroup.Name = "TempRegGroup";
            this.TempRegGroup.Size = new System.Drawing.Size(157, 45);
            this.TempRegGroup.TabIndex = 127;
            this.TempRegGroup.TabStop = false;
            this.TempRegGroup.Text = "\"Temp\" Register";
            // 
            // TempRegValLbl
            // 
            this.TempRegValLbl.AutoSize = true;
            this.TempRegValLbl.Location = new System.Drawing.Point(116, 21);
            this.TempRegValLbl.Name = "TempRegValLbl";
            this.TempRegValLbl.Size = new System.Drawing.Size(29, 13);
            this.TempRegValLbl.TabIndex = 30;
            this.TempRegValLbl.Text = "AVal";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.MDRLEDDisplay);
            this.groupBox7.Controls.Add(this.MDRRegValLbl);
            this.groupBox7.Location = new System.Drawing.Point(62, 216);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(256, 45);
            this.groupBox7.TabIndex = 134;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MDR";
            // 
            // MDRRegValLbl
            // 
            this.MDRRegValLbl.AutoSize = true;
            this.MDRRegValLbl.Location = new System.Drawing.Point(212, 20);
            this.MDRRegValLbl.Name = "MDRRegValLbl";
            this.MDRRegValLbl.Size = new System.Drawing.Size(38, 13);
            this.MDRRegValLbl.TabIndex = 48;
            this.MDRRegValLbl.Text = "MDval";
            // 
            // CRegGroup
            // 
            this.CRegGroup.Controls.Add(this.CRegValLbl);
            this.CRegGroup.Controls.Add(this.CRegLEDDisplay);
            this.CRegGroup.Location = new System.Drawing.Point(508, 267);
            this.CRegGroup.Name = "CRegGroup";
            this.CRegGroup.Size = new System.Drawing.Size(157, 45);
            this.CRegGroup.TabIndex = 130;
            this.CRegGroup.TabStop = false;
            this.CRegGroup.Text = "\"C\" Register";
            // 
            // CRegValLbl
            // 
            this.CRegValLbl.AutoSize = true;
            this.CRegValLbl.Location = new System.Drawing.Point(119, 22);
            this.CRegValLbl.Name = "CRegValLbl";
            this.CRegValLbl.Size = new System.Drawing.Size(29, 13);
            this.CRegValLbl.TabIndex = 32;
            this.CRegValLbl.Text = "CVal";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bin";
            this.openFileDialog1.Filter = "Binary|*.bin";
            // 
            // SRGroup
            // 
            this.SRGroup.Controls.Add(this.label4);
            this.SRGroup.Controls.Add(this.SRIncLED);
            this.SRGroup.Controls.Add(this.label2);
            this.SRGroup.Controls.Add(this.SRDecLED);
            this.SRGroup.Controls.Add(this.SRRegValLbl);
            this.SRGroup.Controls.Add(this.SRLEDDisplay);
            this.SRGroup.Location = new System.Drawing.Point(5, 318);
            this.SRGroup.Name = "SRGroup";
            this.SRGroup.Size = new System.Drawing.Size(313, 45);
            this.SRGroup.TabIndex = 125;
            this.SRGroup.TabStop = false;
            this.SRGroup.Text = "Stack Register";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 186;
            this.label4.Text = "Inc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Dec";
            // 
            // SRRegValLbl
            // 
            this.SRRegValLbl.AutoSize = true;
            this.SRRegValLbl.Location = new System.Drawing.Point(268, 20);
            this.SRRegValLbl.Name = "SRRegValLbl";
            this.SRRegValLbl.Size = new System.Drawing.Size(36, 13);
            this.SRRegValLbl.TabIndex = 68;
            this.SRRegValLbl.Text = "SRval";
            // 
            // SRIncLED
            // 
            this.SRIncLED.LEDColor = System.Drawing.Color.Blue;
            this.SRIncLED.Location = new System.Drawing.Point(12, 26);
            this.SRIncLED.Name = "SRIncLED";
            this.SRIncLED.Size = new System.Drawing.Size(11, 11);
            this.SRIncLED.TabIndex = 185;
            // 
            // SRDecLED
            // 
            this.SRDecLED.LEDColor = System.Drawing.Color.Blue;
            this.SRDecLED.Location = new System.Drawing.Point(40, 26);
            this.SRDecLED.Name = "SRDecLED";
            this.SRDecLED.Size = new System.Drawing.Size(11, 11);
            this.SRDecLED.TabIndex = 69;
            // 
            // SRLEDDisplay
            // 
            this.SRLEDDisplay.Controls.Add(this.led192);
            this.SRLEDDisplay.Controls.Add(this.led194);
            this.SRLEDDisplay.Controls.Add(this.led195);
            this.SRLEDDisplay.Controls.Add(this.led196);
            this.SRLEDDisplay.Controls.Add(this.led197);
            this.SRLEDDisplay.Controls.Add(this.led198);
            this.SRLEDDisplay.Controls.Add(this.led199);
            this.SRLEDDisplay.Controls.Add(this.led200);
            this.SRLEDDisplay.Controls.Add(this.led201);
            this.SRLEDDisplay.Controls.Add(this.led202);
            this.SRLEDDisplay.Controls.Add(this.led203);
            this.SRLEDDisplay.Controls.Add(this.led204);
            this.SRLEDDisplay.Controls.Add(this.led205);
            this.SRLEDDisplay.Controls.Add(this.led206);
            this.SRLEDDisplay.Controls.Add(this.led207);
            this.SRLEDDisplay.Controls.Add(this.led208);
            this.SRLEDDisplay.LEDs.Add(this.led192);
            this.SRLEDDisplay.LEDs.Add(this.led194);
            this.SRLEDDisplay.LEDs.Add(this.led195);
            this.SRLEDDisplay.LEDs.Add(this.led196);
            this.SRLEDDisplay.LEDs.Add(this.led197);
            this.SRLEDDisplay.LEDs.Add(this.led198);
            this.SRLEDDisplay.LEDs.Add(this.led199);
            this.SRLEDDisplay.LEDs.Add(this.led200);
            this.SRLEDDisplay.LEDs.Add(this.led201);
            this.SRLEDDisplay.LEDs.Add(this.led202);
            this.SRLEDDisplay.LEDs.Add(this.led203);
            this.SRLEDDisplay.LEDs.Add(this.led204);
            this.SRLEDDisplay.LEDs.Add(this.led205);
            this.SRLEDDisplay.LEDs.Add(this.led206);
            this.SRLEDDisplay.LEDs.Add(this.led207);
            this.SRLEDDisplay.LEDs.Add(this.led208);
            this.SRLEDDisplay.LEDSpacing = 2;
            this.SRLEDDisplay.Location = new System.Drawing.Point(65, 18);
            this.SRLEDDisplay.Name = "SRLEDDisplay";
            this.SRLEDDisplay.NibbleSpacing = 2;
            this.SRLEDDisplay.Size = new System.Drawing.Size(204, 16);
            this.SRLEDDisplay.TabIndex = 66;
            // 
            // led192
            // 
            this.led192.LEDColor = System.Drawing.Color.LimeGreen;
            this.led192.Location = new System.Drawing.Point(3, 3);
            this.led192.Name = "led192";
            this.led192.Size = new System.Drawing.Size(11, 11);
            this.led192.TabIndex = 0;
            // 
            // led194
            // 
            this.led194.LEDColor = System.Drawing.Color.LimeGreen;
            this.led194.Location = new System.Drawing.Point(15, 3);
            this.led194.Name = "led194";
            this.led194.Size = new System.Drawing.Size(11, 11);
            this.led194.TabIndex = 1;
            // 
            // led195
            // 
            this.led195.LEDColor = System.Drawing.Color.LimeGreen;
            this.led195.Location = new System.Drawing.Point(27, 3);
            this.led195.Name = "led195";
            this.led195.Size = new System.Drawing.Size(11, 11);
            this.led195.TabIndex = 2;
            // 
            // led196
            // 
            this.led196.LEDColor = System.Drawing.Color.LimeGreen;
            this.led196.Location = new System.Drawing.Point(39, 3);
            this.led196.Name = "led196";
            this.led196.Size = new System.Drawing.Size(11, 11);
            this.led196.TabIndex = 3;
            // 
            // led197
            // 
            this.led197.LEDColor = System.Drawing.Color.LimeGreen;
            this.led197.Location = new System.Drawing.Point(53, 3);
            this.led197.Name = "led197";
            this.led197.Size = new System.Drawing.Size(11, 11);
            this.led197.TabIndex = 4;
            // 
            // led198
            // 
            this.led198.LEDColor = System.Drawing.Color.LimeGreen;
            this.led198.Location = new System.Drawing.Point(65, 3);
            this.led198.Name = "led198";
            this.led198.Size = new System.Drawing.Size(11, 11);
            this.led198.TabIndex = 5;
            // 
            // led199
            // 
            this.led199.LEDColor = System.Drawing.Color.LimeGreen;
            this.led199.Location = new System.Drawing.Point(77, 3);
            this.led199.Name = "led199";
            this.led199.Size = new System.Drawing.Size(11, 11);
            this.led199.TabIndex = 6;
            // 
            // led200
            // 
            this.led200.LEDColor = System.Drawing.Color.LimeGreen;
            this.led200.Location = new System.Drawing.Point(89, 3);
            this.led200.Name = "led200";
            this.led200.Size = new System.Drawing.Size(11, 11);
            this.led200.TabIndex = 7;
            // 
            // led201
            // 
            this.led201.LEDColor = System.Drawing.Color.LimeGreen;
            this.led201.Location = new System.Drawing.Point(103, 3);
            this.led201.Name = "led201";
            this.led201.Size = new System.Drawing.Size(11, 11);
            this.led201.TabIndex = 8;
            // 
            // led202
            // 
            this.led202.LEDColor = System.Drawing.Color.LimeGreen;
            this.led202.Location = new System.Drawing.Point(115, 3);
            this.led202.Name = "led202";
            this.led202.Size = new System.Drawing.Size(11, 11);
            this.led202.TabIndex = 9;
            // 
            // led203
            // 
            this.led203.LEDColor = System.Drawing.Color.LimeGreen;
            this.led203.Location = new System.Drawing.Point(127, 3);
            this.led203.Name = "led203";
            this.led203.Size = new System.Drawing.Size(11, 11);
            this.led203.TabIndex = 10;
            // 
            // led204
            // 
            this.led204.LEDColor = System.Drawing.Color.LimeGreen;
            this.led204.Location = new System.Drawing.Point(139, 3);
            this.led204.Name = "led204";
            this.led204.Size = new System.Drawing.Size(11, 11);
            this.led204.TabIndex = 11;
            // 
            // led205
            // 
            this.led205.LEDColor = System.Drawing.Color.LimeGreen;
            this.led205.Location = new System.Drawing.Point(153, 3);
            this.led205.Name = "led205";
            this.led205.Size = new System.Drawing.Size(11, 11);
            this.led205.TabIndex = 12;
            // 
            // led206
            // 
            this.led206.LEDColor = System.Drawing.Color.LimeGreen;
            this.led206.Location = new System.Drawing.Point(165, 3);
            this.led206.Name = "led206";
            this.led206.Size = new System.Drawing.Size(11, 11);
            this.led206.TabIndex = 13;
            // 
            // led207
            // 
            this.led207.LEDColor = System.Drawing.Color.LimeGreen;
            this.led207.Location = new System.Drawing.Point(177, 3);
            this.led207.Name = "led207";
            this.led207.Size = new System.Drawing.Size(11, 11);
            this.led207.TabIndex = 14;
            // 
            // led208
            // 
            this.led208.LEDColor = System.Drawing.Color.LimeGreen;
            this.led208.Location = new System.Drawing.Point(189, 3);
            this.led208.Name = "led208";
            this.led208.Size = new System.Drawing.Size(11, 11);
            this.led208.TabIndex = 15;
            // 
            // TempRegArrow
            // 
            this.TempRegArrow.ArrowLength = 35;
            this.TempRegArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.TempRegArrow.CapLNumber = '8';
            this.TempRegArrow.CapRNumber = '8';
            this.TempRegArrow.Location = new System.Drawing.Point(435, 182);
            this.TempRegArrow.Name = "TempRegArrow";
            this.TempRegArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TempRegArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.TempRegArrow.OnLColorBorder = System.Drawing.Color.DarkGreen;
            this.TempRegArrow.OnLColorFill = System.Drawing.Color.LightGreen;
            this.TempRegArrow.OnRColorBorder = System.Drawing.Color.Red;
            this.TempRegArrow.OnRColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TempRegArrow.Size = new System.Drawing.Size(73, 19);
            this.TempRegArrow.TabIndex = 184;
            // 
            // MARArrow
            // 
            this.MARArrow.ArrowLength = 35;
            this.MARArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.MARArrow.CapLNumber = 'F';
            this.MARArrow.CapRNumber = 'F';
            this.MARArrow.Location = new System.Drawing.Point(318, 128);
            this.MARArrow.Name = "MARArrow";
            this.MARArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MARArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MARArrow.OnLColorBorder = System.Drawing.Color.Red;
            this.MARArrow.OnLColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MARArrow.OnRColorBorder = System.Drawing.Color.DarkGreen;
            this.MARArrow.OnRColorFill = System.Drawing.Color.LightGreen;
            this.MARArrow.Size = new System.Drawing.Size(73, 19);
            this.MARArrow.TabIndex = 183;
            // 
            // MDRArrow
            // 
            this.MDRArrow.ArrowLength = 35;
            this.MDRArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.MDRArrow.CapLNumber = 'F';
            this.MDRArrow.CapRNumber = 'F';
            this.MDRArrow.Location = new System.Drawing.Point(318, 231);
            this.MDRArrow.Name = "MDRArrow";
            this.MDRArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MDRArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MDRArrow.OnLColorBorder = System.Drawing.Color.Red;
            this.MDRArrow.OnLColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MDRArrow.OnRColorBorder = System.Drawing.Color.DarkGreen;
            this.MDRArrow.OnRColorFill = System.Drawing.Color.LightGreen;
            this.MDRArrow.Size = new System.Drawing.Size(73, 19);
            this.MDRArrow.TabIndex = 182;
            // 
            // RAMArrow
            // 
            this.RAMArrow.ArrowLength = 35;
            this.RAMArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.RAMArrow.CapLNumber = '8';
            this.RAMArrow.CapRNumber = '8';
            this.RAMArrow.Location = new System.Drawing.Point(318, 180);
            this.RAMArrow.Name = "RAMArrow";
            this.RAMArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.RAMArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.RAMArrow.OnLColorBorder = System.Drawing.Color.Red;
            this.RAMArrow.OnLColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RAMArrow.OnRColorBorder = System.Drawing.Color.DarkGreen;
            this.RAMArrow.OnRColorFill = System.Drawing.Color.LightGreen;
            this.RAMArrow.Size = new System.Drawing.Size(73, 19);
            this.RAMArrow.TabIndex = 181;
            // 
            // PCArrow
            // 
            this.PCArrow.ArrowLength = 35;
            this.PCArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.PCArrow.CapLNumber = 'F';
            this.PCArrow.CapRNumber = 'F';
            this.PCArrow.Location = new System.Drawing.Point(318, 78);
            this.PCArrow.Name = "PCArrow";
            this.PCArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.PCArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PCArrow.OnLColorBorder = System.Drawing.Color.Red;
            this.PCArrow.OnLColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PCArrow.OnRColorBorder = System.Drawing.Color.DarkGreen;
            this.PCArrow.OnRColorFill = System.Drawing.Color.LightGreen;
            this.PCArrow.Size = new System.Drawing.Size(73, 19);
            this.PCArrow.TabIndex = 180;
            // 
            // CRegArrow
            // 
            this.CRegArrow.ArrowLength = 35;
            this.CRegArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.CRegArrow.CapLNumber = '8';
            this.CRegArrow.CapRNumber = '8';
            this.CRegArrow.Location = new System.Drawing.Point(435, 282);
            this.CRegArrow.Name = "CRegArrow";
            this.CRegArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.CRegArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.CRegArrow.OnLColorBorder = System.Drawing.Color.DarkGreen;
            this.CRegArrow.OnLColorFill = System.Drawing.Color.LightGreen;
            this.CRegArrow.OnRColorBorder = System.Drawing.Color.Red;
            this.CRegArrow.OnRColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CRegArrow.Size = new System.Drawing.Size(73, 19);
            this.CRegArrow.TabIndex = 179;
            // 
            // BRegArrow
            // 
            this.BRegArrow.ArrowLength = 35;
            this.BRegArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.BRegArrow.CapLNumber = '8';
            this.BRegArrow.CapRNumber = '8';
            this.BRegArrow.Location = new System.Drawing.Point(435, 231);
            this.BRegArrow.Name = "BRegArrow";
            this.BRegArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BRegArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.BRegArrow.OnLColorBorder = System.Drawing.Color.DarkGreen;
            this.BRegArrow.OnLColorFill = System.Drawing.Color.LightGreen;
            this.BRegArrow.OnRColorBorder = System.Drawing.Color.Red;
            this.BRegArrow.OnRColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BRegArrow.Size = new System.Drawing.Size(73, 19);
            this.BRegArrow.TabIndex = 178;
            // 
            // ARegArrow
            // 
            this.ARegArrow.ArrowLength = 35;
            this.ARegArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.ARegArrow.CapLNumber = '8';
            this.ARegArrow.CapRNumber = '8';
            this.ARegArrow.Location = new System.Drawing.Point(435, 78);
            this.ARegArrow.Name = "ARegArrow";
            this.ARegArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ARegArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ARegArrow.OnLColorBorder = System.Drawing.Color.DarkGreen;
            this.ARegArrow.OnLColorFill = System.Drawing.Color.LightGreen;
            this.ARegArrow.OnRColorBorder = System.Drawing.Color.Red;
            this.ARegArrow.OnRColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ARegArrow.Size = new System.Drawing.Size(73, 19);
            this.ARegArrow.TabIndex = 177;
            // 
            // FlagRegArrowIn
            // 
            this.FlagRegArrowIn.ArrowDirection = SAPEmulator.AppCode.Visual.Arrow.Direction.Right;
            this.FlagRegArrowIn.ArrowLength = 24;
            this.FlagRegArrowIn.CapNumber = '2';
            this.FlagRegArrowIn.Location = new System.Drawing.Point(732, 128);
            this.FlagRegArrowIn.Name = "FlagRegArrowIn";
            this.FlagRegArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.FlagRegArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.FlagRegArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.FlagRegArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.FlagRegArrowIn.Size = new System.Drawing.Size(43, 19);
            this.FlagRegArrowIn.TabIndex = 175;
            // 
            // InstArrowIn
            // 
            this.InstArrowIn.ArrowDirection = SAPEmulator.AppCode.Visual.Arrow.Direction.Left;
            this.InstArrowIn.ArrowLength = 54;
            this.InstArrowIn.CapNumber = '8';
            this.InstArrowIn.Location = new System.Drawing.Point(318, 282);
            this.InstArrowIn.Name = "InstArrowIn";
            this.InstArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.InstArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.InstArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.InstArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InstArrowIn.Size = new System.Drawing.Size(73, 19);
            this.InstArrowIn.TabIndex = 148;
            // 
            // SUMArrowOut
            // 
            this.SUMArrowOut.ArrowDirection = SAPEmulator.AppCode.Visual.Arrow.Direction.Left;
            this.SUMArrowOut.ArrowLength = 54;
            this.SUMArrowOut.CapNumber = '8';
            this.SUMArrowOut.Location = new System.Drawing.Point(435, 129);
            this.SUMArrowOut.Name = "SUMArrowOut";
            this.SUMArrowOut.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SUMArrowOut.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.SUMArrowOut.OnColorBorder = System.Drawing.Color.DarkGreen;
            this.SUMArrowOut.OnColorFill = System.Drawing.Color.LightGreen;
            this.SUMArrowOut.Size = new System.Drawing.Size(73, 19);
            this.SUMArrowOut.TabIndex = 145;
            // 
            // OutputRegArrowIn
            // 
            this.OutputRegArrowIn.ArrowDirection = SAPEmulator.AppCode.Visual.Arrow.Direction.Right;
            this.OutputRegArrowIn.ArrowLength = 54;
            this.OutputRegArrowIn.CapNumber = '8';
            this.OutputRegArrowIn.Location = new System.Drawing.Point(435, 333);
            this.OutputRegArrowIn.Name = "OutputRegArrowIn";
            this.OutputRegArrowIn.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OutputRegArrowIn.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.OutputRegArrowIn.OnColorBorder = System.Drawing.Color.Red;
            this.OutputRegArrowIn.OnColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OutputRegArrowIn.Size = new System.Drawing.Size(73, 19);
            this.OutputRegArrowIn.TabIndex = 140;
            // 
            // CRegLEDDisplay
            // 
            this.CRegLEDDisplay.Controls.Add(this.led181);
            this.CRegLEDDisplay.Controls.Add(this.led182);
            this.CRegLEDDisplay.Controls.Add(this.led183);
            this.CRegLEDDisplay.Controls.Add(this.led184);
            this.CRegLEDDisplay.Controls.Add(this.led185);
            this.CRegLEDDisplay.Controls.Add(this.led186);
            this.CRegLEDDisplay.Controls.Add(this.led187);
            this.CRegLEDDisplay.Controls.Add(this.led188);
            this.CRegLEDDisplay.LEDs.Add(this.led181);
            this.CRegLEDDisplay.LEDs.Add(this.led182);
            this.CRegLEDDisplay.LEDs.Add(this.led183);
            this.CRegLEDDisplay.LEDs.Add(this.led184);
            this.CRegLEDDisplay.LEDs.Add(this.led185);
            this.CRegLEDDisplay.LEDs.Add(this.led186);
            this.CRegLEDDisplay.LEDs.Add(this.led187);
            this.CRegLEDDisplay.LEDs.Add(this.led188);
            this.CRegLEDDisplay.LEDSpacing = 2;
            this.CRegLEDDisplay.Location = new System.Drawing.Point(9, 19);
            this.CRegLEDDisplay.Name = "CRegLEDDisplay";
            this.CRegLEDDisplay.NibbleSpacing = 2;
            this.CRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
            this.CRegLEDDisplay.TabIndex = 17;
            // 
            // led181
            // 
            this.led181.LEDColor = System.Drawing.Color.Red;
            this.led181.Location = new System.Drawing.Point(3, 3);
            this.led181.Name = "led181";
            this.led181.Size = new System.Drawing.Size(11, 11);
            this.led181.TabIndex = 0;
            // 
            // led182
            // 
            this.led182.LEDColor = System.Drawing.Color.Red;
            this.led182.Location = new System.Drawing.Point(15, 3);
            this.led182.Name = "led182";
            this.led182.Size = new System.Drawing.Size(11, 11);
            this.led182.TabIndex = 1;
            // 
            // led183
            // 
            this.led183.LEDColor = System.Drawing.Color.Red;
            this.led183.Location = new System.Drawing.Point(27, 3);
            this.led183.Name = "led183";
            this.led183.Size = new System.Drawing.Size(11, 11);
            this.led183.TabIndex = 2;
            // 
            // led184
            // 
            this.led184.LEDColor = System.Drawing.Color.Red;
            this.led184.Location = new System.Drawing.Point(39, 3);
            this.led184.Name = "led184";
            this.led184.Size = new System.Drawing.Size(11, 11);
            this.led184.TabIndex = 3;
            // 
            // led185
            // 
            this.led185.LEDColor = System.Drawing.Color.Red;
            this.led185.Location = new System.Drawing.Point(53, 3);
            this.led185.Name = "led185";
            this.led185.Size = new System.Drawing.Size(11, 11);
            this.led185.TabIndex = 4;
            // 
            // led186
            // 
            this.led186.LEDColor = System.Drawing.Color.Red;
            this.led186.Location = new System.Drawing.Point(65, 3);
            this.led186.Name = "led186";
            this.led186.Size = new System.Drawing.Size(11, 11);
            this.led186.TabIndex = 5;
            // 
            // led187
            // 
            this.led187.LEDColor = System.Drawing.Color.Red;
            this.led187.Location = new System.Drawing.Point(77, 3);
            this.led187.Name = "led187";
            this.led187.Size = new System.Drawing.Size(11, 11);
            this.led187.TabIndex = 6;
            // 
            // led188
            // 
            this.led188.LEDColor = System.Drawing.Color.Red;
            this.led188.Location = new System.Drawing.Point(89, 3);
            this.led188.Name = "led188";
            this.led188.Size = new System.Drawing.Size(11, 11);
            this.led188.TabIndex = 7;
            // 
            // MDRLEDDisplay
            // 
            this.MDRLEDDisplay.Controls.Add(this.led134);
            this.MDRLEDDisplay.Controls.Add(this.led135);
            this.MDRLEDDisplay.Controls.Add(this.led136);
            this.MDRLEDDisplay.Controls.Add(this.led137);
            this.MDRLEDDisplay.Controls.Add(this.led138);
            this.MDRLEDDisplay.Controls.Add(this.led139);
            this.MDRLEDDisplay.Controls.Add(this.led140);
            this.MDRLEDDisplay.Controls.Add(this.led141);
            this.MDRLEDDisplay.Controls.Add(this.led142);
            this.MDRLEDDisplay.Controls.Add(this.led143);
            this.MDRLEDDisplay.Controls.Add(this.led144);
            this.MDRLEDDisplay.Controls.Add(this.led145);
            this.MDRLEDDisplay.Controls.Add(this.led146);
            this.MDRLEDDisplay.Controls.Add(this.led147);
            this.MDRLEDDisplay.Controls.Add(this.led148);
            this.MDRLEDDisplay.Controls.Add(this.led149);
            this.MDRLEDDisplay.LEDs.Add(this.led134);
            this.MDRLEDDisplay.LEDs.Add(this.led135);
            this.MDRLEDDisplay.LEDs.Add(this.led136);
            this.MDRLEDDisplay.LEDs.Add(this.led137);
            this.MDRLEDDisplay.LEDs.Add(this.led138);
            this.MDRLEDDisplay.LEDs.Add(this.led139);
            this.MDRLEDDisplay.LEDs.Add(this.led140);
            this.MDRLEDDisplay.LEDs.Add(this.led141);
            this.MDRLEDDisplay.LEDs.Add(this.led142);
            this.MDRLEDDisplay.LEDs.Add(this.led143);
            this.MDRLEDDisplay.LEDs.Add(this.led144);
            this.MDRLEDDisplay.LEDs.Add(this.led145);
            this.MDRLEDDisplay.LEDs.Add(this.led146);
            this.MDRLEDDisplay.LEDs.Add(this.led147);
            this.MDRLEDDisplay.LEDs.Add(this.led148);
            this.MDRLEDDisplay.LEDs.Add(this.led149);
            this.MDRLEDDisplay.LEDSpacing = 2;
            this.MDRLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.MDRLEDDisplay.Name = "MDRLEDDisplay";
            this.MDRLEDDisplay.NibbleSpacing = 2;
            this.MDRLEDDisplay.Size = new System.Drawing.Size(204, 16);
            this.MDRLEDDisplay.TabIndex = 45;
            // 
            // led134
            // 
            this.led134.LEDColor = System.Drawing.Color.Red;
            this.led134.Location = new System.Drawing.Point(3, 3);
            this.led134.Name = "led134";
            this.led134.Size = new System.Drawing.Size(11, 11);
            this.led134.TabIndex = 0;
            // 
            // led135
            // 
            this.led135.LEDColor = System.Drawing.Color.Red;
            this.led135.Location = new System.Drawing.Point(15, 3);
            this.led135.Name = "led135";
            this.led135.Size = new System.Drawing.Size(11, 11);
            this.led135.TabIndex = 1;
            // 
            // led136
            // 
            this.led136.LEDColor = System.Drawing.Color.Red;
            this.led136.Location = new System.Drawing.Point(27, 3);
            this.led136.Name = "led136";
            this.led136.Size = new System.Drawing.Size(11, 11);
            this.led136.TabIndex = 2;
            // 
            // led137
            // 
            this.led137.LEDColor = System.Drawing.Color.Red;
            this.led137.Location = new System.Drawing.Point(39, 3);
            this.led137.Name = "led137";
            this.led137.Size = new System.Drawing.Size(11, 11);
            this.led137.TabIndex = 3;
            // 
            // led138
            // 
            this.led138.LEDColor = System.Drawing.Color.Red;
            this.led138.Location = new System.Drawing.Point(53, 3);
            this.led138.Name = "led138";
            this.led138.Size = new System.Drawing.Size(11, 11);
            this.led138.TabIndex = 4;
            // 
            // led139
            // 
            this.led139.LEDColor = System.Drawing.Color.Red;
            this.led139.Location = new System.Drawing.Point(65, 3);
            this.led139.Name = "led139";
            this.led139.Size = new System.Drawing.Size(11, 11);
            this.led139.TabIndex = 5;
            // 
            // led140
            // 
            this.led140.LEDColor = System.Drawing.Color.Red;
            this.led140.Location = new System.Drawing.Point(77, 3);
            this.led140.Name = "led140";
            this.led140.Size = new System.Drawing.Size(11, 11);
            this.led140.TabIndex = 6;
            // 
            // led141
            // 
            this.led141.LEDColor = System.Drawing.Color.Red;
            this.led141.Location = new System.Drawing.Point(89, 3);
            this.led141.Name = "led141";
            this.led141.Size = new System.Drawing.Size(11, 11);
            this.led141.TabIndex = 7;
            // 
            // led142
            // 
            this.led142.LEDColor = System.Drawing.Color.Red;
            this.led142.Location = new System.Drawing.Point(103, 3);
            this.led142.Name = "led142";
            this.led142.Size = new System.Drawing.Size(11, 11);
            this.led142.TabIndex = 8;
            // 
            // led143
            // 
            this.led143.LEDColor = System.Drawing.Color.Red;
            this.led143.Location = new System.Drawing.Point(115, 3);
            this.led143.Name = "led143";
            this.led143.Size = new System.Drawing.Size(11, 11);
            this.led143.TabIndex = 9;
            // 
            // led144
            // 
            this.led144.LEDColor = System.Drawing.Color.Red;
            this.led144.Location = new System.Drawing.Point(127, 3);
            this.led144.Name = "led144";
            this.led144.Size = new System.Drawing.Size(11, 11);
            this.led144.TabIndex = 10;
            // 
            // led145
            // 
            this.led145.LEDColor = System.Drawing.Color.Red;
            this.led145.Location = new System.Drawing.Point(139, 3);
            this.led145.Name = "led145";
            this.led145.Size = new System.Drawing.Size(11, 11);
            this.led145.TabIndex = 11;
            // 
            // led146
            // 
            this.led146.LEDColor = System.Drawing.Color.Red;
            this.led146.Location = new System.Drawing.Point(153, 3);
            this.led146.Name = "led146";
            this.led146.Size = new System.Drawing.Size(11, 11);
            this.led146.TabIndex = 12;
            // 
            // led147
            // 
            this.led147.LEDColor = System.Drawing.Color.Red;
            this.led147.Location = new System.Drawing.Point(165, 3);
            this.led147.Name = "led147";
            this.led147.Size = new System.Drawing.Size(11, 11);
            this.led147.TabIndex = 13;
            // 
            // led148
            // 
            this.led148.LEDColor = System.Drawing.Color.Red;
            this.led148.Location = new System.Drawing.Point(177, 3);
            this.led148.Name = "led148";
            this.led148.Size = new System.Drawing.Size(11, 11);
            this.led148.TabIndex = 14;
            // 
            // led149
            // 
            this.led149.LEDColor = System.Drawing.Color.Red;
            this.led149.Location = new System.Drawing.Point(189, 3);
            this.led149.Name = "led149";
            this.led149.Size = new System.Drawing.Size(11, 11);
            this.led149.TabIndex = 15;
            // 
            // TempRegLEDDisplay
            // 
            this.TempRegLEDDisplay.Controls.Add(this.led126);
            this.TempRegLEDDisplay.Controls.Add(this.led127);
            this.TempRegLEDDisplay.Controls.Add(this.led128);
            this.TempRegLEDDisplay.Controls.Add(this.led129);
            this.TempRegLEDDisplay.Controls.Add(this.led130);
            this.TempRegLEDDisplay.Controls.Add(this.led131);
            this.TempRegLEDDisplay.Controls.Add(this.led132);
            this.TempRegLEDDisplay.Controls.Add(this.led133);
            this.TempRegLEDDisplay.LEDs.Add(this.led126);
            this.TempRegLEDDisplay.LEDs.Add(this.led127);
            this.TempRegLEDDisplay.LEDs.Add(this.led128);
            this.TempRegLEDDisplay.LEDs.Add(this.led129);
            this.TempRegLEDDisplay.LEDs.Add(this.led130);
            this.TempRegLEDDisplay.LEDs.Add(this.led131);
            this.TempRegLEDDisplay.LEDs.Add(this.led132);
            this.TempRegLEDDisplay.LEDs.Add(this.led133);
            this.TempRegLEDDisplay.LEDSpacing = 2;
            this.TempRegLEDDisplay.Location = new System.Drawing.Point(6, 19);
            this.TempRegLEDDisplay.Name = "TempRegLEDDisplay";
            this.TempRegLEDDisplay.NibbleSpacing = 2;
            this.TempRegLEDDisplay.Size = new System.Drawing.Size(104, 16);
            this.TempRegLEDDisplay.TabIndex = 15;
            // 
            // led126
            // 
            this.led126.LEDColor = System.Drawing.Color.Red;
            this.led126.Location = new System.Drawing.Point(3, 3);
            this.led126.Name = "led126";
            this.led126.Size = new System.Drawing.Size(11, 11);
            this.led126.TabIndex = 0;
            // 
            // led127
            // 
            this.led127.LEDColor = System.Drawing.Color.Red;
            this.led127.Location = new System.Drawing.Point(15, 3);
            this.led127.Name = "led127";
            this.led127.Size = new System.Drawing.Size(11, 11);
            this.led127.TabIndex = 1;
            // 
            // led128
            // 
            this.led128.LEDColor = System.Drawing.Color.Red;
            this.led128.Location = new System.Drawing.Point(27, 3);
            this.led128.Name = "led128";
            this.led128.Size = new System.Drawing.Size(11, 11);
            this.led128.TabIndex = 2;
            // 
            // led129
            // 
            this.led129.LEDColor = System.Drawing.Color.Red;
            this.led129.Location = new System.Drawing.Point(39, 3);
            this.led129.Name = "led129";
            this.led129.Size = new System.Drawing.Size(11, 11);
            this.led129.TabIndex = 3;
            // 
            // led130
            // 
            this.led130.LEDColor = System.Drawing.Color.Red;
            this.led130.Location = new System.Drawing.Point(53, 3);
            this.led130.Name = "led130";
            this.led130.Size = new System.Drawing.Size(11, 11);
            this.led130.TabIndex = 4;
            // 
            // led131
            // 
            this.led131.LEDColor = System.Drawing.Color.Red;
            this.led131.Location = new System.Drawing.Point(65, 3);
            this.led131.Name = "led131";
            this.led131.Size = new System.Drawing.Size(11, 11);
            this.led131.TabIndex = 5;
            // 
            // led132
            // 
            this.led132.LEDColor = System.Drawing.Color.Red;
            this.led132.Location = new System.Drawing.Point(77, 3);
            this.led132.Name = "led132";
            this.led132.Size = new System.Drawing.Size(11, 11);
            this.led132.TabIndex = 6;
            // 
            // led133
            // 
            this.led133.LEDColor = System.Drawing.Color.Red;
            this.led133.Location = new System.Drawing.Point(89, 3);
            this.led133.Name = "led133";
            this.led133.Size = new System.Drawing.Size(11, 11);
            this.led133.TabIndex = 7;
            // 
            // CLDecodedLEDDisplay
            // 
            this.CLDecodedLEDDisplay.Controls.Add(this.led85);
            this.CLDecodedLEDDisplay.Controls.Add(this.led86);
            this.CLDecodedLEDDisplay.Controls.Add(this.led87);
            this.CLDecodedLEDDisplay.Controls.Add(this.led88);
            this.CLDecodedLEDDisplay.Controls.Add(this.led89);
            this.CLDecodedLEDDisplay.Controls.Add(this.led166);
            this.CLDecodedLEDDisplay.Controls.Add(this.led167);
            this.CLDecodedLEDDisplay.Controls.Add(this.led168);
            this.CLDecodedLEDDisplay.Controls.Add(this.led169);
            this.CLDecodedLEDDisplay.Controls.Add(this.led170);
            this.CLDecodedLEDDisplay.Controls.Add(this.led171);
            this.CLDecodedLEDDisplay.Controls.Add(this.led172);
            this.CLDecodedLEDDisplay.Controls.Add(this.led173);
            this.CLDecodedLEDDisplay.Controls.Add(this.led174);
            this.CLDecodedLEDDisplay.Controls.Add(this.led175);
            this.CLDecodedLEDDisplay.Controls.Add(this.led176);
            this.CLDecodedLEDDisplay.Controls.Add(this.led177);
            this.CLDecodedLEDDisplay.Controls.Add(this.led178);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led85);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led86);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led87);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led88);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led89);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led166);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led167);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led168);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led169);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led170);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led171);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led172);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led173);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led174);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led175);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led176);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led177);
            this.CLDecodedLEDDisplay.LEDs.Add(this.led178);
            this.CLDecodedLEDDisplay.LEDSpacing = 5;
            this.CLDecodedLEDDisplay.Location = new System.Drawing.Point(85, 28);
            this.CLDecodedLEDDisplay.Name = "CLDecodedLEDDisplay";
            this.CLDecodedLEDDisplay.NibbleSpacing = 0;
            this.CLDecodedLEDDisplay.Size = new System.Drawing.Size(276, 16);
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
            // led166
            // 
            this.led166.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led166.Location = new System.Drawing.Point(78, 3);
            this.led166.Name = "led166";
            this.led166.Size = new System.Drawing.Size(11, 11);
            this.led166.TabIndex = 5;
            // 
            // led167
            // 
            this.led167.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led167.Location = new System.Drawing.Point(93, 3);
            this.led167.Name = "led167";
            this.led167.Size = new System.Drawing.Size(11, 11);
            this.led167.TabIndex = 6;
            // 
            // led168
            // 
            this.led168.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led168.Location = new System.Drawing.Point(108, 3);
            this.led168.Name = "led168";
            this.led168.Size = new System.Drawing.Size(11, 11);
            this.led168.TabIndex = 7;
            // 
            // led169
            // 
            this.led169.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led169.Location = new System.Drawing.Point(123, 3);
            this.led169.Name = "led169";
            this.led169.Size = new System.Drawing.Size(11, 11);
            this.led169.TabIndex = 8;
            // 
            // led170
            // 
            this.led170.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led170.Location = new System.Drawing.Point(138, 3);
            this.led170.Name = "led170";
            this.led170.Size = new System.Drawing.Size(11, 11);
            this.led170.TabIndex = 9;
            // 
            // led171
            // 
            this.led171.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led171.Location = new System.Drawing.Point(153, 3);
            this.led171.Name = "led171";
            this.led171.Size = new System.Drawing.Size(11, 11);
            this.led171.TabIndex = 10;
            // 
            // led172
            // 
            this.led172.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led172.Location = new System.Drawing.Point(168, 3);
            this.led172.Name = "led172";
            this.led172.Size = new System.Drawing.Size(11, 11);
            this.led172.TabIndex = 11;
            // 
            // led173
            // 
            this.led173.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led173.Location = new System.Drawing.Point(183, 3);
            this.led173.Name = "led173";
            this.led173.Size = new System.Drawing.Size(11, 11);
            this.led173.TabIndex = 12;
            // 
            // led174
            // 
            this.led174.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led174.Location = new System.Drawing.Point(198, 3);
            this.led174.Name = "led174";
            this.led174.Size = new System.Drawing.Size(11, 11);
            this.led174.TabIndex = 13;
            // 
            // led175
            // 
            this.led175.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led175.Location = new System.Drawing.Point(213, 3);
            this.led175.Name = "led175";
            this.led175.Size = new System.Drawing.Size(11, 11);
            this.led175.TabIndex = 14;
            // 
            // led176
            // 
            this.led176.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led176.Location = new System.Drawing.Point(228, 3);
            this.led176.Name = "led176";
            this.led176.Size = new System.Drawing.Size(11, 11);
            this.led176.TabIndex = 15;
            // 
            // led177
            // 
            this.led177.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led177.Location = new System.Drawing.Point(243, 3);
            this.led177.Name = "led177";
            this.led177.Size = new System.Drawing.Size(11, 11);
            this.led177.TabIndex = 16;
            // 
            // led178
            // 
            this.led178.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led178.Location = new System.Drawing.Point(258, 3);
            this.led178.Name = "led178";
            this.led178.Size = new System.Drawing.Size(11, 11);
            this.led178.TabIndex = 17;
            // 
            // rLabel54
            // 
            this.rLabel54.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel54.Location = new System.Drawing.Point(342, 16);
            this.rLabel54.Name = "rLabel54";
            this.rLabel54.RotationAngle = 0D;
            this.rLabel54.Size = new System.Drawing.Size(14, 16);
            this.rLabel54.TabIndex = 121;
            this.rLabel54.Text = "17";
            this.rLabel54.TopLine = true;
            // 
            // rLabel52
            // 
            this.rLabel52.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel52.Location = new System.Drawing.Point(312, 16);
            this.rLabel52.Name = "rLabel52";
            this.rLabel52.RotationAngle = 0D;
            this.rLabel52.Size = new System.Drawing.Size(14, 16);
            this.rLabel52.TabIndex = 119;
            this.rLabel52.Text = "15";
            this.rLabel52.TopLine = true;
            // 
            // rLabel47
            // 
            this.rLabel47.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel47.Location = new System.Drawing.Point(162, 16);
            this.rLabel47.Name = "rLabel47";
            this.rLabel47.RotationAngle = 0D;
            this.rLabel47.Size = new System.Drawing.Size(14, 16);
            this.rLabel47.TabIndex = 109;
            this.rLabel47.Text = "T5";
            this.rLabel47.TopLine = true;
            // 
            // rLabel53
            // 
            this.rLabel53.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel53.Location = new System.Drawing.Point(327, 16);
            this.rLabel53.Name = "rLabel53";
            this.rLabel53.RotationAngle = 0D;
            this.rLabel53.Size = new System.Drawing.Size(14, 16);
            this.rLabel53.TabIndex = 120;
            this.rLabel53.Text = "16";
            this.rLabel53.TopLine = true;
            // 
            // rLabel48
            // 
            this.rLabel48.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel48.Location = new System.Drawing.Point(177, 16);
            this.rLabel48.Name = "rLabel48";
            this.rLabel48.RotationAngle = 0D;
            this.rLabel48.Size = new System.Drawing.Size(14, 16);
            this.rLabel48.TabIndex = 110;
            this.rLabel48.Text = "T6";
            this.rLabel48.TopLine = true;
            // 
            // rLabel49
            // 
            this.rLabel49.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel49.Location = new System.Drawing.Point(192, 16);
            this.rLabel49.Name = "rLabel49";
            this.rLabel49.RotationAngle = 0D;
            this.rLabel49.Size = new System.Drawing.Size(14, 16);
            this.rLabel49.TabIndex = 111;
            this.rLabel49.Text = "T7";
            this.rLabel49.TopLine = true;
            // 
            // rLabel50
            // 
            this.rLabel50.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel50.Location = new System.Drawing.Point(207, 16);
            this.rLabel50.Name = "rLabel50";
            this.rLabel50.RotationAngle = 0D;
            this.rLabel50.Size = new System.Drawing.Size(14, 16);
            this.rLabel50.TabIndex = 112;
            this.rLabel50.Text = "T8";
            this.rLabel50.TopLine = true;
            // 
            // rLabel51
            // 
            this.rLabel51.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel51.Location = new System.Drawing.Point(222, 16);
            this.rLabel51.Name = "rLabel51";
            this.rLabel51.RotationAngle = 0D;
            this.rLabel51.Size = new System.Drawing.Size(14, 16);
            this.rLabel51.TabIndex = 113;
            this.rLabel51.Text = "T9";
            this.rLabel51.TopLine = true;
            // 
            // rLabel16
            // 
            this.rLabel16.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel16.Location = new System.Drawing.Point(87, 16);
            this.rLabel16.Name = "rLabel16";
            this.rLabel16.RotationAngle = 0D;
            this.rLabel16.Size = new System.Drawing.Size(14, 16);
            this.rLabel16.TabIndex = 104;
            this.rLabel16.Text = "T0";
            this.rLabel16.TopLine = true;
            // 
            // rLabel57
            // 
            this.rLabel57.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel57.Location = new System.Drawing.Point(237, 16);
            this.rLabel57.Name = "rLabel57";
            this.rLabel57.RotationAngle = 0D;
            this.rLabel57.Size = new System.Drawing.Size(14, 16);
            this.rLabel57.TabIndex = 114;
            this.rLabel57.Text = "10";
            this.rLabel57.TopLine = true;
            // 
            // rLabel17
            // 
            this.rLabel17.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel17.Location = new System.Drawing.Point(102, 16);
            this.rLabel17.Name = "rLabel17";
            this.rLabel17.RotationAngle = 0D;
            this.rLabel17.Size = new System.Drawing.Size(14, 16);
            this.rLabel17.TabIndex = 105;
            this.rLabel17.Text = "T1";
            this.rLabel17.TopLine = true;
            // 
            // rLabel58
            // 
            this.rLabel58.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel58.Location = new System.Drawing.Point(252, 16);
            this.rLabel58.Name = "rLabel58";
            this.rLabel58.RotationAngle = 0D;
            this.rLabel58.Size = new System.Drawing.Size(14, 16);
            this.rLabel58.TabIndex = 115;
            this.rLabel58.Text = "11";
            this.rLabel58.TopLine = true;
            // 
            // rLabel19
            // 
            this.rLabel19.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel19.Location = new System.Drawing.Point(117, 16);
            this.rLabel19.Name = "rLabel19";
            this.rLabel19.RotationAngle = 0D;
            this.rLabel19.Size = new System.Drawing.Size(14, 16);
            this.rLabel19.TabIndex = 106;
            this.rLabel19.Text = "T2";
            this.rLabel19.TopLine = true;
            // 
            // rLabel59
            // 
            this.rLabel59.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel59.Location = new System.Drawing.Point(267, 16);
            this.rLabel59.Name = "rLabel59";
            this.rLabel59.RotationAngle = 0D;
            this.rLabel59.Size = new System.Drawing.Size(14, 16);
            this.rLabel59.TabIndex = 116;
            this.rLabel59.Text = "12";
            this.rLabel59.TopLine = true;
            // 
            // rLabel18
            // 
            this.rLabel18.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel18.Location = new System.Drawing.Point(132, 16);
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
            this.rLabel21.Location = new System.Drawing.Point(147, 16);
            this.rLabel21.Name = "rLabel21";
            this.rLabel21.RotationAngle = 0D;
            this.rLabel21.Size = new System.Drawing.Size(14, 16);
            this.rLabel21.TabIndex = 108;
            this.rLabel21.Text = "T4";
            this.rLabel21.TopLine = true;
            // 
            // rLabel60
            // 
            this.rLabel60.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel60.Location = new System.Drawing.Point(282, 16);
            this.rLabel60.Name = "rLabel60";
            this.rLabel60.RotationAngle = 0D;
            this.rLabel60.Size = new System.Drawing.Size(14, 16);
            this.rLabel60.TabIndex = 117;
            this.rLabel60.Text = "13";
            this.rLabel60.TopLine = true;
            // 
            // MICounterLEDDisplay
            // 
            this.MICounterLEDDisplay.Controls.Add(this.led82);
            this.MICounterLEDDisplay.Controls.Add(this.led83);
            this.MICounterLEDDisplay.Controls.Add(this.led84);
            this.MICounterLEDDisplay.Controls.Add(this.led179);
            this.MICounterLEDDisplay.Controls.Add(this.led180);
            this.MICounterLEDDisplay.LEDs.Add(this.led82);
            this.MICounterLEDDisplay.LEDs.Add(this.led83);
            this.MICounterLEDDisplay.LEDs.Add(this.led84);
            this.MICounterLEDDisplay.LEDs.Add(this.led179);
            this.MICounterLEDDisplay.LEDs.Add(this.led180);
            this.MICounterLEDDisplay.LEDSpacing = 2;
            this.MICounterLEDDisplay.Location = new System.Drawing.Point(6, 28);
            this.MICounterLEDDisplay.Name = "MICounterLEDDisplay";
            this.MICounterLEDDisplay.NibbleSpacing = 2;
            this.MICounterLEDDisplay.Size = new System.Drawing.Size(66, 16);
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
            // led179
            // 
            this.led179.LEDColor = System.Drawing.Color.Red;
            this.led179.Location = new System.Drawing.Point(39, 3);
            this.led179.Name = "led179";
            this.led179.Size = new System.Drawing.Size(11, 11);
            this.led179.TabIndex = 3;
            // 
            // led180
            // 
            this.led180.LEDColor = System.Drawing.Color.Red;
            this.led180.Location = new System.Drawing.Point(53, 3);
            this.led180.Name = "led180";
            this.led180.Size = new System.Drawing.Size(11, 11);
            this.led180.TabIndex = 4;
            // 
            // rLabel61
            // 
            this.rLabel61.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel61.Location = new System.Drawing.Point(297, 16);
            this.rLabel61.Name = "rLabel61";
            this.rLabel61.RotationAngle = 0D;
            this.rLabel61.Size = new System.Drawing.Size(14, 16);
            this.rLabel61.TabIndex = 118;
            this.rLabel61.Text = "14";
            this.rLabel61.TopLine = true;
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
            this.InstRegLEDDisplay.Location = new System.Drawing.Point(65, 19);
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
            this.led7.LEDColor = System.Drawing.Color.Blue;
            this.led7.Location = new System.Drawing.Point(53, 3);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(11, 11);
            this.led7.TabIndex = 4;
            // 
            // led8
            // 
            this.led8.LEDColor = System.Drawing.Color.Blue;
            this.led8.Location = new System.Drawing.Point(65, 3);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(11, 11);
            this.led8.TabIndex = 5;
            // 
            // led9
            // 
            this.led9.LEDColor = System.Drawing.Color.Blue;
            this.led9.Location = new System.Drawing.Point(77, 3);
            this.led9.Name = "led9";
            this.led9.Size = new System.Drawing.Size(11, 11);
            this.led9.TabIndex = 6;
            // 
            // led10
            // 
            this.led10.LEDColor = System.Drawing.Color.Blue;
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
            this.MARLEDDisplay.Controls.Add(this.led114);
            this.MARLEDDisplay.Controls.Add(this.led115);
            this.MARLEDDisplay.Controls.Add(this.led116);
            this.MARLEDDisplay.Controls.Add(this.led117);
            this.MARLEDDisplay.Controls.Add(this.led118);
            this.MARLEDDisplay.Controls.Add(this.led119);
            this.MARLEDDisplay.Controls.Add(this.led120);
            this.MARLEDDisplay.Controls.Add(this.led121);
            this.MARLEDDisplay.Controls.Add(this.led122);
            this.MARLEDDisplay.Controls.Add(this.led123);
            this.MARLEDDisplay.Controls.Add(this.led124);
            this.MARLEDDisplay.Controls.Add(this.led125);
            this.MARLEDDisplay.LEDs.Add(this.led51);
            this.MARLEDDisplay.LEDs.Add(this.led52);
            this.MARLEDDisplay.LEDs.Add(this.led53);
            this.MARLEDDisplay.LEDs.Add(this.led54);
            this.MARLEDDisplay.LEDs.Add(this.led114);
            this.MARLEDDisplay.LEDs.Add(this.led115);
            this.MARLEDDisplay.LEDs.Add(this.led116);
            this.MARLEDDisplay.LEDs.Add(this.led117);
            this.MARLEDDisplay.LEDs.Add(this.led118);
            this.MARLEDDisplay.LEDs.Add(this.led119);
            this.MARLEDDisplay.LEDs.Add(this.led120);
            this.MARLEDDisplay.LEDs.Add(this.led121);
            this.MARLEDDisplay.LEDs.Add(this.led122);
            this.MARLEDDisplay.LEDs.Add(this.led123);
            this.MARLEDDisplay.LEDs.Add(this.led124);
            this.MARLEDDisplay.LEDs.Add(this.led125);
            this.MARLEDDisplay.LEDSpacing = 2;
            this.MARLEDDisplay.Location = new System.Drawing.Point(5, 19);
            this.MARLEDDisplay.Name = "MARLEDDisplay";
            this.MARLEDDisplay.NibbleSpacing = 2;
            this.MARLEDDisplay.Size = new System.Drawing.Size(204, 16);
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
            // led114
            // 
            this.led114.LEDColor = System.Drawing.Color.Gold;
            this.led114.Location = new System.Drawing.Point(53, 3);
            this.led114.Name = "led114";
            this.led114.Size = new System.Drawing.Size(11, 11);
            this.led114.TabIndex = 4;
            // 
            // led115
            // 
            this.led115.LEDColor = System.Drawing.Color.Gold;
            this.led115.Location = new System.Drawing.Point(65, 3);
            this.led115.Name = "led115";
            this.led115.Size = new System.Drawing.Size(11, 11);
            this.led115.TabIndex = 5;
            // 
            // led116
            // 
            this.led116.LEDColor = System.Drawing.Color.Gold;
            this.led116.Location = new System.Drawing.Point(77, 3);
            this.led116.Name = "led116";
            this.led116.Size = new System.Drawing.Size(11, 11);
            this.led116.TabIndex = 6;
            // 
            // led117
            // 
            this.led117.LEDColor = System.Drawing.Color.Gold;
            this.led117.Location = new System.Drawing.Point(89, 3);
            this.led117.Name = "led117";
            this.led117.Size = new System.Drawing.Size(11, 11);
            this.led117.TabIndex = 7;
            // 
            // led118
            // 
            this.led118.LEDColor = System.Drawing.Color.Gold;
            this.led118.Location = new System.Drawing.Point(103, 3);
            this.led118.Name = "led118";
            this.led118.Size = new System.Drawing.Size(11, 11);
            this.led118.TabIndex = 8;
            // 
            // led119
            // 
            this.led119.LEDColor = System.Drawing.Color.Gold;
            this.led119.Location = new System.Drawing.Point(115, 3);
            this.led119.Name = "led119";
            this.led119.Size = new System.Drawing.Size(11, 11);
            this.led119.TabIndex = 9;
            // 
            // led120
            // 
            this.led120.LEDColor = System.Drawing.Color.Gold;
            this.led120.Location = new System.Drawing.Point(127, 3);
            this.led120.Name = "led120";
            this.led120.Size = new System.Drawing.Size(11, 11);
            this.led120.TabIndex = 10;
            // 
            // led121
            // 
            this.led121.LEDColor = System.Drawing.Color.Gold;
            this.led121.Location = new System.Drawing.Point(139, 3);
            this.led121.Name = "led121";
            this.led121.Size = new System.Drawing.Size(11, 11);
            this.led121.TabIndex = 11;
            // 
            // led122
            // 
            this.led122.LEDColor = System.Drawing.Color.Gold;
            this.led122.Location = new System.Drawing.Point(153, 3);
            this.led122.Name = "led122";
            this.led122.Size = new System.Drawing.Size(11, 11);
            this.led122.TabIndex = 12;
            // 
            // led123
            // 
            this.led123.LEDColor = System.Drawing.Color.Gold;
            this.led123.Location = new System.Drawing.Point(165, 3);
            this.led123.Name = "led123";
            this.led123.Size = new System.Drawing.Size(11, 11);
            this.led123.TabIndex = 13;
            // 
            // led124
            // 
            this.led124.LEDColor = System.Drawing.Color.Gold;
            this.led124.Location = new System.Drawing.Point(177, 3);
            this.led124.Name = "led124";
            this.led124.Size = new System.Drawing.Size(11, 11);
            this.led124.TabIndex = 14;
            // 
            // led125
            // 
            this.led125.LEDColor = System.Drawing.Color.Gold;
            this.led125.Location = new System.Drawing.Point(189, 3);
            this.led125.Name = "led125";
            this.led125.Size = new System.Drawing.Size(11, 11);
            this.led125.TabIndex = 15;
            // 
            // rLabel55
            // 
            this.rLabel55.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel55.Location = new System.Drawing.Point(233, 37);
            this.rLabel55.Name = "rLabel55";
            this.rLabel55.RotationAngle = 90D;
            this.rLabel55.Size = new System.Drawing.Size(14, 16);
            this.rLabel55.TabIndex = 156;
            this.rLabel55.Text = "RT";
            this.rLabel55.TopLine = false;
            // 
            // rLabel56
            // 
            this.rLabel56.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel56.Location = new System.Drawing.Point(248, 28);
            this.rLabel56.Name = "rLabel56";
            this.rLabel56.RotationAngle = 90D;
            this.rLabel56.Size = new System.Drawing.Size(12, 25);
            this.rLabel56.TabIndex = 148;
            this.rLabel56.Text = "MDI";
            this.rLabel56.TopLine = false;
            // 
            // rLabel46
            // 
            this.rLabel46.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel46.Location = new System.Drawing.Point(236, 90);
            this.rLabel46.Name = "rLabel46";
            this.rLabel46.RotationAngle = 90D;
            this.rLabel46.Size = new System.Drawing.Size(15, 25);
            this.rLabel46.TabIndex = 147;
            this.rLabel46.Text = "SRS";
            this.rLabel46.TopLine = false;
            // 
            // rLabel45
            // 
            this.rLabel45.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel45.Location = new System.Drawing.Point(221, 90);
            this.rLabel45.Name = "rLabel45";
            this.rLabel45.RotationAngle = 90D;
            this.rLabel45.Size = new System.Drawing.Size(15, 25);
            this.rLabel45.TabIndex = 146;
            this.rLabel45.Text = "SRA";
            this.rLabel45.TopLine = false;
            // 
            // rLabel44
            // 
            this.rLabel44.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel44.Location = new System.Drawing.Point(207, 90);
            this.rLabel44.Name = "rLabel44";
            this.rLabel44.RotationAngle = 90D;
            this.rLabel44.Size = new System.Drawing.Size(15, 25);
            this.rLabel44.TabIndex = 145;
            this.rLabel44.Text = "SRI";
            this.rLabel44.TopLine = false;
            // 
            // rLabel36
            // 
            this.rLabel36.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel36.Location = new System.Drawing.Point(190, 89);
            this.rLabel36.Name = "rLabel36";
            this.rLabel36.RotationAngle = 90D;
            this.rLabel36.Size = new System.Drawing.Size(15, 25);
            this.rLabel36.TabIndex = 144;
            this.rLabel36.Text = "SRO";
            this.rLabel36.TopLine = false;
            // 
            // rLabel41
            // 
            this.rLabel41.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel41.Location = new System.Drawing.Point(177, 97);
            this.rLabel41.Name = "rLabel41";
            this.rLabel41.RotationAngle = 90D;
            this.rLabel41.Size = new System.Drawing.Size(14, 16);
            this.rLabel41.TabIndex = 142;
            this.rLabel41.Text = "TO";
            this.rLabel41.TopLine = false;
            // 
            // rLabel35
            // 
            this.rLabel35.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel35.Location = new System.Drawing.Point(109, 97);
            this.rLabel35.Name = "rLabel35";
            this.rLabel35.RotationAngle = 90D;
            this.rLabel35.Size = new System.Drawing.Size(14, 16);
            this.rLabel35.TabIndex = 141;
            this.rLabel35.Text = "S3";
            this.rLabel35.TopLine = false;
            // 
            // rLabel10
            // 
            this.rLabel10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel10.Location = new System.Drawing.Point(135, 37);
            this.rLabel10.Name = "rLabel10";
            this.rLabel10.RotationAngle = 90D;
            this.rLabel10.Size = new System.Drawing.Size(14, 16);
            this.rLabel10.TabIndex = 140;
            this.rLabel10.Text = "BO";
            this.rLabel10.TopLine = false;
            // 
            // rLabel28
            // 
            this.rLabel28.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel28.Location = new System.Drawing.Point(10, 89);
            this.rLabel28.Name = "rLabel28";
            this.rLabel28.RotationAngle = 90D;
            this.rLabel28.Size = new System.Drawing.Size(11, 25);
            this.rLabel28.TabIndex = 125;
            this.rLabel28.Text = "MDO";
            this.rLabel28.TopLine = false;
            // 
            // rLabel29
            // 
            this.rLabel29.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel29.Location = new System.Drawing.Point(24, 89);
            this.rLabel29.Name = "rLabel29";
            this.rLabel29.RotationAngle = 90D;
            this.rLabel29.Size = new System.Drawing.Size(11, 25);
            this.rLabel29.TabIndex = 126;
            this.rLabel29.Text = "MDL";
            this.rLabel29.TopLine = false;
            // 
            // rLabel30
            // 
            this.rLabel30.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel30.Location = new System.Drawing.Point(37, 97);
            this.rLabel30.Name = "rLabel30";
            this.rLabel30.RotationAngle = 90D;
            this.rLabel30.Size = new System.Drawing.Size(14, 16);
            this.rLabel30.TabIndex = 127;
            this.rLabel30.Text = "TI";
            this.rLabel30.TopLine = false;
            // 
            // rLabel31
            // 
            this.rLabel31.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel31.Location = new System.Drawing.Point(51, 97);
            this.rLabel31.Name = "rLabel31";
            this.rLabel31.RotationAngle = 90D;
            this.rLabel31.Size = new System.Drawing.Size(14, 16);
            this.rLabel31.TabIndex = 128;
            this.rLabel31.Text = "MO";
            this.rLabel31.TopLine = false;
            // 
            // rLabel32
            // 
            this.rLabel32.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel32.Location = new System.Drawing.Point(67, 97);
            this.rLabel32.Name = "rLabel32";
            this.rLabel32.RotationAngle = 90D;
            this.rLabel32.Size = new System.Drawing.Size(14, 16);
            this.rLabel32.TabIndex = 129;
            this.rLabel32.Text = "CO";
            this.rLabel32.TopLine = false;
            // 
            // rLabel33
            // 
            this.rLabel33.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel33.Location = new System.Drawing.Point(81, 97);
            this.rLabel33.Name = "rLabel33";
            this.rLabel33.RotationAngle = 90D;
            this.rLabel33.Size = new System.Drawing.Size(14, 16);
            this.rLabel33.TabIndex = 130;
            this.rLabel33.Text = "CI";
            this.rLabel33.TopLine = false;
            // 
            // rLabel34
            // 
            this.rLabel34.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel34.Location = new System.Drawing.Point(94, 97);
            this.rLabel34.Name = "rLabel34";
            this.rLabel34.RotationAngle = 90D;
            this.rLabel34.Size = new System.Drawing.Size(14, 16);
            this.rLabel34.TabIndex = 131;
            this.rLabel34.Text = " M";
            this.rLabel34.TopLine = false;
            // 
            // rLabel37
            // 
            this.rLabel37.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel37.Location = new System.Drawing.Point(122, 97);
            this.rLabel37.Name = "rLabel37";
            this.rLabel37.RotationAngle = 90D;
            this.rLabel37.Size = new System.Drawing.Size(14, 16);
            this.rLabel37.TabIndex = 133;
            this.rLabel37.Text = "S2";
            this.rLabel37.TopLine = false;
            // 
            // rLabel38
            // 
            this.rLabel38.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel38.Location = new System.Drawing.Point(136, 98);
            this.rLabel38.Name = "rLabel38";
            this.rLabel38.RotationAngle = 90D;
            this.rLabel38.Size = new System.Drawing.Size(14, 16);
            this.rLabel38.TabIndex = 134;
            this.rLabel38.Text = "S1";
            this.rLabel38.TopLine = false;
            // 
            // rLabel39
            // 
            this.rLabel39.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel39.Location = new System.Drawing.Point(150, 97);
            this.rLabel39.Name = "rLabel39";
            this.rLabel39.RotationAngle = 90D;
            this.rLabel39.Size = new System.Drawing.Size(14, 16);
            this.rLabel39.TabIndex = 135;
            this.rLabel39.Text = "S0";
            this.rLabel39.TopLine = false;
            // 
            // rLabel40
            // 
            this.rLabel40.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel40.Location = new System.Drawing.Point(164, 90);
            this.rLabel40.Name = "rLabel40";
            this.rLabel40.RotationAngle = 90D;
            this.rLabel40.Size = new System.Drawing.Size(15, 25);
            this.rLabel40.TabIndex = 136;
            this.rLabel40.Text = "CRI";
            this.rLabel40.TopLine = false;
            // 
            // StatusLEDDsiaply2
            // 
            this.StatusLEDDsiaply2.Controls.Add(this.led150);
            this.StatusLEDDsiaply2.Controls.Add(this.led151);
            this.StatusLEDDsiaply2.Controls.Add(this.led152);
            this.StatusLEDDsiaply2.Controls.Add(this.led153);
            this.StatusLEDDsiaply2.Controls.Add(this.led154);
            this.StatusLEDDsiaply2.Controls.Add(this.led155);
            this.StatusLEDDsiaply2.Controls.Add(this.led156);
            this.StatusLEDDsiaply2.Controls.Add(this.led157);
            this.StatusLEDDsiaply2.Controls.Add(this.led158);
            this.StatusLEDDsiaply2.Controls.Add(this.led159);
            this.StatusLEDDsiaply2.Controls.Add(this.led160);
            this.StatusLEDDsiaply2.Controls.Add(this.led161);
            this.StatusLEDDsiaply2.Controls.Add(this.led162);
            this.StatusLEDDsiaply2.Controls.Add(this.led163);
            this.StatusLEDDsiaply2.Controls.Add(this.led164);
            this.StatusLEDDsiaply2.Controls.Add(this.led165);
            this.StatusLEDDsiaply2.Controls.Add(this.led67);
            this.StatusLEDDsiaply2.Controls.Add(this.led221);
            this.StatusLEDDsiaply2.LEDs.Add(this.led150);
            this.StatusLEDDsiaply2.LEDs.Add(this.led151);
            this.StatusLEDDsiaply2.LEDs.Add(this.led152);
            this.StatusLEDDsiaply2.LEDs.Add(this.led153);
            this.StatusLEDDsiaply2.LEDs.Add(this.led154);
            this.StatusLEDDsiaply2.LEDs.Add(this.led155);
            this.StatusLEDDsiaply2.LEDs.Add(this.led156);
            this.StatusLEDDsiaply2.LEDs.Add(this.led157);
            this.StatusLEDDsiaply2.LEDs.Add(this.led158);
            this.StatusLEDDsiaply2.LEDs.Add(this.led159);
            this.StatusLEDDsiaply2.LEDs.Add(this.led160);
            this.StatusLEDDsiaply2.LEDs.Add(this.led161);
            this.StatusLEDDsiaply2.LEDs.Add(this.led162);
            this.StatusLEDDsiaply2.LEDs.Add(this.led163);
            this.StatusLEDDsiaply2.LEDs.Add(this.led164);
            this.StatusLEDDsiaply2.LEDs.Add(this.led165);
            this.StatusLEDDsiaply2.LEDs.Add(this.led67);
            this.StatusLEDDsiaply2.LEDs.Add(this.led221);
            this.StatusLEDDsiaply2.LEDSpacing = 4;
            this.StatusLEDDsiaply2.Location = new System.Drawing.Point(8, 115);
            this.StatusLEDDsiaply2.Name = "StatusLEDDsiaply2";
            this.StatusLEDDsiaply2.NibbleSpacing = 0;
            this.StatusLEDDsiaply2.Size = new System.Drawing.Size(258, 16);
            this.StatusLEDDsiaply2.TabIndex = 122;
            // 
            // led150
            // 
            this.led150.LEDColor = System.Drawing.Color.Blue;
            this.led150.Location = new System.Drawing.Point(3, 3);
            this.led150.Name = "led150";
            this.led150.Size = new System.Drawing.Size(11, 11);
            this.led150.TabIndex = 0;
            // 
            // led151
            // 
            this.led151.LEDColor = System.Drawing.Color.Blue;
            this.led151.Location = new System.Drawing.Point(17, 3);
            this.led151.Name = "led151";
            this.led151.Size = new System.Drawing.Size(11, 11);
            this.led151.TabIndex = 1;
            // 
            // led152
            // 
            this.led152.LEDColor = System.Drawing.Color.Blue;
            this.led152.Location = new System.Drawing.Point(31, 3);
            this.led152.Name = "led152";
            this.led152.Size = new System.Drawing.Size(11, 11);
            this.led152.TabIndex = 2;
            // 
            // led153
            // 
            this.led153.LEDColor = System.Drawing.Color.Blue;
            this.led153.Location = new System.Drawing.Point(45, 3);
            this.led153.Name = "led153";
            this.led153.Size = new System.Drawing.Size(11, 11);
            this.led153.TabIndex = 3;
            // 
            // led154
            // 
            this.led154.LEDColor = System.Drawing.Color.Blue;
            this.led154.Location = new System.Drawing.Point(59, 3);
            this.led154.Name = "led154";
            this.led154.Size = new System.Drawing.Size(11, 11);
            this.led154.TabIndex = 4;
            // 
            // led155
            // 
            this.led155.LEDColor = System.Drawing.Color.Blue;
            this.led155.Location = new System.Drawing.Point(73, 3);
            this.led155.Name = "led155";
            this.led155.Size = new System.Drawing.Size(11, 11);
            this.led155.TabIndex = 5;
            // 
            // led156
            // 
            this.led156.LEDColor = System.Drawing.Color.Blue;
            this.led156.Location = new System.Drawing.Point(87, 3);
            this.led156.Name = "led156";
            this.led156.Size = new System.Drawing.Size(11, 11);
            this.led156.TabIndex = 6;
            // 
            // led157
            // 
            this.led157.LEDColor = System.Drawing.Color.Blue;
            this.led157.Location = new System.Drawing.Point(101, 3);
            this.led157.Name = "led157";
            this.led157.Size = new System.Drawing.Size(11, 11);
            this.led157.TabIndex = 7;
            // 
            // led158
            // 
            this.led158.LEDColor = System.Drawing.Color.Blue;
            this.led158.Location = new System.Drawing.Point(115, 3);
            this.led158.Name = "led158";
            this.led158.Size = new System.Drawing.Size(11, 11);
            this.led158.TabIndex = 8;
            // 
            // led159
            // 
            this.led159.LEDColor = System.Drawing.Color.Blue;
            this.led159.Location = new System.Drawing.Point(129, 3);
            this.led159.Name = "led159";
            this.led159.Size = new System.Drawing.Size(11, 11);
            this.led159.TabIndex = 9;
            // 
            // led160
            // 
            this.led160.LEDColor = System.Drawing.Color.Blue;
            this.led160.Location = new System.Drawing.Point(143, 3);
            this.led160.Name = "led160";
            this.led160.Size = new System.Drawing.Size(11, 11);
            this.led160.TabIndex = 10;
            // 
            // led161
            // 
            this.led161.LEDColor = System.Drawing.Color.Blue;
            this.led161.Location = new System.Drawing.Point(157, 3);
            this.led161.Name = "led161";
            this.led161.Size = new System.Drawing.Size(11, 11);
            this.led161.TabIndex = 11;
            // 
            // led162
            // 
            this.led162.LEDColor = System.Drawing.Color.Blue;
            this.led162.Location = new System.Drawing.Point(171, 3);
            this.led162.Name = "led162";
            this.led162.Size = new System.Drawing.Size(11, 11);
            this.led162.TabIndex = 12;
            // 
            // led163
            // 
            this.led163.LEDColor = System.Drawing.Color.Blue;
            this.led163.Location = new System.Drawing.Point(185, 3);
            this.led163.Name = "led163";
            this.led163.Size = new System.Drawing.Size(11, 11);
            this.led163.TabIndex = 13;
            // 
            // led164
            // 
            this.led164.LEDColor = System.Drawing.Color.Blue;
            this.led164.Location = new System.Drawing.Point(199, 3);
            this.led164.Name = "led164";
            this.led164.Size = new System.Drawing.Size(11, 11);
            this.led164.TabIndex = 14;
            // 
            // led165
            // 
            this.led165.LEDColor = System.Drawing.Color.Blue;
            this.led165.Location = new System.Drawing.Point(213, 3);
            this.led165.Name = "led165";
            this.led165.Size = new System.Drawing.Size(11, 11);
            this.led165.TabIndex = 15;
            // 
            // led67
            // 
            this.led67.LEDColor = System.Drawing.Color.Blue;
            this.led67.Location = new System.Drawing.Point(227, 3);
            this.led67.Name = "led67";
            this.led67.Size = new System.Drawing.Size(11, 11);
            this.led67.TabIndex = 16;
            // 
            // led221
            // 
            this.led221.LEDColor = System.Drawing.Color.Blue;
            this.led221.Location = new System.Drawing.Point(241, 3);
            this.led221.Name = "led221";
            this.led221.Size = new System.Drawing.Size(11, 11);
            this.led221.TabIndex = 17;
            // 
            // StatusLEDDsiaply1
            // 
            this.StatusLEDDsiaply1.Controls.Add(this.led68);
            this.StatusLEDDsiaply1.Controls.Add(this.led69);
            this.StatusLEDDsiaply1.Controls.Add(this.led70);
            this.StatusLEDDsiaply1.Controls.Add(this.led71);
            this.StatusLEDDsiaply1.Controls.Add(this.led72);
            this.StatusLEDDsiaply1.Controls.Add(this.led73);
            this.StatusLEDDsiaply1.Controls.Add(this.led74);
            this.StatusLEDDsiaply1.Controls.Add(this.led75);
            this.StatusLEDDsiaply1.Controls.Add(this.led76);
            this.StatusLEDDsiaply1.Controls.Add(this.led77);
            this.StatusLEDDsiaply1.Controls.Add(this.led78);
            this.StatusLEDDsiaply1.Controls.Add(this.led79);
            this.StatusLEDDsiaply1.Controls.Add(this.led80);
            this.StatusLEDDsiaply1.Controls.Add(this.led81);
            this.StatusLEDDsiaply1.Controls.Add(this.led94);
            this.StatusLEDDsiaply1.Controls.Add(this.led211);
            this.StatusLEDDsiaply1.Controls.Add(this.led212);
            this.StatusLEDDsiaply1.Controls.Add(this.led213);
            this.StatusLEDDsiaply1.LEDs.Add(this.led68);
            this.StatusLEDDsiaply1.LEDs.Add(this.led69);
            this.StatusLEDDsiaply1.LEDs.Add(this.led70);
            this.StatusLEDDsiaply1.LEDs.Add(this.led71);
            this.StatusLEDDsiaply1.LEDs.Add(this.led72);
            this.StatusLEDDsiaply1.LEDs.Add(this.led73);
            this.StatusLEDDsiaply1.LEDs.Add(this.led74);
            this.StatusLEDDsiaply1.LEDs.Add(this.led75);
            this.StatusLEDDsiaply1.LEDs.Add(this.led76);
            this.StatusLEDDsiaply1.LEDs.Add(this.led77);
            this.StatusLEDDsiaply1.LEDs.Add(this.led78);
            this.StatusLEDDsiaply1.LEDs.Add(this.led79);
            this.StatusLEDDsiaply1.LEDs.Add(this.led80);
            this.StatusLEDDsiaply1.LEDs.Add(this.led81);
            this.StatusLEDDsiaply1.LEDs.Add(this.led94);
            this.StatusLEDDsiaply1.LEDs.Add(this.led211);
            this.StatusLEDDsiaply1.LEDs.Add(this.led212);
            this.StatusLEDDsiaply1.LEDs.Add(this.led213);
            this.StatusLEDDsiaply1.LEDSpacing = 4;
            this.StatusLEDDsiaply1.Location = new System.Drawing.Point(8, 53);
            this.StatusLEDDsiaply1.Name = "StatusLEDDsiaply1";
            this.StatusLEDDsiaply1.NibbleSpacing = 0;
            this.StatusLEDDsiaply1.Size = new System.Drawing.Size(258, 16);
            this.StatusLEDDsiaply1.TabIndex = 83;
            // 
            // led68
            // 
            this.led68.LEDColor = System.Drawing.Color.Blue;
            this.led68.Location = new System.Drawing.Point(3, 3);
            this.led68.Name = "led68";
            this.led68.Size = new System.Drawing.Size(11, 11);
            this.led68.TabIndex = 1;
            // 
            // led69
            // 
            this.led69.LEDColor = System.Drawing.Color.Blue;
            this.led69.Location = new System.Drawing.Point(17, 3);
            this.led69.Name = "led69";
            this.led69.Size = new System.Drawing.Size(11, 11);
            this.led69.TabIndex = 2;
            // 
            // led70
            // 
            this.led70.LEDColor = System.Drawing.Color.Blue;
            this.led70.Location = new System.Drawing.Point(31, 3);
            this.led70.Name = "led70";
            this.led70.Size = new System.Drawing.Size(11, 11);
            this.led70.TabIndex = 3;
            // 
            // led71
            // 
            this.led71.LEDColor = System.Drawing.Color.Blue;
            this.led71.Location = new System.Drawing.Point(45, 3);
            this.led71.Name = "led71";
            this.led71.Size = new System.Drawing.Size(11, 11);
            this.led71.TabIndex = 4;
            // 
            // led72
            // 
            this.led72.LEDColor = System.Drawing.Color.Blue;
            this.led72.Location = new System.Drawing.Point(59, 3);
            this.led72.Name = "led72";
            this.led72.Size = new System.Drawing.Size(11, 11);
            this.led72.TabIndex = 5;
            // 
            // led73
            // 
            this.led73.LEDColor = System.Drawing.Color.Blue;
            this.led73.Location = new System.Drawing.Point(73, 3);
            this.led73.Name = "led73";
            this.led73.Size = new System.Drawing.Size(11, 11);
            this.led73.TabIndex = 6;
            // 
            // led74
            // 
            this.led74.LEDColor = System.Drawing.Color.Blue;
            this.led74.Location = new System.Drawing.Point(87, 3);
            this.led74.Name = "led74";
            this.led74.Size = new System.Drawing.Size(11, 11);
            this.led74.TabIndex = 7;
            // 
            // led75
            // 
            this.led75.LEDColor = System.Drawing.Color.Blue;
            this.led75.Location = new System.Drawing.Point(101, 3);
            this.led75.Name = "led75";
            this.led75.Size = new System.Drawing.Size(11, 11);
            this.led75.TabIndex = 8;
            // 
            // led76
            // 
            this.led76.LEDColor = System.Drawing.Color.Blue;
            this.led76.Location = new System.Drawing.Point(115, 3);
            this.led76.Name = "led76";
            this.led76.Size = new System.Drawing.Size(11, 11);
            this.led76.TabIndex = 9;
            // 
            // led77
            // 
            this.led77.LEDColor = System.Drawing.Color.Blue;
            this.led77.Location = new System.Drawing.Point(129, 3);
            this.led77.Name = "led77";
            this.led77.Size = new System.Drawing.Size(11, 11);
            this.led77.TabIndex = 10;
            // 
            // led78
            // 
            this.led78.LEDColor = System.Drawing.Color.Blue;
            this.led78.Location = new System.Drawing.Point(143, 3);
            this.led78.Name = "led78";
            this.led78.Size = new System.Drawing.Size(11, 11);
            this.led78.TabIndex = 11;
            // 
            // led79
            // 
            this.led79.LEDColor = System.Drawing.Color.Blue;
            this.led79.Location = new System.Drawing.Point(157, 3);
            this.led79.Name = "led79";
            this.led79.Size = new System.Drawing.Size(11, 11);
            this.led79.TabIndex = 12;
            // 
            // led80
            // 
            this.led80.LEDColor = System.Drawing.Color.Blue;
            this.led80.Location = new System.Drawing.Point(171, 3);
            this.led80.Name = "led80";
            this.led80.Size = new System.Drawing.Size(11, 11);
            this.led80.TabIndex = 13;
            // 
            // led81
            // 
            this.led81.LEDColor = System.Drawing.Color.Blue;
            this.led81.Location = new System.Drawing.Point(185, 3);
            this.led81.Name = "led81";
            this.led81.Size = new System.Drawing.Size(11, 11);
            this.led81.TabIndex = 14;
            // 
            // led94
            // 
            this.led94.LEDColor = System.Drawing.Color.Blue;
            this.led94.Location = new System.Drawing.Point(199, 3);
            this.led94.Name = "led94";
            this.led94.Size = new System.Drawing.Size(11, 11);
            this.led94.TabIndex = 15;
            // 
            // led211
            // 
            this.led211.LEDColor = System.Drawing.Color.Blue;
            this.led211.Location = new System.Drawing.Point(213, 3);
            this.led211.Name = "led211";
            this.led211.Size = new System.Drawing.Size(11, 11);
            this.led211.TabIndex = 16;
            // 
            // led212
            // 
            this.led212.LEDColor = System.Drawing.Color.Red;
            this.led212.Location = new System.Drawing.Point(227, 3);
            this.led212.Name = "led212";
            this.led212.Size = new System.Drawing.Size(11, 11);
            this.led212.TabIndex = 17;
            // 
            // led213
            // 
            this.led213.LEDColor = System.Drawing.Color.Blue;
            this.led213.Location = new System.Drawing.Point(241, 3);
            this.led213.Name = "led213";
            this.led213.Size = new System.Drawing.Size(11, 11);
            this.led213.TabIndex = 18;
            // 
            // rLabel1
            // 
            this.rLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel1.Location = new System.Drawing.Point(9, 28);
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
            this.rLabel2.Location = new System.Drawing.Point(23, 37);
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
            this.rLabel3.Location = new System.Drawing.Point(37, 37);
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
            this.rLabel4.Location = new System.Drawing.Point(51, 37);
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
            this.rLabel5.Location = new System.Drawing.Point(65, 37);
            this.rLabel5.Name = "rLabel5";
            this.rLabel5.RotationAngle = 90D;
            this.rLabel5.Size = new System.Drawing.Size(14, 16);
            this.rLabel5.TabIndex = 89;
            this.rLabel5.Text = "AC";
            this.rLabel5.TopLine = false;
            // 
            // rLabel6
            // 
            this.rLabel6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel6.Location = new System.Drawing.Point(79, 37);
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
            this.rLabel7.Location = new System.Drawing.Point(94, 37);
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
            this.rLabel8.Location = new System.Drawing.Point(108, 37);
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
            this.rLabel9.Location = new System.Drawing.Point(121, 37);
            this.rLabel9.Name = "rLabel9";
            this.rLabel9.RotationAngle = 90D;
            this.rLabel9.Size = new System.Drawing.Size(14, 16);
            this.rLabel9.TabIndex = 93;
            this.rLabel9.Text = "SO";
            this.rLabel9.TopLine = false;
            // 
            // rLabel25
            // 
            this.rLabel25.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel25.Location = new System.Drawing.Point(219, 37);
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
            this.rLabel12.Location = new System.Drawing.Point(149, 37);
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
            this.rLabel11.Location = new System.Drawing.Point(163, 37);
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
            this.rLabel13.Location = new System.Drawing.Point(177, 38);
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
            this.rLabel14.Location = new System.Drawing.Point(191, 37);
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
            this.rLabel15.Location = new System.Drawing.Point(205, 28);
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
            // rLabel43
            // 
            this.rLabel43.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel43.Location = new System.Drawing.Point(38, 17);
            this.rLabel43.Name = "rLabel43";
            this.rLabel43.RotationAngle = 90D;
            this.rLabel43.Size = new System.Drawing.Size(14, 16);
            this.rLabel43.TabIndex = 119;
            this.rLabel43.Text = "MF";
            this.rLabel43.TopLine = false;
            // 
            // FlagRegLEDDisplay
            // 
            this.FlagRegLEDDisplay.Controls.Add(this.led92);
            this.FlagRegLEDDisplay.Controls.Add(this.led93);
            this.FlagRegLEDDisplay.Controls.Add(this.led190);
            this.FlagRegLEDDisplay.LEDs.Add(this.led92);
            this.FlagRegLEDDisplay.LEDs.Add(this.led93);
            this.FlagRegLEDDisplay.LEDs.Add(this.led190);
            this.FlagRegLEDDisplay.LEDSpacing = 4;
            this.FlagRegLEDDisplay.Location = new System.Drawing.Point(9, 33);
            this.FlagRegLEDDisplay.Name = "FlagRegLEDDisplay";
            this.FlagRegLEDDisplay.NibbleSpacing = 0;
            this.FlagRegLEDDisplay.Size = new System.Drawing.Size(48, 16);
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
            // led190
            // 
            this.led190.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.led190.Location = new System.Drawing.Point(31, 3);
            this.led190.Name = "led190";
            this.led190.Size = new System.Drawing.Size(11, 11);
            this.led190.TabIndex = 2;
            // 
            // rLabel24
            // 
            this.rLabel24.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel24.Location = new System.Drawing.Point(12, 17);
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
            this.rLabel23.Location = new System.Drawing.Point(25, 17);
            this.rLabel23.Name = "rLabel23";
            this.rLabel23.RotationAngle = 90D;
            this.rLabel23.Size = new System.Drawing.Size(14, 16);
            this.rLabel23.TabIndex = 118;
            this.rLabel23.Text = "ZF";
            this.rLabel23.TopLine = false;
            // 
            // rLabel42
            // 
            this.rLabel42.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel42.Location = new System.Drawing.Point(195, 12);
            this.rLabel42.Name = "rLabel42";
            this.rLabel42.RotationAngle = 0D;
            this.rLabel42.Size = new System.Drawing.Size(12, 10);
            this.rLabel42.TabIndex = 116;
            this.rLabel42.Text = "M";
            this.rLabel42.TopLine = false;
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
            this.led35.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led35.Location = new System.Drawing.Point(3, 3);
            this.led35.Name = "led35";
            this.led35.Size = new System.Drawing.Size(11, 11);
            this.led35.TabIndex = 0;
            // 
            // led36
            // 
            this.led36.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led36.Location = new System.Drawing.Point(15, 3);
            this.led36.Name = "led36";
            this.led36.Size = new System.Drawing.Size(11, 11);
            this.led36.TabIndex = 1;
            // 
            // led37
            // 
            this.led37.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led37.Location = new System.Drawing.Point(27, 3);
            this.led37.Name = "led37";
            this.led37.Size = new System.Drawing.Size(11, 11);
            this.led37.TabIndex = 2;
            // 
            // led38
            // 
            this.led38.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led38.Location = new System.Drawing.Point(39, 3);
            this.led38.Name = "led38";
            this.led38.Size = new System.Drawing.Size(11, 11);
            this.led38.TabIndex = 3;
            // 
            // led39
            // 
            this.led39.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led39.Location = new System.Drawing.Point(53, 3);
            this.led39.Name = "led39";
            this.led39.Size = new System.Drawing.Size(11, 11);
            this.led39.TabIndex = 4;
            // 
            // led40
            // 
            this.led40.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led40.Location = new System.Drawing.Point(65, 3);
            this.led40.Name = "led40";
            this.led40.Size = new System.Drawing.Size(11, 11);
            this.led40.TabIndex = 5;
            // 
            // led41
            // 
            this.led41.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led41.Location = new System.Drawing.Point(77, 3);
            this.led41.Name = "led41";
            this.led41.Size = new System.Drawing.Size(11, 11);
            this.led41.TabIndex = 6;
            // 
            // led42
            // 
            this.led42.LEDColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.led42.Location = new System.Drawing.Point(89, 3);
            this.led42.Name = "led42";
            this.led42.Size = new System.Drawing.Size(11, 11);
            this.led42.TabIndex = 7;
            // 
            // rLabel20
            // 
            this.rLabel20.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel20.Location = new System.Drawing.Point(165, 12);
            this.rLabel20.Name = "rLabel20";
            this.rLabel20.RotationAngle = 0D;
            this.rLabel20.Size = new System.Drawing.Size(12, 10);
            this.rLabel20.TabIndex = 114;
            this.rLabel20.Text = "C";
            this.rLabel20.TopLine = false;
            // 
            // rLabel22
            // 
            this.rLabel22.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel22.Location = new System.Drawing.Point(180, 12);
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
            this.SumFlagsLEDDisplay.Controls.Add(this.led189);
            this.SumFlagsLEDDisplay.LEDs.Add(this.led90);
            this.SumFlagsLEDDisplay.LEDs.Add(this.led91);
            this.SumFlagsLEDDisplay.LEDs.Add(this.led189);
            this.SumFlagsLEDDisplay.LEDSpacing = 5;
            this.SumFlagsLEDDisplay.Location = new System.Drawing.Point(162, 20);
            this.SumFlagsLEDDisplay.Name = "SumFlagsLEDDisplay";
            this.SumFlagsLEDDisplay.NibbleSpacing = 0;
            this.SumFlagsLEDDisplay.Size = new System.Drawing.Size(51, 16);
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
            // led189
            // 
            this.led189.LEDColor = System.Drawing.Color.Blue;
            this.led189.Location = new System.Drawing.Point(33, 3);
            this.led189.Name = "led189";
            this.led189.Size = new System.Drawing.Size(11, 11);
            this.led189.TabIndex = 2;
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
            // PCIncLED
            // 
            this.PCIncLED.LEDColor = System.Drawing.Color.Blue;
            this.PCIncLED.Location = new System.Drawing.Point(13, 26);
            this.PCIncLED.Name = "PCIncLED";
            this.PCIncLED.Size = new System.Drawing.Size(11, 11);
            this.PCIncLED.TabIndex = 69;
            // 
            // PCLEDDisplay
            // 
            this.PCLEDDisplay.Controls.Add(this.led55);
            this.PCLEDDisplay.Controls.Add(this.led56);
            this.PCLEDDisplay.Controls.Add(this.led57);
            this.PCLEDDisplay.Controls.Add(this.led58);
            this.PCLEDDisplay.Controls.Add(this.led1);
            this.PCLEDDisplay.Controls.Add(this.led95);
            this.PCLEDDisplay.Controls.Add(this.led96);
            this.PCLEDDisplay.Controls.Add(this.led97);
            this.PCLEDDisplay.Controls.Add(this.led98);
            this.PCLEDDisplay.Controls.Add(this.led99);
            this.PCLEDDisplay.Controls.Add(this.led100);
            this.PCLEDDisplay.Controls.Add(this.led101);
            this.PCLEDDisplay.Controls.Add(this.led102);
            this.PCLEDDisplay.Controls.Add(this.led103);
            this.PCLEDDisplay.Controls.Add(this.led104);
            this.PCLEDDisplay.Controls.Add(this.led105);
            this.PCLEDDisplay.LEDs.Add(this.led55);
            this.PCLEDDisplay.LEDs.Add(this.led56);
            this.PCLEDDisplay.LEDs.Add(this.led57);
            this.PCLEDDisplay.LEDs.Add(this.led58);
            this.PCLEDDisplay.LEDs.Add(this.led1);
            this.PCLEDDisplay.LEDs.Add(this.led95);
            this.PCLEDDisplay.LEDs.Add(this.led96);
            this.PCLEDDisplay.LEDs.Add(this.led97);
            this.PCLEDDisplay.LEDs.Add(this.led98);
            this.PCLEDDisplay.LEDs.Add(this.led99);
            this.PCLEDDisplay.LEDs.Add(this.led100);
            this.PCLEDDisplay.LEDs.Add(this.led101);
            this.PCLEDDisplay.LEDs.Add(this.led102);
            this.PCLEDDisplay.LEDs.Add(this.led103);
            this.PCLEDDisplay.LEDs.Add(this.led104);
            this.PCLEDDisplay.LEDs.Add(this.led105);
            this.PCLEDDisplay.LEDSpacing = 2;
            this.PCLEDDisplay.Location = new System.Drawing.Point(38, 18);
            this.PCLEDDisplay.Name = "PCLEDDisplay";
            this.PCLEDDisplay.NibbleSpacing = 2;
            this.PCLEDDisplay.Size = new System.Drawing.Size(204, 16);
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
            // led1
            // 
            this.led1.LEDColor = System.Drawing.Color.LimeGreen;
            this.led1.Location = new System.Drawing.Point(53, 3);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(11, 11);
            this.led1.TabIndex = 4;
            // 
            // led95
            // 
            this.led95.LEDColor = System.Drawing.Color.LimeGreen;
            this.led95.Location = new System.Drawing.Point(65, 3);
            this.led95.Name = "led95";
            this.led95.Size = new System.Drawing.Size(11, 11);
            this.led95.TabIndex = 5;
            // 
            // led96
            // 
            this.led96.LEDColor = System.Drawing.Color.LimeGreen;
            this.led96.Location = new System.Drawing.Point(77, 3);
            this.led96.Name = "led96";
            this.led96.Size = new System.Drawing.Size(11, 11);
            this.led96.TabIndex = 6;
            // 
            // led97
            // 
            this.led97.LEDColor = System.Drawing.Color.LimeGreen;
            this.led97.Location = new System.Drawing.Point(89, 3);
            this.led97.Name = "led97";
            this.led97.Size = new System.Drawing.Size(11, 11);
            this.led97.TabIndex = 7;
            // 
            // led98
            // 
            this.led98.LEDColor = System.Drawing.Color.LimeGreen;
            this.led98.Location = new System.Drawing.Point(103, 3);
            this.led98.Name = "led98";
            this.led98.Size = new System.Drawing.Size(11, 11);
            this.led98.TabIndex = 8;
            // 
            // led99
            // 
            this.led99.LEDColor = System.Drawing.Color.LimeGreen;
            this.led99.Location = new System.Drawing.Point(115, 3);
            this.led99.Name = "led99";
            this.led99.Size = new System.Drawing.Size(11, 11);
            this.led99.TabIndex = 9;
            // 
            // led100
            // 
            this.led100.LEDColor = System.Drawing.Color.LimeGreen;
            this.led100.Location = new System.Drawing.Point(127, 3);
            this.led100.Name = "led100";
            this.led100.Size = new System.Drawing.Size(11, 11);
            this.led100.TabIndex = 10;
            // 
            // led101
            // 
            this.led101.LEDColor = System.Drawing.Color.LimeGreen;
            this.led101.Location = new System.Drawing.Point(139, 3);
            this.led101.Name = "led101";
            this.led101.Size = new System.Drawing.Size(11, 11);
            this.led101.TabIndex = 11;
            // 
            // led102
            // 
            this.led102.LEDColor = System.Drawing.Color.LimeGreen;
            this.led102.Location = new System.Drawing.Point(153, 3);
            this.led102.Name = "led102";
            this.led102.Size = new System.Drawing.Size(11, 11);
            this.led102.TabIndex = 12;
            // 
            // led103
            // 
            this.led103.LEDColor = System.Drawing.Color.LimeGreen;
            this.led103.Location = new System.Drawing.Point(165, 3);
            this.led103.Name = "led103";
            this.led103.Size = new System.Drawing.Size(11, 11);
            this.led103.TabIndex = 13;
            // 
            // led104
            // 
            this.led104.LEDColor = System.Drawing.Color.LimeGreen;
            this.led104.Location = new System.Drawing.Point(177, 3);
            this.led104.Name = "led104";
            this.led104.Size = new System.Drawing.Size(11, 11);
            this.led104.TabIndex = 14;
            // 
            // led105
            // 
            this.led105.LEDColor = System.Drawing.Color.LimeGreen;
            this.led105.Location = new System.Drawing.Point(189, 3);
            this.led105.Name = "led105";
            this.led105.Size = new System.Drawing.Size(11, 11);
            this.led105.TabIndex = 15;
            // 
            // ClkLed
            // 
            this.ClkLed.LEDColor = System.Drawing.Color.Fuchsia;
            this.ClkLed.Location = new System.Drawing.Point(182, 34);
            this.ClkLed.Name = "ClkLed";
            this.ClkLed.Size = new System.Drawing.Size(11, 11);
            this.ClkLed.TabIndex = 112;
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
            this.BusLEDDisplay.Controls.Add(this.led106);
            this.BusLEDDisplay.Controls.Add(this.led107);
            this.BusLEDDisplay.Controls.Add(this.led108);
            this.BusLEDDisplay.Controls.Add(this.led109);
            this.BusLEDDisplay.Controls.Add(this.led110);
            this.BusLEDDisplay.Controls.Add(this.led111);
            this.BusLEDDisplay.Controls.Add(this.led112);
            this.BusLEDDisplay.Controls.Add(this.led113);
            this.BusLEDDisplay.LEDs.Add(this.led11);
            this.BusLEDDisplay.LEDs.Add(this.led12);
            this.BusLEDDisplay.LEDs.Add(this.led13);
            this.BusLEDDisplay.LEDs.Add(this.led14);
            this.BusLEDDisplay.LEDs.Add(this.led15);
            this.BusLEDDisplay.LEDs.Add(this.led16);
            this.BusLEDDisplay.LEDs.Add(this.led17);
            this.BusLEDDisplay.LEDs.Add(this.led18);
            this.BusLEDDisplay.LEDs.Add(this.led106);
            this.BusLEDDisplay.LEDs.Add(this.led107);
            this.BusLEDDisplay.LEDs.Add(this.led108);
            this.BusLEDDisplay.LEDs.Add(this.led109);
            this.BusLEDDisplay.LEDs.Add(this.led110);
            this.BusLEDDisplay.LEDs.Add(this.led111);
            this.BusLEDDisplay.LEDs.Add(this.led112);
            this.BusLEDDisplay.LEDs.Add(this.led113);
            this.BusLEDDisplay.LEDSpacing = 2;
            this.BusLEDDisplay.Location = new System.Drawing.Point(5, 18);
            this.BusLEDDisplay.Name = "BusLEDDisplay";
            this.BusLEDDisplay.NibbleSpacing = 2;
            this.BusLEDDisplay.Size = new System.Drawing.Size(204, 16);
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
            // led106
            // 
            this.led106.LEDColor = System.Drawing.Color.Red;
            this.led106.Location = new System.Drawing.Point(103, 3);
            this.led106.Name = "led106";
            this.led106.Size = new System.Drawing.Size(11, 11);
            this.led106.TabIndex = 8;
            // 
            // led107
            // 
            this.led107.LEDColor = System.Drawing.Color.Red;
            this.led107.Location = new System.Drawing.Point(115, 3);
            this.led107.Name = "led107";
            this.led107.Size = new System.Drawing.Size(11, 11);
            this.led107.TabIndex = 9;
            // 
            // led108
            // 
            this.led108.LEDColor = System.Drawing.Color.Red;
            this.led108.Location = new System.Drawing.Point(127, 3);
            this.led108.Name = "led108";
            this.led108.Size = new System.Drawing.Size(11, 11);
            this.led108.TabIndex = 10;
            // 
            // led109
            // 
            this.led109.LEDColor = System.Drawing.Color.Red;
            this.led109.Location = new System.Drawing.Point(139, 3);
            this.led109.Name = "led109";
            this.led109.Size = new System.Drawing.Size(11, 11);
            this.led109.TabIndex = 11;
            // 
            // led110
            // 
            this.led110.LEDColor = System.Drawing.Color.Red;
            this.led110.Location = new System.Drawing.Point(153, 3);
            this.led110.Name = "led110";
            this.led110.Size = new System.Drawing.Size(11, 11);
            this.led110.TabIndex = 12;
            // 
            // led111
            // 
            this.led111.LEDColor = System.Drawing.Color.Red;
            this.led111.Location = new System.Drawing.Point(165, 3);
            this.led111.Name = "led111";
            this.led111.Size = new System.Drawing.Size(11, 11);
            this.led111.TabIndex = 13;
            // 
            // led112
            // 
            this.led112.LEDColor = System.Drawing.Color.Red;
            this.led112.Location = new System.Drawing.Point(177, 3);
            this.led112.Name = "led112";
            this.led112.Size = new System.Drawing.Size(11, 11);
            this.led112.TabIndex = 14;
            // 
            // led113
            // 
            this.led113.LEDColor = System.Drawing.Color.Red;
            this.led113.Location = new System.Drawing.Point(189, 3);
            this.led113.Name = "led113";
            this.led113.Size = new System.Drawing.Size(11, 11);
            this.led113.TabIndex = 15;
            // 
            // SRArrow
            // 
            this.SRArrow.ArrowLength = 35;
            this.SRArrow.ArrowPointingDirection = SAPEmulator.AppCode.Visual.DoubleEndedArrow.Direction.None;
            this.SRArrow.CapLNumber = 'F';
            this.SRArrow.CapRNumber = 'F';
            this.SRArrow.Location = new System.Drawing.Point(318, 333);
            this.SRArrow.Name = "SRArrow";
            this.SRArrow.OffColorBorder = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.SRArrow.OffColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.SRArrow.OnLColorBorder = System.Drawing.Color.Red;
            this.SRArrow.OnLColorFill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SRArrow.OnRColorBorder = System.Drawing.Color.DarkGreen;
            this.SRArrow.OnRColorFill = System.Drawing.Color.LightGreen;
            this.SRArrow.Size = new System.Drawing.Size(73, 19);
            this.SRArrow.TabIndex = 185;
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
            // led193
            // 
            this.led193.LEDColor = System.Drawing.Color.Blue;
            this.led193.Location = new System.Drawing.Point(63, 3);
            this.led193.Name = "led193";
            this.led193.Size = new System.Drawing.Size(11, 11);
            this.led193.TabIndex = 4;
            // 
            // rLabel26
            // 
            this.rLabel26.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel26.Location = new System.Drawing.Point(248, 90);
            this.rLabel26.Name = "rLabel26";
            this.rLabel26.RotationAngle = 90D;
            this.rLabel26.Size = new System.Drawing.Size(15, 25);
            this.rLabel26.TabIndex = 157;
            this.rLabel26.Text = "MDR";
            this.rLabel26.TopLine = false;
            // 
            // Sap2SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 595);
            this.Controls.Add(this.SRGroup);
            this.Controls.Add(this.TempRegArrow);
            this.Controls.Add(this.MARArrow);
            this.Controls.Add(this.MDRArrow);
            this.Controls.Add(this.RAMArrow);
            this.Controls.Add(this.PCArrow);
            this.Controls.Add(this.CRegArrow);
            this.Controls.Add(this.BRegArrow);
            this.Controls.Add(this.ARegArrow);
            this.Controls.Add(this.FlagRegArrowIn);
            this.Controls.Add(this.InstArrowIn);
            this.Controls.Add(this.SUMArrowOut);
            this.Controls.Add(this.OutputRegArrowIn);
            this.Controls.Add(this.CRegGroup);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.TempRegGroup);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.PCGroup);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.SRArrow);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Sap2SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAP2 Computer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyAdjust)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RAMGridView)).EndInit();
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
            this.TempRegGroup.ResumeLayout(false);
            this.TempRegGroup.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.CRegGroup.ResumeLayout(false);
            this.CRegGroup.PerformLayout();
            this.SRGroup.ResumeLayout(false);
            this.SRGroup.PerformLayout();
            this.SRLEDDisplay.ResumeLayout(false);
            this.CRegLEDDisplay.ResumeLayout(false);
            this.MDRLEDDisplay.ResumeLayout(false);
            this.TempRegLEDDisplay.ResumeLayout(false);
            this.CLDecodedLEDDisplay.ResumeLayout(false);
            this.MICounterLEDDisplay.ResumeLayout(false);
            this.InstRegLEDDisplay.ResumeLayout(false);
            this.RAMLEDDisplay.ResumeLayout(false);
            this.MARLEDDisplay.ResumeLayout(false);
            this.StatusLEDDsiaply2.ResumeLayout(false);
            this.StatusLEDDsiaply1.ResumeLayout(false);
            this.OutputRegLEDDisplay.ResumeLayout(false);
            this.BRegLEDDisplay.ResumeLayout(false);
            this.FlagRegLEDDisplay.ResumeLayout(false);
            this.SumRegLEDDisplay.ResumeLayout(false);
            this.SumFlagsLEDDisplay.ResumeLayout(false);
            this.ARegLEDDisplay.ResumeLayout(false);
            this.PCLEDDisplay.ResumeLayout(false);
            this.BusLEDDisplay.ResumeLayout(false);
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
        private AppCode.Visual.LEDDisplay StatusLEDDsiaply1;
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
        private AppCode.Visual.RLabel rLabel11;
        private AppCode.Visual.RLabel rLabel12;
        private AppCode.Visual.RLabel rLabel13;
        private AppCode.Visual.RLabel rLabel14;
        private AppCode.Visual.RLabel rLabel15;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox PCGroup;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox ARegGroup;
        private System.Windows.Forms.GroupBox SumGroup;
        private System.Windows.Forms.GroupBox FlagsGroup;
        private System.Windows.Forms.GroupBox BRegGroup;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox MARGroup;
        private System.Windows.Forms.GroupBox RAMGroup;
        private System.Windows.Forms.GroupBox InstGroup;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppCode.Visual.Arrow OutputRegArrowIn;
        private AppCode.Visual.Arrow InstArrowIn;
        private System.Windows.Forms.Label label1;
        private AppCode.Visual.LED PCIncLED;
        private AppCode.Visual.LED ClkLed;
        private System.Windows.Forms.Button OpenAssemblerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer ScreenUpdateTimer;
        private AppCode.Visual.LED led1;
        private AppCode.Visual.LED led95;
        private AppCode.Visual.LED led96;
        private AppCode.Visual.LED led97;
        private AppCode.Visual.LED led98;
        private AppCode.Visual.LED led99;
        private AppCode.Visual.LED led100;
        private AppCode.Visual.LED led101;
        private AppCode.Visual.LED led102;
        private AppCode.Visual.LED led103;
        private AppCode.Visual.LED led104;
        private AppCode.Visual.LED led105;
        private AppCode.Visual.LED led106;
        private AppCode.Visual.LED led107;
        private AppCode.Visual.LED led108;
        private AppCode.Visual.LED led109;
        private AppCode.Visual.LED led110;
        private AppCode.Visual.LED led111;
        private AppCode.Visual.LED led112;
        private AppCode.Visual.LED led113;
        private AppCode.Visual.LED led114;
        private AppCode.Visual.LED led115;
        private AppCode.Visual.LED led116;
        private AppCode.Visual.LED led117;
        private AppCode.Visual.LED led118;
        private AppCode.Visual.LED led119;
        private AppCode.Visual.LED led120;
        private AppCode.Visual.LED led121;
        private AppCode.Visual.LED led122;
        private AppCode.Visual.LED led123;
        private AppCode.Visual.LED led124;
        private AppCode.Visual.LED led125;
        private System.Windows.Forms.GroupBox TempRegGroup;
        private AppCode.Visual.LEDDisplay TempRegLEDDisplay;
        private AppCode.Visual.LED led126;
        private AppCode.Visual.LED led127;
        private AppCode.Visual.LED led128;
        private AppCode.Visual.LED led129;
        private AppCode.Visual.LED led130;
        private AppCode.Visual.LED led131;
        private AppCode.Visual.LED led132;
        private AppCode.Visual.LED led133;
        private System.Windows.Forms.Label TempRegValLbl;
        private System.Windows.Forms.GroupBox groupBox7;
        private AppCode.Visual.LEDDisplay MDRLEDDisplay;
        private AppCode.Visual.LED led134;
        private AppCode.Visual.LED led135;
        private AppCode.Visual.LED led136;
        private AppCode.Visual.LED led137;
        private AppCode.Visual.LED led138;
        private AppCode.Visual.LED led139;
        private AppCode.Visual.LED led140;
        private AppCode.Visual.LED led141;
        private System.Windows.Forms.Label MDRRegValLbl;
        private AppCode.Visual.LED led142;
        private AppCode.Visual.LED led143;
        private AppCode.Visual.LED led144;
        private AppCode.Visual.LED led145;
        private AppCode.Visual.LED led146;
        private AppCode.Visual.LED led147;
        private AppCode.Visual.LED led148;
        private AppCode.Visual.LED led149;
        private System.Windows.Forms.Button RefreshRamView;
        private AppCode.Visual.RLabel rLabel28;
        private AppCode.Visual.RLabel rLabel29;
        private AppCode.Visual.RLabel rLabel30;
        private AppCode.Visual.RLabel rLabel31;
        private AppCode.Visual.RLabel rLabel32;
        private AppCode.Visual.RLabel rLabel33;
        private AppCode.Visual.RLabel rLabel34;
        private AppCode.Visual.RLabel rLabel37;
        private AppCode.Visual.RLabel rLabel38;
        private AppCode.Visual.RLabel rLabel39;
        private AppCode.Visual.RLabel rLabel40;
        private AppCode.Visual.LEDDisplay StatusLEDDsiaply2;
        private AppCode.Visual.LED led150;
        private AppCode.Visual.LED led151;
        private AppCode.Visual.LED led152;
        private AppCode.Visual.LED led153;
        private AppCode.Visual.LED led154;
        private AppCode.Visual.LED led155;
        private AppCode.Visual.LED led156;
        private AppCode.Visual.LED led157;
        private AppCode.Visual.LED led158;
        private AppCode.Visual.LED led159;
        private AppCode.Visual.LED led160;
        private AppCode.Visual.LED led161;
        private AppCode.Visual.LED led162;
        private AppCode.Visual.LED led163;
        private AppCode.Visual.LED led164;
        private AppCode.Visual.LED led165;
        private AppCode.Visual.LED led166;
        private AppCode.Visual.LED led167;
        private AppCode.Visual.LED led168;
        private AppCode.Visual.LED led169;
        private AppCode.Visual.LED led170;
        private AppCode.Visual.LED led171;
        private AppCode.Visual.LED led172;
        private AppCode.Visual.LED led173;
        private AppCode.Visual.LED led174;
        private AppCode.Visual.LED led175;
        private AppCode.Visual.LED led176;
        private AppCode.Visual.LED led177;
        private AppCode.Visual.LED led178;
        private AppCode.Visual.LED led179;
        private AppCode.Visual.LED led180;
        private System.Windows.Forms.GroupBox CRegGroup;
        private System.Windows.Forms.Label CRegValLbl;
        private AppCode.Visual.LEDDisplay CRegLEDDisplay;
        private AppCode.Visual.LED led181;
        private AppCode.Visual.LED led182;
        private AppCode.Visual.LED led183;
        private AppCode.Visual.LED led184;
        private AppCode.Visual.LED led185;
        private AppCode.Visual.LED led186;
        private AppCode.Visual.LED led187;
        private AppCode.Visual.LED led188;
        private AppCode.Visual.LED led193;
        private AppCode.Visual.RLabel rLabel10;
        private AppCode.Visual.RLabel rLabel35;
        private AppCode.Visual.RLabel rLabel41;
        private AppCode.Visual.RLabel rLabel54;
        private AppCode.Visual.RLabel rLabel52;
        private AppCode.Visual.RLabel rLabel47;
        private AppCode.Visual.RLabel rLabel53;
        private AppCode.Visual.RLabel rLabel48;
        private AppCode.Visual.RLabel rLabel49;
        private AppCode.Visual.RLabel rLabel50;
        private AppCode.Visual.RLabel rLabel51;
        private AppCode.Visual.RLabel rLabel57;
        private AppCode.Visual.RLabel rLabel58;
        private AppCode.Visual.RLabel rLabel59;
        private AppCode.Visual.RLabel rLabel60;
        private AppCode.Visual.RLabel rLabel61;
        private System.Windows.Forms.Label InstructionLBL;
        private AppCode.Visual.Arrow FlagRegArrowIn;
        private AppCode.Visual.Arrow SUMArrowOut;
        private AppCode.Visual.DoubleEndedArrow ARegArrow;
        private AppCode.Visual.DoubleEndedArrow BRegArrow;
        private AppCode.Visual.DoubleEndedArrow CRegArrow;
        private AppCode.Visual.DoubleEndedArrow PCArrow;
        private AppCode.Visual.DoubleEndedArrow RAMArrow;
        private AppCode.Visual.DoubleEndedArrow MDRArrow;
        private System.Windows.Forms.Label ClkCounterLBL;
        private System.Windows.Forms.Label SWLbl;
        private System.Windows.Forms.DataGridView RAMGridView;
        private System.Windows.Forms.CheckBox UpdateRAMViewCB;
        private AppCode.Visual.DoubleEndedArrow MARArrow;
        private AppCode.Visual.DoubleEndedArrow TempRegArrow;
        private System.Windows.Forms.CheckBox AnimationCB;
        private System.Windows.Forms.Button LoadBinFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AppCode.Visual.RLabel rLabel42;
        private AppCode.Visual.LED led189;
        private AppCode.Visual.LED led190;
        private AppCode.Visual.RLabel rLabel43;
        private System.Windows.Forms.GroupBox SRGroup;
        private System.Windows.Forms.Label label4;
        private AppCode.Visual.LED SRIncLED;
        private System.Windows.Forms.Label label2;
        private AppCode.Visual.LED SRDecLED;
        private System.Windows.Forms.Label SRRegValLbl;
        private AppCode.Visual.LEDDisplay SRLEDDisplay;
        private AppCode.Visual.LED led192;
        private AppCode.Visual.LED led194;
        private AppCode.Visual.LED led195;
        private AppCode.Visual.LED led196;
        private AppCode.Visual.LED led197;
        private AppCode.Visual.LED led198;
        private AppCode.Visual.LED led199;
        private AppCode.Visual.LED led200;
        private AppCode.Visual.LED led201;
        private AppCode.Visual.LED led202;
        private AppCode.Visual.LED led203;
        private AppCode.Visual.LED led204;
        private AppCode.Visual.LED led205;
        private AppCode.Visual.LED led206;
        private AppCode.Visual.LED led207;
        private AppCode.Visual.LED led208;
        private AppCode.Visual.DoubleEndedArrow SRArrow;
        private AppCode.Visual.RLabel rLabel46;
        private AppCode.Visual.RLabel rLabel45;
        private AppCode.Visual.RLabel rLabel44;
        private AppCode.Visual.RLabel rLabel36;
        private AppCode.Visual.LED led67;
        private AppCode.Visual.LED led221;
        private AppCode.Visual.LED led211;
        private AppCode.Visual.LED led212;
        private AppCode.Visual.LED led213;
        private AppCode.Visual.RLabel rLabel55;
        private AppCode.Visual.RLabel rLabel56;
        private AppCode.Visual.RLabel rLabel26;
    }
}

