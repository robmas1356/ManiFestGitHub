using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class Form3 : Form
    {
        private int EditID = 0;
        private int Mode, localSubString = 5;
        public static string Total, Gross, DefValue, lblVoy3Tooltip;
        private bool LoadingDone = false;
        public Form3(int _mode)
        {
            InitializeComponent();
            Mode = _mode;
        }

        //List<CountryCityCodesViewModel> tCountryCityCode = CountryCityCodes.GetAllData();
        //List<CountryCodesViewModel> tCountryCode = CountryCodes.GetAllData();
        //List<PortCodes3ViewModel> tPortCode3;
        //List<PortCodes5ViewModel> tPortCode5;


        clsProgress cPro = new clsProgress();
        private void Form3_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);

            txtVoy1.Text = Properties.Settings.Default.LineCode;
            txtVoy2.Text = Properties.Settings.Default.LineCode;
            txt02.Text = Properties.Settings.Default.LineCode;

            cmb06.DataSource = CustomsCode.GetAllData();
            cmb06.DisplayMember = "Full";

            cmb07.DataSource = CustomsCode.GetAllData();
            cmb07.DisplayMember = "Full";

        }
        private void SetDefaults()
        {
            cmbVoy5.Text = DefValue;
            cmb06.Text = DefValue;
            cmb07.Text = DefValue;
            txt03.Text = Properties.Settings.Default.Company.ToString();
        }
        private bool IsAllRequiredComboboxesFilled()
        {
            if (cmb18.Text.Trim() == string.Empty) return false;
            if (cmb04.Text.Trim() == string.Empty) return false;
            if (cmb05.Text.Trim() == string.Empty) return false;
            if (cmb06.Text.Trim() == string.Empty) return false;
            if (cmb07.Text.Trim() == string.Empty) return false;
            return true;
        }
        private void btnBolSave_Click(object sender, EventArgs e)
        {
            //========== Voy ====================

            //Check empty textboxes
            if (!IsAllRequiredTextFilled())
            {
                MessageBox.Show("لطفا همه فیلدها را پر کنید");
                ActiveControl = txtVoy3;
                return;
            }
            //Check empty ComboBox
            if (!IsAllRequiredComboboxesFilled())
            {
                MessageBox.Show("لطفا همه فیلدها را پر کنید");
                ActiveControl = txtVoy3;
                return;
            }

            //Save or Edit VOY 
            txtVoy3.Enabled = false;
            txtVoy4.Enabled = false;
            cmbVoy5.Enabled = false;
            txtVoy7.Enabled = false;
            dtVoy6.Enabled = false;
            txtVoy10.Enabled = false;


            try
            {
                //if (EditID == 0)
                //{
                VOYViewModel _voy = new VOYViewModel
                {
                    ID = 1,
                    txt1 = "VOY",
                    txt2 = txtVoy1.Text.Trim(),
                    txt3 = txtVoy2.Text.Trim(),
                    txt4 = (Mode == 3) ? cmbVoy3.Text : txtVoy3.Text.Trim(),
                    txt5 = txtVoy4.Text.Trim(),
                    txt6 = cmbVoy5.Text.Trim(),
                    txt7 = dtVoy6.Text.Trim(),
                    txt8 = "",
                    txt9 = "MFI",
                    txt10 = "0",
                    txt11 = txtVoy10.Text.Trim()
                };

                //There is just ONE Voyage so...
                if (VOY.GetAllData().Count == 0)
                    VOY.Insert(_voy);
                else
                    VOY.Update(_voy);

                //WriteClass.WriteToFile("tt", WriteClass.WriteVOY(VOY.GetById(1)));
                //}


                //Save or Edit BOL
                BOLViewModel _bol = new BOLViewModel
                {
                    txt1 = "BOL",
                    txt2 = txt01.Text,
                    txt3 = txt02.Text,
                    txt4 = txt03.Text,
                    txt5 = cmb04.Text,
                    txt6 = cmb05.Text,
                    txt7 = cmb06.Text,
                    txt8 = cmb07.Text,
                    txt9 = dt08.Text,
                    txt10 = "",
                    txt11 = "I",
                    txt12 = "S",
                    txt13 = "",
                    txt14 = "",
                    txt15 = "G",
                    txt16 = "N",
                    txt17 = "D",
                    txt18 = cmb17.Text,
                    txt19 = cmb18.Text,
                    txt20 = txt19.Text,
                    txt21 = txt20.Text,
                    txt22 = txt21.Text,
                    txt23 = txt22.Text,
                    txt24 = "",
                    txt25 = "",
                    txt26 = "",
                    txt27 = txt27.Text,
                    txt28 = txt26.Text,
                    txt29 = "",
                    txt30 = txt29.Text,
                    txt31 = "-",
                    txt32 = txt31.Text,
                    txt33 = "",
                    txt34 = txt33.Text,
                    txt35 = txt34.Text,
                    txt36 = "",
                    txt37 = "",
                    txt38 = "",
                    txt39 = "",
                    txt40 = "",
                    txt41 = "",
                    txt42 = "-",
                    txt43 = "00000000",
                    txt44 = "",
                    txt45 = txt44.Text,
                    txt46 = "-",
                    txt47 = txt44.Text,
                    txt48 = "",
                    txt49 = "",
                    txt50 = "",
                    txt51 = txt50.Text,
                    txt52 = "",
                    txt53 = "0",
                    txt54 = txt53.Text,
                    txt55 = "",
                    txt56 = "",
                    txt57 = "",
                    txt58 = "",
                    txt59 = cmb58.Text,
                    txt60 = "",
                    txt61 = "",
                    txt62 = "",
                };

                if (EditID == 0)
                    BOL.Insert(_bol);
                else
                {
                    _bol.ID = EditID;
                    BOL.Update(_bol);
                    EditID = 0;
                    btnBolSave.Text = "ذخیره بارنامه";
                }

                Properties.Settings.Default.FileName = txtVoy10.Text;
                Properties.Settings.Default.Save();

                //Empty All Textboxes
                foreach (Control c2 in TabPage1.Controls)
                {
                    if (c2 is TextBox)
                        c2.Text = string.Empty;
                    if (c2 is ComboBox)
                        c2.Text = string.Empty;
                }

                txt02.Text = txtVoy1.Text;
                cmbVoy3.Enabled = false;

                SetDefaults();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Refresh dgv
                dgv.DataSource = null;
                dgv.DataSource = BOL.GetAllData();
            }
        }
        private bool IsAllRequiredTextFilled()
        {
            foreach (Control c1 in GroupBox1.Controls)
            {
                txtSearch.Text = "-";
                if ((c1 is TextBox || c1 is ComboBox) && c1.Visible)
                {
                    if (c1.Text == string.Empty)
                        return false;
                }
                txtSearch.Text = "";
            }

            foreach (Control c2 in TabPage1.Controls)
            {
                if ((c2 is TextBox || c2 is ComboBox) && c2.Visible)
                {
                    if (c2.Text == string.Empty)
                        return false;
                }
            }

            return true;
        }
        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv != null)
            {
                foreach (DataGridViewRow r in dgv.Rows)
                {
                    dgv.Rows[r.Index].Cells["No"].Value = (r.Index + 1).ToString();
                }
            }

            //Sum of DGV
            double sumTotalNumber = 0;
            double sumTotalGrossWeight = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                sumTotalNumber += Convert.ToDouble(row.Cells["col4"].Value);
                sumTotalGrossWeight += Convert.ToDouble(row.Cells["col5"].Value);
            }
            txtTotalNumber.Text = sumTotalNumber.ToString();
            txtTotalGross.Text = sumTotalGrossWeight.ToString();

            btnNext.Enabled = dgv.Rows.Count > 0;
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditCol.Index)  //Edit
            {
                EditID = int.Parse(dgv.CurrentRow.Cells["ID"].Value.ToString());

                var BL = BOL.GetById(EditID);
                txt01.Text = BL.txt2;
                txt02.Text = BL.txt3;
                txt03.Text = BL.txt4;
                cmb04.Text = BL.txt5;
                cmb05.Text = BL.txt6;
                cmb06.Text = BL.txt7;
                cmb07.Text = BL.txt8;
                dt08.Text = BL.txt9;
                cmb10.Text = BL.txt11;
                cmb11.Text = BL.txt12;
                cmb14.Text = BL.txt15;
                cmb15.Text = BL.txt16;
                cmb16.Text = BL.txt17;
                cmb17.Text = BL.txt18;
                cmb18.Text = BL.txt19;
                txt19.Text = BL.txt20;
                txt20.Text = BL.txt21;
                txt21.Text = BL.txt22;
                txt22.Text = BL.txt23;
                txt27.Text = BL.txt27;
                txt26.Text = BL.txt28;
                txt29.Text = BL.txt30;
                txt33.Text = BL.txt34;
                txt34.Text = BL.txt35;
                txt44.Text = BL.txt45;
                txt50.Text = BL.txt51;
                txt53.Text = BL.txt54;
                cmb58.Text = BL.txt59;
                btnBolSave.Text = "ذخیره تغییرات";

            }

            if (e.ColumnIndex == DelCol.Index)  //Del
            {
                if (MessageBox.Show("آیا مایلید بارنامه شماره " + dgv.CurrentRow.Cells[2].Value.ToString() + " با متلقاتش پاک شود؟"
                    , "Delete"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    try
                    {
                        int _deleteID = int.Parse(dgv.CurrentRow.Cells["ID"].Value.ToString());
                        BOL.Delete(_deleteID);
                        if (Mode != 2)
                            CONN.DeleteByBolID(_deleteID);
                        else
                        {
                            foreach (CTRViewModel CTRVM in CTR.GetByRef(_deleteID))
                            {
                                CONN.DeleteByCTRID(CTRVM.ID);
                            }

                            CTR.DeleteByBolRef(_deleteID);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        dgv.DataSource = BOL.GetAllData();
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgv.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        }
                    }

                }
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + txtSearch.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("لطفا اطلاعات بارنامه را تکمیل نمایید ، سپس به صفحه بعد بروید "
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand
                    , MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }

            Total = txtTotalNumber.Text;
            Gross = txtTotalGross.Text;

            Hide();
            if (Mode != 2)
                new Form4(Mode).ShowDialog();
            else
                new Form6().ShowDialog();
            Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("Manifest.db");
            new Form2().reload = false;
            Close();
        }
        private void JustNumberWithDot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        private void cmb06_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb06.Text.Length != 5)
                    cmb06.Text = cmb06.Text.Split('_')[1];
            }
            catch
            {
                cmb06.Text = "";
            }

            cmbVoy5.Text = cmb06.Text;

        }
        private void cmb07_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb07.Text.Length != 5)
                    cmb07.Text = cmb07.Text.Split('_')[1];
            }
            catch
            {
                cmb07.Text = "";
            }
        }
        private void cmb04_Leave(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case 1: //Truck
                case 2: //Ship

                    try
                    {
                        if (cmb04.SelectedIndex != -1)
                        {
                            if (cmb04.Text.Length != localSubString)
                                cmb04.Text = cmb04.Text.Substring(cmb04.Text.Length - localSubString).ToUpper();
                        }
                        else
                        {
                            if (cmb04.Text.Trim().Length == 5)
                            {
                                cmb04.Text = cmb04.Text.ToUpper();
                            }
                            else
                            {
                                MessageBox.Show("پورت کد بندر مبدا و بارگیری 5 حرفی می باشد لطفا مجددا پورت را وارد نمایید");
                                cmb04.Text = string.Empty;
                                ActiveControl = cmb04;
                            }
                        }
                    }
                    catch
                    {
                        cmb04.Text = string.Empty;
                    }
                    break;


                case 3: //Air
                    if (cmb04.SelectedValue != null)
                        cmb04.Text = cmb04.SelectedValue.ToString();
                    else
                    {
                        if (cmb04.Text.Trim().Length == 3)
                        {
                            cmb04.Text = cmb04.Text.ToUpper();
                        }
                        else
                        {
                            MessageBox.Show("پورت کد هوایی ( یاتا ) سه حرفی می باشد لطفا مجددا پورت را وارد نمایید");
                            cmb04.Text = string.Empty;
                            ActiveControl = cmb04;
                        }
                    }
                    break;

                default:
                    break;
            }


            cmb05.Text = cmb04.Text;
        }
        private void cmb05_Leave(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case 1: //Truck
                case 2: //Ship

                    try
                    {
                        if (cmb05.SelectedIndex != -1)
                        {
                            if (cmb05.Text.Length != localSubString)
                                cmb05.Text = cmb05.Text.Substring(cmb05.Text.Length - localSubString).ToUpper();
                        }
                        else
                        {
                            if (cmb05.Text.Trim().Length == 5)
                            {
                                cmb05.Text = cmb05.Text.ToUpper();
                            }
                            else
                            {
                                MessageBox.Show("پورت کد بندر مبدا و بارگیری 5 حرفی می باشد لطفا مجددا پورت را وارد نمایید");
                                cmb05.Text = string.Empty;
                                ActiveControl = cmb05;
                            }
                        }
                    }
                    catch
                    {
                        cmb04.Text = string.Empty;
                    }
                    break;

                case 3: //Air
                    if (cmb05.SelectedValue != null)
                        cmb05.Text = cmb05.SelectedValue.ToString();
                    else
                    {
                        if (cmb05.Text.Trim().Length == 3)
                        {
                            cmb05.Text = cmb05.Text.ToUpper();
                        }
                        else
                        {
                            MessageBox.Show("پورت کد هوایی ( یاتا ) سه حرفی می باشد لطفا مجددا پورت را وارد نمایید");
                            cmb05.Text = string.Empty;
                            ActiveControl = cmb05;
                        }
                    }
                    break;
                default:
                    break;
            }



            if (Mode != 3)
            {
                try
                {
                    if (cmb05.Text.Length != localSubString)
                        cmb05.Text = cmb05.Text.Substring(cmb05.Text.Length - localSubString).ToUpper();
                }
                catch
                {
                    cmb05.Text = "";
                }
            }
        }
        private void cmb18_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmb18.Text.Length != 2)
                    cmb18.Text = cmb18.Text.Substring(cmb18.Text.Length - 2).ToUpper();
            }
            catch
            {
                cmb18.Text = "";
            }
        }
        private void Form3_Shown(object sender, EventArgs e)
        {
            cPro.startProgress();


            HeavyLoad();
            SetTooltips();

            cPro.stopProgress();
        }
        private void HeavyLoad()
        {
            switch (Mode)
            {
                case 1:  //Truck
                    lblVoy3.Text = "3 - Truck Name";
                    DefValue = "IRTHR";
                    lblVoy3Tooltip = "شماره کامیون";
                    txtVoy4.Text = "-";

                    //cmb04.DataSource = PortCodes3.GetAllData();
                    //cmb04.DisplayMember = "EN";

                    //cmb05.DataSource = PortCodes3.GetAllData();
                    //cmb05.DisplayMember = "EN";

                    //localSubString = 3;

                    break;
                case 2: //Ship
                    lblVoy3.Text = "3 - Vessel Name";
                    GroupBox1.Text = "اطلاعات سفر دریایی";
                    DefValue = "IRBND";
                    lblVoy3Tooltip = "نام کشتی";
                    txtVoy4.Text = "";

                    txtVoy4.Enabled = true;
                    cmbVoy5.Enabled = true;
                    txtVoy7.Enabled = true;

                    foreach (Control item in TabPage2.Controls)
                    {
                        item.Enabled = true;
                    }

                    //cmb04.DataSource = PortCodes3.GetAllData();
                    //cmb04.DisplayMember = "EN";

                    //cmb05.DataSource = PortCodes3.GetAllData();
                    //cmb05.DisplayMember = "EN";


                    localSubString = 3;

                    break;
                case 3: //Air
                    lblVoy3.Text = "3 - Flight Name";

                    txtVoy4.Enabled = true;
                    txtVoy4.Text = "";

                    GroupBox1.Text = "اطلاعات سفر هوایی";
                    DefValue = "IRIKA";
                    lblVoy3Tooltip = "نام شرکت هواپیمایی";

                    txtVoy3.Visible = false;
                    cmbVoy3.Visible = true;

                    //cmb04.DataSource = PortCodes3.GetAllData();
                    //cmb04.DisplayMember = "EN";

                    //cmb05.DataSource = PortCodes3.GetAllData();
                    //cmb05.DisplayMember = "EN";

                    localSubString = 3;

                    break;
                default:
                    break;
            }

            SetDefaults();

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = BOL.GetAllData();

            cmb18.DataSource = CountryCodes.GetAllData();
            cmb18.DisplayMember = "Full";

            cmb18.Text = "";
            cmb04.Text = "";
            cmb05.Text = "";

            LoadingDone = true;
        }

        private void cmbVoy3_Enter(object sender, EventArgs e) => cmbVoy3.DroppedDown = true;

        private void cmb04_Enter(object sender, EventArgs e)
        {
            //if (cmb04.Items.Count == 0)
            //{
            //    cPro.startProgress();
            //    //cmb04.DataSource = CountryCityCodes.GetAllData();
            //    //cmb04.DataSource = tCountryCityCode;
            //    //cmb04.DisplayMember = "Full";
            //    cPro.stopProgress();
            //}
        }

        private void cmb05_Enter(object sender, EventArgs e)
        {
            //if (cmb05.Items.Count == 0)
            //{
            //    cPro.startProgress();
            //    cmb05.DataSource = CountryCityCodes.GetAllData();
            //    //cmb05.DataSource = tCountryCityCode;
            //    cmb05.DisplayMember = "Full";
            //    cPro.stopProgress();
            //}
        }

        private void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //switch (Mode)
            //{
            //    case 3: tPortCode3 = PortCodes3.GetAllData(); break;
            //    default: tPortCode5 = PortCodes5.GetAllData(); break;
            //}
            //tCountryCityCode = CountryCityCodes.GetAllData();
            //tCountryCode = CountryCodes.GetAllData();
        }

        private void cmb18_Enter(object sender, EventArgs e)
        {
            //if (cmb18.Items.Count == 0)
            //{
            //    //cmb18.DataSource = CountryCodes.GetAllData();
            //    cmb18.DataSource = tCountryCode;
            //    cmb18.DisplayMember = "Full";
            //}
        }

        private void cmb18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LoadingDone) return;

            cmb18_Leave(sender, e);

            switch (Mode)
            {
                case 1: //Truck
                case 2: //ship
                    if (cmb18.Text == "IR")
                    {
                        cmb04.DataSource = CustomsCode.GetAllData();
                        cmb04.DisplayMember = "Full";

                        cmb05.DataSource = CustomsCode.GetAllData();
                        cmb05.DisplayMember = "Full";
                    }
                    else
                    {
                        cmb04.DataSource = PortCodes5.GetData(cmb18.Text);
                        cmb04.DisplayMember = "EN";

                        cmb05.DataSource = PortCodes5.GetData(cmb18.Text);
                        cmb05.DisplayMember = "EN";

                        localSubString = 5;
                    }
                    break;
                case 3: //Air

                    if (PortCodesAir.GetData(cmb18.Text).Count == 0)
                    {
                        MessageBox.Show("کشوری که شما انتخاب کرده اید پشتیبانی نمیشود");
                        ActiveControl = cmb18;
                        cmb18.Text = string.Empty;
                    }
                    else
                    {
                        cmb04.DataSource = PortCodesAir.GetData(cmb18.Text);
                        cmb04.DisplayMember = "Name";
                        cmb04.ValueMember = "FullCode";



                        cmb05.DataSource = PortCodesAir.GetData(cmb18.Text);
                        cmb05.DisplayMember = "Name";
                        cmb05.ValueMember = "FullCode";
                    }
                    break;

                default:
                    break;
            }

            cmb04.Text = string.Empty;
            cmb05.Text = string.Empty;
        }

        private void cmbVoy5_Leave(object sender, EventArgs e)
        {
            if (Mode != 3)
            {
                try
                {
                    if (cmbVoy5.Text.Length != 5)
                        cmbVoy5.Text = cmbVoy5.Text.Split('-')[1];
                }
                catch
                {
                    cmbVoy5.Text = "";
                }
                cmb06.Text = cmbVoy5.Text;
            }
        }

        private void SetTooltips()
        {
            toolTip1.SetToolTip(Label1, "شناسه ملی شرکت حمل");
            toolTip1.SetToolTip(Label2, "شناسه ملی شرکت حمل ");
            toolTip1.SetToolTip(lblVoy3, lblVoy3Tooltip);
            toolTip1.SetToolTip(Label4, "شماره سفر");
            toolTip1.SetToolTip(Label5, "کد بندر تخلیه");
            toolTip1.SetToolTip(Label6, "تعداد دفعات بارگیری");
            toolTip1.SetToolTip(Label7, "تاریخ ورود کالا / تاریخ تخلیه");

            if (Mode != 1) toolTip1.SetToolTip(Label8, "شماره مانیفست");
            else toolTip1.SetToolTip(Label8, "شماره اظهار ترانزیت");

            toolTip1.SetToolTip(Label9, "شماره بارنامه");
            toolTip1.SetToolTip(Label10, "شناسه ملی نمایندگی شرکت حمل ");
            toolTip1.SetToolTip(Label11, "نام نمایندگی شرکت حمل");
            toolTip1.SetToolTip(Label12, "کد و نشانی فرستنده ");
            toolTip1.SetToolTip(Label13, "نام فرستنده");
            toolTip1.SetToolTip(Label14, "کشور مبدأ");
            toolTip1.SetToolTip(Label15, "کد بندری مبدأ");
            toolTip1.SetToolTip(Label16, "کد بندر بارگیری");
            toolTip1.SetToolTip(Label17, "کد بندر تخلیه ");
            toolTip1.SetToolTip(Label18, "کد بندر مقصد");
            toolTip1.SetToolTip(Label19, "تاریخ بارنامه / تاریخ بارگیری");
            toolTip1.SetToolTip(Label20, "شناسه ملی صاحب کالا ");
            toolTip1.SetToolTip(Label21, "تعداد کله بسته ها ");
            toolTip1.SetToolTip(Label22, "وزن کل محموله");
            toolTip1.SetToolTip(Label23, "کد قانون تجارت ");
            toolTip1.SetToolTip(Label24, "کد های بین المللی  حمل و نقل ");
            toolTip1.SetToolTip(Label30, "واحدی معادل بیست و یک پا");
            toolTip1.SetToolTip(Label31, "نام مطلع شونده ");
            toolTip1.SetToolTip(Label32, "نشانی مطلع شونده");
            toolTip1.SetToolTip(Label33, "نام کامل کشتی");
            toolTip1.SetToolTip(Label37, "نشانی صاحب کالا");
            toolTip1.SetToolTip(cmb10, "I  = IMPORT * T = TRANS SHIPMENT");
            toolTip1.SetToolTip(cmb14, "F FCL=Full Container Load * L LCL = Less than Container Load, aka Groupage or Consolidation* M = EMPTY CONTAINER *  B  =  BULK SOLID * Q  = BULK LIQUID *  R  =  RO - RO UNIT *  P  =  PASSENGER  * G  = GENERAL CARGO(BREAK BULK)");
            toolTip1.SetToolTip(cmb16, "D = DIRECT DELIVEY * S = STORAGE IN SHEDS * Y = STORAGE IN YARDS");
            toolTip1.SetToolTip(cmb11, "S  = SEA * A =  AIR * R =  ROAD");
        }
        private void txt01_Leave(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow R in dgv.Rows)
                {
                    if (R.Cells[2].Value.ToString().Equals(txt01.Text.Trim()))
                    {
                        MessageBox.Show("شماره بارنامه تکراری است");
                        txt01.Focus();
                        return;
                    }
                }
            }
        }
        private void txt29_Leave(object sender, EventArgs e)
        {
            if (txt29.Text.Trim().Length == 0) return;
            if (txt29.Text.Trim().Length < 10)
            {
                MessageBox.Show("شناسه ملی یا کد ملی صاحب کالا باید ده یا یازده کاراکتر باشد");
                txt29.Text = string.Empty;
            }
        }
    }
}
