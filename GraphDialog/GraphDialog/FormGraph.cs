using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Threading;
using System.Diagnostics;

using System.IO.Ports;


namespace GraphDialog
{
    public partial class Form_Graph : Form
    {
        private msProfileGraph msGraph;
        private Thread cpuThread=null;
        bool bKillsw = false;
        private double[] cpuArray = new double[256];
        public Form_Graph()
        {
            InitializeComponent();
            //////////////////////////////////////
            msGraph = new msProfileGraph();
            this.Controls.Add(msGraph);
            msGraph.Location = new Point(10, 10);
            msGraph.BackColor = Color.Black;
            msGraph.Width = 200;
            msGraph.Height = 100;
            msGraph.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            timer1.Interval = 100;
            timer1.Start();
            Random rand = new Random();
            chart1.Series["Series1"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.Add(rand.Next(100));
                chart3.Series["Series1"].Points.Add(rand.Next(100));
            }
            button1_Click(null, null);
            button_DrawMFT_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            chart1.Series["Series1"].Points.Clear();
            //chart3.Series["Series1"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["Series1"].Points.Add(rand.Next(128000));
                //chart3.Series["Series1"].Points.Add(rand.Next(128000));
            }
        }

        private void getPerformanceCounters()
        {
            var cpuPerformanceCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while (bKillsw==false)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerformanceCounter.NextValue(), 0);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (chart3.IsHandleCreated && chart3.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {
                    //
                }
                Thread.Sleep(100);
            }
        }
        private void UpdateCpuChart()
        {
            //if (chart3.IsHandleCreated)
            {
                //chart2.Series["Series1"].Points.Clear();
                chart3.Series["Series1"].Points.Clear();
                for (int i = 0; i < cpuArray.Length - 1; ++i)
                {
                    //chart2.Series["Series1"].Points.AddY(cpuArray[i]);
                    chart3.Series["Series1"].Points.AddY(cpuArray[i]);
                    //chart3.Series["Series1"].Points.Add(rand.Next(128000));
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cpuThread != null)
            {
                bKillsw = true;
                if (cpuThread.Join(200)) ;
                else
                {
                    MessageBox.Show("안죽었다. 강제로 종료");
                    cpuThread.Abort();
                }
                cpuThread = null;
            }
            else
            {
                bKillsw = false;
                cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
                cpuThread.IsBackground = true;
                cpuThread.Start();
            }
        }

        delegate void AddStringDelegate(string str);
        private void AddString(string str)
        {
            if (InvokeRequired)//richTextBox1.InvokeRequired)
            {
                Invoke(new AddStringDelegate(AddString), str);
                return;
            }
            else
            {
                richTextBox1.AppendText(str);
            }
        }

        private void button_serialPort_Click(object sender, EventArgs e)
        {
            SerialPort comport = new SerialPort("COM3");
            comport.BaudRate = 115200;
            comport.Parity = Parity.None;
            comport.StopBits = StopBits.One;
            comport.DataBits = 8;
            comport.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);

            if(!comport.IsOpen)
            {
                comport.Open();
            }

        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sport = sender as SerialPort;
            string str = sport.ReadLine();
            richTextBox1.Invoke((MethodInvoker)delegate { richTextBox1.AppendText("Received: "+str); });
        }



        private void buttonDraw_Click(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            g.Clear(Color.AntiqueWhite);
            Point pt1 = new Point(0, 40);
            Point pt2 = new Point(40, 30);
            PointF ptF1 = new PointF(0F, 80F);
            PointF ptF2 = new PointF(300F, 80F);
            g.DrawLine(pen, pt1, pt2);
            g.DrawLine(pen, ptF1, ptF2);
            g.DrawLine(pen, 0, 120, 300, 120);
            g.DrawLine(pen, 0F, 160F, 300F, 160F);
            ///////////////////////////////////////////

            Pen pen2 = new Pen(Color.Red, 5);
            Rectangle rectC = new Rectangle(50, 55, 50, 50);
            Rectangle rectR = new Rectangle(0, 0, w, h);
            g.DrawArc(pen2, rectC, 0, 270);
            g.DrawRectangle(pen2, rectR);
        }

        private void button_DrawMFT_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            chart2.Series["left"].Points.Clear();
            chart2.Series["right"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                // double left = (double)rand.Next(100) / 100f;
                // double right = (double)rand.Next(100) / 100f;

                 double left = (double)1.0f / ((i+1)*2);
                 double right = (double)1.0f / (i+1);
                chart2.Series["left"].Points.Add(left);
                chart2.Series["right"].Points.Add(right);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cpuThread != null)
            {
                bKillsw = true;
                if (cpuThread.Join(200)) ;
                else
                {
                    MessageBox.Show("안죽었다. 강제로 종료");
                    cpuThread.Abort();
                }
                cpuThread = null;
            }
        }


        public static int ThresholdByIsoData(int[] histogram)
        {
            int bef = histogram.Length / 2;
            while (true)
            {
                int sumL = 0;
                int countL = 0;
                int sumR = 0;
                int countR = 0;
                for (int i = 0; i < bef; i++)
                {
                    sumL += histogram[i] * i;
                    countL += histogram[i];
                }
                for (int i = bef; i < histogram.Length; i++)
                {
                    sumR += histogram[i] * i;
                    countR += histogram[i];
                }

                if (countR == 0)
                {
                    countR++;
                }
                if (countL == 0)
                {
                    countL++;
                }

                int cur = (sumL / countL + sumR / countR) / 2;
                if (cur == bef)
                {
                    break;
                }
                else
                {
                    bef = cur;
                }
            }
            return bef;
        }
        public static int ThresholdByOtsu(int[] histData)
        {

            float sum = 0;
            int total = 0;
            for (int t = 0; t < 256; t++)
            {
                sum += t * histData[t];
                total += histData[t];
            }

            float sumB = 0;
            int wB = 0;
            int wF = 0;

            float varMax = 0;

            int threshold = 0;

            for (int t = 0; t < 256; t++)
            {
                wB += histData[t];               // Weight Background
                if (wB == 0) continue;

                wF = total - wB;                 // Weight Foreground
                if (wF == 0) break;

                sumB += t * histData[t];

                float mB = sumB / wB;            // Mean Background
                float mF = (sum - sumB) / wF;    // Mean Foreground

                // Calculate Between Class Variance
                float varBetween = wB * (float)wF * (mB - mF) * (mB - mF);

                // Check if new maximum found
                if (varBetween > varMax)
                {
                    varMax = varBetween;
                    threshold = t;
                }
            }

            return threshold;
        }
        public static int ThresholdByTriangle(int[] histogram)
        {

            float a;
            float b;
            float c;
            float d;
            int max;

            {
                int min = 0;
                max = 0;
                int maxValue = 0;

                for (int i = 0; i < histogram.Length; i++)
                {
                    if (histogram[i + 1] > 0)
                    {
                        min = i; break;
                    }
                }

                Console.WriteLine("min : " + min);

                for (int i = 0; i < histogram.Length; i++)
                {
                    if (histogram[i] > maxValue)
                    {
                        maxValue = histogram[i];
                        max = i;
                    }
                }

                //a = -maxValue
                //b = max-min
                //c = maxValue*min

                a = -maxValue;
                b = max - min;
                c = maxValue * min;
                d = (float)Math.Sqrt(a * a + b * b);
            }

            int threshold = 0;
            float value = 0;

            Console.WriteLine("max : " + max);

            for (int i = 0; i < max; i++)
            {
                float temp = Math.Abs(a * i + b * histogram[i] + c) / d;
                if (temp > value)
                {
                    value = temp;
                    threshold = i;
                }
            }
            return threshold;
        }

    }

}
