using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GraphDialog
{
    public partial class Form_RS232c : Form
    {

        enum STATUS{INIT, OPEN, CLOSE };

        public Form_RS232c()
        {
            InitializeComponent();
            initComboBox_com();
            SetState(STATUS.INIT);
        }
        private void initComboBox_com()
        {
            string [] ports =SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                if (!comboBox_Com.Items.Contains(ports[i] ))
                {
                    comboBox_Com.Items.Add(ports[i]);
                }
            }
            comboBox_Com.SelectionStart=0;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            open();
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            close();
        }
        void open()
        {
            string ComPortNum = (string)comboBox_Com.SelectedItem;

            SerialPort sp = new SerialPort();
            if (ComPortNum != null && !serialPort1.IsOpen)
            {
                // Allow the user to set the appropriate properties.
                serialPort1.PortName = ComPortNum;
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;


                // Set the read/write timeouts
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout =123;

                int n = serialPort1.WriteBufferSize;

                serialPort1.Open();
                SetState(STATUS.OPEN);

                serialPort1.PinChanged += SerialPinChangedEventHandler;
                serialPort1.DataReceived += SerialDataReceivedEventHandler;
            }
        }
        void close()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.PinChanged -= SerialPinChangedEventHandler;
                serialPort1.DataReceived -= SerialDataReceivedEventHandler;
                serialPort1.Close();
                SetState(STATUS.CLOSE);
            }
        }
        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {

        }

        static bool RIon = true;
        private void SerialPinChangedEventHandler(object sender, SerialPinChangedEventArgs e)
        {
            //+12v 입력시 On으로 표시됨.
            SerialPort serialport = sender as SerialPort;

            if (e.EventType == SerialPinChange.Break)
                SetColorControl(label_Break, serialport.BreakState);
          
            else if (e.EventType == SerialPinChange.CDChanged)
                SetColorControl(label_DCD, serialPort1.CDHolding);
          
            else if (e.EventType == SerialPinChange.CtsChanged)
                SetColorControl(label_CTS, serialPort1.CtsHolding);
         
            else if (e.EventType == SerialPinChange.DsrChanged)
                SetColorControl(label_DSR, serialPort1.DsrHolding);
          
            else if (e.EventType == SerialPinChange.Ring)//Rising Falling 일때 검지됨.. 핀상태는 알수가 없나?
                SetColorControl(label_RI, RIon ^= true);
        }

        private void SetColorControl(Control ctrl, bool on )
        {  //+12v 입력시 On으로 표시됨.
            ctrl.BackColor = on ? Color.Lime : Color.DarkGreen;
        }


        private void SetState(STATUS status)
        {
            switch (status)
            {
                case STATUS.INIT:
                    comboBox_Com.Enabled = true;
                    button_Open.Enabled = true;
                    button_Close.Enabled = false;

                    break;

                case STATUS.OPEN:
                    comboBox_Com.Enabled = false;
                    button_Open.Enabled = false;
                    button_Close.Enabled = true;
                    break;

                case STATUS.CLOSE:
                    comboBox_Com.Enabled = true;
                    button_Open.Enabled = true;
                    button_Close.Enabled = false;
                    break;
            }
            checkBox_RTS.Enabled = button_Close.Enabled;
            checkBox_DTR.Enabled = button_Close.Enabled;
            label_DCD.Enabled = button_Close.Enabled;
            label_RI.Enabled = button_Close.Enabled;
            label_DSR.Enabled = button_Close.Enabled;
            label_CTS.Enabled = button_Close.Enabled;
            label_Break.Enabled = button_Close.Enabled;
        }

        private void checkBox_RTS_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.RtsEnable =  checkBox_RTS.Checked; //true이면 +12V false 이면 -12V
            SetColorControl(checkBox_RTS, checkBox_RTS.Checked);
            //TXD핀은 재어보니 기본 -12V 임.
            //RS232C는 -3v 이하가 ON, +3V이상 OFF임
        }

        private void checkBox_DTR_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = checkBox_DTR.Checked; //true이면 +12V false 이면 -12V
            SetColorControl(checkBox_DTR, checkBox_DTR.Checked);
        }

        private void Form_RS232c_FormClosing(object sender, FormClosingEventArgs e)
        {
            close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ret = false;

            try
            {
//                serialPort1.Write("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
//                "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789"
//);

//                serialPort1.Write("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");



                serialPort1.Write("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
                    "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789" +
                    "0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");

                byte[] data = new byte[20000];
                serialPort1.Write(data, 0, data.Length);
              //  serialPort1.WriteLine()
                
            }
            catch (Exception ex)
            //catch (TimeoutException to)
            {

                string msg = ex.Message;

            }


        }
    }
}
