namespace sed1330_configurer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cmPort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPortRefreshList = new System.Windows.Forms.ToolStripMenuItem();
            this.miPortListDetailed = new System.Windows.Forms.ToolStripMenuItem();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.eCon = new System.Windows.Forms.TextBox();
            this.cmCon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiClearCon = new System.Windows.Forms.ToolStripMenuItem();
            this.eSend = new System.Windows.Forms.TextBox();
            this.bOpen = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.Port1 = new System.IO.Ports.SerialPort(this.components);
            this.cbCR = new System.Windows.Forms.CheckBox();
            this.cbLF = new System.Windows.Forms.CheckBox();
            this.bSendDEC = new System.Windows.Forms.Button();
            this.bSendHEX = new System.Windows.Forms.Button();
            this.eCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eChar = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbAddSent = new System.Windows.Forms.CheckBox();
            this.cbHexRead = new System.Windows.Forms.CheckBox();
            this.cbC40bDR = new System.Windows.Forms.CheckBox();
            this.cbC40bTL = new System.Windows.Forms.CheckBox();
            this.cbC40bIV = new System.Windows.Forms.CheckBox();
            this.cbC40bWS = new System.Windows.Forms.CheckBox();
            this.cbC40bM2 = new System.Windows.Forms.CheckBox();
            this.cbC40bM1 = new System.Windows.Forms.CheckBox();
            this.cbC40bM0 = new System.Windows.Forms.CheckBox();
            this.cbC40bWF = new System.Windows.Forms.CheckBox();
            this.eC40FX = new System.Windows.Forms.NumericUpDown();
            this.eC40FY = new System.Windows.Forms.NumericUpDown();
            this.eC40CR = new System.Windows.Forms.NumericUpDown();
            this.eC40TCR = new System.Windows.Forms.NumericUpDown();
            this.eC40LF = new System.Windows.Forms.NumericUpDown();
            this.eC40AP = new System.Windows.Forms.NumericUpDown();
            this.eC44SL1SL2 = new System.Windows.Forms.NumericUpDown();
            this.eC5AD2_0 = new System.Windows.Forms.NumericUpDown();
            this.bCalcHexCmd5A = new System.Windows.Forms.Button();
            this.bCalcHexCmd44 = new System.Windows.Forms.Button();
            this.bCalcHexCmd40 = new System.Windows.Forms.Button();
            this.bMakeConfigStr = new System.Windows.Forms.Button();
            this.cbDispDual = new System.Windows.Forms.CheckBox();
            this.bDispDoMath = new System.Windows.Forms.Button();
            this.eSEDXTALkHz = new System.Windows.Forms.NumericUpDown();
            this.eSEDFFR = new System.Windows.Forms.NumericUpDown();
            this.lbLoadConf = new System.Windows.Forms.ListBox();
            this.cmPresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miPresetsLoadSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.miPresetsSaveCurrentConf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miReloadPresetFile = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eC40Hex7 = new System.Windows.Forms.TextBox();
            this.eC40Hex8 = new System.Windows.Forms.TextBox();
            this.eC40Hex6 = new System.Windows.Forms.TextBox();
            this.eC40Hex5 = new System.Windows.Forms.TextBox();
            this.eC40Hex4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.eC40Hex3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eC40Hex2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eC40Hex1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eC44Hex36 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eC5AHex1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.eDispX = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.eDispY = new System.Windows.Forms.NumericUpDown();
            this.bDispInfoCreate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.cmPort.SuspendLayout();
            this.cmCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eC40FX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40FY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40CR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40TCR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40LF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40AP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC44SL1SL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC5AD2_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSEDXTALkHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSEDFFR)).BeginInit();
            this.cmPresets.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDispX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDispY)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbPort
            // 
            this.cbPort.ContextMenuStrip = this.cmPort;
            this.cbPort.FormattingEnabled = true;
            resources.ApplyResources(this.cbPort, "cbPort");
            this.cbPort.Name = "cbPort";
            this.cbPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPort_KeyDown);
            // 
            // cmPort
            // 
            this.cmPort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPortRefreshList,
            this.miPortListDetailed});
            this.cmPort.Name = "cmPort";
            resources.ApplyResources(this.cmPort, "cmPort");
            // 
            // cmiPortRefreshList
            // 
            this.cmiPortRefreshList.Name = "cmiPortRefreshList";
            resources.ApplyResources(this.cmiPortRefreshList, "cmiPortRefreshList");
            this.cmiPortRefreshList.Click += new System.EventHandler(this.cmiPortRefreshList_Click);
            // 
            // miPortListDetailed
            // 
            this.miPortListDetailed.Name = "miPortListDetailed";
            resources.ApplyResources(this.miPortListDetailed, "miPortListDetailed");
            this.miPortListDetailed.Click += new System.EventHandler(this.miPortListDetailed_Click);
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            resources.ApplyResources(this.cbBaud, "cbBaud");
            this.cbBaud.Name = "cbBaud";
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.FormattingEnabled = true;
            resources.ApplyResources(this.cbDataBits, "cbDataBits");
            this.cbDataBits.Name = "cbDataBits";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            resources.ApplyResources(this.cbParity, "cbParity");
            this.cbParity.Name = "cbParity";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.FormattingEnabled = true;
            resources.ApplyResources(this.cbStopBits, "cbStopBits");
            this.cbStopBits.Name = "cbStopBits";
            // 
            // eCon
            // 
            resources.ApplyResources(this.eCon, "eCon");
            this.eCon.ContextMenuStrip = this.cmCon;
            this.eCon.Name = "eCon";
            this.eCon.ReadOnly = true;
            this.eCon.TabStop = false;
            // 
            // cmCon
            // 
            this.cmCon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiClearCon});
            this.cmCon.Name = "cmCon";
            resources.ApplyResources(this.cmCon, "cmCon");
            // 
            // cmiClearCon
            // 
            this.cmiClearCon.Name = "cmiClearCon";
            resources.ApplyResources(this.cmiClearCon, "cmiClearCon");
            this.cmiClearCon.Click += new System.EventHandler(this.cmiClearCon_Click);
            // 
            // eSend
            // 
            resources.ApplyResources(this.eSend, "eSend");
            this.eSend.Name = "eSend";
            this.eSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eSend_KeyDown);
            this.eSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.eSend_KeyUp);
            // 
            // bOpen
            // 
            resources.ApplyResources(this.bOpen, "bOpen");
            this.bOpen.Name = "bOpen";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bClose
            // 
            resources.ApplyResources(this.bClose, "bClose");
            this.bClose.Name = "bClose";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSend
            // 
            resources.ApplyResources(this.bSend, "bSend");
            this.bSend.Name = "bSend";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // Port1
            // 
            this.Port1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port1_DataReceived);
            // 
            // cbCR
            // 
            resources.ApplyResources(this.cbCR, "cbCR");
            this.cbCR.Name = "cbCR";
            this.cbCR.UseVisualStyleBackColor = true;
            this.cbCR.Click += new System.EventHandler(this.cbCR_Click);
            // 
            // cbLF
            // 
            resources.ApplyResources(this.cbLF, "cbLF");
            this.cbLF.Name = "cbLF";
            this.cbLF.UseVisualStyleBackColor = true;
            this.cbLF.Click += new System.EventHandler(this.cbLF_Click);
            // 
            // bSendDEC
            // 
            resources.ApplyResources(this.bSendDEC, "bSendDEC");
            this.bSendDEC.Name = "bSendDEC";
            this.bSendDEC.UseVisualStyleBackColor = true;
            this.bSendDEC.Click += new System.EventHandler(this.bSendDEC_Click);
            // 
            // bSendHEX
            // 
            resources.ApplyResources(this.bSendHEX, "bSendHEX");
            this.bSendHEX.Name = "bSendHEX";
            this.bSendHEX.UseVisualStyleBackColor = true;
            this.bSendHEX.Click += new System.EventHandler(this.bSendHEX_Click);
            // 
            // eCount
            // 
            resources.ApplyResources(this.eCount, "eCount");
            this.eCount.Name = "eCount";
            this.eCount.ReadOnly = true;
            this.eCount.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // eChar
            // 
            resources.ApplyResources(this.eChar, "eChar");
            this.eChar.Name = "eChar";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cbAddSent
            // 
            resources.ApplyResources(this.cbAddSent, "cbAddSent");
            this.cbAddSent.Name = "cbAddSent";
            this.toolTip1.SetToolTip(this.cbAddSent, resources.GetString("cbAddSent.ToolTip"));
            this.cbAddSent.UseVisualStyleBackColor = true;
            // 
            // cbHexRead
            // 
            resources.ApplyResources(this.cbHexRead, "cbHexRead");
            this.cbHexRead.Name = "cbHexRead";
            this.toolTip1.SetToolTip(this.cbHexRead, resources.GetString("cbHexRead.ToolTip"));
            this.cbHexRead.UseVisualStyleBackColor = true;
            // 
            // cbC40bDR
            // 
            resources.ApplyResources(this.cbC40bDR, "cbC40bDR");
            this.cbC40bDR.Name = "cbC40bDR";
            this.toolTip1.SetToolTip(this.cbC40bDR, resources.GetString("cbC40bDR.ToolTip"));
            this.cbC40bDR.UseVisualStyleBackColor = true;
            // 
            // cbC40bTL
            // 
            resources.ApplyResources(this.cbC40bTL, "cbC40bTL");
            this.cbC40bTL.Name = "cbC40bTL";
            this.toolTip1.SetToolTip(this.cbC40bTL, resources.GetString("cbC40bTL.ToolTip"));
            this.cbC40bTL.UseVisualStyleBackColor = true;
            // 
            // cbC40bIV
            // 
            resources.ApplyResources(this.cbC40bIV, "cbC40bIV");
            this.cbC40bIV.Name = "cbC40bIV";
            this.toolTip1.SetToolTip(this.cbC40bIV, resources.GetString("cbC40bIV.ToolTip"));
            this.cbC40bIV.UseVisualStyleBackColor = true;
            // 
            // cbC40bWS
            // 
            resources.ApplyResources(this.cbC40bWS, "cbC40bWS");
            this.cbC40bWS.Name = "cbC40bWS";
            this.toolTip1.SetToolTip(this.cbC40bWS, resources.GetString("cbC40bWS.ToolTip"));
            this.cbC40bWS.UseVisualStyleBackColor = true;
            // 
            // cbC40bM2
            // 
            resources.ApplyResources(this.cbC40bM2, "cbC40bM2");
            this.cbC40bM2.Name = "cbC40bM2";
            this.toolTip1.SetToolTip(this.cbC40bM2, resources.GetString("cbC40bM2.ToolTip"));
            this.cbC40bM2.UseVisualStyleBackColor = true;
            // 
            // cbC40bM1
            // 
            resources.ApplyResources(this.cbC40bM1, "cbC40bM1");
            this.cbC40bM1.Name = "cbC40bM1";
            this.toolTip1.SetToolTip(this.cbC40bM1, resources.GetString("cbC40bM1.ToolTip"));
            this.cbC40bM1.UseVisualStyleBackColor = true;
            // 
            // cbC40bM0
            // 
            resources.ApplyResources(this.cbC40bM0, "cbC40bM0");
            this.cbC40bM0.Name = "cbC40bM0";
            this.toolTip1.SetToolTip(this.cbC40bM0, resources.GetString("cbC40bM0.ToolTip"));
            this.cbC40bM0.UseVisualStyleBackColor = true;
            // 
            // cbC40bWF
            // 
            resources.ApplyResources(this.cbC40bWF, "cbC40bWF");
            this.cbC40bWF.Name = "cbC40bWF";
            this.toolTip1.SetToolTip(this.cbC40bWF, resources.GetString("cbC40bWF.ToolTip"));
            this.cbC40bWF.UseVisualStyleBackColor = true;
            // 
            // eC40FX
            // 
            resources.ApplyResources(this.eC40FX, "eC40FX");
            this.eC40FX.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.eC40FX.Name = "eC40FX";
            this.toolTip1.SetToolTip(this.eC40FX, resources.GetString("eC40FX.ToolTip"));
            // 
            // eC40FY
            // 
            resources.ApplyResources(this.eC40FY, "eC40FY");
            this.eC40FY.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.eC40FY.Name = "eC40FY";
            this.toolTip1.SetToolTip(this.eC40FY, resources.GetString("eC40FY.ToolTip"));
            this.eC40FY.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // eC40CR
            // 
            resources.ApplyResources(this.eC40CR, "eC40CR");
            this.eC40CR.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            0});
            this.eC40CR.Name = "eC40CR";
            this.toolTip1.SetToolTip(this.eC40CR, resources.GetString("eC40CR.ToolTip"));
            // 
            // eC40TCR
            // 
            resources.ApplyResources(this.eC40TCR, "eC40TCR");
            this.eC40TCR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.eC40TCR.Name = "eC40TCR";
            this.toolTip1.SetToolTip(this.eC40TCR, resources.GetString("eC40TCR.ToolTip"));
            // 
            // eC40LF
            // 
            resources.ApplyResources(this.eC40LF, "eC40LF");
            this.eC40LF.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.eC40LF.Name = "eC40LF";
            this.toolTip1.SetToolTip(this.eC40LF, resources.GetString("eC40LF.ToolTip"));
            // 
            // eC40AP
            // 
            resources.ApplyResources(this.eC40AP, "eC40AP");
            this.eC40AP.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.eC40AP.Name = "eC40AP";
            this.toolTip1.SetToolTip(this.eC40AP, resources.GetString("eC40AP.ToolTip"));
            // 
            // eC44SL1SL2
            // 
            resources.ApplyResources(this.eC44SL1SL2, "eC44SL1SL2");
            this.eC44SL1SL2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.eC44SL1SL2.Name = "eC44SL1SL2";
            this.toolTip1.SetToolTip(this.eC44SL1SL2, resources.GetString("eC44SL1SL2.ToolTip"));
            // 
            // eC5AD2_0
            // 
            resources.ApplyResources(this.eC5AD2_0, "eC5AD2_0");
            this.eC5AD2_0.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.eC5AD2_0.Name = "eC5AD2_0";
            this.toolTip1.SetToolTip(this.eC5AD2_0, resources.GetString("eC5AD2_0.ToolTip"));
            // 
            // bCalcHexCmd5A
            // 
            this.bCalcHexCmd5A.Image = global::sed1330_configurer.Properties.Resources.quickopen;
            resources.ApplyResources(this.bCalcHexCmd5A, "bCalcHexCmd5A");
            this.bCalcHexCmd5A.Name = "bCalcHexCmd5A";
            this.toolTip1.SetToolTip(this.bCalcHexCmd5A, resources.GetString("bCalcHexCmd5A.ToolTip"));
            this.bCalcHexCmd5A.UseVisualStyleBackColor = true;
            this.bCalcHexCmd5A.Click += new System.EventHandler(this.bCalcHexCmd5A_Click);
            // 
            // bCalcHexCmd44
            // 
            this.bCalcHexCmd44.Image = global::sed1330_configurer.Properties.Resources.quickopen;
            resources.ApplyResources(this.bCalcHexCmd44, "bCalcHexCmd44");
            this.bCalcHexCmd44.Name = "bCalcHexCmd44";
            this.toolTip1.SetToolTip(this.bCalcHexCmd44, resources.GetString("bCalcHexCmd44.ToolTip"));
            this.bCalcHexCmd44.UseVisualStyleBackColor = true;
            this.bCalcHexCmd44.Click += new System.EventHandler(this.bCalcHexCmd44_Click);
            // 
            // bCalcHexCmd40
            // 
            this.bCalcHexCmd40.Image = global::sed1330_configurer.Properties.Resources.quickopen;
            resources.ApplyResources(this.bCalcHexCmd40, "bCalcHexCmd40");
            this.bCalcHexCmd40.Name = "bCalcHexCmd40";
            this.toolTip1.SetToolTip(this.bCalcHexCmd40, resources.GetString("bCalcHexCmd40.ToolTip"));
            this.bCalcHexCmd40.UseVisualStyleBackColor = true;
            this.bCalcHexCmd40.Click += new System.EventHandler(this.bCalcHexCmd40_Click);
            // 
            // bMakeConfigStr
            // 
            this.bMakeConfigStr.Image = global::sed1330_configurer.Properties.Resources.quickopen;
            resources.ApplyResources(this.bMakeConfigStr, "bMakeConfigStr");
            this.bMakeConfigStr.Name = "bMakeConfigStr";
            this.toolTip1.SetToolTip(this.bMakeConfigStr, resources.GetString("bMakeConfigStr.ToolTip"));
            this.bMakeConfigStr.UseVisualStyleBackColor = true;
            this.bMakeConfigStr.Click += new System.EventHandler(this.bMakeConfigStr_Click);
            // 
            // cbDispDual
            // 
            resources.ApplyResources(this.cbDispDual, "cbDispDual");
            this.cbDispDual.Name = "cbDispDual";
            this.toolTip1.SetToolTip(this.cbDispDual, resources.GetString("cbDispDual.ToolTip"));
            this.cbDispDual.UseVisualStyleBackColor = true;
            // 
            // bDispDoMath
            // 
            resources.ApplyResources(this.bDispDoMath, "bDispDoMath");
            this.bDispDoMath.Name = "bDispDoMath";
            this.toolTip1.SetToolTip(this.bDispDoMath, resources.GetString("bDispDoMath.ToolTip"));
            this.bDispDoMath.UseVisualStyleBackColor = true;
            this.bDispDoMath.Click += new System.EventHandler(this.bDispDoMath_Click);
            // 
            // eSEDXTALkHz
            // 
            resources.ApplyResources(this.eSEDXTALkHz, "eSEDXTALkHz");
            this.eSEDXTALkHz.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.eSEDXTALkHz.Name = "eSEDXTALkHz";
            this.toolTip1.SetToolTip(this.eSEDXTALkHz, resources.GetString("eSEDXTALkHz.ToolTip"));
            this.eSEDXTALkHz.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // eSEDFFR
            // 
            resources.ApplyResources(this.eSEDFFR, "eSEDFFR");
            this.eSEDFFR.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.eSEDFFR.Name = "eSEDFFR";
            this.toolTip1.SetToolTip(this.eSEDFFR, resources.GetString("eSEDFFR.ToolTip"));
            this.eSEDFFR.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbLoadConf
            // 
            this.lbLoadConf.ContextMenuStrip = this.cmPresets;
            this.lbLoadConf.FormattingEnabled = true;
            resources.ApplyResources(this.lbLoadConf, "lbLoadConf");
            this.lbLoadConf.Name = "lbLoadConf";
            this.toolTip1.SetToolTip(this.lbLoadConf, resources.GetString("lbLoadConf.ToolTip"));
            this.lbLoadConf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLoadConf_MouseDoubleClick);
            // 
            // cmPresets
            // 
            this.cmPresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPresetsLoadSelected,
            this.miPresetsSaveCurrentConf,
            this.toolStripMenuItem1,
            this.miReloadPresetFile});
            this.cmPresets.Name = "cmPresets";
            resources.ApplyResources(this.cmPresets, "cmPresets");
            // 
            // miPresetsLoadSelected
            // 
            this.miPresetsLoadSelected.Name = "miPresetsLoadSelected";
            resources.ApplyResources(this.miPresetsLoadSelected, "miPresetsLoadSelected");
            this.miPresetsLoadSelected.Click += new System.EventHandler(this.miPresetsLoadSelected_Click);
            // 
            // miPresetsSaveCurrentConf
            // 
            this.miPresetsSaveCurrentConf.Name = "miPresetsSaveCurrentConf";
            resources.ApplyResources(this.miPresetsSaveCurrentConf, "miPresetsSaveCurrentConf");
            this.miPresetsSaveCurrentConf.Click += new System.EventHandler(this.miPresetsSaveCurrentConf_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // miReloadPresetFile
            // 
            this.miReloadPresetFile.Name = "miReloadPresetFile";
            resources.ApplyResources(this.miReloadPresetFile, "miReloadPresetFile");
            this.miReloadPresetFile.Click += new System.EventHandler(this.miReloadPresetFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // sStatus
            // 
            this.sStatus.Name = "sStatus";
            resources.ApplyResources(this.sStatus, "sStatus");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCalcHexCmd40);
            this.groupBox1.Controls.Add(this.eC40Hex7);
            this.groupBox1.Controls.Add(this.eC40Hex8);
            this.groupBox1.Controls.Add(this.eC40Hex6);
            this.groupBox1.Controls.Add(this.eC40Hex5);
            this.groupBox1.Controls.Add(this.eC40Hex4);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.eC40AP);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.eC40LF);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.eC40TCR);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.eC40CR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.eC40Hex3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.eC40FY);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.eC40FX);
            this.groupBox1.Controls.Add(this.eC40Hex2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbC40bWF);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.eC40Hex1);
            this.groupBox1.Controls.Add(this.cbC40bM0);
            this.groupBox1.Controls.Add(this.cbC40bM1);
            this.groupBox1.Controls.Add(this.cbC40bM2);
            this.groupBox1.Controls.Add(this.cbC40bWS);
            this.groupBox1.Controls.Add(this.cbC40bIV);
            this.groupBox1.Controls.Add(this.cbC40bTL);
            this.groupBox1.Controls.Add(this.cbC40bDR);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // eC40Hex7
            // 
            resources.ApplyResources(this.eC40Hex7, "eC40Hex7");
            this.eC40Hex7.Name = "eC40Hex7";
            // 
            // eC40Hex8
            // 
            resources.ApplyResources(this.eC40Hex8, "eC40Hex8");
            this.eC40Hex8.Name = "eC40Hex8";
            // 
            // eC40Hex6
            // 
            resources.ApplyResources(this.eC40Hex6, "eC40Hex6");
            this.eC40Hex6.Name = "eC40Hex6";
            // 
            // eC40Hex5
            // 
            resources.ApplyResources(this.eC40Hex5, "eC40Hex5");
            this.eC40Hex5.Name = "eC40Hex5";
            // 
            // eC40Hex4
            // 
            resources.ApplyResources(this.eC40Hex4, "eC40Hex4");
            this.eC40Hex4.Name = "eC40Hex4";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // eC40Hex3
            // 
            resources.ApplyResources(this.eC40Hex3, "eC40Hex3");
            this.eC40Hex3.Name = "eC40Hex3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // eC40Hex2
            // 
            resources.ApplyResources(this.eC40Hex2, "eC40Hex2");
            this.eC40Hex2.Name = "eC40Hex2";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // eC40Hex1
            // 
            resources.ApplyResources(this.eC40Hex1, "eC40Hex1");
            this.eC40Hex1.Name = "eC40Hex1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCalcHexCmd44);
            this.groupBox2.Controls.Add(this.eC44Hex36);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.eC44SL1SL2);
            this.groupBox2.Controls.Add(this.label19);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // eC44Hex36
            // 
            resources.ApplyResources(this.eC44Hex36, "eC44Hex36");
            this.eC44Hex36.Name = "eC44Hex36";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bCalcHexCmd5A);
            this.groupBox3.Controls.Add(this.eC5AHex1);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.eC5AD2_0);
            this.groupBox3.Controls.Add(this.label22);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // eC5AHex1
            // 
            resources.ApplyResources(this.eC5AHex1, "eC5AHex1");
            this.eC5AHex1.Name = "eC5AHex1";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // eDispX
            // 
            resources.ApplyResources(this.eDispX, "eDispX");
            this.eDispX.Maximum = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.eDispX.Name = "eDispX";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // eDispY
            // 
            resources.ApplyResources(this.eDispY, "eDispY");
            this.eDispY.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.eDispY.Name = "eDispY";
            // 
            // bDispInfoCreate
            // 
            resources.ApplyResources(this.bDispInfoCreate, "bDispInfoCreate");
            this.bDispInfoCreate.Name = "bDispInfoCreate";
            this.bDispInfoCreate.UseVisualStyleBackColor = true;
            this.bDispInfoCreate.Click += new System.EventHandler(this.bDispInfoCreate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.eSEDFFR);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.eSEDXTALkHz);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.eDispX);
            this.groupBox4.Controls.Add(this.eDispY);
            this.groupBox4.Controls.Add(this.cbDispDual);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.bDispInfoCreate);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbLoadConf);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // bReset
            // 
            resources.ApplyResources(this.bReset, "bReset");
            this.bReset.Name = "bReset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bMakeConfigStr);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bDispDoMath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHexRead);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.eChar);
            this.Controls.Add(this.cbAddSent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eCount);
            this.Controls.Add(this.bSendHEX);
            this.Controls.Add(this.bSendDEC);
            this.Controls.Add(this.eCon);
            this.Controls.Add(this.cbStopBits);
            this.Controls.Add(this.cbLF);
            this.Controls.Add(this.cbCR);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.eSend);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.cmPort.ResumeLayout(false);
            this.cmCon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eC40FX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40FY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40CR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40TCR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40LF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC40AP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC44SL1SL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eC5AD2_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSEDXTALkHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSEDFFR)).EndInit();
            this.cmPresets.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eDispX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDispY)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.TextBox eCon;
        private System.Windows.Forms.TextBox eSend;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSend;
        private System.IO.Ports.SerialPort Port1;
        private System.Windows.Forms.CheckBox cbCR;
        private System.Windows.Forms.CheckBox cbLF;
        private System.Windows.Forms.ContextMenuStrip cmCon;
        private System.Windows.Forms.ToolStripMenuItem cmiClearCon;
        private System.Windows.Forms.ContextMenuStrip cmPort;
        private System.Windows.Forms.ToolStripMenuItem cmiPortRefreshList;
        private System.Windows.Forms.Button bSendDEC;
        private System.Windows.Forms.Button bSendHEX;
        private System.Windows.Forms.TextBox eCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eChar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sStatus;
        private System.Windows.Forms.CheckBox cbAddSent;
        private System.Windows.Forms.CheckBox cbHexRead;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPortListDetailed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eC40Hex1;
        private System.Windows.Forms.CheckBox cbC40bM0;
        private System.Windows.Forms.CheckBox cbC40bM1;
        private System.Windows.Forms.CheckBox cbC40bM2;
        private System.Windows.Forms.CheckBox cbC40bWS;
        private System.Windows.Forms.CheckBox cbC40bIV;
        private System.Windows.Forms.CheckBox cbC40bTL;
        private System.Windows.Forms.CheckBox cbC40bDR;
        private System.Windows.Forms.TextBox eC40Hex2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbC40bWF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown eC40FX;
        private System.Windows.Forms.TextBox eC40Hex3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown eC40FY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown eC40AP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown eC40LF;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown eC40TCR;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown eC40CR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox eC40Hex7;
        private System.Windows.Forms.TextBox eC40Hex8;
        private System.Windows.Forms.TextBox eC40Hex6;
        private System.Windows.Forms.TextBox eC40Hex5;
        private System.Windows.Forms.TextBox eC40Hex4;
        private System.Windows.Forms.Button bCalcHexCmd40;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCalcHexCmd44;
        private System.Windows.Forms.TextBox eC44Hex36;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown eC44SL1SL2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bCalcHexCmd5A;
        private System.Windows.Forms.TextBox eC5AHex1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown eC5AD2_0;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button bMakeConfigStr;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown eDispX;
        private System.Windows.Forms.CheckBox cbDispDual;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown eDispY;
        private System.Windows.Forms.Button bDispInfoCreate;
        private System.Windows.Forms.Button bDispDoMath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown eSEDFFR;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown eSEDXTALkHz;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox lbLoadConf;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ContextMenuStrip cmPresets;
        private System.Windows.Forms.ToolStripMenuItem miPresetsLoadSelected;
        private System.Windows.Forms.ToolStripMenuItem miPresetsSaveCurrentConf;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miReloadPresetFile;
        private System.Windows.Forms.Button bReset;
    }
}

