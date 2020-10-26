using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDialog
{
    public partial class UserControl_CircleProgress : UserControl
    {
        public UserControl_CircleProgress()
        {
            InitializeComponent();
        }
        int max = 100;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("최대 값"), Browsable(true)]
        public int MaxValue
        {
            get { return max; }
            set { max = value; Invalidate(); }
        }

        int val = 80;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("현재 값"), Browsable(true)]
        public int Value
        {
            get { return val; }
            set { val = value; Invalidate(); }
        }

        Color bs = Color.LightGray;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("최대 값"), Browsable(true)]
        public Color BaseColor
        {
            get { return bs; }
            set { bs = value; Invalidate(); }
        }

        Color cs = Color.Orange;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("최대 값"), Browsable(true)]
        public Color CircleColor
        {
            get { return cs; }
            set { cs = value; Invalidate(); }
        }

        int line = 10;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Description("최대 값"), Browsable(true)]
        public int LineWidth
        {
            get { return line; }
            set { line = value; Invalidate(); }
        }



        private int Cal(int a1, int a2, int b2)
        {
            return a1 * b2 / a2;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Invalidate();
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grp = e.Graphics;
            grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            grp.DrawEllipse(new Pen(BaseColor, LineWidth), 10, 10, Width - 20, Height - 20);
            int progress = Cal(Value, MaxValue, 360);
            grp.DrawArc(new Pen(CircleColor, LineWidth), 10, 10, Width - 20, Height - 20, -90, progress);
        }
    }
}
