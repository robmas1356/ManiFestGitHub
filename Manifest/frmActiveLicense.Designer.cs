namespace Manifest
{
    partial class frmActiveLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUniqueCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLineCode = new System.Windows.Forms.TextBox();
            this.btnActive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbBG = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtUniqueCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLineCode);
            this.groupBox1.Font = new System.Drawing.Font("Shabnam", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(333, 122);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فعالسازی :";
            // 
            // txtUniqueCode
            // 
            this.txtUniqueCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUniqueCode.Location = new System.Drawing.Point(6, 74);
            this.txtUniqueCode.MaxLength = 11;
            this.txtUniqueCode.Name = "txtUniqueCode";
            this.txtUniqueCode.Size = new System.Drawing.Size(219, 26);
            this.txtUniqueCode.TabIndex = 34;
            this.txtUniqueCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(253, 34);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "شناسه ملی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(231, 79);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "شناسه پرداخت :";
            // 
            // txtLineCode
            // 
            this.txtLineCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLineCode.Location = new System.Drawing.Point(6, 31);
            this.txtLineCode.MaxLength = 13;
            this.txtLineCode.Name = "txtLineCode";
            this.txtLineCode.Size = new System.Drawing.Size(219, 26);
            this.txtLineCode.TabIndex = 33;
            this.txtLineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnActive
            // 
            this.btnActive.BackColor = System.Drawing.Color.LawnGreen;
            this.btnActive.Font = new System.Drawing.Font("Shabnam", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnActive.Location = new System.Drawing.Point(115, 230);
            this.btnActive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(132, 31);
            this.btnActive.TabIndex = 40;
            this.btnActive.Text = "فعالسازی";
            this.btnActive.UseVisualStyleBackColor = false;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Shabnam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(247, 21);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "وضعیت اینترنت :";
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.BackColor = System.Drawing.Color.White;
            this.lblInternetStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInternetStatus.Location = new System.Drawing.Point(15, 26);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(82, 16);
            this.lblInternetStatus.TabIndex = 42;
            this.lblInternetStatus.Text = "----";
            this.lblInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::Manifest.Properties.Resources.Close_icon2;
            this.pbClose.Location = new System.Drawing.Point(749, 21);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 6;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbBG
            // 
            this.pbBG.Image = global::Manifest.Properties.Resources.RegisterBG;
            this.pbBG.Location = new System.Drawing.Point(0, 0);
            this.pbBG.Name = "pbBG";
            this.pbBG.Size = new System.Drawing.Size(795, 450);
            this.pbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBG.TabIndex = 0;
            this.pbBG.TabStop = false;
            // 
            // frmActiveLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.lblInternetStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActiveLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmActiveLicense";
            this.Load += new System.EventHandler(this.frmActiveLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBG;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUniqueCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLineCode;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternetStatus;
    }
}