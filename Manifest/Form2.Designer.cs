namespace Manifest
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbAir = new System.Windows.Forms.PictureBox();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.pbTruck = new System.Windows.Forms.PictureBox();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNewDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProgressBar1.Location = new System.Drawing.Point(851, 51);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar1.RightToLeftLayout = true;
            this.ProgressBar1.Size = new System.Drawing.Size(302, 10);
            this.ProgressBar1.TabIndex = 10;
            this.ProgressBar1.Value = 50;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar2.Location = new System.Drawing.Point(461, 51);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar2.RightToLeftLayout = true;
            this.progressBar2.Size = new System.Drawing.Size(354, 10);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar3.Location = new System.Drawing.Point(87, 51);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar3.RightToLeftLayout = true;
            this.progressBar3.Size = new System.Drawing.Size(338, 10);
            this.progressBar3.TabIndex = 12;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label1.Location = new System.Drawing.Point(754, 519);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(440, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = ": کاربر گرامی لطفا هنگام استفاده از این برنامه موارد زیر را مد نظر داشته باشید ";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Items.AddRange(new object[] {
            "نوع حمل خود را انتخاب کنید  .",
            "کلیه موارد فیلدها اجباری است و باید حتما تکمیل گردند .",
            "فرآیند تبدیل تنها زمانی به پایان می رسد که خروجی این برنامه را دریافت کرده و در س" +
                "امانه گمرک ( ارسال مانیفست ) ثبت نمایید .",
            "در حین تبدیل اطلاعات می توانید اطلاعات خود را ذخیره نمایید و بعدا مجددا اقدام به " +
                "وارد کردن اطلاعات نمود ."});
            this.ListBox1.Location = new System.Drawing.Point(56, 538);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBox1.Size = new System.Drawing.Size(1138, 69);
            this.ListBox1.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1119, 658);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "مرحله قبل";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNext.Location = new System.Drawing.Point(56, 658);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "مرحله بعد";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Manifest.Properties.Resources.Airplan1;
            this.pictureBox7.Location = new System.Drawing.Point(927, 132);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(289, 331);
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // pbAir
            // 
            this.pbAir.Image = global::Manifest.Properties.Resources.Airplan2;
            this.pbAir.Location = new System.Drawing.Point(927, 132);
            this.pbAir.Name = "pbAir";
            this.pbAir.Size = new System.Drawing.Size(289, 331);
            this.pbAir.TabIndex = 21;
            this.pbAir.TabStop = false;
            this.pbAir.Click += new System.EventHandler(this.pbAir_Click);
            // 
            // pbShip
            // 
            this.pbShip.Image = global::Manifest.Properties.Resources.Ship1;
            this.pbShip.Location = new System.Drawing.Point(508, 132);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(276, 331);
            this.pbShip.TabIndex = 19;
            this.pbShip.TabStop = false;
            this.pbShip.Click += new System.EventHandler(this.pbShip_Click);
            // 
            // pbTruck
            // 
            this.pbTruck.Image = global::Manifest.Properties.Resources.Truck1;
            this.pbTruck.Location = new System.Drawing.Point(56, 132);
            this.pbTruck.Name = "pbTruck";
            this.pbTruck.Size = new System.Drawing.Size(280, 331);
            this.pbTruck.TabIndex = 15;
            this.pbTruck.TabStop = false;
            this.pbTruck.Click += new System.EventHandler(this.pbTruck_Click);
            // 
            // pbHeader
            // 
            this.pbHeader.Image = global::Manifest.Properties.Resources.Heder1;
            this.pbHeader.Location = new System.Drawing.Point(-4, 0);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(1257, 92);
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Manifest.Properties.Resources.Truck2;
            this.pictureBox2.Location = new System.Drawing.Point(56, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 331);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Manifest.Properties.Resources.Ship2;
            this.pictureBox3.Location = new System.Drawing.Point(508, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(276, 331);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLoad.Location = new System.Drawing.Point(579, 658);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 32);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "فراخوانی اطلاعات";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Data Files|*.sol";
            this.openFileDialog1.Title = "Restore Data";
            // 
            // btnNewDB
            // 
            this.btnNewDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNewDB.Location = new System.Drawing.Point(378, 658);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(120, 32);
            this.btnNewDB.TabIndex = 25;
            this.btnNewDB.Text = "خالی کردن بانک";
            this.btnNewDB.UseVisualStyleBackColor = true;
            this.btnNewDB.Visible = false;
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1245, 719);
            this.Controls.Add(this.btnNewDB);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbAir);
            this.Controls.Add(this.pbShip);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbTruck);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.pbHeader);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار تجارت الکترونیک ( ساخت مانیفست )";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHeader;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.ProgressBar progressBar2;
        internal System.Windows.Forms.ProgressBar progressBar3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.PictureBox pbTruck;
        internal System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.PictureBox pbShip;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pbAir;
        internal System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNewDB;
    }
}