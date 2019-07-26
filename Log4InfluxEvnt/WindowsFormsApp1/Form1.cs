using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using Newtonsoft.Json;

using System.Diagnostics;
using System.Threading;

using InfluxDB.LineProtocol;
using InfluxDB.LineProtocol.Payload;
using InfluxDB.LineProtocol.Client;
//using InfluxDB.Collector;

using log4net;
using log4net.Config;
using System.Runtime.InteropServices;





[assembly: XmlConfigurator(Watch = true)]

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        /// 콘솔 할당하기
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AttachConsole(int dwProcessID);



        public class Product        //Json Data를 만들기 위한 변수 모음
        {
            public double Cos;
            public double Sin;
            public double Random;
        }

        //MQTT client
        MqttClient client = null;

        //Json
        Product product = new Product();
        public Form1()
        {
            //var f=System.Reflection.MethodBase.GetCurrentMethod().DeclaringType;
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void Button1_Connect(object sender, EventArgs e)
        {
            client = new MqttClient("127.0.0.1");
            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId, "", "", true, 10);
            client.Subscribe(new string[] { "/EDMS/Position" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            client.ConnectionClosed += Client_ConnectionClosed;

        }
        private void Button_Disconnect(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.MqttMsgPublishReceived -= Client_MqttMsgPublishReceived;
                client.ConnectionClosed -= Client_ConnectionClosed;
                client.Disconnect();
            }
        }



        private void Client_ConnectionClosed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        delegate void Client_MqttMsgPublishReceivedDelegate(object sender, MqttMsgPublishEventArgs e);

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Client_MqttMsgPublishReceivedDelegate(Client_MqttMsgPublishReceived), sender, e);
                return;
            }
            string receivedMessage = Encoding.UTF8.GetString(e.Message);
            listBox1.Items.Add(receivedMessage);
        }



        private void button2_Click(object sender, EventArgs e)
        {

            string strValue = Convert.ToString(numericUpDown1.Value);
            client.Publish("/EDMS/Position", Encoding.UTF8.GetBytes(strValue), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);


        }

        private void button_InsertDB_Click(object sender, EventArgs e)
        {
            Send_InfluxDB_Test();
        }
        public Dictionary<string, object> _field = new Dictionary<string, object>();
        public IReadOnlyDictionary<string, object> Fields { get { return _field; } }

        public Dictionary<string, string> _tags = new Dictionary<string, string>();
        public IReadOnlyDictionary<string, string> Tags { get { return _tags; } }

        static int distance = 0;

        private void Send_InfluxDB_RVMS()
        {
            InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "gravureprint");
            InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                new InfluxDB.LineProtocol.Payload.LineProtocolPayload();

            if (distance > 100) distance = 0;
            _field.Clear();
            _tags.Clear();
            _tags["model"] = "model123";
            _tags["lot"] = "lot123";


            var val = distance > 10 ? distance % 10 : distance;
            double dval = (double)val / 10.0;


            _field["distance"] = dval;
            _field["left"] = dval;
            _field["right"] = dval;

            var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("rvms", Fields, Tags);
            payload.Add(data);
            Task<LineProtocolWriteResult> influxResult = client.WriteAsync(payload);
            if (!influxResult.Result.Success)
            {
                Debug.Print("▶--RVMS--" + influxResult.Result.ErrorMessage + "...\n");
            }
        }
        private void Send_InfluxDB_PINHOLE()
        {
            InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "gravureprint");
            InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                new InfluxDB.LineProtocol.Payload.LineProtocolPayload();


            if (distance > 100) distance = 0;
            _field.Clear();
            _tags.Clear();
            _tags["model"] = "model123";
            _tags["lot"] = "lot123";

            var val = distance > 10 ? distance % 10 : distance;
            double dval = (double)val % 10.0;

            _field["distance"] = dval;
            _field["count"] = dval;


            var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("pinhole", Fields, Tags);
            payload.Add(data);
            client.WriteAsync(payload).Wait();
        }
        private void Send_InfluxDB_COLORSENSOR()
        {
            InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "gravureprint");
            InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                new InfluxDB.LineProtocol.Payload.LineProtocolPayload();

            if (distance > 100) distance = 0;
            _field.Clear();
            _tags.Clear();
            _tags["model"] = "model123";
            _tags["lot"] = "lot123";
            var val = distance > 10 ? distance % 10 : distance;
            double dval = (double)val / 10.0;
            _field["distance"] = dval;
            _field["brightness"] = dval;

            var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("colorsensor", Fields, Tags);
            payload.Add(data);
            client.WriteAsync(payload).Wait();
        }
        private void Send_InfluxDB_STOPIMAGE()
        {
            InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "gravureprint");
            InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                new InfluxDB.LineProtocol.Payload.LineProtocolPayload();


            if (distance > 100) distance = 0;
            _field.Clear();
            _tags.Clear();
            _tags["model"] = "model123";
            _tags["lot"] = "lot123";
            var val = distance > 10 ? distance % 10 : distance;
            double dval = (double)val / 10.0;
            _field["distance"] = dval;
            _field["size_w"] = dval;
            _field["size_l"] = dval;
            _field["margin_w"] = dval;
            _field["margin_l"] = dval;

            var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("stopimage", Fields, Tags);
            payload.Add(data);
            client.WriteAsync(payload);
        }
        private void Send_InfluxDB_EDMS()
        {
            InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "gravureprint");
            InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                new InfluxDB.LineProtocol.Payload.LineProtocolPayload();

            if (distance > 100) distance = 0;
            _field.Clear();
            _tags.Clear();
            _tags["model"] = "model123";
            _tags["lot"] = "lot123";

            var val = distance > 10 ? distance % 10 : distance;
            double dval = (double)val / 10.0;

            _field["distance"] = dval;
            _field["variation"] = dval;
            var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("edms", Fields, Tags);
            payload.Add(data);
            client.WriteAsync(payload);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            distance++;
            Send_InfluxDB_RVMS();
            Send_InfluxDB_PINHOLE();
            Send_InfluxDB_COLORSENSOR();
            Send_InfluxDB_STOPIMAGE();
            Send_InfluxDB_EDMS();
        }

        private void Send_InfluxDB_Test()
        {
            Task<LineProtocolWriteResult> influxResult = null;
            try
            {
                InfluxDB.LineProtocol.Client.LineProtocolClient client =
                new InfluxDB.LineProtocol.Client.LineProtocolClient(new Uri("http://127.0.0.1:8086"), "unieye");
                InfluxDB.LineProtocol.Payload.LineProtocolPayload payload =
                    new InfluxDB.LineProtocol.Payload.LineProtocolPayload();

                if (client == null)
                    Debug.Print("@@@@@@@@@@@@@@@@@@@@@\n");

                if (distance > 100) distance = 0;
                _field.Clear();
                _tags.Clear();
                _tags["model"] = "model123";
                _tags["lot"] = "lot123";


                //var val = distance > 10 ? distance % 10 : distance;
                double val = distance++;
                double dval = (double)val / 10.0;


                _field["distance"] = dval;
                _field["left"] = dval;
                _field["right"] = dval;

                var data = new InfluxDB.LineProtocol.Payload.LineProtocolPoint("rvms", Fields, Tags);
                payload.Add(data);

                //influxResult=client.WriteAsync(payload);

                //influxResult.Wait();
                //if (!influxResult.Result.Success)
                //    Console.Error.WriteLine(influxResult.Result.ErrorMessage);
            }
            catch (Exception e)
            {
                string err = "";
                Exception er = e;
                while (er.InnerException != null)
                {
                    err += er.Message + "\n";
                    er = er.InnerException;
                }
                Debug.Print(err);
            }
            return;
            //influxResult.Wait();
            //await Task.WhenAll(influxResult);
            //var re = await influxResult;
            //if (!influxResult.Result.Success)
            //{
            //    //Debug.Print("▶-----------" + influxResult.ErrorMessage + "...\n");
            //}

            //var client = new LineProtocolClient(new Uri("http://my-server:8086"), "data");
            //var influxResult = await client.WriteAsync(payload);
            //if (!influxResult.Success)
            //    Console.Error.WriteLine(influxResult.ErrorMessage);


        }


        public AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        private void button1_test_Click(object sender, EventArgs e)
        {
            Debug.Print("1.begin Start........\n");
            Task export = Task.Factory.StartNew(() => Test());
            Debug.Print("2.Starting........\n");

        }
        async private void Test()
        {
            Debug.Print("3.Test  Start........\n");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
                autoResetEvent.WaitOne();


                //Send_InfluxDB_RVMS();
                //Send_InfluxDB_Test();

                Debug.Write("Debug...{0}........\n", i.ToString());
                //task.Wait();
                //Send_InfluxDB_COLORSENSOR();
                Thread.Sleep(500);
            }
            sw.Stop();
            Debug.Print("4.ending........\n");
            MessageBox.Show(sw.ElapsedMilliseconds.ToString() + "ms");
        }

        private void button1_setEvent_Click(object sender, EventArgs e)
        {
            //autoResetEvent.Set();
           // TTest();
            Console.WriteLine("asdf \n");
            //primenumber();
        }


        private Task primenumber()
        {
            return Task.Run(() =>
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                //Thread.Sleep(5000);
                //IEnumerable<int> primes = Enumerable.Range(2, 100000) //Int32.MaxValue - 1
                //    .Where(
                //    number => Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0)
                //    );

                //IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
                //int count = squares.Count();
                //squares.Any();

                double dval = 0;
                int i, j, k;
                for (i = 0; i < 10000; i++)
                    for (j = 0; j < 10000; j++)
                    {
                        //try
                        //{
                            dval = Math.Atan2(i, j);
                        //}
                        //catch (Exception e)
                        //{
                        //    Debug.Print(e.Message);
                        //}
                    }

                sw.Stop();
                MessageBox.Show(sw.ElapsedMilliseconds.ToString() + "ms");
                Debug.Print("+elaped time ........" + sw.ElapsedMilliseconds.ToString() + "\n");
            });
            //Console.WriteLine("First 10 primes");
            //primes
            //    .Take(10)
            //    .ToList()
            //    .ForEach(prime => Console.WriteLine(prime));

            //Console.WriteLine("Primes less than 100");
            //primes
            //    .TakeWhile(p => p < 100)
            //    .ToList()
            //    .ForEach(prime => Console.WriteLine(prime));

            //Console.WriteLine("There are {0:#,###} primes smaller than 100,000",
            //                  primes.TakeWhile(p => p < 100000).Count());

            //Console.WriteLine("There are {0:#,###} primes smaller than 1,000,000",
            //                  primes.TakeWhile(p => p < 1000000).Count());
        }

        async void TTest()
        {
            Debug.Print("Start().....TTest...\n");
            int i = 11;
            Debug.Print("i={0}...start.....\n", i.ToString());
            await primenumber();
            Debug.Print("i={0}...end.....\n", i.ToString());

            Debug.Print("★finish-----TTest ??\n");
            MessageBox.Show("finish-----TTest ??");

        }

        private void button_log4net_Click(object sender, EventArgs e)
        {
            log4net.ILog log = null;

            string AppPath = AppDomain.CurrentDomain.BaseDirectory + @"log4net.xml";
            var file = new System.IO.FileInfo(AppPath);
            var retval =XmlConfigurator.Configure(file);

            string str = "";
            log = log4net.LogManager.GetLogger("Operation");

            log.Debug("Hello logging world!dgfhdfghdh");

        }

        private void BtnConsole_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (success = AllocConsole())
            {
                //AttachConsole(-1);
                //IntPtr console = GetConsoleWindow();
                for (int i = 0; i < 100; i++)
                    Console.WriteLine("console test");
            }
        }
    }
}
