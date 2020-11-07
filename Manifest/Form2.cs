using LogicNP.CryptoLicensing;
using System;
using System.IO;
using System.Windows.Forms;
using Manifest.ManifestServiceReference;

namespace Manifest
{
    public partial class Form2 : Form
    {
        int mode = 2;
        public bool reload = false;

        ManifestWSSoapClient manifestWS = new ManifestWSSoapClient();


        public Form2()
        {
            InitializeComponent();
        }

        CryptoLicense license;
        string ValidationKey = "AMQAMQCM4XqxVo9K9N2p8a4eYkVsOExih0xbKDVQBrXo2TGpfWLpAhiDU2hVY/76nYnwmnA3AwABAAE=";
        private void Form2_Load(object sender, EventArgs e)
        {
            //Check internet status for protect lock
            if (frmLicense.CheckForInternetConnection() && DateTime.Now.ToShortDateString() == frmLicense.GetNistTime().ToShortDateString())
            {
                Properties.Settings.Default.OfflineCount = 0;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.OfflineCount += 1;
                Properties.Settings.Default.Save();
            }

            if (Properties.Settings.Default.OfflineCount > 5 && Environment.MachineName != "SHAHAB-LAP")
            {
                MessageBox.Show("لطفا به اینترنت وصل شده، تاریخ سیستم را بروز کرده و برنامه را اجرا نمایید");
                Application.Exit();
            }
            try
            {
                if (!CryptoLicensing(Properties.Settings.Default.IsNewLic))
                //new frmLicense().ShowDialog();
                {
                    // new frmLic().ShowDialog();
                    new frmOpenLicense().ShowDialog();
                    Application.Exit();
                }
            }
            catch (Exception eex)
            {
                MessageBox.Show("خطا در اجرای برنامه");
               Utilities.SendError("Lock Error", eex.Message);

                Application.Exit();
            }

            if (Properties.Settings.Default.Company == "0")
            {
                MessageBox.Show("خطا در اجرای برنامه");
                // Utilities.SendError("Caption Error", "Company is zero\n Win Name:"+Environment.MachineName);
                Application.Exit();
            }
        }

        public bool CryptoLicensing(bool IsNewLic=false)
        {
            if (IsNewLic)
            {
                try
                {
                    int days = manifestWS.ValidateDays(Properties.Settings.Default.LineCode);
                    //Console.WriteLine("Days:"+days.ToString());
                    if( days > 0)
                    {
                        if (Properties.Settings.Default.OfflineCount != 0)
                        {
                            Properties.Settings.Default.OfflineCount = 0;
                            Properties.Settings.Default.Save();
                        }
                        return true;
                    }
                    else
                    {
                        Properties.Settings.Default.OfflineCount += 1;
                        Properties.Settings.Default.Save();

                        if (Properties.Settings.Default.OfflineCount < 5)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                try
                {
                    license = new CryptoLicense
                    {
                        ValidationKey = ValidationKey,
                        StorageMode = LicenseStorageMode.ToRegistry
                    };

                    if (!license.Load())
                        return false;

                    if (license.Status == LicenseStatus.Valid)
                    {
                        //if (license.HasUserData)
                        //{
                        //    string aaa = license.ParseUserData("#")["linecode"].ToString();
                        //    MessageBox.Show(aaa);
                        //}
                        //Read information from lock every time execute program
                        Properties.Settings.Default.LineCode = license.UserData.Split('#')[0].Split('=')[1].ToString();
                        Properties.Settings.Default.Company = license.UserData.Split('#')[1].Split('=')[1].ToString();
                        //Properties.Settings.Default.Save();
                        return true;
                    }
                    else
                    {
                        license.Remove();
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                finally
                {
                    license.Dispose();
                }
            }
        }
        private void pbTruck_Click(object sender, EventArgs e)
        {
            pbTruck.Image = Properties.Resources.Truck2; //Active
            pbShip.Image = Properties.Resources.Ship2;
            pbAir.Image = Properties.Resources.Airplan2;
            mode = 1;
        }

        private void pbShip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("در نسخه آزمایشی این گزینه غیر فعال است");
            //return;

            pbTruck.Image = Properties.Resources.Truck1;
            pbShip.Image = Properties.Resources.Ship1; //Active
            pbAir.Image = Properties.Resources.Airplan2;
            mode = 2;
        }

        private void pbAir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("در نسخه آزمایشی این گزینه غیر فعال است");
            //return;

            pbTruck.Image = Properties.Resources.Truck1;
            pbShip.Image = Properties.Resources.Ship2;
            pbAir.Image = Properties.Resources.Airplan1; //Active
            mode = 3;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (!reload)
                {
                    File.Copy("_db.db", "Manifest.db", true);
                }

                //if(!File.Exists("Manifest.db"))
                //{
                //    File.Copy("_db.db", "Manifest.db");
                //}

                SettingViewModel setMode = new SettingViewModel
                {
                    ID = 1,
                    Ver = int.Parse(System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Build.ToString()),
                    Mode = mode
                };
                Setting.Update(setMode);
            }
            catch (Exception)
            {
                MessageBox.Show("عملیات ایجاد مانیفست با مشکل مواجه  شد. با پشتیبانی تماس بگیرید");
            }
            Hide();
            new Form3(mode).ShowDialog();
            Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(openFileDialog1.FileName, "Manifest.db", true);
                    reload = true;

                    if (Setting.GetData("VER") == System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Build.ToString())
                        switch (int.Parse(Setting.GetData("Mode")))
                        {
                            case 1:
                                pbTruck_Click(sender, e);
                                break;
                            case 2:
                                pbShip_Click(sender, e);
                                break;
                            case 3:
                                pbAir_Click(sender, e);
                                break;
                        }

                    else
                    {
                        //Setting.CreateSettingtbl();
                        //SettingViewModel sv = new SettingViewModel
                        //{
                        //    ID = 1,
                        //    Ver = 1,
                        //    Mode = mode
                        //};
                        //Setting.Insert(sv);
                        MessageBox.Show("فایل فراخوانی شده با نسخه برنامه هماهنگی ندارد");
                        File.Delete("Manifest.db");
                        Cursor.Current = Cursors.Default;

                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("فایل بازخوانی شده با نسخه برنامه هماهنگی ندارد");
                    File.Delete("Manifest.db");
                    Cursor.Current = Cursors.Default;
                    return;
                    ////MessageBox.Show("Loading data file error\n" + ex.Message);
                }
            }
            Cursor.Current = Cursors.Default;
            btnNext_Click(sender, e);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNewDB_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("_db.db", "Manifest.db", true);
                MessageBox.Show("بانک اطلاعاتی خالی شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در خالی کردن بانک اطلاعاتی" + "\n" + ex.Message);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //Utilities.CaptureScreen("log.jpg");
        }
    }
}
