namespace Manifest
{
    partial class frmLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicense));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMachineCode = new System.Windows.Forms.TextBox();
            this.txtLineCode = new System.Windows.Forms.TextBox();
            this.txtValidation = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtWinVer = new System.Windows.Forms.TextBox();
            this.txtWinName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.txtBuyLic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuyLic = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(518, 396);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 27);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(11, 396);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(86, 27);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "فعال سازی";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد دستگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "شناسه ملی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام شرکت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "نام ویندوز";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "نسخه ویندوز";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Enabled = false;
            this.txtMachineCode.Location = new System.Drawing.Point(6, 22);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMachineCode.Size = new System.Drawing.Size(201, 23);
            this.txtMachineCode.TabIndex = 0;
            // 
            // txtLineCode
            // 
            this.txtLineCode.Location = new System.Drawing.Point(6, 51);
            this.txtLineCode.MaxLength = 11;
            this.txtLineCode.Name = "txtLineCode";
            this.txtLineCode.Size = new System.Drawing.Size(175, 23);
            this.txtLineCode.TabIndex = 1;
            this.txtLineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLineCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLineCode_KeyPress);
            this.txtLineCode.Leave += new System.EventHandler(this.txtLineCode_Leave);
            // 
            // txtValidation
            // 
            this.txtValidation.Location = new System.Drawing.Point(12, 283);
            this.txtValidation.Multiline = true;
            this.txtValidation.Name = "txtValidation";
            this.txtValidation.Size = new System.Drawing.Size(579, 107);
            this.txtValidation.TabIndex = 3;
            this.txtValidation.TextChanged += new System.EventHandler(this.txtValidation_TextChanged);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(6, 80);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(175, 23);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWinVer
            // 
            this.txtWinVer.Enabled = false;
            this.txtWinVer.Location = new System.Drawing.Point(6, 80);
            this.txtWinVer.Name = "txtWinVer";
            this.txtWinVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWinVer.Size = new System.Drawing.Size(190, 23);
            this.txtWinVer.TabIndex = 4;
            // 
            // txtWinName
            // 
            this.txtWinName.Enabled = false;
            this.txtWinName.Location = new System.Drawing.Point(6, 51);
            this.txtWinName.Name = "txtWinName";
            this.txtWinName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWinName.Size = new System.Drawing.Size(201, 23);
            this.txtWinName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "درج کد فعالسازی";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "ایمیل معتبر";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 225);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 27);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "درخواست فعالسازی";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(454, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "لطفا جهت فعالسازی نرم افزار، از دکمه روبرو، نسبت به خرید لایسنس اقدام فرمائید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 9);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "وضعیت اینترنت :";
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInternetStatus.Location = new System.Drawing.Point(407, 9);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(82, 16);
            this.lblInternetStatus.TabIndex = 18;
            this.lblInternetStatus.Text = "----";
            this.lblInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 9);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "تاریخ سیستم :";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Location = new System.Drawing.Point(18, 6);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(181, 22);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = ".";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBuyLic
            // 
            this.txtBuyLic.Location = new System.Drawing.Point(6, 22);
            this.txtBuyLic.MaxLength = 15;
            this.txtBuyLic.Name = "txtBuyLic";
            this.txtBuyLic.Size = new System.Drawing.Size(175, 23);
            this.txtBuyLic.TabIndex = 0;
            this.txtBuyLic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuyLic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuyLic_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "شماره تراکنش";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMachineCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWinName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWinVer);
            this.groupBox1.Location = new System.Drawing.Point(312, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(285, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات سیستم";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBuyLic);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLineCode);
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(291, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات تکمیلی";
            // 
            // btnBuyLic
            // 
            this.btnBuyLic.Location = new System.Drawing.Point(21, 32);
            this.btnBuyLic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuyLic.Name = "btnBuyLic";
            this.btnBuyLic.Size = new System.Drawing.Size(97, 27);
            this.btnBuyLic.TabIndex = 6;
            this.btnBuyLic.Text = "خرید لایسنس";
            this.btnBuyLic.UseVisualStyleBackColor = true;
            this.btnBuyLic.Click += new System.EventHandler(this.btnBuyLic_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(449, 225);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(148, 27);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "راهنمای فعالسازی";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBuyLic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInternetStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValidation);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم فعال ساز برنامه";
            this.Load += new System.EventHandler(this.frmLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMachineCode;
        private System.Windows.Forms.TextBox txtLineCode;
        private System.Windows.Forms.TextBox txtValidation;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtWinVer;
        private System.Windows.Forms.TextBox txtWinName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternetStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtBuyLic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuyLic;
        private System.Windows.Forms.Button btnHelp;
    }
}