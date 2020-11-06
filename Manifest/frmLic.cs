using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using Manifest.ManifestServiceReference;
using zarinpal;
using Microsoft.Win32;

namespace Manifest
{
    public partial class frmLic : Form
    {
        ManifestWSSoapClient manifestWS = new ManifestWSSoapClient();

        public frmLic()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

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

        private void frmLic_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToShortDateString();

            Properties.Settings.Default.IsNewLic = true;
            Properties.Settings.Default.Save();

            txtLineCode.Text = Properties.Settings.Default.LineCode;
            txtCompany.Text = Properties.Settings.Default.Company;

            if (!string.IsNullOrEmpty(txtLineCode.Text.Trim())) chkRenew.Checked = true;

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

        private void AddClient()
        {
            //Should Make MachineCode
            if (manifestWS.InsertClient("MachineCode"
                 , Environment.MachineName
                 , Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString()
                 , Environment.UserName
                 , txtLineCode.Text.Trim()))
            {
                MessageBox.Show("با موفقیت اضافه گردید. لطفا برنامه را دوباره اجرا کنید.");
                Application.Exit();

            }
            else
            {
                MessageBox.Show("عملیات با اشکال روبرو شد. اگر مطمئن هستید از تعداد لایسنس شما باقی مانده است، لطفا با مسئول برنامه تماس حاصل کنید"
                     , "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                #region CheckValidity
                if (manifestWS.ValidateDays(txtLineCode.Text.Trim()) > 0)
                {
                    string MSG = "برای این شماره شناسه قبلاً کد خریداری شده است. آیا مایلید این کامپیوتر با شماره شناسه ذکر شده ثبت گردد؟";
                    if (MessageBox.Show(MSG, "Register"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Warning
                        , MessageBoxDefaultButton.Button2
                        , MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {

                        //Add client
                        AddClient();
                    }
                    else //No
                    {
                        txtLineCode.Text = string.Empty;
                        txtCompany.Text = string.Empty;
                        ActiveControl = txtLineCode;
                    }
                }
                #endregion


                #region CheckTexts

                if (string.IsNullOrEmpty(txtLineCode.Text.Trim()))
                {
                    MessageBox.Show("لطفا شناسه ملی را پر کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtCompany.Text.Trim()))
                {
                    MessageBox.Show("لطفا نام شرکت را پر کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("لطفا ایمیل را پر کنید");
                    return;
                }
                if (string.IsNullOrEmpty(txtMobile.Text.Trim()))
                {
                    MessageBox.Show("لطفا شماره موبایل را پر کنید");
                    return;
                }

                #endregion

                #region CheckRenew
                if (chkRenew.Checked)
                    if (!manifestWS.IsRenewLic(txtLineCode.Text.Trim()))
                    {
                        MessageBox.Show("این شناسه ملی در لیست خریدهای پارسال نیست");
                        chkRenew.Checked = false;
                    }

                #endregion

                string CurrentAmount = "900,000";
                if (chkRenew.Checked) CurrentAmount = "750,000";
                if (txtQty.Value > 3)
                {
                    lblAmount.Text = ((txtQty.Value - 3) * 250000 + int.Parse(CurrentAmount.Replace(",", ""))).ToString("N0");
                }
                else
                {
                    lblAmount.Text = CurrentAmount;
                }

                btnPay.Enabled = true;
                //lblAmount.Text = Convert.ToInt32(lblAmount.Text.Replace(",", "")).ToString("n0");
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در ثبت اطلاعات محاسبات");

            }
        }

        pay payment;
        string auth;

        private void btnPay_Click(object sender, EventArgs e)
        {
            #region SaveData
            Properties.Settings.Default.LineCode = txtLineCode.Text.Trim();
            Properties.Settings.Default.Company = txtCompany.Text.Trim();
            Properties.Settings.Default.Save();
            #endregion

            #region Payment
            payment = new pay("9d217c8e-f979-11e9-b4aa-000c295eb8fc", int.Parse(lblAmount.Text.Replace(",", "")), "Des", "http://e-manifest.ir", txtEmail.Text.Trim(), txtMobile.Text.Trim());
            //auth = payment.StartPay();
            auth = payment.StartPay();
            System.Diagnostics.Process.Start(payment.URL + auth);
            payment.OnPaymentAction += Payment_OnPaymentAction;
            #endregion

            #region SaveDB
            if (!manifestWS.InsertCompany(txtLineCode.Text.Trim(), txtCompany.Text.Trim(), txtEmail.Text.Trim(), txtMobile.Text.Trim(), (int)(txtQty.Value), auth))
                MessageBox.Show("خطا در ثبت اطلاعات شرکت");
            #endregion
        }

        private void Payment_OnPaymentAction(object sender, pay.PayArgs e)
        {
            if (e.RefID == 100)  //OK Payment
            {
                //pictureBox.BackColor = Color.Green;
                //MessageBox.Show("Payment is OK");
            }
            else
            {
                //pictureBox.BackColor = Color.OrangeRed;
                //MessageBox.Show("Payment is not OK");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = true;
            grbRenew.Visible = false;
            btnPay.Visible = true;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRenewLineCode.Text.Trim()) && manifestWS.ValidateDays(txtLineCode.Text.Trim()) > 0)
                    AddClient();
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در ثبت اطلاعات کامپیوتر جدید");
            }
        }
    }
}
