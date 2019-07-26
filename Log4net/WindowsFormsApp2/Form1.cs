using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            findpath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string logConfigFile = "..\\cfg\\log4net.xml";
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(logConfigFile);
            var data = log4net.Config.XmlConfigurator.Configure(fileInfo);

            ILog log = LogManager.GetLogger("Operation");
            log.Fatal("DATA...............12345");


            log = LogManager.GetLogger("Console");
            log.Fatal("console DATA...............12345");


        }

        private void findpath()
        {
            string str0 = Application.StartupPath;
            string str1 = Application.ExecutablePath;
            string str2 = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string str3 = System.IO.Path.GetDirectoryName(str2);




            //작업디렉토리...
            string str10 = System.Environment.CurrentDirectory;
            string str11 = System.IO.Directory.GetCurrentDirectory();

        }
    }
}
