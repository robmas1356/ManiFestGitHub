using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class Form6 : Form
    {
        public Form6() => InitializeComponent();

        private int ContainerEditID = 0, KalaEditID = 0;

        private void txtTotalNumber_TextChanged(object sender, EventArgs e) => btnNext.Enabled = (txtTotalNumber.Text == Form3.Total) && (txtTotalGross.Text == Form3.Gross) ? true : false;

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            new Form5(2).ShowDialog();
            Show();
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();
        private bool IsAllRequiredTextFilled()
        {
            foreach (Control c1 in gbContainer.Controls)
            {
                if ((c1 is TextBox) && (c1.Text == string.Empty))
                    return false;
            }

            return true;
        }

        private void gbKalaStatus() => gbKala.Enabled = dgvContainer.Rows.Count > 0 ? true : false;

        private void Form6_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);

            dgvContainer.AutoGenerateColumns = false;
            dgvKala.AutoGenerateColumns = false;

            if (CTR.GetAllData().Count > 0)
                dgvContainer.DataSource = CTR.GetAllData();

            gbKalaStatus();
            if (dgvKala.Enabled) dgvKala.DataSource = CONN.GetAllData();

            cmbBlNo.DataSource = BOL.GetAllData();
            cmbBlNo.DisplayMember = "txt2";
            cmbBlNo.ValueMember = "ID";

            cmb07.DataSource = PackageCodes.GetAllData();
            cmb07.DisplayMember = "Full";
            cmb07.ValueMember = "Code";

            cmb07.Text = "";

            loadTooltips();
        }

        private void loadTooltips()
        {
            //toolTip1.SetToolTip(this.Label1, "شناسه ملی شرکت حمل");
            //toolTip1.SetToolTip(this.Label2, "تعداد کانتینر");
            //toolTip1.SetToolTip(this.Label3, "وزن خالی کانتینر");
            //toolTip1.SetToolTip(this.Label4, "شماره پلمپ");
            //toolTip1.SetToolTip(this.Label5, "شماره بارنامه");
            //toolTip1.SetToolTip(this.Label6, "شرح کالا");
            //toolTip1.SetToolTip(this.Label7, "تعداد بسته ها");
            //toolTip1.SetToolTip(this.Label8, "کد کالا");
            //toolTip1.SetToolTip(this.Label9, "نوع بسته ها ");
            //toolTip1.SetToolTip(this.Label10, "کد بسته ها ");
            //toolTip1.SetToolTip(this.Label11, "وزن ناخالص");
            //toolTip1.SetToolTip(this.Label12, "حجم به متر مکعب");
            //toolTip1.SetToolTip(this.Label13, "نشانگر خطرناک");
            //toolTip1.SetToolTip(this.Label14, "کالای یخچالی");
            //toolTip1.SetToolTip(this.Label15, "مارک یا نشانه کالا");
            //toolTip1.SetToolTip(this.Label16, "شماره سریال ");
            //toolTip1.SetToolTip(this.Label17, "شماره پالت");
            //toolTip1.SetToolTip(this.TabControl1, "فیلد های ضروری");
            //toolTip1.SetToolTip(this.TabPage1, "فیلد های ضروری");
            //toolTip1.SetToolTip(this.TabPage2, "فیلد های غیرضروری");
        }

        private void dgvContainer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvContainer != null)
            {
                foreach (DataGridViewRow r in dgvContainer.Rows)
                {
                    dgvContainer.Rows[r.Index].Cells["No"].Value = (r.Index + 1).ToString();
                }
            }
        }

        private void dgvContainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditCol.Index)  //Edit
            {
                try
                {
                    cmbBlNo.Enabled = false;
                    gbKala.Enabled = false;
                    ContainerEditID = int.Parse(dgvContainer.CurrentRow.Cells["ID"].Value.ToString());

                    var ctr = CTR.GetById(ContainerEditID);

                    cmbBlNo.Text = ctr.BolNo;
                    txtCtr1.Text = ctr.txt2;
                    txtCtr2.Text = ctr.txt3;
                    cmbCtr3.Text = ctr.txt4;
                    lblCtr3.Text = ctr.txt4;
                    txtCtr4.Text = ctr.txt5;

                    btnSaveContainer.Text = "ذخیره تغییرات";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در خواندن اطلاعات\nError:" + ex.Message);
                }

            }

            if (e.ColumnIndex == DelCol.Index)  //Del
            {
                if (MessageBox.Show("آیا مایلید کانتینر مورد نظر با کالاهای آن حذف شود؟"
                    , "Delete"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button2
                    ) == DialogResult.Yes)
                {
                    try
                    {
                        int _id = int.Parse(dgvContainer.CurrentRow.Cells["ID"].Value.ToString());
                        CONN.DeleteByCTRID(_id);
                        CTR.Delete(_id);
                        if (dgvContainer.Rows.Count == 0) progressBar3.Value = 25;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا در خواندن اطلاعات\nError:" + ex.Message);
                    }
                    finally
                    {
                        dgvContainer.DataSource = null;
                        dgvContainer.DataSource = CTR.GetAllData();

                        RefreshCTR_cmb();

                        dgvKala.DataSource = null;
                        if (dgvKala.Enabled) dgvKala.DataSource = CONN.GetAllData();
                    }
                }
            }
        }

        private void RefreshCTR_cmb()
        {
            cmbContainerNumber.DataSource = null;
            cmbContainerNumber.DataSource = CTR.GetAllData();
            cmbContainerNumber.DisplayMember = "txt2";
            cmbContainerNumber.ValueMember = "ID";
        }

        private void gbKala_EnabledChanged(object sender, EventArgs e)
        {
            if (gbKala.Enabled)
            {
                RefreshCTR_cmb();
            }
        }

        private void btnSaveKala_Click(object sender, EventArgs e)
        {
            try
            {
                CONNViewModel cons = new CONNViewModel
                {
                    CTRRef = int.Parse(cmbContainerNumber.SelectedValue.ToString()),
                    CTRNo = cmbContainerNumber.Text,
                    //BolRef = int.Parse(cmbBlNo.SelectedValue.ToString()),
                    //BolNo = cmbBlNo.Text,
                    txt1 = "CON",
                    txt2 = txt01.Text,
                    txt3 = txt02.Text,
                    txt4 = txt03.Text,
                    txt6 = txt05.Text,
                    txt7 = txt06.Text,
                    txt8 = cmb08.Text,
                    txt9 = cmb07.Text,
                    txt10 = txt09.Text,
                    txt11 = txt10.Text,
                    txt12 = txt11.Text,
                    txt13 = cmb12.Text,
                    txt19 = cmb18.Text,
                };

                if (KalaEditID == 0)//Save
                    CONN.Insert(cons);
                else //Edit
                {
                    cons.ID = int.Parse(dgvKala.CurrentRow.Cells["KALA_ID"].Value.ToString());
                    CONN.Update(cons);

                    cmbContainerNumber.Enabled = true;
                    btnSaveKala.Text = "ذخیره کالا";
                }
                //Empty All Textboxes
                foreach (Control c1 in tabRequired.Controls)
                {
                    if (c1 is TextBox)
                        c1.Text = string.Empty;
                }
                SetTabPage2Defaults();

                progressBar3.Value = 75;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Refresh dgv
                dgvKala.DataSource = null;
                dgvKala.DataSource = CONN.GetAllData();
                KalaEditID = 0;
                btnSaveKala.Text = "دخیره کالا";
            }
        }

        private void SetTabPage2Defaults()
        {
            txt01.Text = "0";
            txt02.Text = "-";
            txt09.Text = "0";
            txt11.Text = "0";
            cmb12.Text = "N";
            cmb18.Text = "N";
        }

        private void dgvKala_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == KalaEditCol.Index)  //Edit
            {
                try
                {
                    cmbContainerNumber.Enabled = false;

                    KalaEditID = int.Parse(dgvKala.CurrentRow.Cells["KALA_ID"].Value.ToString());
                    var conn = CONN.GetById(KalaEditID);

                    cmbContainerNumber.Text = conn.CTRNo;
                    txt01.Text = conn.txt2;
                    txt02.Text = conn.txt3;
                    txt03.Text = conn.txt4;
                    txt05.Text = conn.txt6;
                    txt06.Text = conn.txt7;
                    cmb08.Text = conn.txt8;
                    cmb07.Text = conn.txt9;
                    txt09.Text = conn.txt10;
                    txt10.Text = conn.txt11;
                    txt11.Text = conn.txt12;
                    cmb12.Text = conn.txt13;
                    cmb18.Text = conn.txt19;

                    btnSaveKala.Text = "ذخیره تغییرات";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در خواندن اطلاعات\nError: " + ex.Message);
                }

            }
            if (e.ColumnIndex == KalaDelCol.Index) //Del
            {
                if (MessageBox.Show("آیا مایلید کالای مورد نظر حذف شود؟"
                                    , "Delete"
                                    , MessageBoxButtons.YesNo
                                    , MessageBoxIcon.Question
                                    , MessageBoxDefaultButton.Button2
                                    ) == DialogResult.Yes)
                {
                    try
                    {
                        CONN.Delete(int.Parse(dgvKala.CurrentRow.Cells["KALA_ID"].Value.ToString()));
                        if (dgvKala.Rows.Count == 0) progressBar3.Value = 50;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    finally
                    {
                        dgvKala.DataSource = null;
                        dgvKala.DataSource = CONN.GetAllData();
                    }

                }
            }
        }

        private void dgvKala_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvKala != null)
            {
                foreach (DataGridViewRow r in dgvKala.Rows)
                {
                    dgvKala.Rows[r.Index].Cells["Kala_No"].Value = (r.Index + 1).ToString();
                }
            }

            //Sum of DGV
            double sumTotalNumber = 0;
            double sumTotalGrossWeight = 0;
            foreach (DataGridViewRow row in dgvKala.Rows)
            {
                sumTotalNumber += Convert.ToDouble(row.Cells["column4"].Value);
                sumTotalGrossWeight += Convert.ToDouble(row.Cells["column5"].Value);
            }
            txtTotalNumber.Text = sumTotalNumber.ToString();
            txtTotalGross.Text = sumTotalGrossWeight.ToString();
            btnNext.Enabled = (txtTotalNumber.Text == Form3.Total) && (txtTotalGross.Text == Form3.Gross) ? true : false;

        }

        private void cmb07_Leave(object sender, EventArgs e)
        {
            try
            {
                //cmb08.Text = cmb07.Text.Split('-')[1];
                //cmb07.Text = cmb07.Text.Split('-')[0];

                cmb08.Text = cmb07.SelectedValue.ToString();
                cmb07.Text = cmb07.Text.Split('_')[0];
            }
            catch
            {
                cmb08.Text = "";
                cmb07.Text = "";
            }
        }

        private void btnRefreshKala_Click(object sender, EventArgs e) => dgvKala.DataSource = CONN.GetAllData();


        private void dgvContainer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => RefreshCTR_cmb();

        private void dgvContainer_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => RefreshCTR_cmb();

        private void txt05_Leave(object sender, EventArgs e)
        {
            if (txt05.Text.Trim().Length == 0) return;
            if (txt05.Text.Length < 8)
            {
                MessageBox.Show("تعرفه کالا باید هشت رقم باشد");
                txt05.Focus();
                return;
            }
        }

        private void txtCtr1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCtr1.Text.Trim().Length == 0) return;

                if (txtCtr1.Text.Trim().Length == 12)
                    txtCtr2.Text = txtCtr1.Text.Split('-')[1];
                else
                {
                    MessageBox.Show("شماره کانتینر میباید 12 کاراکتر باشد");
                    ActiveControl = txtCtr1;
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("شماره کانتینر معتبر نمیباشد");
                ActiveControl = txtCtr1;
                return;
            }
        }

        private void cmbCtr3_Leave(object sender, EventArgs e)
        {
            if (cmbCtr3.SelectedIndex >= 0)
            {
                lblCtr3.Text = cmbCtr3.Text.Substring(cmbCtr3.Text.Length - 4);
                if (lblCtr3.Text == "5500") lblCtr3.Text = "15500";
            }
            else
                lblCtr3.Text = cmbCtr3.Text;
            //MessageBox.Show(cmbCtr3.SelectedIndex.ToString());
        }

        private void btnSaveContainer_Click(object sender, EventArgs e)
        {
            if (!IsAllRequiredTextFilled() || (cmbCtr3.Text.Trim() == string.Empty))
            {
                MessageBox.Show("لطفا همه فیلدها را پر کنید");
                ActiveControl = cmbBlNo;
                return;
            }

            try
            {
                //Save or Edit Ctr
                CTRViewModel ctr = new CTRViewModel
                {
                    txt1 = "CTR",
                    BolRef = int.Parse(cmbBlNo.SelectedValue.ToString()),
                    BolNo = cmbBlNo.Text,
                    txt2 = txtCtr1.Text,
                    txt3 = txtCtr2.Text,
                    txt4 = lblCtr3.Text,
                    txt5 = txtCtr4.Text
                };
                if (ContainerEditID == 0)
                    CTR.Insert(ctr);
                else  //Update
                {
                    ctr.ID = int.Parse(dgvContainer.CurrentRow.Cells["ID"].Value.ToString());
                    CTR.Update(ctr);

                    cmbBlNo.Enabled = true;
                }

                //Empty All Textboxes
                foreach (Control c in gbContainer.Controls)
                {
                    if (c is TextBox)
                        c.Text = string.Empty;
                }
                cmbCtr3.Text = "";
                txtCtr4.Text = "0";

                progressBar3.Value = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvContainer.DataSource = CTR.GetAllData();

                RefreshCTR_cmb();
                btnSaveContainer.Text = "ذخیره کانتینر";
                ContainerEditID = 0; gbKalaStatus();
            }

        }
    }
}
