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

    public partial class FormGraph_Color : Form
    {

        List<float> list_DataX = new List<float>();
        List<float> list_DataY = new List<float>();
        Random rand = new Random();
        int distance=0;
        public FormGraph_Color()
        {
            InitializeComponent();
            Init_PiChart();
            timer1.Interval = 1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            list_DataX.Add(distance++);
            list_DataY.Add(rand.Next(200)+12.3f);

            float max = list_DataX[list_DataX.Count-1];
            float min = max - 100;
            int endIndex = list_DataX.Count - 1;

            List<float> lx = list_DataX.FindAll(data => data > min && data < max);

            int beginIndex = endIndex -lx.Count ;
            if (beginIndex < 0) beginIndex = 0;


            List<float> ly = list_DataY.GetRange(beginIndex, endIndex-beginIndex);


            chart_100m.ChartAreas[0].AxisY.Minimum = ly.Min();
            chart_100m.ChartAreas[0].AxisY.Maximum = ly.Max();

            chart_100m.ChartAreas[0].AxisX.Minimum = lx.Min(); 
            chart_100m.ChartAreas[0].AxisX.Maximum = lx.Max();

            chart_100m.Series["graphdata"].Points.DataBindXY(lx, ly);
            ////////////////////////////////////////////////////

            chart_Multi.ChartAreas[0].AxisY.Minimum = ly.Min();
            chart_Multi.ChartAreas[0].AxisY.Maximum = ly.Max();

            chart_Multi.ChartAreas[0].AxisX.Minimum = lx.Min();
            chart_Multi.ChartAreas[0].AxisX.Maximum = lx.Max();

            chart_Multi.Series["graphdata"].Points.DataBindXY(lx, ly);
            chart_Multi.Series["Series3"].Points.DataBindXY(lx, ly);

            chart_Multi.ChartAreas[1].AxisY.Minimum = ly.Min();
            chart_Multi.ChartAreas[1].AxisY.Maximum = ly.Max();

            chart_Multi.ChartAreas[1].AxisX.Minimum = lx.Min();
            chart_Multi.ChartAreas[1].AxisX.Maximum = lx.Max();
            chart_Multi.Series["Series2"].Points.DataBindXY(lx, ly);
            
            ////////////////////////////////////////////////////
            int count = 20;// list_DataX.Count/100;
            int i = 0;
            List<float> Fx = list_DataX.FindAll(f =>
            {
                i++;
                return (i% count == 0);
            });

            i = 0;
            List<float> Fy = list_DataY.FindAll(f =>
            {
                i++;
                return (i % count == 0);
            });
            chart_Full.Series["graphdata"].Points.DataBindXY(Fx, Fy);
        }

        private void Init_PiChart()
        {
            chart_Pie.Series[0].Points.AddXY("이정재", 10);
            chart_Pie.Series[0].Points.AddXY("김윤석", 30);
            chart_Pie.Series[0].Points.AddXY("조승우", 10);
            chart_Pie.Series[0].Points.AddXY("하정우", 10);
            chart_Pie.Series[0].Points.AddXY("최민식", 20);
            chart_Pie.Series[0].Points.AddXY("마동석", 50);
            chart_Pie.Series[0].Points.AddXY("황정민", 10);
            

        }
        private void FormGraph_Color_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void FormGraph_Color_Load(object sender, EventArgs e)
        {
            
            chart_100m.Series["graphdata"].Points.Clear();

            for (distance = 0; distance < 10000; distance++)
            {

                list_DataX.Add(distance);
                list_DataY.Add(rand.Next(200));
                //chart_CertainTime.Series["graphdata"].Points.Add(rand.Next(100));

            }
               //chart_CertainTime.Series["graphdata"].Points.Add(rand.Next(100));
            chart_100m.Series["graphdata"].Points.DataBindXY(list_DataX, list_DataY);
        }
    }
}
