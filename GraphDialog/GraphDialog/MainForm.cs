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
    }
}
