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
    public partial class Form_UIFlicker : Form
    {
        public Form_UIFlicker()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            chart1.Series[0].Points.AddXY("최민수", 10);
            chart1.Series[0].Points.AddXY("이정재", 15);
            chart1.Series[0].Points.AddXY("마동석", 38);
            chart1.Series[0].Points.AddXY("김윤석", 20);
            chart1.Series[0].Points.AddXY("하정우", 10);
            chart1.Series[0].Points.AddXY("최민식", 23);
            chart1.Series[0].Points.AddXY("조재윤", 10);
            chart1.Series[0].Points.AddXY("최귀화", 30);
            chart1.Series[0].Points.AddXY("임시완", 8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            dataGridView2.Rows.RemoveAt(0);

            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(dataGridView2);
            dataGridView2.Rows.Add(dataGridViewRow);



        int n = dataGridView2.Rows.GetLastRow(DataGridViewElementStates.None);
            //dataGridView1[column, row].Value = "";
            //dataGridView1.Rows[row].Cells[column].Value = "";
            dataGridView2[2, 3].Value = 3.14; //세번째 콜룸, 네번째 라우 //인덱스 범위 에러 처리.


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
    }
}
