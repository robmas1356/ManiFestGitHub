namespace Manifest
{
    partial class frmLic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLic));
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chkRenew = new System.Windows.Forms.CheckBox();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLineCode = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpRegister = new System.Windows.Forms.GroupBox();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.grbRenew = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRenewLineCode = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.grpRegister.SuspendLayout();
            this.flp.SuspendLayout();
            this.grbRenew.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInternetStatus.Location = new System.Drawing.Point(34, 19);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(82, 16);
            this.lblInternetStatus.TabIndex = 22;
            this.lblInternetStatus.Text = "----";
            this.lblInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 19);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "وضعیت اینترنت :";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(3, 759);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(181, 22);
            this.lblDateTime.TabIndex = 19;
            this.lblDateTime.Text = ".";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalc);
            this.groupBox2.Controls.Add(this.chkRenew);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLineCode);
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(8, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(283, 285);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات لایسنس";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(45, 252);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(180, 27);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "محاسبه قیمت لایسنس";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chkRenew
            // 
            this.chkRenew.AutoSize = true;
            this.chkRenew.Location = new System.Drawing.Point(45, 226);
            this.chkRenew.Name = "chkRenew";
            this.chkRenew.Size = new System.Drawing.Size(180, 20);
            this.chkRenew.TabIndex = 6;
            this.chkRenew.Text = "لایسنس پارسال تمدید شود";
            this.chkRenew.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(6, 169);
            this.txtQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQty.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(85, 23);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "تعداد لایسنس";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "شماره موبایل";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(6, 140);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(175, 23);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "شناسه ملی";
            // 
            // txtLineCode
            // 
            this.txtLineCode.Location = new System.Drawing.Point(6, 22);
            this.txtLineCode.MaxLength = 11;
            this.txtLineCode.Name = "txtLineCode";
            this.txtLineCode.Size = new System.Drawing.Size(175, 23);
            this.txtLineCode.TabIndex = 1;
            this.txtLineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(6, 82);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(268, 23);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام شرکت";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "ایمیل معتبر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "قابل پرداخت ";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(101, 326);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(15, 16);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "تومان";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(79, 729);
            this.btnPay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(105, 27);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "پرداخت";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(2, 729);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpRegister
            // 
            this.grpRegister.Controls.Add(this.label3);
            this.grpRegister.Controls.Add(this.label5);
            this.grpRegister.Controls.Add(this.lblAmount);
            this.grpRegister.Controls.Add(this.groupBox2);
            this.grpRegister.Controls.Add(this.label7);
            this.grpRegister.Controls.Add(this.lblInternetStatus);
            this.grpRegister.Location = new System.Drawing.Point(3, 3);
            this.grpRegister.Name = "grpRegister";
            this.grpRegister.Size = new System.Drawing.Size(302, 357);
            this.grpRegister.TabIndex = 24;
            this.grpRegister.TabStop = false;
            this.grpRegister.Visible = false;
            // 
            // flp
            // 
            this.flp.Controls.Add(this.grpRegister);
            this.flp.Controls.Add(this.grbRenew);
            this.flp.Controls.Add(this.btnExit);
            this.flp.Controls.Add(this.btnPay);
            this.flp.Controls.Add(this.lblDateTime);
            this.flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp.Location = new System.Drawing.Point(0, 0);
            this.flp.Name = "flp";
            this.flp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flp.Size = new System.Drawing.Size(317, 785);
            this.flp.TabIndex = 24;
            // 
            // grbRenew
            // 
            this.grbRenew.Controls.Add(this.label10);
            this.grbRenew.Controls.Add(this.btnSwitch);
            this.grbRenew.Controls.Add(this.btnAddClient);
            this.grbRenew.Controls.Add(this.label6);
            this.grbRenew.Controls.Add(this.txtRenewLineCode);
            this.grbRenew.Location = new System.Drawing.Point(3, 366);
            this.grbRenew.Name = "grbRenew";
            this.grbRenew.Size = new System.Drawing.Size(302, 357);
            this.grbRenew.TabIndex = 25;
            this.grbRenew.TabStop = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(282, 101);
            this.label10.TabIndex = 3;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // btnSwitch
            // 
            this.btnSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSwitch.Location = new System.Drawing.Point(22, 290);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(263, 27);
            this.btnSwitch.TabIndex = 9;
            this.btnSwitch.Text = "پرداخت هزینه لایسنس";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClient.Location = new System.Drawing.Point(22, 174);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(263, 27);
            this.btnAddClient.TabIndex = 9;
            this.btnAddClient.Text = "ثبت کامپیوتر برای شناسه شرکت";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "شناسه ملی";
            // 
            // txtRenewLineCode
            // 
            this.txtRenewLineCode.Location = new System.Drawing.Point(22, 145);
            this.txtRenewLineCode.MaxLength = 11;
            this.txtRenewLineCode.Name = "txtRenewLineCode";
            this.txtRenewLineCode.Size = new System.Drawing.Size(159, 23);
            this.txtRenewLineCode.TabIndex = 1;
            this.txtRenewLineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 785);
            this.ControlBox = false;
            this.Controls.Add(this.flp);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فعال سازی برنامه";
            this.Load += new System.EventHandler(this.frmLic_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.grpRegister.ResumeLayout(false);
            this.grpRegister.PerformLayout();
            this.flp.ResumeLayout(false);
            this.grbRenew.ResumeLayout(false);
            this.grbRenew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInternetStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLineCode;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkRenew;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpRegister;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.GroupBox grbRenew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRenewLineCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnAddClient;
    }
}