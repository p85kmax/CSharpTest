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
    public partial class PropertGridDialog : Form
    {
        public PropertGridDialog()
        {
            InitializeComponent();
        }

        private void PropertGridDialog_Load(object sender, EventArgs e)
        {
            DeviceInfo info = new DeviceInfo();
            this.propertyGrid1.SelectedObject = info;
        }
    }
}
