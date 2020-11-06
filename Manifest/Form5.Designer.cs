namespace Manifest
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.DataSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.zipDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnZipfile = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar3.Location = new System.Drawing.Point(76, 51);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar3.RightToLeftLayout = true;
            this.progressBar3.Size = new System.Drawing.Size(337, 10);
            this.progressBar3.TabIndex = 20;
            this.progressBar3.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar2.Location = new System.Drawing.Point(451, 51);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar2.RightToLeftLayout = true;
            this.progressBar2.Size = new System.Drawing.Size(352, 10);
            this.progressBar2.TabIndex = 19;
            this.progressBar2.Value = 100;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressBar1.Location = new System.Drawing.Point(841, 51);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar1.RightToLeftLayout = true;
            this.ProgressBar1.Size = new System.Drawing.Size(301, 10);
            this.ProgressBar1.TabIndex = 18;
            this.ProgressBar1.Value = 100;
            // 
            // pbSave
            // 
            this.pbSave.Image = global::Manifest.Properties.Resources.Save;
            this.pbSave.Location = new System.Drawing.Point(222, 51);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(735, 486);
            this.pbSave.TabIndex = 21;
            this.pbSave.TabStop = false;
            this.pbSave.Visible = false;
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::Manifest.Properties.Resources.Heder4;
            this.pbHeader.Location = new System.Drawing.Point(-15, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1261, 92);
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(1119, 658);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "مرحله قبل";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(56, 658);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 70;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSave.Location = new System.Drawing.Point(732, 658);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 49);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "ذخیره فایل خروجی SOL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // DataSaveDialog
            // 
            this.DataSaveDialog.DefaultExt = "Sol";
            this.DataSaveDialog.FileName = "Data.Sol";
            this.DataSaveDialog.Filter = "Data Files|*.Sol";
            this.DataSaveDialog.Title = "Save Data";
            // 
            // zipDialog
            // 
            this.zipDialog.DefaultExt = "zip";
            this.zipDialog.Filter = "Zip File|*.zip";
            this.zipDialog.Title = "Save File";
            // 
            // btnZipfile
            // 
            this.btnZipfile.BackColor = System.Drawing.Color.Gold;
            this.btnZipfile.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnZipfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnZipfile.Location = new System.Drawing.Point(407, 658);
            this.btnZipfile.Name = "btnZipfile";
            this.btnZipfile.Size = new System.Drawing.Size(119, 49);
            this.btnZipfile.TabIndex = 73;
            this.btnZipfile.Text = "ذخیره فایل خروجی ZIP";
            this.btnZipfile.UseVisualStyleBackColor = false;
            this.btnZipfile.Click += new System.EventHandler(this.btnZipfile_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 719);
            this.Controls.Add(this.btnZipfile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.pbSave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار تجارت الکترونیک ( ساخت مانیفست )";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        internal System.Windows.Forms.ProgressBar progressBar3;
        internal System.Windows.Forms.ProgressBar progressBar2;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.PictureBox pbSave;
        internal System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog DataSaveDialog;
        private System.Windows.Forms.SaveFileDialog zipDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        internal System.Windows.Forms.Button btnZipfile;
        private System.Windows.Forms.Timer timer1;
    }
}