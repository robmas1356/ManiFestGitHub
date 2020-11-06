using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmCpp1 : Form
    {
        public frmCpp1()
        {
            InitializeComponent();
        }

        private void frmCpp1_Load(object sender, EventArgs e)
        {
            //Screen scr = Screen.PrimaryScreen;
            //this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            //this.Top = (scr.WorkingArea.Height - this.Height) / 2;

            cmbSearch.SelectedIndex = 0;

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = EX_IM98.GetAllData();
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
