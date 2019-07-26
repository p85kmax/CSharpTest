using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;

namespace GraphDialog
{
    public partial class Form_Image : Form
    {
        Image loaded_image;
        public Form_Image()
        {
            InitializeComponent();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFile = new OpenFileDialog();
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                


                string ResultPath = ofdFile.FileName;
                //this.Visible = false; //폼 감추기 
                if (loaded_image != null)
                {
                    loaded_image.Dispose();
                    loaded_image = null;
                }
                loaded_image = Image.FromFile(ResultPath); //얘는 메모리 문제가 없네.
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                pictureBox1.Image = loaded_image;
            }
        }

        private double[] getMTF(Image image)
        {
            int w = image.Width;
            int h = image.Height;

            byte[] imgar = imageToByteArray(image);
            double[] mtf = new double[w];
            
            int step = 3 * 2;
           // byte[] calbuf = new byte[step];
            for(int i=0; i<w; i++)
            {
               // byte[] temp= imgar[i];
            }
            return mtf;
        }
        //C# 이미지를 byte 배열로 바꾸는 법 
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }

        //C# byte 배열를 image 로 바꾸는 법 
        public Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image recImg = Image.FromStream(ms);
            return recImg;
        }//출처: http://itnhappy.tistory.com/89 [즐거운 IT 연구개발을 위해]

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            string str1, str2;
            str1 =  string.Format("{0}, {1}", e.X, e.Y);
            if(loaded_image !=null)
            {
                int imgW = loaded_image.Width;
                int imgH = loaded_image.Height;
                int picW = pictureBox1.Width;
                int picH = pictureBox1.Height;
                double rx = (imgW) / picW;
                double ry = (imgH) / picH;
                int x = (int)(rx* e.X) ;
                int y = (int)(ry* e.Y) ;

                str2 = string.Format("--ImageCoord({0},{1})", x, y);
                str1 += str2;


                byte[] imagear = imageToByteArray(loaded_image);
                byte[] linedata = new byte[imgW];
                Array.Copy(imagear, imgW * y, linedata, 0, imgW);
                DrawProfile(linedata);
            }

            this.Text = str1 ;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_HideShow_Click(object sender, EventArgs e)
        {
            if(button_HideShow.Text == "Hide")
            {
                button_HideShow.Text = "Show";
                panel2.Visible=false;
                groupBox1.Visible = false;
            }
            else
            {
                button_HideShow.Text = "Hide";
                panel2.Visible = true;
                groupBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form_Image_Load(object sender, EventArgs e)
        {
            int a = 1;
            a = 3;
        }
        private void DrawProfile(byte [] data)
        {
            chart_ProfileX.Series["Series1"].Points.Clear();
            foreach (byte intensity in data)
            {
                chart_ProfileX.Series["Series1"].Points.Add(intensity);
            }
        }
    }
}
