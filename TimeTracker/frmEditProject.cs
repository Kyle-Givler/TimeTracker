using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerUI
{
    public partial class frmEditProject : Form
    {
        public frmEditProject()
        {
            InitializeComponent();
        }

        private void frmEditProject_Load(object sender, EventArgs e)
        {
            SetupData();
        }

        private async Task SetupData()
        {

        }
    }
}
