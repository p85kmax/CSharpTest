using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace GraphDialog
{
    public partial class Form_UIFlicker : Form
    {
        public Form_UIFlicker()
        {
            InitializeComponent();
            CreateGraph(zedGraphControl1);
        }
        private void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "My Test Graph";
            myPane.XAxis.Title.Text = "X Value";
            myPane.YAxis.Title.Text = "My Y Axis";

            // Make up some data points from the Sine function
            PointPairList list = new PointPairList();
            for (double x = 0; x < 36; x++)
            {
                double y = Math.Sin(x * Math.PI / 15.0);

                list.Add(x, y);
            }

            // Generate a blue curve with circle symbols, and "My Curve 2" in the legend
            LineItem myCurve = myPane.AddCurve("My Curve", list, Color.Blue,
                                    SymbolType.Circle);
            // Fill the area under the curve with a white-red gradient at 45 degrees
            myCurve.Line.Fill = new Fill(Color.White, Color.Red, 45F);
            // Make the symbols opaque by filling them with white
            myCurve.Symbol.Fill = new Fill(Color.White);

            // Fill the axis background with a color gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);

            // Fill the pane background with a color gradient
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            // Calculate the Axis Scale Ranges
            zgc.AxisChange();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();

            dataGridView1.Enabled = true;
            dataGridView2.Rows.RemoveAt(0);

            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dataGridView2);
            dataGridView2.Rows.Add(dataGridViewRow);



        int n = dataGridView2.Rows.GetLastRow(DataGridViewElementStates.None);
            //dataGridView1[column, row].Value = "";
            //dataGridView1.Rows[row].Cells[column].Value = "";
            dataGridView2[2, 3].Value = 3.14; //세번째 콜룸, 네번째 라우 //인덱스 범위 에러 처리.

            this.ResumeLayout(false);
        }

        private void Form_UIFlicker_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Zone1", typeof(float));
            table.Columns.Add("Zone2", typeof(float));
            table.Columns.Add("Zone3", typeof(float));
            table.Columns.Add("Zone4", typeof(float));
            table.Columns.Add("Zone5", typeof(float));
            table.Columns.Add("Zone6", typeof(float));


            float fval = 3.14f;
            table.Rows.Add("spec", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("Avg", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("Max", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("Min", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("M-m", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("Stdev", fval, fval, fval, fval, fval, fval);
            table.Rows.Add("Var(%)", fval, fval, fval, fval, fval, fval);

            dataGridView1.DataSource = table;

            ///////////////////////////////////////////////////////////////////////////////
            ///    

            string[] titles = new string[] { "spec", "Avg", "Max", "Min", "M-m", "Stdev", "Var(%)" };
            for (int i = 0; i < 7; i++)
            {
                double val = (i+1) + (i+1) / 10.0;

                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                //dataGridViewRow.Cells[0] = val * 1;
                if (i == 0)
                    dataGridViewRow.DefaultCellStyle.BackColor = Color.Gray;

                //dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.Red;

                dataGridViewRow.Height = 40;
                dataGridViewRow.CreateCells(dataGridView2, val*1, val * 2, val * 3, val * 4, val * 5, val * 6);
                dataGridView2.Rows.Add(dataGridViewRow);
                dataGridView2.Rows[i].HeaderCell.Value = titles[i];
            }
            dataGridView2.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dataGridView2.ClearSelection();
            dataGridView1.CurrentRow.Selected = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sender == dataGridView2)
            {
                int a = 123;
                a += 123;
            }
            int selectedRow = e.RowIndex;//콜룸 선택하면 -1
            if (selectedRow > -1)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


public class MyPanel : System.Windows.Forms.Panel
{
    public MyPanel()
    {
        this.SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);
    }
    //이 작업을 수행 한 후에(실제로 수행중인 작업을 알지 못하면 디자이너 코드를 편집하지 않아도되지만) Form.Designer.cs를 편집해야합니다.이 파일 안에는 다음과 같은 코드가 있습니다.
    //this.panelArea = new YourProject.MyPanel();    위의 줄을 다음과 같이 변경해야합니다.
    //this.panelArea = new MyPanel();    이 단계를 완료하면 내 페인트 프로그램이 더 이상 깜박이지 않습니다.

    //Control.SuspendRedraw()
    //this.doStuff()
    //this.doOtherStuff()
    //this.doSomeReallyCoolStuff()
    //Control.ResumeRedaw()
}
