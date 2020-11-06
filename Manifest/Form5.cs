using System;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Reflection;


namespace Manifest
{
    public partial class Form5 : Form
    {
        private int Mode;
        private string FilePath, ZipPath;
        private bool outputfile = false;
        public Form5(int _mode)
        {
            InitializeComponent();
            Mode = _mode;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (outputfile)
                msg = "آیا مایلید از برنامه خارج شوید؟";
            else
                msg = "شما هنوز فایل خروجی را نساخته اید. آیا مایلید از برنامه خارج شوید؟";

            if (MessageBox.Show(msg, "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                //if (File.Exists("Manifest.db")) File.Delete("Manifest.db");
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy("Manifest.db", folderBrowserDialog1.SelectedPath + @"\" + Properties.Settings.Default.FileName.Replace("/", "_") + ".sol", true);
                    //MessageBox.Show("اطلاعات مانیفست ذخیره شد\n" + Properties.Settings.Default.FileName + ".sol");
                    MessageBox.Show(string.Format("اطلاعات مانیفست در فایل {0} ذخیره شد", Properties.Settings.Default.FileName.Replace("/", "_")),
                        "Save Manifest", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("عملیات با مشکل مواجه شد\n" + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbSave.Enabled = false;
            timer1.Enabled = false;
            //MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void btnZipfile_Click(object sender, EventArgs e)
        {
            pbSave.Visible = false;
            zipDialog.FileName = Properties.Settings.Default.FileName.Replace("/", "_");
            if (zipDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = ".\\output\\" + Properties.Settings.Default.FileName.Replace("/", "_");
                ZipPath = zipDialog.FileName;


                //Create temp directory
                if (!Directory.Exists("output"))
                {
                    Directory.CreateDirectory("output");
                }


                //Save txt file to temp directory
                try
                {
                    WriteClass.WriteToFile(FilePath, WriteClass.WriteVOY(VOY.GetById(1)));

                    if (Mode != 2)
                    {
                        foreach (BOLViewModel BolItem in BOL.GetAllData())
                        {
                            WriteClass.Append(FilePath, WriteClass.WriteBol(BolItem));
                            WriteClass.Append(FilePath, WriteClass.WriteCtr(CTR.GetById(1)));
                            foreach (CONNViewModel connItem in CONN.GetByBolRef(BolItem.ID))
                            {
                                WriteClass.Append(FilePath, WriteClass.WriteCons(connItem));
                            }
                        }
                    }
                    else  //ship
                    {
                        foreach (BOLViewModel BolItem in BOL.GetAllData())
                        {
                            WriteClass.Append(FilePath, WriteClass.WriteBol(BolItem));

                            foreach (CTRViewModel CtrItem in CTR.GetByRef(BolItem.ID))
                            {
                                WriteClass.Append(FilePath, WriteClass.WriteCtr(CtrItem));

                                foreach (CONNViewModel connItems in CONN.GetByCtrRef(CtrItem.ID))
                                {
                                    WriteClass.Append(FilePath, WriteClass.WriteCons(connItems));
                                }
                            }
                        }
                    }


                    //zip txt file from output directory
                    if (File.Exists(ZipPath)) File.Delete(ZipPath);
                    ZipFile.CreateFromDirectory(@".\output", ZipPath);

                    //Control if it is illigal
                    if (Properties.Settings.Default.Company == "0")
                        Utilities.SendMail("Send Zip file from Manifest", "Win Name:" + Environment.MachineName, ZipPath, "Shahab2025@gmail.com");
                    else
                        File.Delete("a.pz");

                    if (Directory.Exists("output"))
                        Directory.Delete("output", true);

                    pbSave.Visible = true;
                    pbSave.Enabled = true;
                    outputfile = true;

                    timer1.Enabled = true;
                    //MessageBox.Show("عملیات با موفقیت انجام شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("عملیات با مشکل مواجه شد\n" + ex.Message);
                }
            }
        }
    }
}

