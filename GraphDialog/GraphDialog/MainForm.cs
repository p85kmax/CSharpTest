using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;



namespace GraphDialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            var a=SystemInformation.MouseHoverTime ;
            InitializeComponent();
        }

        private void button_GUI_Click(object sender, EventArgs e)
        {
            Form_GUI dlg = new GraphDialog.Form_GUI();
            dlg.ShowDialog();
        }

        private void button_Graph_Click(object sender, EventArgs e)
        {
            Form_Graph dlg = new GraphDialog.Form_Graph();
            dlg.ShowDialog();
        }
        private void button_Graph2_Click(object sender, EventArgs e)
        {
            FormGraph_Color dlg = new GraphDialog.FormGraph_Color();
            dlg.ShowDialog();
        }
        private void button_Image_Click(object sender, EventArgs e)
        {
            Form_Image dlg = new GraphDialog.Form_Image();
            dlg.ShowDialog();
        }

        private void button_RS232c_Click(object sender, EventArgs e)
        {
            Form_RS232c dlg = new GraphDialog.Form_RS232c();
            dlg.ShowDialog();
        }

        private void button_UI_Flicker_Click(object sender, EventArgs e)
        {
            Form_UIFlicker dlg = new GraphDialog.Form_UIFlicker();
            dlg.ShowDialog();
        }
        private void button_ChartArray_Click(object sender, EventArgs e)
        {
            ChartArray dlg = new GraphDialog.ChartArray();
            dlg.ShowDialog();
        }
        private void button_UserControl_Click(object sender, EventArgs e)
        {
            Form_UserControl dlg = new GraphDialog.Form_UserControl();
            dlg.ShowDialog();
        }
        private void button_DataGridForm_Click(object sender, EventArgs e)
        {
            DataGrigForm dlg = new GraphDialog.DataGrigForm();
            dlg.ShowDialog();
        }

        class ABC
        {
            public bool IsValid()
            {
                return true;
            }
        }
        private void button1_Click_CloudCompare(object sender, EventArgs e)
        {
            ABC abc = null;

            bool btest = false;
            var c = abc?.IsValid();
            if (btest= abc?.IsValid() == false)
            {
                
                return;

            }


            return;


            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "파일 오픈";
            dlg.FileName = "Choice ConvertFile";
            dlg.Filter = "아스키(*.csv)|*.csv|모든 파일(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = dlg.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = dlg.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");


                StreamReader sr = new StreamReader(fileFullName, Encoding.GetEncoding("euc-kr"));
                StreamWriter sw = new StreamWriter(fileFullName + "_", false,  Encoding.UTF8);

                int i = 0;
                int j = 0;

                float x, y;
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    
                    
                    string[] temp = s.Split(',');        // Split() 메서드를 이용하여 ',' 구분하여 잘라냄

                    foreach(var val in temp)
                    {
                        x = 0.01f * i;
                        y = 0.01f * j;
                        i++;

                        if (val == "-99999.9999") continue;
                        sw.WriteLine(x.ToString() + "," + y.ToString()+ "," + val);
                    
                    }
                    j++;
                    i = 0;
                }
                sr.Close();
                sw.Close();

                MessageBox.Show("Complete");
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Async dlg = new Form_Async()                ;
            dlg.ShowDialog();

        }
        private void button_Files_Click(object sender, EventArgs e)
        {
            Form_Files dlg = new Form_Files();
            dlg.ShowDialog();
        }

        //스레드 풀  가장 쓰기 쉽지만 가장 효과적이진 않다.
        //TreadPool.QueueUserWorkItem -작업 완료시점 모름,
        //작업수행결과를 못얻어옴, 취소/예외처리 안됨....
        //Task<int>
        //Task(Action()).Run(); >> Task.Wait();  
        //ConfigureWait(false); 병렬화됨.
        void SaveXml()
        {
            // using System.Xml;

            XmlDocument xdoc = new XmlDocument();

            // 루트노드
            XmlNode root = xdoc.CreateElement("Employees");
            xdoc.AppendChild(root);

            // Employee#1001
            XmlNode emp1 = xdoc.CreateElement("Employee");
            XmlAttribute attr = xdoc.CreateAttribute("Id");
            attr.Value = "1001";
            emp1.Attributes.Append(attr);

            XmlNode name1 = xdoc.CreateElement("Name");
            name1.InnerText = "Tim";
            emp1.AppendChild(name1);

            XmlNode dept1 = xdoc.CreateElement("Dept");
            dept1.InnerText = "Sales";
            emp1.AppendChild(dept1);

            root.AppendChild(emp1);

            // Employee#1002
            var emp2 = xdoc.CreateElement("Employee");
            var attr2 = xdoc.CreateAttribute("Id");
            attr2.Value = "1002";
            emp2.Attributes.Append(attr2);

            var name2 = xdoc.CreateElement("Name");
            name2.InnerText = "John";
            emp2.AppendChild(name2);

            XmlNode dept2 = xdoc.CreateElement("Dept");
            dept2.InnerText = "HR";
            emp2.AppendChild(dept2);

            root.AppendChild(emp2);

            // XML 파일 저장
            xdoc.Save(@"C:\Temp\Emp.xml");


            /* 출력파일 Emp.xml

            <Employees>
              <Employee Id="1001">
                <Name>Tim</Name>
                <Dept>Sales</Dept>
              </Employee>
              <Employee Id="1002">
                <Name>John</Name>
                <Dept>HR</Dept>
              </Employee>
            </Employees>

            */
        }
        void LoadXml()
        {
            // using System.Xml;

            XmlDocument xdoc = new XmlDocument();

            // XML 데이타를 파일에서 로드
            xdoc.Load(@"C:\Temp\Emp.xml");

            // 특정 노드들을 필터링
            XmlNodeList nodes = xdoc.SelectNodes("/Employees/Employee");

            foreach (XmlNode emp in nodes)
            {
                // Attribute 읽기
                string id = emp.Attributes["Id"].Value;

                // 특정 자식 Element 읽기
                string name = emp.SelectSingleNode("./Name").InnerText; //Relative Path 사용
                string dept = emp.SelectSingleNode("Dept").InnerText;   //간단히 자식 Element명 사용
                Console.WriteLine(id + "," + name + "," + dept);

                // 자식 노드들에 대해 Loop를 도는 예
                foreach (XmlNode child in emp.ChildNodes)
                {
                    Console.WriteLine("{0}: {1}", child.Name, child.InnerText);
                }
            }

            // 특정 Id 속성으로 하나의 Employee 검색 예
            XmlNode emp1002 = xdoc.SelectSingleNode("/Employees/Employee[@Id='1002']");
            Console.WriteLine(emp1002.InnerXml);
        }

        private void buttonCtrl_Click(object sender, EventArgs e)
        {
            Socket soket= new Socket(SocketType.Stream, ProtocolType.Tcp);
            var time = soket.ReceiveTimeout;
            var time2 = soket.SendTimeout;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
          //  panel1.BackColor = Color.DarkBlue;
           // Invalidate();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DimGray;
           // Invalidate();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkBlue;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var value = Decimal.ToSingle(numericUpDown1.Value);
        }

 

        private void textBox_OnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

                int[] arr = { -10, 20, -30, 4, -5 };

                // Predicate의 사용
                //   Array.Find(int[], Predicate<int>)    
                int pos = Array.Find(arr, IsPositive);

                // LINQ에서 Func의 사용
                //   Where(Func<int, bool> predicate)
                var v = arr.Where(n => n >= 0);

            bool IsPositive(int i)
            {
                return i >= 0;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPropertyGrid_Click(object sender, EventArgs e)
        {
            PropertGridDialog dlg = new GraphDialog.PropertGridDialog();
            dlg.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Task testTask2 = Task.Run(() => Check_Sleep_Error());
            //Thread first = new Thread(new ThreadStart(Check_Sleep_Error)  );
            var MainThread = new Thread(Check_Sleep_Error);
            MainThread.Priority = ThreadPriority.Highest;
            MainThread.Start();
        }

        static void Check_Sleep_Error()
        {
            Debug.WriteLine("Start---Check_Sleep_Error()");
            StreamWriter sw = new StreamWriter(new FileStream("d:\\SleepTest55.csv", FileMode.Create));
            Stopwatch watch = new Stopwatch();
            SWSleep utimer = new SWSleep();
            for (int i = 0; i < 10000000; i++) ;

                var systimer = new System.Timers.Timer();
            for (int i = 0; i < 100; i++)
            {
                watch.Reset();
                watch.Start();
                utimer.MSleep(1000);
                watch.Stop();
                double elapsed = (double)watch.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
                Debug.WriteLine(i.ToString(), elapsed.ToString());
                sw.WriteLine(string.Format("{0},{1}",i, elapsed.ToString()) );
            }
            sw.Close();
            Debug.WriteLine("Finish---Check_Sleep_Error()");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int w = 1024;
            int h = 768;
            byte[] data = new byte[w * h];

            for(int j=0; j<h; j++)
            {
                for(int i=0; i<w; i++)
                {
                    data[j * w + i] =(byte) ((i + j) % 255);
                }
            }


            IntPtr ptr = Marshal.AllocHGlobal((Int32)w * h);
            Marshal.Copy(data, 0, ptr, w * h);

            SaveRaw("d:\\mashal.1024.768.raw", ptr,(uint)( w * h));


            Marshal.Release(ptr);

        }
        static void SaveRaw(string filename, IntPtr pData, uint size)
        {
            byte[] data = new byte[size];

            for (int i = 0; i < size; i++) data[i] = (byte)(i % 255);
            FileStream pFile = null;
            try
            {
                Marshal.Copy(pData, data, 0, (int)size);
                pFile = new FileStream(filename, FileMode.Create);
                pFile.Write(data, 0, data.Length);
            }
            catch
            {
                Console.WriteLine("fuck");
            }
            finally
            {
                pFile.Close();
            }
        }

    }




    class SWSleep
    {
        long freq = 0;
        public SWSleep()
        {
            this.freq = Stopwatch.Frequency;
            USleep(0);
        }

        internal void USleep(int us)
        {
            double sec = (double)us / 1000000;
            Stopwatch sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks / (double)freq < sec)
            {
              //  Thread.Sleep(0);
            }
        }

        internal void MSleep(int ms)
        {
            double sec = (double)ms / 1000;
            Stopwatch sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks / (double)freq < sec)
            {
              //  Thread.Sleep(0);
            }
        }
    }//    출처: https://ehdrn.tistory.com/402 [동구의 블로그:티스토리]
}
