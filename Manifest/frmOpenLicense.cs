using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmOpenLicense : Form
    {
        public frmOpenLicense()
        {
            InitializeComponent();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult Res = new frmActiveLicense().ShowDialog();
            Show();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult Res = new frmBuyLicense(false).ShowDialog();
            Show();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult Res = new frmBuyLicense(true).ShowDialog();
            Show();
        }

        private void frmOpenLicense_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsNewLic = true;
            Properties.Settings.Default.Save();
        }
    }
}
