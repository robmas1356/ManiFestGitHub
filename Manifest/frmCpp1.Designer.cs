namespace Manifest
{
    partial class frmCpp1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCpp1));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarefehNumber = new TextBoxtest.TxtProNet();
            this.txtKalaKind = new TextBoxtest.TxtProNet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new TextBoxtest.TxtProNet();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1035, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(198, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNote
            // 
            this.btnNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNote.ForeColor = System.Drawing.Color.Black;
            this.btnNote.Location = new System.Drawing.Point(12, 98);
            this.btnNote.Name = "btnNote";
            this.btnNote.Size = new System.Drawing.Size(223, 35);
            this.btnNote.TabIndex = 2;
            this.btnNote.Text = "مشاهده یادداشت های فصل";
            this.btnNote.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(12, 672);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(1129, 672);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 35);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "مرحله قبل";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(890, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "شماره تعرفه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(517, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "نوع کالا ";
            // 
            // txtTarefehNumber
            // 
            this.txtTarefehNumber.AutoSprator = false;
            this.txtTarefehNumber.EnterToTab = true;
            this.txtTarefehNumber.EscToClose = true;
            this.txtTarefehNumber.FocusBackColor = System.Drawing.Color.Lime;
            this.txtTarefehNumber.FocusFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtTarefehNumber.FocusForeColor = System.Drawing.Color.Black;
            this.txtTarefehNumber.FocusTextSelect = true;
            this.txtTarefehNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarefehNumber.Location = new System.Drawing.Point(667, 107);
            this.txtTarefehNumber.MaxLength = 8;
            this.txtTarefehNumber.MessageEmptyShowDialog = false;
            this.txtTarefehNumber.MessegeEmpty = "";
            this.txtTarefehNumber.MessegeEmptyInFormRight = true;
            this.txtTarefehNumber.MessegeEmptyShowInForm = false;
            this.txtTarefehNumber.Name = "txtTarefehNumber";
            this.txtTarefehNumber.Size = new System.Drawing.Size(217, 21);
            this.txtTarefehNumber.TabIndex = 9;
            this.txtTarefehNumber.TypeAllChar = false;
            this.txtTarefehNumber.TypeDateShamsi = false;
            this.txtTarefehNumber.TypeEnglishOnly = false;
            this.txtTarefehNumber.TypeFarsiOnly = false;
            this.txtTarefehNumber.TypeNumricOnly = true;
            this.txtTarefehNumber.TypeOtherChar = "";
            // 
            // txtKalaKind
            // 
            this.txtKalaKind.AutoSprator = false;
            this.txtKalaKind.EnterToTab = true;
            this.txtKalaKind.EscToClose = true;
            this.txtKalaKind.FocusBackColor = System.Drawing.Color.Lime;
            this.txtKalaKind.FocusFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtKalaKind.FocusForeColor = System.Drawing.Color.Black;
            this.txtKalaKind.FocusTextSelect = true;
            this.txtKalaKind.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKalaKind.Location = new System.Drawing.Point(290, 107);
            this.txtKalaKind.MaxLength = 10000;
            this.txtKalaKind.MessageEmptyShowDialog = false;
            this.txtKalaKind.MessegeEmpty = "";
            this.txtKalaKind.MessegeEmptyInFormRight = true;
            this.txtKalaKind.MessegeEmptyShowInForm = true;
            this.txtKalaKind.Name = "txtKalaKind";
            this.txtKalaKind.Size = new System.Drawing.Size(221, 21);
            this.txtKalaKind.TabIndex = 10;
            this.txtKalaKind.TypeAllChar = true;
            this.txtKalaKind.TypeDateShamsi = false;
            this.txtKalaKind.TypeEnglishOnly = false;
            this.txtKalaKind.TypeFarsiOnly = false;
            this.txtKalaKind.TypeNumricOnly = false;
            this.txtKalaKind.TypeOtherChar = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manifest.Properties.Resources.Heder01;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.No,
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7});
            this.dgv.Location = new System.Drawing.Point(12, 164);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.RowHeadersWidth = 10;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1221, 502);
            this.dgv.TabIndex = 11;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "شماره تعرفه",
            "نوع کالا"});
            this.cmbSearch.Location = new System.Drawing.Point(1109, 139);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(124, 21);
            this.cmbSearch.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSprator = false;
            this.txtSearch.EnterToTab = true;
            this.txtSearch.EscToClose = true;
            this.txtSearch.FocusBackColor = System.Drawing.Color.Lime;
            this.txtSearch.FocusFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.FocusForeColor = System.Drawing.Color.Black;
            this.txtSearch.FocusTextSelect = true;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(886, 139);
            this.txtSearch.MaxLength = 8;
            this.txtSearch.MessageEmptyShowDialog = false;
            this.txtSearch.MessegeEmpty = "";
            this.txtSearch.MessegeEmptyInFormRight = true;
            this.txtSearch.MessegeEmptyShowInForm = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 21);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TypeAllChar = false;
            this.txtSearch.TypeDateShamsi = false;
            this.txtSearch.TypeEnglishOnly = false;
            this.txtSearch.TypeFarsiOnly = false;
            this.txtSearch.TypeNumricOnly = true;
            this.txtSearch.TypeOtherChar = "";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "GroupID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // No
            // 
            this.No.DataPropertyName = "GroupID";
            this.No.FillWeight = 5F;
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Visible = false;
            // 
            // Col1
            // 
            this.Col1.DataPropertyName = "GroupID";
            this.Col1.FillWeight = 10F;
            this.Col1.HeaderText = "فصل";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.DataPropertyName = "TN";
            this.Col2.FillWeight = 40F;
            this.Col2.HeaderText = "شماره تعرفه";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.DataPropertyName = "TKalaName";
            this.Col3.HeaderText = "نوع کالا";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.DataPropertyName = "TVorodi";
            this.Col4.FillWeight = 25F;
            this.Col4.HeaderText = "حقوق ورودی";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.DataPropertyName = "TSUQ";
            this.Col5.FillWeight = 25F;
            this.Col5.HeaderText = "SUQ";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.DataPropertyName = "TPreferential";
            this.Col6.FillWeight = 25F;
            this.Col6.HeaderText = "کد کشور تعرفه دارنده ترجیحی";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.DataPropertyName = "TDesc";
            this.Col7.HeaderText = "نوع کالا";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // frmCpp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1245, 719);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtKalaKind);
            this.Controls.Add(this.txtTarefehNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCpp1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "( IMP & EXP ) نرم افزار تجارت الکترونیک";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCpp1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBoxtest.TxtProNet txtTarefehNumber;
        private TextBoxtest.TxtProNet txtKalaKind;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbSearch;
        private TextBoxtest.TxtProNet txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
    }
}

