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
    public partial class Form_Files : Form
    {
        public Form_Files()
        {
            InitializeComponent();
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void Form_Files_Load(object sender, EventArgs e)
        {
            ListDirectory(treeView1, @"d:\");
        }

        private void button_PairLoad_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog 보다 괜찮은 폴더 선택 화면 -CommonOpenFileDialog
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

        private void button_Path_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog 보다 괜찮은 폴더 선택 화면 -CommonOpenFileDialog
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var folderPath=dlg.SelectedPath.ToString();
                ListDirectory(treeView1, folderPath);
            }

        }

        private void button_FileNameChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var folderPath = dlg.SelectedPath.ToString();
                ChangeFileNameFromDirectory(new DirectoryInfo(folderPath));
            }
        }
        private TreeNode ChangeFileNameFromDirectory(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(ChangeFileNameFromDirectory(directory));
            foreach (var file in directoryInfo.GetFiles())
            {
               if(file.Name == "MainApp.cs")
                {
                    //var lastFolder = Path.GetDirectoryName(file.FullName);
                    //var pathWithoutLastFolder = Path.GetDirectoryName(lastFolder);
                    var lastfolder2= parentFolderName(file.FullName);
                    var parent = Directory.GetParent(Path.GetDirectoryName(file.FullName));
                    

                    //Path.GetFileName(fullName);                   //test.txt
                    //Path.GetFileNameWithoutExtension(fullName);   //test
                    //Path.GetExtension(fullName);                  //.txt
                    //Path.GetPathRoot(fullName);                   //c:\
                    string dir =Path.GetDirectoryName(file.FullName);              //c:\\folder\\
                    string ext =Path.GetExtension(file.FullName);                  //.txt

                    Path.Combine(dir, lastfolder2 + ext);
                    File.Copy(file.FullName, Path.Combine(parent.FullName, lastfolder2 + ".txt"));

                }
            }
            return directoryNode;
        }

        string parentFolderName(string path)
        {
            DirectoryInfo parentDir = Directory.GetParent(path);
            string dir = Path.GetDirectoryName(path);
            var folders = dir.Split('\\');
            var lastfolderName = folders.Last();
            // or possibly
            // DirectoryInfo parentDir = Directory.GetParent(path.EndsWith("\\") ? path : string.Concat(path, "\\"));
            // The result is available here
            //var myParentDir = parentDir.Parent.FullName;
            return lastfolderName;
        }

    }
}
