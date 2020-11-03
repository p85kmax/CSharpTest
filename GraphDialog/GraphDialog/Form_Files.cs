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
    public partial class Form_Files : Form
    {
        public Form_Files()
        {
            InitializeComponent();
        }


        private void button_PairLoad_Click(object sender, EventArgs e)
        {
            ////FolderBrowserDialog 

            //OpenFileDialog ofdFile = new OpenFileDialog();
            //ofdFile.ShowHelp = true;
            //ofdFile.AutoUpgradeEnabled = false;
            //ofdFile.Title = "IR 파일 오픈";
            //ofdFile.FileName = "IR";
            //ofdFile.Filter = "비트맵(*.jpeg)|*.jpeg|모든 파일(*.*)|*.*";
            //if (ofdFile.ShowDialog() == DialogResult.OK)
            //{
            //    string ResultPath = ofdFile.FileName;
            //    this.Text = ofdFile.FileName;
            //    //this.Visible = false; //폼 감추기 
            //    if (loaded_image != null)
            //    {
            //        loaded_image.Dispose();
            //        loaded_image = null;
            //    }
            //    string filename = Path.GetFileNameWithoutExtension(ofdFile.FileName);
            //    string path = Path.GetDirectoryName(ofdFile.FileName);
            //    string fileExt = Path.GetExtension(ofdFile.FileName);
            //    var split = filename.Split('_');

            //    if (split.Length < 3)
            //    {
            //        MessageBox.Show(this, "File name format invalid");
            //        return;
            //    }
            //    ////////////////////////////////////////////////////////////////////////////
            //    split[3] = "L02";
            //    string IRfullPath = Path.Combine(path, String.Join("_", split) + fileExt);
            //    if (File.Exists(IRfullPath))
            //    {
            //        loaded_image = (Bitmap)Image.FromFile(IRfullPath);
            //        canvasPanel.Clear();
            //        canvasPanel.UpdateImage(loaded_image);
            //        canvasPanel?.ZoomFit();
            //    }
            //    else canvasPanel.Clear();

            //    /////////////////////////////////////////////////////////////////////////////
            //    split[3] = "L01";
            //    string BLUEfullPath = Path.Combine(path, String.Join("_", split) + fileExt);
            //    if (File.Exists(IRfullPath))
            //    {
            //        loaded_image2 = (Bitmap)Image.FromFile(BLUEfullPath); //얘는 메모리 문제가 없네.
            //        pictureBox1.Image = loaded_image2;
            //    }
            //    else pictureBox1.Image = null;
            //}

            //Path.GetFileName(fullName);                   //test.txt
            //Path.GetFileNameWithoutExtension(fullName);   //test
            //Path.GetExtension(fullName);                  //.txt
            //Path.GetPathRoot(fullName);                   //c:\
            //Path.GetDirectoryName(fullName);              //c:\\folder\\

        }
    }
}
