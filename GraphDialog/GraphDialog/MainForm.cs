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

        private void button1_Click_CloudCompare(object sender, EventArgs e)
        {
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

        private void buttonCtrl_Click(object sender, EventArgs e)
        {

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


    }
}
