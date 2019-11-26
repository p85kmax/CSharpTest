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
            table.Columns.Add("Zone1", typeof(float));
            table.Columns.Add("Zone2", typeof(float));
            table.Columns.Add("Zone3", typeof(float));
            table.Columns.Add("Zone4", typeof(float));
            table.Columns.Add("Zone5", typeof(float));
            table.Columns.Add("Zone6", typeof(float));

            table.Rows.Add( 0.1, 0.2, 0.3, 0.4, 0.5, 0.6);
            table.Rows.Add( 0.1, 0.2, 0.3, 0.4, 0.5, 0.6);
            table.Rows.Add( 0.1, 0.2, 0.3, 0.4, 0.5, 0.6);
            table.Rows.Add( 0.1, 0.2, 0.3, 0.4, 0.5, 0.6);
            table.Rows.Add( 0.1, 0.2, 0.3, 0.4, 0.5, 0.6);
            table.Rows.Add( 0.1);

            dataGridView1.DataSource = table;

            ///////////////////////////////////////////////////////////////////////////////
            for (int i = 1; i < 7; i++)
            {
                double val = i + i / 10.0;

                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                //dataGridViewRow.Cells[0] = val * 1;

                
                dataGridViewRow.CreateCells(dataGridView2, val*1, val * 2, val * 3, val * 4, val * 5, val * 6);
                dataGridView2.Rows.Add(dataGridViewRow);
            }
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
