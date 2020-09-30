using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;
using System.Text;
using System.IO;

namespace GraphDialog
{
    public partial class Form_GUI : Form
    {
        public Form_GUI()
        {
            InitializeComponent();
        }

        private void Form_GUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateTreeview();
        }
        //Open the XML file, and start to populate the treeview
        private void populateTreeview()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            dlg.FileName = Application.StartupPath + "\\..\\..\\example.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Just a good practice -- change the cursor to a 
                    //wait cursor while the nodes populate
                    this.Cursor = Cursors.WaitCursor;
                    //First, we'll load the Xml document
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(dlg.FileName);
                    //Now, clear out the treeview, 
                    //and add the first (root) node
                    treeView1.Nodes.Clear();
                    treeView1.Nodes.Add(new  TreeNode(xDoc.DocumentElement.Name));
                    TreeNode tNode = new TreeNode();
                    tNode = (TreeNode)treeView1.Nodes[0];
                    //We make a call to addTreeNode, 
                    //where we'll add all of our nodes
                    addTreeNode(xDoc.DocumentElement, tNode);
                    //Expand the treeview to show all nodes
                    treeView1.ExpandAll();
                }
                catch (XmlException xExc)
                //Exception is thrown is there is an error in the Xml
                {
                    MessageBox.Show(xExc.Message);
                }
                catch (Exception ex) //General exception
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default; //Change the cursor back
                }
            }
        }
        //This function is called recursively until all nodes are loaded
        private void addTreeNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;
            if (xmlNode.HasChildNodes) //The current node has children
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                //Loop through the child nodes
                {
                    xNode = xmlNode.ChildNodes[x];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[x];
                    addTreeNode(xNode, tNode);
                }
            }
            else //No children, so add the outer xml (trimming off whitespace)
                treeNode.Text = xmlNode.OuterXml.Trim();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

            imageBox1.Image = Image.FromFile("D:\\Test.bmp");
            return;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "파일 오픈";
            dlg.FileName = "Choice ImageFile";
            dlg.Filter = "이미지(*.BMP)|*.BMP|모든 파일(*.*)|*.*";
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = dlg.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = dlg.FileName;
                //File경로만 가지고 온다.
//string filePath = fileFullName.Replace(fileName, "");
                var im =Image.FromFile(fileFullName);
                imageBox1.Image = im;

                //MessageBox.Show("Complete");
            }

            
        }
    }
}
