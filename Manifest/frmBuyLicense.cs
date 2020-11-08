using Manifest.ManifestServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zarinpal;

namespace Manifest
{
    public partial class frmBuyLicense : Form
    {
        private bool _isRenew;
        ManifestWSSoapClient manifestWS = new ManifestWSSoapClient();

        public frmBuyLicense(bool IsRenew)
        {
            InitializeComponent();
            _isRenew = IsRenew;
        }

        private void pbClose_Click(object sender, EventArgs e) => Close();

        private void frmBuyLicense_Load(object sender, EventArgs e)
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

            if (_isRenew)
            {
                txtLineCode.Text = Properties.Settings.Default.LineCode;
                txtCompany.Text = Properties.Settings.Default.Company;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (_isRenew)
            {
                try
                {
                    if (string.IsNullOrEmpty(txtLineCode.Text.Trim()))
                    {
                        MessageBox.Show("لطفا شناسه ملی را پر کنید");
                        return;
                    }
                    else
                    {
                        if (!manifestWS.IsRenewLic(txtLineCode.Text.Trim()))
                        {
                            MessageBox.Show("این شناسه ملی در لیست خریدهای پارسال نبوده و قابل تمدید نیست");
                            return;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("بررسی تمدید لایسنس با مشکل روبرو است. مطمئن شوید که اینترنت متصل باشد");
                    Close();
                }
            }
            try
            {
                int CurrentAmount = _isRenew ? 750000 : 900000;
                if (txtQty.Value > 3)
                {
                    CurrentAmount += ((int)txtQty.Value - 3) * 250000;
                }

                lblAmount.Text = CurrentAmount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطایی در محاسبات انجام شده است" + "\n" + ex.Message);
                lblAmount.Text = "0";
            }
        }
        pay payment;
        string auth;
        private void btnPay_Click(object sender, EventArgs e)
        {
            #region CheckTextboxes

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

            try
            {
                #region SaveData
                Properties.Settings.Default.LineCode = txtLineCode.Text.Trim();
                Properties.Settings.Default.Company = txtCompany.Text.Trim();
                Properties.Settings.Default.Save();
                #endregion

                #region Payment
                payment = new pay("9d217c8e-f979-11e9-b4aa-000c295eb8fc", int.Parse(lblAmount.Text.Replace(",", "")), "Des", "http://e-manifest.ir/payment", txtEmail.Text.Trim(), txtMobile.Text.Trim());
                //auth = payment.StartPay();
                auth = payment.StartPay();
                System.Diagnostics.Process.Start(payment.URL + auth);
                payment.OnPaymentAction += Payment_OnPaymentAction;
                #endregion

                #region SaveDB
                if (!manifestWS.InsertCompany(txtLineCode.Text.Trim(), txtCompany.Text.Trim(), txtEmail.Text.Trim(), txtMobile.Text.Trim(), (int)(txtQty.Value), auth))
                    MessageBox.Show("خطا در ثبت اطلاعات شرکت");
                #endregion

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشکلی در پرداخت به وجود آمده است \n" + ex.Message);
            }

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
    }
}
