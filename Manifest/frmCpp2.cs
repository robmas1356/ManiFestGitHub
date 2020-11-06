using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmCpp2 : Form
    {
        public frmCpp2()
        {
            InitializeComponent();
        }

        private void frmCpp2_Load(object sender, EventArgs e)
        {
            //Screen scr = Screen.PrimaryScreen;
            //this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            //this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
