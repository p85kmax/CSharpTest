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
    public partial class msProfileGraph : UserControl
    {
        
        public msProfileGraph()
        {
            InitializeComponent();
        }

        private void msProfileGraph_Load(object sender, EventArgs e)
        {

            var k=0;

        }

        private void msProfileGraph_Paint(object sender, PaintEventArgs e)
        {
            Draw_Test();
        }
        private void Draw_Test()
        {
            int w = this.Width;
            int h = this.Height;
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            g.Clear(Color.AntiqueWhite);
            Point pt1 = new Point(0, 40);
            Point pt2 = new Point(40, 30);
            PointF ptF1 = new PointF(0F, 80F);
            PointF ptF2 = new PointF(300F, 80F);
            g.DrawLine(pen, pt1, pt2);
            g.DrawLine(pen, ptF1, ptF2);
            g.DrawLine(pen, 0, 120, 300, 120);
            g.DrawLine(pen, 0F, 160F, 300F, 160F);
            ///////////////////////////////////////////

            Pen pen2 = new Pen(Color.Red, 5);
            Rectangle rectC = new Rectangle(50, 55, 50, 50);
            Rectangle rectR = new Rectangle(0, 0, w, h);
            g.DrawArc(pen2, rectC, 0, 270);
            g.DrawRectangle(pen2, rectR);
        }
    }
}
