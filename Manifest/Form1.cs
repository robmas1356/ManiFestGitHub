using LogicNP.CryptoLicensing;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Windows.Forms;
using Manifest.ManifestServiceReference;
using Microsoft.Win32;

namespace Manifest
{
    public partial class Form1 : Form
    {

        bool ProgramMode = true;
        public Form1()
        {
            InitializeComponent();
        }

        ManifestWSSoapClient manifestWS = new ManifestWSSoapClient();
        CryptoLicense license;
        //string ValidationKey = "AMQAMQCM4XqxVo9K9N2p8a4eYkVsOExih0xbKDVQBrXo2TGpfWLpAhiDU2hVY/76nYnwmnA3AwABAAE=";

        public void InsertData()
        {
            string Res = manifestWS.InsertData(
                Properties.Settings.Default.Company,
                Properties.Settings.Default.LineCode,
                license.MachineCodeAsString,
                Environment.MachineName,
                Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString(),
                license.ID,
                license.RemainingUsageDays,
                license.DateExpires);
            if (Res != "Inserted" && Res != "Exists")
            {
                string Body = $"Company:{Properties.Settings.Default.Company}" +
                    $",\nLine Code:{Properties.Settings.Default.LineCode}" +
                    $"\nMachine Code: {license.MachineCodeAsString}" +
                    $"\nWin Name:{Environment.MachineName}" +
                    $"\nWin Ver:{Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", "").ToString()}" +
                    $"\nLicense ID:{license.ID}" +
                    $"\nRemaining Days:{license.RemainingUsageDays}" +
                    $"\nExpire Date:{license.DateExpires}" +
                    $"\nCurrent Date:{DateTime.Now.ToShortDateString()}";
                //Email me
                Utilities.SendMail("Insert Data Error", Body, "", "shahab2025@gmail.com");
            }
        }

        //public bool CryptoLicensing(bool IsNewLic = false)
        //{
        //    if (IsNewLic)
        //    {
        //        try
        //        {
        //            int days = int.Parse(manifestWS.ValidateDays(Properties.Settings.Default.LineCode));
        //            //Console.WriteLine("Days:"+days.ToString());
        //            return days > 0 ? true : false;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            return false;
        //        }
        //    }
        //    else  //old lic
        //    {
        //        try
        //        {
        //            license = new CryptoLicense
        //            {
        //                ValidationKey = ValidationKey,
        //                StorageMode = LicenseStorageMode.ToRegistry
        //            };

        //            if (!license.Load())
        //                return false;

        //            if (license.Status == LicenseStatus.Valid)
        //            {
        //                //Read information from lock every time execute program
        //                Properties.Settings.Default.LineCode = license.UserData.Split('#')[0].Split('=')[1].ToString();
        //                Properties.Settings.Default.Company = license.UserData.Split('#')[1].Split('=')[1].ToString();
        //                //Properties.Settings.Default.Save();

        //                return true;
        //            }
        //            else
        //            {
        //                license.Remove();
        //                return false;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //            throw;
        //        }
        //        finally
        //        {
        //            InsertData();
        //            license.Dispose();
        //        }
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            lblCompany.Text =new Form2().CryptoLicensing(Properties.Settings.Default.IsNewLic)
                ? string.Format("این نرم افزار به نام {0} ثبت شده است", Properties.Settings.Default.Company.ToString())
                : "این نرم افزار فعال نیست و شما از نسخه رایگان استفاده میکنید";

            lblManifestVer.Text += ProductVersion;

            //lblValidationDays.Text = (license.RemainingUsageDays + 1).ToString() + " روز";
        }

        private void chkAgreement_CheckedChanged(object sender, EventArgs e) => btnNext.Enabled = chkAgreement.Checked;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ProgramMode)
            {
                new Form2().Show();
                Hide();

            }
            else
            {
                MessageBox.Show("این برنامه در حال آماده سازی است");
                pbManifest_Click(sender, e);
                return;
                //Hide();
                //new frmCpp1().ShowDialog();
                //Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void pbManifest_Click(object sender, EventArgs e)
        {
            pbManifest.Image = Properties.Resources.cover2;
            pbCPP.Image = Properties.Resources.Cover_99_BW;
            pbTel.Image = Properties.Resources.Phone_2;
            ProgramMode = true;
        }

        private void pbCPP_Click(object sender, EventArgs e)
        {
            pbManifest.Image = Properties.Resources.cover4;
            pbCPP.Image = Properties.Resources.Cover_99_Color;
            pbTel.Image = Properties.Resources.Phone_2;
            ProgramMode = false;
        }

        private void pbTel_Click(object sender, EventArgs e)
        {
            pbTel.Image = Properties.Resources.Phone_1;
            pbCPP.Image = Properties.Resources.Cover_99_BW;
            pbManifest.Image = Properties.Resources.cover4;
            ProgramMode = false;
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {
            if (new Form2().CryptoLicensing())
                if (MessageBox.Show("آیا مایلید این لایسنس حذف گردد؟"
                    , "Delete License"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Stop
                    , MessageBoxDefaultButton.Button2
                    , MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    license.Remove();
                    Application.Exit();
                }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                MessageBox.Show("Remaining Days:" + (license.RemainingUsageDays + 1).ToString());

            if (e.KeyCode == Keys.F12)
                MessageBox.Show(manifestWS.ValidateDays(Properties.Settings.Default.LineCode).ToString());

            //if (e.KeyCode == Keys.F5)
            //    new frmLic().ShowDialog();

            //if (e.KeyCode == Keys.F3)
            //{
            //    Hide();
            //    new frmCpp1().ShowDialog();
            //    Show();
            //}
        }

        private void lblManifestVer_Click(object sender, EventArgs e)
        {
            //if (Utilities.SendMail("Email Tester", "This is email test at " + DateTime.Now,"", "Register@epl-iran.ir"))
            //MessageBox.Show("Sent...");

        }


    }
}