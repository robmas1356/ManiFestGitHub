using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manifest.ManifestServiceReference;
using System.Net;
using zarinpal;
using Microsoft.Win32;
using LogicNP.CryptoLicensing;
using System.ServiceModel;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmActiveLicense : Form
    {

        ManifestWSSoapClient manifestWS = new ManifestWSSoapClient();
        CryptoLicense license = new CryptoLicense("AMQAMQCM4XqxVo9K9N2p8a4eYkVsOExih0xbKDVQBrXo2TGpfWLpAhiDU2hVY/76nYnwmnA3AwABAAE=");

        string MachineCode;
        public frmActiveLicense()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e) => Close();

        private void frmActiveLicense_Load(object sender, EventArgs e)
        {
            if (Utilities.CheckForInternetConnection())
            {
                lblInternetStatus.Text = "Connected";
                lblInternetStatus.ForeColor = Color.Green;
            }
            else
            {
                lblInternetStatus.Text = "Disconnected";
                lblInternetStatus.ForeColor = Color.Red;
            }



        }

        private void btnActive_Click(object sender, EventArgs e)
        {

            #region CheckTextboxes
            if (string.IsNullOrEmpty(txtLineCode.Text.Trim()) || string.IsNullOrEmpty(txtUniqueCode.Text.Trim()))
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را وارد نمائید");
                return;
            }

            //if (txtLineCode.Text.Length < 13)
            //{
            //    MessageBox.Show("شناسه شرکت نادرست میباشد");
            //    return;
            //}

            if (txtUniqueCode.Text.Length < 11)
            {
                MessageBox.Show("شناسه پرداخت نادرست میباشد");
                return;
            }

            #endregion



            if (manifestWS.ValidateDays(txtLineCode.Text.Trim()) > 0)
            {
                string MSG = " آیا مایلید این کامپیوتر با شماره شناسه ذکر شده ثبت گردد؟";
                if (MessageBox.Show(MSG, "Register"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning
                    , MessageBoxDefaultButton.Button2
                    , MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    if (manifestWS.ValidatePaymentNumber(txtLineCode.Text.Trim(), txtUniqueCode.Text.Trim())) //CheckPayment
                    {
                        //Add client
                        AddClient();
                    }
                    else
                    {
                        MessageBox.Show("شناسه پرداخت درست نمی باشد");
                        return;
                    }
                }
                else //No
                {
                    txtLineCode.Text = string.Empty;
                    txtUniqueCode.Text = string.Empty;
                    ActiveControl = txtLineCode;
                }
            }
            else
            {
                MessageBox.Show("این شناسه فعال نیست");
            }
        }
        private void AddClient()
        {
            //Should Make MachineCode
            MachineCode = license.GetLocalMachineCodeAsString();
            if (manifestWS.InsertClient(MachineCode
                 , Environment.MachineName
                 , Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString()
                 , Environment.UserName
                 , txtLineCode.Text.Trim()))
            {
                Properties.Settings.Default.LineCode = txtLineCode.Text.Trim();
                Properties.Settings.Default.Company = manifestWS.CompanyName(txtLineCode.Text.Trim());
                Properties.Settings.Default.Save();
                MessageBox.Show("با موفقیت اضافه گردید. لطفا برنامه را دوباره اجرا کنید.");
                Application.Exit();

            }
            else
            {
                MessageBox.Show("عملیات با اشکال روبرو شد. اگر مطمئن هستید از تعداد لایسنس شما باقی مانده است، لطفا با مسئول برنامه تماس حاصل کنید"
                     , "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
