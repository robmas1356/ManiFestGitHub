namespace Manifest
{
    partial class frmOpenLicense
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
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Shabnam", 14.25F);
            this.btnBuy.Location = new System.Drawing.Point(57, 136);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(231, 48);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "خرید لایسنس";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Font = new System.Drawing.Font("Shabnam", 14.25F);
            this.btnRenew.Location = new System.Drawing.Point(57, 218);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(231, 48);
            this.btnRenew.TabIndex = 2;
            this.btnRenew.Text = "تمدید لایسنس";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnActive
            // 
            this.btnActive.Font = new System.Drawing.Font("Shabnam", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnActive.Location = new System.Drawing.Point(57, 299);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(231, 48);
            this.btnActive.TabIndex = 3;
            this.btnActive.Text = "فعالسازی برنامه";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::Manifest.Properties.Resources.Close_icon2;
            this.pbClose.Location = new System.Drawing.Point(749, 21);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(24, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbBG
            // 
            this.pbBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBG.Image = global::Manifest.Properties.Resources.RegisterBG;
            this.pbBG.Location = new System.Drawing.Point(0, 0);
            this.pbBG.Name = "pbBG";
            this.pbBG.Size = new System.Drawing.Size(795, 450);
            this.pbBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBG.TabIndex = 0;
            this.pbBG.TabStop = false;
            // 
            // frmOpenLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.pbBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpenLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOpenLicense";
            this.Load += new System.EventHandler(this.frmOpenLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBG;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.PictureBox pbClose;
    }
}