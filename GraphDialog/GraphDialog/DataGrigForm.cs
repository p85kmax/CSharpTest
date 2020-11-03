using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace GraphDialog
{
    public partial class DataGrigForm : Form
    {
        Bitmap capureBitmap;
        public DataGrigForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog 
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            string selected = dlg.SelectedPath;
        }

        public static void Copy(string outputFilename)
        {
            // 주화면의 크기 정보 읽기
            Rectangle rect = Screen.PrimaryScreen.Bounds;
            // 2nd screen = Screen.AllScreens[1]

            // 픽셀 포맷 정보 얻기 (Optional)
            int bitsPerPixel = Screen.PrimaryScreen.BitsPerPixel;
            PixelFormat pixelFormat = PixelFormat.Format32bppArgb;
            if (bitsPerPixel <= 16)
            {
                pixelFormat = PixelFormat.Format16bppRgb565;
            }
            if (bitsPerPixel == 24)
            {
                pixelFormat = PixelFormat.Format24bppRgb;
            }

            // 화면 크기만큼의 Bitmap 생성
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, pixelFormat);

            // Bitmap 이미지 변경을 위해 Graphics 객체 생성
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                // 화면을 그대로 카피해서 Bitmap 메모리에 저장
                gr.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
            }

            // Bitmap 데이타를 파일로 저장
            bmp.Save(outputFilename);
            bmp.Dispose();
        }

        private void btFilesave_Click(object sender, EventArgs e)
        { //File Save
            if (capureBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPG File(*.jpg) | *.jpg";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    capureBitmap.Save(sfd.FileName);
                }
            }
        }

        private void button_Capture_Click(object sender, EventArgs e)
        {
            // Total Screen Capture 
            //capureBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //using (Graphics g = Graphics.FromImage(capureBitmap))
            //{
            //    g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, capureBitmap.Size,
            //        CopyPixelOperation.SourceCopy);
            //    //Picture Box Display
            //    pictureBox1.Image = capureBitmap;
            //}
            pictureBox1.Image = CaptureFom(this);
            pictureBox1.Image.Save("D:\\Capture.png");

        }

        public Bitmap CaptureFom(Form form)
        {
            Bitmap bitmap = new Bitmap(form.Width, form.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(form.PointToScreen(new Point(form.Left, form.Top)), new Point(0, 0), form.Size);
            graphics.Save();
            return bitmap;
        }
        public Bitmap CaptureControl(Form form, Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(form.PointToScreen(new Point(control.Left, control.Top)), new Point(0, 0), control.Size);
            graphics.Save();
            return bitmap;
        }


    }
}
