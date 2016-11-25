using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace sed1330_configurer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TrimOldLines(TextBox target, int linesToRemove)
        {
            if (!target.Multiline)
            {
                throw new Exception("Please use this method with Multiline text boxes only.");
            }

            // Nothing to do if the text box does not have more lines
            // than we are trying to remove
            if (target.Lines.Length > linesToRemove)
            {
                StringBuilder newText = new StringBuilder();

                for (int i = linesToRemove; i < target.Lines.Length; i++)
                {
                    newText.AppendLine(target.Lines[i]);
                }

                target.Text = newText.ToString();
            }
        }


        private void update_com_ports()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            cbPort.Items.Clear();
            cbPort.Items.AddRange(ports);
        }

        delegate void AddConTextDelegate(string val);

        public void AddConText(string val)
        {
            if (InvokeRequired) Invoke(new AddConTextDelegate(AddConText), val);
            else
            {

                eCon.Text += val;

                //if (eCon.Text.Length > 100000) eCon.Text = eCon.Text.Substring(1000, eCon.Text.Length);
                if (eCon.Lines.Length > 5000)
                {
                    TrimOldLines(eCon, 200);
                }
                eCon.SelectionStart = eCon.Text.Length;
                eCon.ScrollToCaret();
            }

        }

        delegate void AddConTextNLDelegate(string val);

        public void AddConTextNL(string val)
        {
            if (InvokeRequired) Invoke(new AddConTextNLDelegate(AddConTextNL), val);
            else
            {

                eCon.Text += val + Environment.NewLine;

                //if (eCon.Text.Length > 100000) eCon.Text = eCon.Text.Substring(1000, eCon.Text.Length);
                if (eCon.Lines.Length > 5000)
                {
                    TrimOldLines(eCon, 200);
                }
                eCon.SelectionStart = eCon.Text.Length;
                eCon.ScrollToCaret();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] c_BaudRates = new int[] { 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 115200, 256000, 921160 };
            int[] c_dBits = new int[] { 7, 8, 9 };
            string[] c_Parity = new string[] { "None", "Odd", "Even", "Mark", "Space" };
            string[] c_StopBits = new string[] { "0", "1", "1.5", "2" };


            // baud rates
            System.Object[] bauds = new System.Object[c_BaudRates.Length];
            for (int i = 0; i < c_BaudRates.Length; i++) bauds[i] = c_BaudRates[i].ToString();
            cbBaud.Items.Clear();
            cbBaud.Items.AddRange(bauds);
            // port list
            update_com_ports();
            // Data bits
            System.Object[] dbits = new System.Object[c_dBits.Length];
            for (int i = 0; i < c_dBits.Length; i++) dbits[i] = c_dBits[i].ToString();
            cbDataBits.Items.Clear();
            cbDataBits.Items.AddRange(dbits);
            cbDataBits.SelectedIndex = 1; // 8
            // parity
            cbParity.Items.Clear();
            cbParity.Items.AddRange(c_Parity);
            cbParity.SelectedIndex = 0; // None
            // stop bits
            cbStopBits.Items.Clear();
            cbStopBits.Items.AddRange(c_StopBits);
            cbStopBits.SelectedIndex = 1; // 1

            bClose.Enabled = false;
            bOpen.Enabled = true;
            bSend.Enabled = false;

            toolTip1.SetToolTip(cbPort, "Serial port. [F5] to refresh.");
            toolTip1.SetToolTip(cbCR, "Add \"Carret Return\" (0x0d = 13dec) character at end of line.");
            toolTip1.SetToolTip(cbLF, "Add \"Line Feed\" (0x0a = 10dec) character at end of line. This is added after CR (if added).");
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            if (Port1.IsOpen) Port1.Close();

            string s;

            // port
            Port1.PortName = cbPort.Text;
            s = Port1.PortName.ToUpper();
            // baud rate
            Port1.BaudRate = Convert.ToInt32(cbBaud.Text, 10);
            s += "@" + Port1.BaudRate.ToString();
            // data bits
            switch (cbDataBits.SelectedIndex)
            {
                case 0: Port1.DataBits = 7; s += ",7"; break;
                case 1: Port1.DataBits = 8; s += ",8"; break;
                case 2: Port1.DataBits = 9; s += ",9"; break;
            }
            // parity
            switch (cbParity.SelectedIndex)
            {
                case 0: Port1.Parity = System.IO.Ports.Parity.None; s += "N"; break;
                case 1: Port1.Parity = System.IO.Ports.Parity.Odd; s += "O"; break;
                case 2: Port1.Parity = System.IO.Ports.Parity.Even; s += "E"; break;
                case 3: Port1.Parity = System.IO.Ports.Parity.Mark; s += "M"; break;
                case 4: Port1.Parity = System.IO.Ports.Parity.Space; s += "S"; break;
            }
            // stop bits
            switch (cbStopBits.SelectedIndex)
            {
                case 0: Port1.StopBits = System.IO.Ports.StopBits.None; s += "0"; break;
                case 1: Port1.StopBits = System.IO.Ports.StopBits.One; s += "1"; break;
                case 2: Port1.StopBits = System.IO.Ports.StopBits.OnePointFive; s += "1.5"; break;
                case 3: Port1.StopBits = System.IO.Ports.StopBits.Two; s += "2"; break;
            }

            try
            {
                Port1.Open();
                bOpen.Enabled = false;
                bClose.Enabled = true;
                bSend.Enabled = true;
                cbPort.Enabled = false;
                cbBaud.Enabled = false;
                cbDataBits.Enabled = false;
                cbParity.Enabled = false;
                cbStopBits.Enabled = false;
                sStatus.Text = s;
            }
            catch
            {
                MessageBox.Show("Unable to open port: " + Port1.PortName, "Port open error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sStatus.Text = "Port not opended";
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (Port1.IsOpen) Port1.Close();
            bOpen.Enabled = true;
            bClose.Enabled = false;
            bSend.Enabled = false;
            cbPort.Enabled = true;
            cbBaud.Enabled = true;
            cbDataBits.Enabled = true;
            cbParity.Enabled = true;
            cbStopBits.Enabled = true;
        }

        private void Port1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (e.EventType == System.IO.Ports.SerialData.Chars)
            {
                byte[] buff = new byte[Port1.ReadBufferSize];
                int reads;
                string str = "";

                reads = Port1.Read(buff, 0, Port1.ReadBufferSize);
                //eCon.Text += buff.ToString().Trim();

                if (cbHexRead.Checked) {
                    str = "<" + reads.ToString() + "> ";
                    for (int i = 0; i < reads; i++) str += buff[i].ToString("X2") + " ";
                    str += Environment.NewLine;
                } else {
                    for (int i = 0; i < reads; i++)
                    {
                        // check if character is convertable to ascii codes
                        if ((buff[i] > 0x1f && buff[i] < 0x80) || (buff[i] == 0x0d || buff[i] == 0x0a))
                        {
                            str += Convert.ToChar(buff[i]);
                        }
                        else
                        {
                            str += "<0x" + buff[i].ToString("X2") + ">";
                        }
                    }
                }
                AddConText(str);
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {

            if ((eSend.Text.Length < 1) && (!cbCR.Checked) && (!cbLF.Checked)) return;

            int buff_len = eSend.Text.Length;
            if (cbCR.Checked) buff_len++;
            if (cbLF.Checked) buff_len++;
            byte[] buff = new byte[buff_len];
            int bytes = 0;

            if (cbAddSent.Checked)
            {

                eCon.AppendText(Environment.NewLine + "---- SENT: " + (eSend.Text.Length > 0 ? eSend.Text + " (Len=" + eSend.Text.Length.ToString() + ") " : "") + (cbCR.Checked ? "[0x0d=CR]" : "") + (cbLF.Checked ? "[0x0a=LF]" : "") + Environment.NewLine);
            }


            // fill buffer
            if (eSend.Text.Length > 0)
            {
                for (int i = 0; i < eSend.Text.Length; i++)
                {
                    buff[i] = Convert.ToByte(eSend.Text[i]);
                    bytes++;
                }
            }

            if (cbCR.Checked) buff[bytes++] = 0x0d;
            if (cbLF.Checked) buff[bytes++] = 0x0a;

            if (!Port1.IsOpen)
            {
                eCon.AppendText(Environment.NewLine + "!!!!!!!!!!!!!! Port closed. !!!!!!!!!!!!!!!!!!" + Environment.NewLine);
                return;
            }

            try
            {
                Port1.Write(buff, 0, bytes);
                eSend.Clear();
            } catch (Exception er) {
                AddConText(Environment.NewLine + "!!!!!!!! Unable to write to port " + Port1.PortName + ". Error: " + er.ToString() + " !!!!!!!!!!!!!!" + Environment.NewLine);
            }

            eCount.Text = (eSend.Text.Length + (cbCR.Checked ? 1 : 0) + (cbLF.Checked ? 1 : 0)).ToString();
        }

        private void eSend_KeyDown(object sender, KeyEventArgs e)
        {
            if ((bSend.Enabled == true) && (e.KeyCode == Keys.Enter)) bSend.PerformClick();
            eCount.Text = (eSend.Text.Length + (cbCR.Checked ? 1 : 0) + (cbLF.Checked ? 1 : 0)).ToString();
        }

        private void cmiClearCon_Click(object sender, EventArgs e)
        {
            eCon.Clear();
        }

        private void cmiPortRefreshList_Click(object sender, EventArgs e)
        {
            update_com_ports();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bSendDEC_Click(object sender, EventArgs e)
        {
            if (eChar.Text.Length < 1) return;

            int buff_len = 1;
            //if (cbCR.Checked) buff_len++;
            //if (cbLF.Checked) buff_len++;
            byte[] buff = new byte[buff_len];
            int bytes = 0;

            // fill buffer
            //for (int i = 0; i < eSend.Text.Length; i++)
            //{
            buff[0] = Convert.ToByte(eChar.Text, 10);
            bytes++;
            //}

            //if (cbCR.Checked) buff[bytes++] = 0x0a;
            //if (cbLF.Checked) buff[bytes++] = 0x0d;

            if (!Port1.IsOpen) return;
            Port1.Write(buff, 0, bytes);
            //eSend.Clear();
        }

        private void bSendHEX_Click(object sender, EventArgs e)
        {
            if (eChar.Text.Length < 1) return;

            int buff_len = 1;
            //if (cbCR.Checked) buff_len++;
            //if (cbLF.Checked) buff_len++;
            byte[] buff = new byte[buff_len];
            int bytes = 0;

            // fill buffer
            //for (int i = 0; i < eSend.Text.Length; i++)
            //{
            buff[0] = Convert.ToByte(eChar.Text, 16);
            bytes++;
            //}

            //if (cbCR.Checked) buff[bytes++] = 0x0a;
            //if (cbLF.Checked) buff[bytes++] = 0x0d;

            if (!Port1.IsOpen) return;
            Port1.Write(buff, 0, bytes);
            //eSend.Clear();

        }

        private void eSend_KeyUp(object sender, KeyEventArgs e)
        {
            eCount.Text = (eSend.Text.Length + (cbCR.Checked ? 1 : 0) + (cbLF.Checked ? 1 : 0)).ToString();
        }

        private void cbPort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (!Port1.IsOpen) update_com_ports();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cbCR_Click(object sender, EventArgs e)
        {
            eCount.Text = (eSend.Text.Length + (cbCR.Checked ? 1 : 0) + (cbLF.Checked ? 1 : 0)).ToString();
        }

        private void cbLF_Click(object sender, EventArgs e)
        {
            eCount.Text = (eSend.Text.Length + (cbCR.Checked ? 1 : 0) + (cbLF.Checked ? 1 : 0)).ToString();
        }

        private void miPortListDetailed_Click(object sender, EventArgs e)
        {
            SerialPortLister sp = new SerialPortLister(false);

            string s = "";
            string[] s2 = sp.GetSerialPorts();
            for (int i = 0; i < s2.Length; i++)
            {
                s += s2[i] + Environment.NewLine;
            }
            MessageBox.Show("Serial ports in system:" + Environment.NewLine + s);
        }

        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************
        // ******************************************************************************************************

        SEDPresets ConfPresets = new SEDPresets();
        int lastLoadPreset = -1;

        byte get_cmd40_P1()
        {
            byte v = 0;

            bool dr, tl, iv, ws, m2, m1, m0;
            dr = (cbC40bDR.Checked ? true : false);
            tl = (cbC40bTL.Checked ? true : false);
            iv = (cbC40bIV.Checked ? true : false);
            ws = (cbC40bWS.Checked ? true : false);
            m2 = (cbC40bM2.Checked ? true : false);
            m1 = (cbC40bM1.Checked ? true : false);
            m0 = (cbC40bM0.Checked ? true : false);

            v = (byte)(
                (dr ? 0x80 : 0x00) | (tl ? 0x40 : 0x00) | (iv ? 0x20 : 0x00) | 0x10 |
                (ws ? 0x08 : 0x00) | (m2 ? 0x04 : 0x00) | (m1 ? 0x02 : 0x00) | (m0 ? 0x01 : 0x00)
                );

            eC40Hex1.Text = v.ToString("X2");
            return v;
        }

        void set_cmd40_P1(byte val)
        {
            cbC40bM0.Checked = cbC40bM1.Checked = cbC40bM2.Checked = cbC40bWS.Checked = false;
            cbC40bIV.Checked = cbC40bTL.Checked = cbC40bDR.Checked = false;

            if ((val & 0x01) == 0x01) cbC40bM0.Checked = true;
            if ((val & 0x02) == 0x02) cbC40bM1.Checked = true;
            if ((val & 0x04) == 0x04) cbC40bM2.Checked = true;
            if ((val & 0x08) == 0x08) cbC40bWS.Checked = true;
            //if ((val & 0x10) == 0x10) cbC40bM0.Checked = true;
            if ((val & 0x20) == 0x20) cbC40bIV.Checked = true;
            if ((val & 0x40) == 0x40) cbC40bTL.Checked = true;
            if ((val & 0x80) == 0x80) cbC40bDR.Checked = true;

            get_cmd40_P1(); // update textbox
        }

        byte get_cmd40_P2()
        {
            byte v = 0;
            bool wf = (cbC40bWF.Checked ? true : false);
            byte fx = (byte)(Convert.ToByte(eC40FX.Value) & 0x07);

            v = (byte)((wf ? 0x80 : 0x00) | fx);

            eC40Hex2.Text = v.ToString("X2");
            return v;
        }

        void set_cmd40_P2(byte val)
        {
            cbC40bWF.Checked = ((val & 0x80) == 0x80 ? true : false);
            eC40FX.Value = val & 0x07;

            get_cmd40_P2();// update textbox
        }

        byte get_cmd40_P3()
        {
            byte fy = (byte)(Convert.ToByte(eC40FY.Value) & 0x0f);

            eC40Hex3.Text = fy.ToString("X2");
            return fy;
        }

        void set_cmd40_P3(byte val)
        {
            //AddConTextNL("Preset P3 to " + val.ToString() + " ignored. P3 set to 7.");

            eC40FY.Value = (val&0x0f);
            get_cmd40_P3(); // update
        }

        byte get_cmd40_P4()
        {
            byte cr = Convert.ToByte(eC40CR.Value);
            if (cr > 239)
            {
                cr = 239;
                eC40CR.Value = 239;
            }

            eC40Hex4.Text = cr.ToString("X2");
            return cr;
        }

        void set_cmd40_P4(byte val)
        {
            eC40CR.Value = val;
            get_cmd40_P4();
        }

        byte get_cmd40_P5()
        {
            byte tcr = Convert.ToByte(eC40TCR.Value);

            eC40Hex5.Text = tcr.ToString("X2");
            return tcr;
        }

        void set_cmd40_P5(byte val)
        {
            eC40TCR.Value = val;
            get_cmd40_P5();
        }

        byte get_cmd40_P6()
        {
            byte lf = Convert.ToByte(eC40LF.Value);

            eC40Hex6.Text = lf.ToString("X2");
            return lf;
        }

        void set_cmd40_P6(byte val)
        {
            eC40LF.Value = val;

            get_cmd40_P6(); // update
        }

        byte get_cmd40_P7()
        {
            ushort ap = Convert.ToUInt16(eC40AP.Value);
            byte apl = Convert.ToByte(ap & 0x00ff);

            eC40Hex7.Text = apl.ToString("X2");
            return apl;
        }

        byte get_cmd40_P8()
        {
            ushort ap = Convert.ToUInt16(eC40AP.Value);
            byte aph = Convert.ToByte((ap >> 8) & 0x00ff);

            eC40Hex8.Text = aph.ToString("X2");
            return aph;
        }

        void set_cmd40_P7P8(ushort val)
        {
            eC40AP.Value = val;

            get_cmd40_P7();
            get_cmd40_P8();
        }

        private void bCalcHexCmd40_Click(object sender, EventArgs e)
        {
            get_cmd40_P1();
            get_cmd40_P2();
            get_cmd40_P3();
            get_cmd40_P4();
            get_cmd40_P5();
            get_cmd40_P6();
            get_cmd40_P7();
            get_cmd40_P8();
        }

        byte get_cmd44_P3P6()
        {
            byte v = Convert.ToByte(eC44SL1SL2.Value);

            eC44Hex36.Text = v.ToString("X2");
            return v;
        }

        void set_cmd44_P3P6(byte val)
        {
            eC44SL1SL2.Value = val;
            get_cmd44_P3P6(); // update
        }

        private void bCalcHexCmd44_Click(object sender, EventArgs e)
        {
            get_cmd44_P3P6();
        }

        byte get_cmd5A_P1()
        {
            byte v = Convert.ToByte(eC5AD2_0.Value);

            v = (byte)(v & 0x07);

            eC5AHex1.Text = v.ToString("X2");
            return v;
        }

        void set_cmd5A_P1(byte val)
        {
            eC5AD2_0.Value = val;
            get_cmd5A_P1();
        }

        private void bCalcHexCmd5A_Click(object sender, EventArgs e)
        {
            get_cmd5A_P1();
        }

        private void bMakeConfigStr_Click(object sender, EventArgs e)
        {
            string s = "c";

            byte[] cnf = new byte[9];

            cnf[0] = get_cmd40_P1();
            cnf[1] = get_cmd40_P2();
            cnf[2] = get_cmd40_P4();
            cnf[3] = get_cmd40_P5();
            cnf[4] = get_cmd40_P6();
            cnf[5] = get_cmd40_P7();
            cnf[6] = get_cmd40_P8();
            cnf[7] = get_cmd44_P3P6();
            cnf[8] = get_cmd5A_P1();

            for (int i=0;i<cnf.Length;i++)
            {
                s += cnf[i].ToString("X2");
            }

            AddConTextNL("Prepared config string: " + s);
            AddConTextNL("String must be terminated with CR (0x0D)");

            eSend.Text = s;
        }

        private void bDispInfoCreate_Click(object sender, EventArgs e)
        {
            ushort dispx = Convert.ToUInt16(eDispX.Value);
            ushort dispy = Convert.ToUInt16(eDispY.Value);
            bool dispDual = (cbDispDual.Checked ? true : false);

            // internal CGROM, 32char CGRAM1, 8px CGROM & CGRAM char height
            cbC40bM0.Checked = false;
            cbC40bM1.Checked = false;
            cbC40bM2.Checked = false;

            if (dispDual) cbC40bWS.Checked = true;
            else cbC40bWS.Checked = false;

            // no screen top line correction, LCD mode
            cbC40bIV.Checked = true;
            cbC40bTL.Checked = false;
            // no extra shift clock cycles
            cbC40bDR.Checked = false;
            // char height
            eC40FX.Value = 7; // 8bits width
            // two-frame AC drive
            cbC40bWF.Checked = true;
            // char width
            eC40FY.Value = 7; // 8bit/pix

            int vc = dispx / 8; // FX+1
            // C/R
            int cr = 0;
            // math
            cr = (8/8) * vc;
            if (cr > 239)
            {
                AddConTextNL("Fill from info: C/R > 239!! C/R=" + cr.ToString());
                cr = 239;
            }
            eC40CR.Value = cr-1;

            // TC/R
            int tcr = 0;
            // math
            tcr = cr + 4;
            if (tcr < (cr+4))
            {
                AddConTextNL("Fill from info: TC/R is less than C/R+4!! TC/R=" + tcr.ToString());
            }
            eC40TCR.Value = tcr-1;

           
            // L/F
            int lf = 0;
            lf = dispy;

            if (lf > 255)
            {
                AddConTextNL("Fill from info: L/F > 255!! L/F=" + lf.ToString());
                lf = 255;
            }
            eC40LF.Value = lf-1;


            // crystal advise
            int ffr = Convert.ToInt32(eSEDFFR.Value);
            AddConTextNL("Fill from info: selected fFR=" + ffr.ToString() + "Hz .");
            int fosc = ((tcr * 9) + 1) * lf * ffr;
            AddConTextNL("Fill form info: Advised XTAL for SED must be grater than: " + fosc.ToString("### ### ##0") + "Hz ");

            // AP
            int ap = cr;
            eC40AP.Value = ap;

            // SLx
            int sl = 0;
            if (dispDual)
            {
                sl = (lf / 2) + 1; 
            } else
            {
                sl = lf + 1;
            }

            eC44SL1SL2.Value = sl;

            // HDOT SCR
            eC5AD2_0.Value = 0;

            // update
            bCalcHexCmd40.PerformClick();
            bCalcHexCmd44.PerformClick();
            bCalcHexCmd5A.PerformClick();
        }

        private void bDispDoMath_Click(object sender, EventArgs e)
        {
            ushort dispx = Convert.ToUInt16(eDispX.Value);
            ushort dispy = Convert.ToUInt16(eDispY.Value);
            bool dispDual = (cbDispDual.Checked ? true : false);

            byte fx = Convert.ToByte(eC40FX.Value+1); // 8bits width
            byte fy = Convert.ToByte(eC40FY.Value+1); // 8bit/pix
            byte cr = Convert.ToByte(eC40CR.Value+1);
            byte tcr =Convert.ToByte( eC40TCR.Value+1);
            byte lf = Convert.ToByte(eC40LF.Value+1);
            ushort ap = Convert.ToUInt16(eC40AP.Value);
            int ffr = Convert.ToInt32(eSEDFFR.Value);
            int fosc = Convert.ToInt32(eSEDXTALkHz.Value*1000);

            AddConTextNL("CALC: Display size=" + dispx.ToString() + "x" + dispy.ToString());
            AddConTextNL("CALC: DualPanel=" + dispDual.ToString());
            AddConTextNL("CALC: Char width: FX=" + fx.ToString());
            AddConTextNL("CALC: Char height: FY=" + fy.ToString());
            AddConTextNL("CALC: Visible addr range of line (bytes): C/R=" + cr.ToString());
            AddConTextNL("CALC: Line length with blanking: TC/R=" + tcr.ToString());
            AddConTextNL("CALC: Frame height in lines: L/F=" + lf.ToString());
            AddConTextNL("CALC: Horizontal addr range of virtual screen: AP=" + ap.ToString() + "[0x" + ap.ToString("X4") + "]");
            AddConTextNL("CALC: Desired frame rate fFR=" + ffr.ToString());
            AddConTextNL("CALC: Desired XTAL/CLKI fosc=" + fosc.ToString());
            //AddConTextNL("CALC: " + .ToString());
            //AddConTextNL("CALC: " + .ToString());

            // calc visible part of display, at one clock pulse there is loaded 4pixels, that's why there is division by 4
            // tcr[whole line]*fx[char size] * LF[lines per frame] / 4bit
            int screen_clocks = (tcr*fx*lf) / 4;
            int desired_ffr_clocks = screen_clocks * ffr;
            AddConTextNL("CALC: to draw one frame there is need for XCLK clock: " + screen_clocks.ToString());
            AddConTextNL("CALC: to reach desired fFR (" + ffr.ToString() + "Hz) there is need for XCLK clocks: " + desired_ffr_clocks.ToString());

            int fosc2 = (tcr * 9 + 1) * lf * ffr;
            AddConTextNL("CALC: For desired fFR you need XTAL/CLKI >= " + fosc2.ToString("### ### ##0") + "Hz");
            if (fosc2 > fosc) AddConTextNL("CALC:    Entered XTAL/CLKI fosc is not enaught to get desired frame rate.");

            int cr2 = dispx / fx;
            int cr2r = dispx % fx;
            AddConTextNL("CALC: C/R for given FX and DispXSize = " + cr2.ToString() + " (rest: " + cr2r.ToString() + ")");

            int tcr2 = ((fosc / (lf * ffr)) - 1) / 9;
            AddConTextNL("CALC: For given XTAL/CLKI fosc, LF and fFR - should be TC/R=" + tcr2.ToString());
            double ffr2 = (fosc*1.0) / ((tcr * 9.0 + 1.0) * lf);
            AddConTextNL("CALC: For given XTAL/CLKI fosc, LF and TC/R - refresh rate be fFR=" + ffr2.ToString("6.3f")+"Hz");

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            lastLoadPreset = -1;
            set_cmd40_P1(0x30);
            set_cmd40_P2(0x87);
            set_cmd40_P3(0x07);
            set_cmd40_P4(0x00);
            set_cmd40_P5(0x00);
            set_cmd40_P6(0x00);
            set_cmd40_P7P8(0x0000);
            set_cmd44_P3P6(0x00);
            set_cmd5A_P1(0x00);
            eDispX.Value = eDispY.Value = 0;
            eSEDXTALkHz.Value = 0;
            eSEDFFR.Value = 0;
            cbDispDual.Checked = false;
        }

        private void lblSetStrEDMMPU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //             00 1 2 3 4 5 6 7 8
            eSend.Text = "c3087272CEF2800F000"; //c30873136A03200A000
            set_cmd40_P1(0x30);
            set_cmd40_P2(0x87);
            set_cmd40_P3(0x07);
            set_cmd40_P4(0x27);
            set_cmd40_P5(0x2C);
            set_cmd40_P6(0xEF);
            set_cmd40_P7P8(0x0028);
            set_cmd44_P3P6(0xF0);
            set_cmd5A_P1(0x00);
            
        }

        private void lblSetStrITE400160_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //             001122334455667788 
            eSend.Text = "c30873136A03200A000";
            set_cmd40_P1(0x30);
            set_cmd40_P2(0x87);
            set_cmd40_P3(0x07);
            set_cmd40_P4(0x31);
            set_cmd40_P5(0x36);
            set_cmd40_P6(0xA0);
            set_cmd40_P7P8(0x0032);
            set_cmd44_P3P6(0xA0);
            set_cmd5A_P1(0x00);
        }

        void LoadPresetsFromFile()
        {
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "presets.txt");
            if (!File.Exists(path))
            {
                AddConTextNL("No preset file `" + path + "`.");
                return;
            }

            try
            {
                ConfPresets.LoadPresetsFile(path);

                // fill list box
                lbLoadConf.Items.Clear();
                for (int i = 0; i < ConfPresets.Count; i++)
                {
                    lbLoadConf.Items.Add(ConfPresets[i].Name);
                }
            } catch (Exception ee)
            {
                AddConTextNL("Loading presets failed. ERROR:" + ee.ToString());
            }
        }

        void SavePresetsToFile()
        {
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "presets.txt");
            if (File.Exists(path))
            {
                AddConTextNL("Preset file found `" + path + "`.");
            }

            try
            {
                ConfPresets.SavePresetsFile(path);
            }
            catch (Exception ee)
            {
                AddConTextNL("Saving presets failed. ERROR:" + ee.ToString());
            }
        }

        void LoadSelectedPreset()
        {
            int idx = lbLoadConf.SelectedIndex;
            if (idx < 0 || idx >= ConfPresets.Count) return;

            lastLoadPreset = idx;
            SEDPreset p = ConfPresets[idx];

            set_cmd40_P1(p.C40P1);
            set_cmd40_P2(p.C40P2);
            set_cmd40_P3(p.C40P3);
            set_cmd40_P4(p.C40P4);
            set_cmd40_P5(p.C40P5);
            set_cmd40_P6(p.C40P6);
            set_cmd40_P7P8((ushort)((p.C40P8<<8) | p.C40P7));
            set_cmd44_P3P6(p.C44P3_P6);
            set_cmd5A_P1(p.C5A_P1);
            // display info
            eDispX.Value = p.DispX;
            eDispY.Value = p.DispY;
            cbDispDual.Checked = p.DualPanel;
            eSEDXTALkHz.Value = p.FOSC;
            eSEDFFR.Value = p.FFR;

        }



        private void lbLoadConf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadSelectedPreset();
        }

        private void miPresetsLoadSelected_Click(object sender, EventArgs e)
        {
            LoadSelectedPreset();
        }

        private void miPresetsSaveCurrentConf_Click(object sender, EventArgs e)
        {
            string[] list = new string[ConfPresets.Count];
            for (int i=0;i<ConfPresets.Count;i++)
            {
                list[i] = ConfPresets[i].Name;
            }

            FormCfgSaveAs f = new FormCfgSaveAs(list, lastLoadPreset);

            if (f.ShowDialog() == DialogResult.OK)
            {
                string selName = f.SelectedName;

                SEDPreset p = new SEDPreset();
                int ix = ConfPresets.GetPresetByName(selName);

                if (ix != -1)
                {
                    p = ConfPresets[ix];
                } else
                {
                    p.Name = selName;
                }

                p.C40P1 = get_cmd40_P1();
                p.C40P2 = get_cmd40_P2();
                p.C40P3 = get_cmd40_P3();
                p.C40P4 = get_cmd40_P4();
                p.C40P5 = get_cmd40_P5();
                p.C40P6 = get_cmd40_P6();
                p.C40P7 = get_cmd40_P7();
                p.C40P8 = get_cmd40_P8();
                p.C44P3_P6 = get_cmd44_P3P6();
                p.C5A_P1 = get_cmd5A_P1();

                p.DispX = Convert.ToInt32(eDispX.Value);
                p.DispY = Convert.ToInt32(eDispY.Value);
                p.DualPanel = cbDispDual.Checked;
                p.FFR = Convert.ToInt32(eSEDFFR.Value);
                p.FOSC = Convert.ToInt32(eSEDXTALkHz.Value);

                if (ix == -1)
                {
                    ConfPresets.Add(p);
                }

                SavePresetsToFile();
                LoadPresetsFromFile();

            }

            f.Dispose();
        }

        private void miReloadPresetFile_Click(object sender, EventArgs e)
        {
            LoadPresetsFromFile();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LoadPresetsFromFile();
        }

    }
}
