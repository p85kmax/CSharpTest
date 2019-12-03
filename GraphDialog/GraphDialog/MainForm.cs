using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void button1_Click(object sender, EventArgs e)
        {

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

    }
}
