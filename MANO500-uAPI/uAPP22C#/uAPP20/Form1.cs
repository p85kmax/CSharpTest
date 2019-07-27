using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

//Ver20 is original
//Ver21 is fixed didn't Set/Get DIO when not support DIO

namespace uAPP20
{
    public partial class uAPP : Form
    {
        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxBoardLoadLibrary(char[] dllName);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxBoardReleaseLibrary();

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetCPUTemp(float[] CTemp);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetSYSTemp(float[] STemp);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetCPUFAN(float[] CTemp);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetSYSFAN(float[] STemp);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetCPUVcore(float[] CPUVoltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGet3V(float[] V33Voltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGet5V(float[] V5Voltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGet12V(float[] V12Voltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetNeg5V(float[] VN5Voltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetNeg12V(float[] VN12Voltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetVbat(float[] VBVoltage);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxSetDIODirection(int pin, int[] pinData);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetDIOValidPin(int pin, int[] pinData);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetDI(int pin, int[] pinData);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxGetDO(int pin, int[] pinData);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxSetDO(int pin, int[] pinData);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxWDTSetCounter(int timeCounter);

        [DllImport("AxUfiAPIx64.dll")]
        public static extern bool AxWDTexec(int subFunction);

        enum WDTFuntion
        {
            bWDT_ENABLE = 0x0001,
            bWDT_DISABLE = 0x0002,
            bWDT_RELOAD = 0x0003,
            bWDT_EVENT = 0x0004,
            bWDT_EVENT_CLR = 0x0005,
            bWDT_SECOND = 0x000,
            bWDT_MINUTE = 0x100
        }

        private static bool LoadFlag;
        private static bool uAPPFlag;
        private static bool WDTFlag;
        private static char[] dllName = new char[25];
        private static float[] CTemp = new float[1];
        private static float[] STemp = new float[1];
        private static float[] CFan = new float[1];
        private static float[] SFan = new float[1];
        private static float[] CPUVoltage = new float[1];
        private static float[] V33Voltage = new float[1];
        private static float[] V5Voltage = new float[1];
        private static float[] V12Voltage = new float[1];
        private static float[] VN5Voltage = new float[1];
        private static float[] VN12Voltage = new float[1];
        private static float[] VBVoltage = new float[1];
        private static int[] pinIn = new int[1];
        private static int[] pinOut = new int[1];
        private static int[] pinData = new int[1];
        private static int[] pinValue = new int[1];
        private int timer, DIPin, DOPin;

        public uAPP()
        {
            InitializeComponent();
        }

        private void uAPP_Load(object sender, EventArgs e)
        {
            DLLList();
            uAPPFlag = false;
            this.ActiveControl = AXLogo;
            WDTFlag = false;
        }

        private void DLLList()//list all library files
        {
            string[] files = System.IO.Directory.GetFiles(Application.StartupPath);
            int j = 0;
            int l = files[0].Split('\\').Length;

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Split('\\')[l - 1].Split('.')[0].Contains("dt"))
                {
                    for (int m = 0; m <= BoardSelect.Items.Count; m++)
                    {
                        if (!BoardSelect.Items.Contains(files[i].Split('\\')[l - 1].Split('.')[0]))
                        {
                            j++;
                            BoardSelect.Items.Add(files[i].Split('\\')[l - 1].Split('.')[0].Trim());
                        }
                    }
                }
            }

            //BoardSelect.SelectedIndex = 0;
            //Timer5.Checked = true;
            //WDTTimerSelect.SelectedIndex = 0;

            if (j == 0)
                MessageBox.Show("Detect No Board Library Files!");
            else
                BoardSelect.SelectedIndex = 0;
        }

        private void MiniForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitForm_Click(object sender, EventArgs e)
        {
            uAPPTimer.Enabled = false;

            //WDT Disable
            StopWDT();

            if (LoadFlag)
                AxBoardReleaseLibrary();

            this.Close();
        }

        private void BoardSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            uAPPFlag = false;
            uAPPTimer.Enabled = false;

            //WDT Disable
            StopWDT();

            if (LoadFlag)
                AxBoardReleaseLibrary();

            uAPPSet.Text = "Go";

            uAPPInitial();
        }

        private void uAPPInitial()
        {
            Zone2.Enabled = false;
            Zone3.Enabled = false;
            Zone4.Enabled = false;

            //Zone1
            Timer5.Checked = true;
            bit0.Checked = false;
            bit1.Checked = false;
            bit2.Checked = false;
            bit3.Checked = false;
            bit4.Checked = false;
            bit5.Checked = false;
            bit6.Checked = false;
            bit7.Checked = false;

            bit0.Enabled = true;
            bit1.Enabled = true;
            bit2.Enabled = true;
            bit3.Enabled = true;
            bit4.Enabled = true;
            bit5.Enabled = true;
            bit6.Enabled = true;
            bit7.Enabled = true;

            //Zone2
            Zone2.Enabled = false;
            CPUTemp.Text = "---";
            SysTemp.Text = "---";
            CPUFan.Text = "---";
            SysFan.Text = "---";
            VCore.Text = "---";
            V3.Text = "---";
            V5.Text = "---";
            V12.Text = "---";

            //Zone3
            Zone3.Enabled = false;
            Ibit0.Text = "---";
            Ibit1.Text = "---";
            Ibit2.Text = "---";
            Ibit3.Text = "---";
            Ibit4.Text = "---";
            Ibit5.Text = "---";
            Ibit6.Text = "---";
            Ibit7.Text = "---";
            Obit0.Checked = false;
            Obit1.Checked = false;
            Obit2.Checked = false;
            Obit3.Checked = false;
            Obit4.Checked = false;
            Obit5.Checked = false;
            Obit6.Checked = false;
            Obit7.Checked = false;

            //Zone4
            Zone4.Enabled = false;
            WDTTimerSelect.SelectedIndex = 0;
            WDTRun.Enabled = false;
            WDTRe.Enabled = false;
            WDTStop.Enabled = false;
        }

        private void uAPPSet_Click(object sender, EventArgs e)
        {
            if (!uAPPFlag)//start to run uAPP
            {
                if (Timer5.Checked)
                    uAPPTimer.Interval = 5000;
                else if (Timer10.Checked)
                    uAPPTimer.Interval = 10000;
                else
                    uAPPTimer.Interval = 30000;

                LoadDLL();                
            }
            else//stop to run uAPP
            {
                uAPPFlag = false;
                uAPPTimer.Enabled = false;

                //WDT Disable
                StopWDT();

                if (LoadFlag)
                    AxBoardReleaseLibrary();

                uAPPSet.Text = "Go";

                uAPPInitial();
            }
        }

        private void LoadDLL()//load library, initial and get all hardware status
        {
            dllName = BoardSelect.SelectedItem.ToString().Trim().ToCharArray();//get library name
            LoadFlag = AxBoardLoadLibrary(dllName);//load library

            if (LoadFlag)
            {
                //Zone2 is Hardware Monitor
                Zone2.Enabled = true;
                GetCPUTemp();
                GetSYSTemp();
                GetCPUFan();
                GetSYSFan();
                GetCPUVoltage();
                GetV33Voltage();
                GetV5Voltage();
                GetV12Voltage();

                //Zone3 is Digital I/O
                if (DIOPinSet())
                    Zone3.Enabled = true;
                else
                    Zone3.Enabled = false;

                //Zone4 is WatchDog Timer
                Zone4.Enabled = true;
                WDTRun.Enabled = true;

                uAPPFlag = true;
                uAPPSet.Text = "Stop";

                uAPPTimer.Enabled = true;
            }
            else
                MessageBox.Show("Library Loading is Failed!", "uAPP Load Library");
        }

        private void uAPPTimer_Tick(object sender, EventArgs e)
        {
            GetCPUTemp();
            GetSYSTemp();
            GetCPUFan();
            GetSYSFan();
            GetCPUVoltage();
            GetV33Voltage();
            GetV5Voltage();
            GetV12Voltage();

            if (Zone3.Enabled)
            {
                SetDO();
                GetDI();
            }
        }

        //********************************************
        //**************Hardware Monitor**************
        //********************************************
        private void GetCPUTemp()//get CPU temperature
        {
            if (AxGetCPUTemp(CTemp))
                CPUTemp.Text = CTemp[0].ToString("f1");
            else
                CPUTemp.Text = "---";
        }

        private void GetSYSTemp()//get System temperature
        {
            if (AxGetSYSTemp(STemp))
                SysTemp.Text = STemp[0].ToString("f1");
            else
                SysTemp.Text = "---";
        }

        private void GetCPUFan()//get CPU fan speed
        {
            if (AxGetCPUFAN(CFan))
                CPUFan.Text = CFan[0].ToString("f0");
            else
                CPUFan.Text = "---";
        }

        private void GetSYSFan()//get System fan speed
        {
            if (AxGetSYSFAN(SFan))
                SysFan.Text = SFan[0].ToString("f0");
            else
                SysFan.Text = "---";
        }

        private void GetCPUVoltage()//get CPU voltage
        {
            if (AxGetCPUVcore(CPUVoltage))
                VCore.Text = CPUVoltage[0].ToString("f2");
            else
                VCore.Text = "---";
        }

        private void GetV33Voltage()//get +3.3 voltage
        {
            if (AxGet3V(V33Voltage))
                V3.Text = V33Voltage[0].ToString("f2");
            else
                V3.Text = "---";
        }

        private void GetV5Voltage()//get +5 voltage
        {
            if (AxGet5V(V5Voltage))
                V5.Text = V5Voltage[0].ToString("f2");
            else
                V5.Text = "---";
        }

        private void GetV12Voltage()//get +12 voltage
        {
            if (AxGet12V(V12Voltage))
                V12.Text = V12Voltage[0].ToString("f2");
            else
                V12.Text = "---";
        }

        //********************************************
        //***************WatchDog Timer***************
        //********************************************
        private void WDTRun_Click(object sender, EventArgs e)
        {
            uAPPTimer.Stop();
            RunWDT();
            uAPPTimer.Start();
        }

        private void RunWDT()//set WDT and run WDT
        {
            Int32.TryParse(WDTTimerSelect.SelectedItem.ToString().Trim(), out timer);

            if (SecTimer.Checked)
                timer += (int)WDTFuntion.bWDT_SECOND;
            else
                timer += (int)WDTFuntion.bWDT_MINUTE;

            if (AxWDTSetCounter(timer))
            {
                if (AxWDTexec((int)WDTFuntion.bWDT_ENABLE))
                {
                    WDTRun.Enabled = false;
                    WDTRe.Enabled = true;
                    WDTStop.Enabled = true;
                    WDTFlag = true;
                }
                else
                    MessageBox.Show("Run WDT Failed or NOT Support.", "RunWDT");
            }
            else
                MessageBox.Show("Set WDT Failed or NOT Support.", "SetCounter");
        }

        private void WDTRe_Click(object sender, EventArgs e)
        {
            uAPPTimer.Stop();
            ReWDT();
            uAPPTimer.Start();
        }

        private void ReWDT()//reload WDT
        {
            if (AxWDTexec((int)WDTFuntion.bWDT_RELOAD) == false && WDTFlag == true)
            {
                WDTRun.Enabled = true;
                WDTRe.Enabled = false;
                WDTStop.Enabled = false;
                MessageBox.Show("Reload WDT Failed or NOT Support.", "ReWDT");
            }
        }

        private void WDTStop_Click(object sender, EventArgs e)
        {
            uAPPTimer.Stop();
            StopWDT();
            uAPPTimer.Start();
        }

        private void StopWDT()//stop WDT
        {
            if (AxWDTexec((int)WDTFuntion.bWDT_DISABLE) == false && WDTFlag == true)
                MessageBox.Show("Stop WDT Failed or NOT Support.", "StopWDT");
            else if (AxWDTexec((int)WDTFuntion.bWDT_DISABLE) == true && WDTFlag == true)
                WDTFlag = false;

            WDTRun.Enabled = true;
            WDTRe.Enabled = false;
            WDTStop.Enabled = false;
        }

        //********************************************
        //****************Digital  I/O****************
        //********************************************
        private bool DIOPinSet()
        {
            pinData[0] = 0x00;

            if (!bit0.Checked)
                pinData[0] += 0x01;

            if (!bit1.Checked)
                pinData[0] += 0x02;

            if (!bit2.Checked)
                pinData[0] += 0x04;

            if (!bit3.Checked)
                pinData[0] += 0x08;

            if (!bit4.Checked)
                pinData[0] += 0x10;

            if (!bit5.Checked)
                pinData[0] += 0x20;

            if (!bit6.Checked)
                pinData[0] += 0x40;

            if (!bit7.Checked)
                pinData[0] += 0x80;

            pinValue[0] = 0xFF;

            if (!AxSetDIODirection(pinValue[0], pinData))
            {
                MessageBox.Show("Wrong Pin Data:" + pinData[0].ToString("X") + ", or NOT Support", "SetDIODirection");
                return false;
            }
            else
            {
                SetPortStatus(pinData[0]);

                DIPin = pinData[0];
                DOPin = 0xFF - pinData[0];

                SetDO();
                GetDI();

                return true;
            }
        }

        private void SetPortStatus(int PinStatus)
        {
            if ((PinStatus & 0x01) == 0x01)//bit0 is DI
            {
                Ibit0.Enabled = true;
                Ibit0.Text = "---";
                Obit0.Enabled = false;
                Obit0.Checked = false;
            }
            else//bit0 is DO
            {
                Ibit0.Enabled = false;
                Ibit0.Text = "---";
                Obit0.Enabled = true;
                Obit0.Checked = false;
            }

            if ((PinStatus & 0x02) == 0x02)//bit1 is DI
            {
                Ibit1.Enabled = true;
                Ibit1.Text = "---";
                Obit1.Enabled = false;
                Obit1.Checked = false;
            }
            else//bit1 is DO
            {
                Ibit1.Enabled = false;
                Ibit1.Text = "---";
                Obit1.Enabled = true;
                Obit1.Checked = false;
            }

            if ((PinStatus & 0x04) == 0x04)//bit2 is DI
            {
                Ibit2.Enabled = true;
                Ibit2.Text = "---";
                Obit2.Enabled = false;
                Obit2.Checked = false;
            }
            else//bit2 is DO
            {
                Ibit2.Enabled = false;
                Ibit2.Text = "---";
                Obit2.Enabled = true;
                Obit2.Checked = false;
            }

            if ((PinStatus & 0x08) == 0x08)//bit3 is DI
            {
                Ibit3.Enabled = true;
                Ibit3.Text = "---";
                Obit3.Enabled = false;
                Obit3.Checked = false;
            }
            else//bit3 is DO
            {
                Ibit3.Enabled = false;
                Ibit3.Text = "---";
                Obit3.Enabled = true;
                Obit3.Checked = false;
            }

            if ((PinStatus & 0x10) == 0x10)//bit4 is DI
            {
                Ibit4.Enabled = true;
                Ibit4.Text = "---";
                Obit4.Enabled = false;
                Obit4.Checked = false;
            }
            else//bit4 is DO
            {
                Ibit4.Enabled = false;
                Ibit4.Text = "---";
                Obit4.Enabled = true;
                Obit4.Checked = false;
            }

            if ((PinStatus & 0x20) == 0x20)//bit5 is DI
            {
                Ibit5.Enabled = true;
                Ibit5.Text = "---";
                Obit5.Enabled = false;
                Obit5.Checked = false;
            }
            else//bit5 is DO
            {
                Ibit5.Enabled = false;
                Ibit5.Text = "---";
                Obit5.Enabled = true;
                Obit5.Checked = false;
            }

            if ((PinStatus & 0x40) == 0x40)//bit6 is DI
            {
                Ibit6.Enabled = true;
                Ibit6.Text = "---";
                Obit6.Enabled = false;
                Obit6.Checked = false;
            }
            else//bit6 is DO
            {
                Ibit6.Enabled = false;
                Ibit6.Text = "---";
                Obit6.Enabled = true;
                Obit6.Checked = false;
            }

            if ((PinStatus & 0x80) == 0x80)//bit7 is DI
            {
                Ibit7.Enabled = true;
                Ibit7.Text = "---";
                Obit7.Enabled = false;
                Obit7.Checked = false;
            }
            else//bit7 is DO
            {
                Ibit7.Enabled = false;
                Ibit7.Text = "---";
                Obit7.Enabled = true;
                Obit7.Checked = false;
            }
        }

        private void GetDI()//get digital input port status
        {
            pinValue[0] = DIPin;
            pinData[0] = 0x0;
            if (!AxGetDI(pinValue[0], pinData))
                MessageBox.Show("Wrong Pin Data:" + pinData[0].ToString("X"), "GetDI");
            else
            {
                if (Ibit0.Enabled)
                {
                    if ((pinData[0] & 0x01) == 0x01)
                        Ibit0.Text = "High";
                    else
                        Ibit0.Text = "Low";
                }
                else
                    Ibit0.Text = "---";

                if (Ibit1.Enabled)
                {
                    if ((pinData[0] & 0x02) == 0x02)
                        Ibit1.Text = "High";
                    else
                        Ibit1.Text = "Low";
                }
                else
                    Ibit1.Text = "---";

                if (Ibit2.Enabled)
                {
                    if ((pinData[0] & 0x04) == 0x04)
                        Ibit2.Text = "High";
                    else
                        Ibit2.Text = "Low";
                }
                else
                    Ibit2.Text = "---";

                if (Ibit3.Enabled)
                {
                    if ((pinData[0] & 0x08) == 0x08)
                        Ibit3.Text = "High";
                    else
                        Ibit3.Text = "Low";
                }
                else
                    Ibit3.Text = "---";

                if (Ibit4.Enabled)
                {
                    if ((pinData[0] & 0x10) == 0x10)
                        Ibit4.Text = "High";
                    else
                        Ibit4.Text = "Low";
                }
                else
                    Ibit4.Text = "---";

                if (Ibit5.Enabled)
                {
                    if ((pinData[0] & 0x20) == 0x20)
                        Ibit5.Text = "High";
                    else
                        Ibit5.Text = "Low";
                }
                else
                    Ibit5.Text = "---";

                if (Ibit6.Enabled)
                {
                    if ((pinData[0] & 0x40) == 0x40)
                        Ibit6.Text = "High";
                    else
                        Ibit6.Text = "Low";
                }
                else
                    Ibit6.Text = "---";

                if (Ibit7.Enabled)
                {
                    if ((pinData[0] & 0x80) == 0x80)
                        Ibit7.Text = "High";
                    else
                        Ibit7.Text = "Low";
                }
                else
                    Ibit7.Text = "---";
            }
        }

        private void SetDO()//set digital output port status
        {
            pinValue[0] = DOPin;
            pinData[0] = 0x0;

            if (Obit0.Checked)
                pinData[0] += 0x01;

            if (Obit1.Checked)
                pinData[0] += 0x02;

            if (Obit2.Checked)
                pinData[0] += 0x04;

            if (Obit3.Checked)
                pinData[0] += 0x08;

            if (Obit4.Checked)
                pinData[0] += 0x10;

            if (Obit5.Checked)
                pinData[0] += 0x20;

            if (Obit6.Checked)
                pinData[0] += 0x40;

            if (Obit7.Checked)
                pinData[0] += 0x80;

            if (!AxSetDO(pinValue[0], pinData))
                MessageBox.Show("Error Pin Data:" + pinData[0].ToString("X"), "SetDO");
        }

        private void AxTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _TextBrush;

            // Get the item from the collection.
            TabPage _TabPage = AxTab.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _TabBounds = AxTab.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _TextBrush = new SolidBrush(Color.FromArgb(127, 0, 62));
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                _TextBrush = new SolidBrush(Color.White);
            }

            // Use our own font. Because we CAN.
            Font _TabFont = new Font("PMingLiU", 16, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _StringFlags = new StringFormat();
            _StringFlags.Alignment = StringAlignment.Center;
            _StringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_TabPage.Text, _TabFont, _TextBrush,
                         _TabBounds, new StringFormat(_StringFlags));
        }
    }
}
