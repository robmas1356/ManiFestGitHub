using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmBuyLicense : Form
    {
        private bool _isRenew;

        public frmBuyLicense(bool IsRenew)
        {
            InitializeComponent();
            _isRenew = IsRenew;
        }

        private void pbClose_Click(object sender, EventArgs e) => Close();

        private void frmBuyLicense_Load(object sender, EventArgs e)
        {
            if(Utilities.CheckForInternetConnection())
            {
                lblInternetStatus.Text = "Connected";
                lblInternetStatus.ForeColor = Color.Green;
            }
            else
            {
                lblInternetStatus.Text = "Disconnected";
                lblInternetStatus.ForeColor = Color.Red;
            }

            if(_isRenew)
            {
                txtLineCode.Text = Properties.Settings.Default.LineCode;
                txtCompany.Text = Properties.Settings.Default.Company;
            }
            else
            {

            }



        }
    }
}
