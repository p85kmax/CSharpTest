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
    public partial class Form_UserControl : Form
    {
        public Form_UserControl()
        {
            InitializeComponent();
            userControl_CircleProgress1.CircleColor = Color.BlueViolet;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (userControl_CircleProgress1.Value >= 100)
                userControl_CircleProgress1.Value = 0;

            if (userControl_CircleProgress2.Value >= 100)
                userControl_CircleProgress2.Value = 0;

            userControl_CircleProgress1.Value += 1;
            userControl_CircleProgress2.Value += 3;
        }
    }
}
