using LogicNP.CryptoLicensing;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace Manifest
{
    public partial class frmLicense : Form
    {
        public frmLicense()
        {
            InitializeComponent();
        }

        CryptoLicense license;
        string ValidationKey = "AMQAMQCM4XqxVo9K9N2p8a4eYkVsOExih0xbKDVQBrXo2TGpfWLpAhiDU2hVY/76nYnwmnA3AwABAAE=";

        private void frmLicense_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongDateString();//GetNistTime().ToLongDateString();

            license = new CryptoLicense(ValidationKey);

            txtMachineCode.Text = license.GetLocalMachineCodeAsString();
            txtWinName.Text = Environment.MachineName;
            //txtWinVer.Text = Environment.OSVersion.ToString();
            txtWinVer.Text = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString();
            if (CheckForInternetConnection())
            {
                lblInternetStatus.Text = "متصل";
                lblInternetStatus.ForeColor = Color.Green;
            }
            else
            {
                lblInternetStatus.Text = "قطع";
                lblInternetStatus.ForeColor = Color.DarkRed;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
        public static DateTime GetNistTime()
        {
            DateTime dt;

            try
            {
                //var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                //var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("https://time.ir");
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://e-manifest.ir/");
                var response = myHttpWebRequest.GetResponse();
                string todaysDates = response.Headers["date"];
                dt = DateTime.ParseExact(todaysDates,
                                           "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                           CultureInfo.InvariantCulture.DateTimeFormat,
                                           DateTimeStyles.AssumeUniversal);
            }

            catch (Exception)
            {
                MessageBox.Show("دسترسی به تاریخ روز با مشکل مواجه شد");
                dt = DateTime.MinValue;
            }

            return dt;
        }



        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.ToShortDateString() == GetNistTime().ToShortDateString())
            {
                license.LicenseCode = txtValidation.Text.Trim();

                if (license.HasHostAssemblyName)
                {
                    if (license.HostAssemblyName.ToString() != "Manifest")
                    {
                        MessageBox.Show("هویت فعالساز مورد نظر با برنامه مغایرت دارد");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("هویت فعالساز مورد نظر تایید نشد");
                    return;
                }

                if (license.Status== LicenseStatus.InstancesExceeded)
                {
                    MessageBox.Show("تعداد دفعات نصب تمام شده است");
                    return;
                }


                if (license.Status == LicenseStatus.Valid)
                {
                    license.StorageMode = LicenseStorageMode.ToRegistry;
                    license.Save();
                    MessageBox.Show("برنامه با موفقیت فعال شد");
                    Hide();
                    Application.Restart();
                }
                else
                {
                    license.Remove();
                    MessageBox.Show("کد فعال سازی معتبر نمی باشد");
                    txtValidation.Text = string.Empty;
                }
                license.Dispose();
            }
            else  //Date is not OK
            {
                MessageBox.Show("امکان فعال سازی برنامه بدون اتصال به اینترنت میسر نیست");
                return;
            }
        }

        private void txtValidation_TextChanged(object sender, EventArgs e)
        {
            btnValidate.Enabled = txtValidation.Text.Trim().Length == 0 ? false : true;
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (WebClient client = new WebClient())
                //using (client.OpenRead("http://clients3.google.com/generate_204"))
                using (client.OpenRead("https://www.time.ir/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }



        private bool CheckTexboxes()
        {
            if (txtLineCode.Text.Trim() == string.Empty) return false;
            if (txtCompany.Text.Trim() == string.Empty) return false;
            if (txtEmail.Text.Trim() == string.Empty) return false;
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Check textboxes
            if (!CheckTexboxes())
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را وارد کنید");
                return;
            }


            if (!Utilities.IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("لطفا آدرس ایمیل را به درستی وارد نمایید");
                return;
            }

            if (txtBuyLic.Text.Trim() == "")
            {
                MessageBox.Show("ابتدا باید هزینه نرم افزار را پرداخت نمایید و سپس شماره تراکنش را وارد نمایید");
                return;
            }


            if (!CheckForInternetConnection())
            {
                MessageBox.Show("برای ارسال اطلاعات، میباید ارتباط شما با اینترنت برقرار باشد");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;

            string MailBody = string.Format("LineCode: {0}\nCompany: {1}\nMachineCode: {2}\nWinName: {3}\nWinVer: {4}\nEmail: {5}\nPaymentNumber: {6}"
                , txtLineCode.Text, txtCompany.Text, txtMachineCode.Text, txtWinName.Text, txtWinVer.Text, txtEmail.Text, txtBuyLic.Text);

            if (Utilities.SendMail("Manifest Register for " + txtLineCode.Text, MailBody))
            {
                MessageBox.Show("اطلاعات ثبت شد، کد فعالسازی تا چند لحظه دیگر به ایمیل شما ارسال خواهد شد");
                btnSend.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnSend.Enabled = false;
            }
            else
            {
                MessageBox.Show("ارسال اطلاعات با مشکل مواجه شد \nلطفا اطلاعات را به صورت دستی ایمیل فرمایید\nRegister@epl-iran.ir");
                txtMachineCode.Enabled = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtLineCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtLineCode_Leave(object sender, EventArgs e)
        {
            if ((txtLineCode.Text.Length < 11) && (txtLineCode.Text.Trim() != ""))
            {
                MessageBox.Show("شناسه ملی باید 11 رقم باشد");
                txtLineCode.Focus();
            }
        }

        private void btnBuyLic_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://www.epl-iran.ir");

        private void btnHelp_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("http://epl-iran.ir/help_new_manifest/");

        private void txtBuyLic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
