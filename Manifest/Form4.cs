using System;
using System.Windows.Forms;

namespace Manifest
{
    public partial class Form4 : Form
    {
        private int EditID = 0;
        private int Mode;


        public Form4(int _mode)
        {
            InitializeComponent();
            Mode = _mode;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Label1, "شناسه ملی شرکت حمل");
            toolTip1.SetToolTip(this.Label2, "تعداد کانتینر");
            toolTip1.SetToolTip(this.Label3, "وزن خالی کانتینر");
            toolTip1.SetToolTip(this.Label4, "شماره پلمپ");
            toolTip1.SetToolTip(this.Label5, "شماره بارنامه");
            toolTip1.SetToolTip(this.Label6, "شرح کالا");
            toolTip1.SetToolTip(this.Label7, "تعداد بسته ها");
            toolTip1.SetToolTip(this.Label8, "کد کالا");
            toolTip1.SetToolTip(this.Label9, "نوع بسته ها ");
            toolTip1.SetToolTip(this.Label10, "کد بسته ها ");
            toolTip1.SetToolTip(this.Label11, "وزن ناخالص");
            toolTip1.SetToolTip(this.Label12, "حجم به متر مکعب");
            toolTip1.SetToolTip(this.Label13, "نشانگر خطرناک");
            toolTip1.SetToolTip(this.Label14, "کالای یخچالی");
            toolTip1.SetToolTip(this.Label15, "مارک یا نشانه کالا");
            toolTip1.SetToolTip(this.Label16, "شماره سریال ");
            toolTip1.SetToolTip(this.Label17, "شماره پالت");
            toolTip1.SetToolTip(this.TabControl1, "فیلد های ضروری");
            toolTip1.SetToolTip(this.TabPage1, "فیلد های ضروری");
            toolTip1.SetToolTip(this.TabPage2, "فیلد های غیرضروری");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);

            Screen scr = Screen.PrimaryScreen;
            Left = (scr.WorkingArea.Width - Width) / 2;
            Top = (scr.WorkingArea.Height - Height) / 2;

            switch (Mode)
            {
                case 1: //Truck
                    cmbCtr3.Text = "45'   Truck - 15500";
                    chkFake.Visible = true;
                    break;
                case 2: //Ship
                    GroupBox1.Text = "اطلاعات کانتینر دریایی";
                    cmbCtr3.Text = "2200";
                    txtCtr1.Text = "";
                    txtCtr1.Enabled = true;
                    txtCtr2.Enabled = true;
                    cmbCtr3.Enabled = true;
                    txtCtr4.Enabled = true;
                    break;
                case 3: //Air
                    GroupBox1.Text = "اطلاعات کانتینر هوایی";

                    cmbCtr3.Enabled = false;
                    cmbCtr3.Text = "0";
                    break;
                default:
                    break;
            }

            dgv.AutoGenerateColumns = false;
            dgv.DataSource = CONN.GetAllDataSortedByBolNo();

            cmbBlNo.DataSource = BOL.GetAllData();
            cmbBlNo.DisplayMember = "txt2";
            cmbBlNo.ValueMember = "ID";

            cmb07.DataSource = PackageCodes.GetAllData();
            cmb07.DisplayMember = "Full";
            cmb07.ValueMember = "Code";

            cmb07.Text = "";


        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

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
            btnNext.Enabled = (txtTotalNumber.Text == Form3.Total) && (txtTotalGross.Text == Form3.Gross) ? true : false;

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EditCol.Index)  //Edit
            {
                EditID = int.Parse(dgv.CurrentRow.Cells["ID"].Value.ToString());

                var con = CONN.GetById(EditID);

                txt01.Text = con.txt2;
                txt02.Text = con.txt3;
                txt03.Text = con.txt4;
                txt05.Text = con.txt6;
                txt06.Text = con.txt7;
                cmb08.Text = con.txt8;
                cmb07.Text = con.txt9;
                txt09.Text = con.txt10;
                txt10.Text = con.txt11;
                cmb12.Text = con.txt13;
                cmb18.Text = con.txt19;

                btnSave.Text = "ذخیره تغییرات";

            }

            if (e.ColumnIndex == DelCol.Index)  //Del
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
                        CONN.Delete(int.Parse(dgv.CurrentRow.Cells["ID"].Value.ToString()));
                        dgv.DataSource = CONN.GetAllData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsAllRequiredTextFilled() || (cmb08.Text.Trim() == string.Empty))
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
                    ID = 1,
                    txt1 = "CTR",
                    BolRef = int.Parse(cmbBlNo.SelectedValue.ToString()),
                    txt2 = chkFake.Checked ? "FAKE123456-1" : txtCtr1.Text,
                    txt3 = txtCtr2.Text,
                    txt4 = lblCtr3.Text,
                    txt5 = txtCtr4.Text
                };

                if (CTR.IsFirstRecord()) //Save
                {
                    CTR.Insert(ctr);
                }
                else  //Update
                {
                    CTR.Update(ctr);
                }
                //============================= Save or Edit Cons =================================
                CONNViewModel cons = new CONNViewModel
                {
                    CTRRef = 1,
                    BolRef = int.Parse(cmbBlNo.SelectedValue.ToString()),
                    BolNo = cmbBlNo.Text,
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

                if (EditID == 0)//Save
                {
                    CONN.Insert(cons);
                }
                else //Edit
                {
                    cons.ID = int.Parse(dgv.CurrentRow.Cells["ID"].Value.ToString());
                    CONN.Update(cons);
                }

                //Empty All Textboxes
                foreach (Control c2 in TabPage1.Controls)
                {
                    if (c2 is TextBox)
                        c2.Text = string.Empty;
                }

                //Refresh dgv
                dgv.DataSource = null;
                dgv.DataSource = CONN.GetAllDataSortedByBolNo();
                EditID = 0;
                btnSave.Text = "دخیره کالا";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsAllRequiredTextFilled()
        {
            foreach (Control c1 in TabPage1.Controls)
            {
                if (c1 is TextBox)
                {
                    if (c1.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
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
            Hide();
            new Form5(Mode).ShowDialog();
            Show();
        }

        private void cmb07_Leave(object sender, EventArgs e)
        {
            //cmb08.Text = cmb07.Text.Substring(0, 3);
            //cmb07.Text = cmb07.Text.Substring(4);

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

        private void txtTotalNumber_TextChanged(object sender, EventArgs e)
        {
            btnNext.Enabled = (txtTotalNumber.Text == Form3.Total) && (txtTotalGross.Text == Form3.Gross) ? true : false;
        }

        private void cmbCtr3_Leave(object sender, EventArgs e)
        {
            lblCtr3.Text = cmbCtr3.Text.Substring(cmbCtr3.Text.Length - 4);
            if (lblCtr3.Text == "5500") lblCtr3.Text = "15500";
        }

        private void txt05_Leave(object sender, EventArgs e)
        {
            if (txt05.Text.Length < 8)
            {
                MessageBox.Show("تعرفه کالا باید هشت رقم باشد");
                txt05.Focus();
                return;
            }
        }
    }
}
