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
namespace GraphDialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
        private void button1_Click(object sender, EventArgs e)
        {

            byte a, b, c;
            a = 128;
            b = 133;
            c = 200;

            a = (byte)(a - b);
            b = (byte)(b + c);

            
            List<int> list = new List<int>() { 8, 5, 1 };

            list.Sort((f, g) =>
            {
                int dir = f.CompareTo(g);
                
                return dir;
            });
            //double pi = 3.141592;
            //double val = 1;

            //int n = pi.CompareTo(val);
            //int k = val.CompareTo(pi);
            //int z = val.CompareTo(1);
            //List<int> list = new List<int> { 11, 22, 33, 44, 55, 66 };
            //int A=0, B=0;
            //var nval= list.Aggregate((f, g) =>
            //{
            //    A = f;
            //    B = g;
            //    return f*g;
            //});

            //var cnt = list.Count(k => k > 45);



            //float[] data = new float[1000];
            //for(int i=0; i<1000; i++)
            //{
            //    data[i] = ((float)i / 10.0f);
            //}

            //float[] pfdata = data;
            //for (int i = 0; i < 1000; i++)
            //{
            //    data[i] = ((float)(1000- i) / 10.0f);
            //}

            //double k = 0;
            //foreach(var v in pfdata)
            //{
            //    k += v;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Async dlg = new Form_Async();
            dlg.ShowDialog();
        }

        //스레드 풀  가장 쓰기 쉽지만 가장 효과적이진 않다. TreadPool.QueueUserWorkItem -작업 완료시점 모름, 작업수행결과를 못얻어옴, 취소/예외처리 안됨....
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


    }
}
