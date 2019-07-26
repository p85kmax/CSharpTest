using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleImageView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = (Bitmap)Image.FromFile(@"C:\\그라비아\\F4.7, S50, L90.BMP", true);
        }
    }
}
