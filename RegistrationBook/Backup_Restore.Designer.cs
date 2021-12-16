namespace RegistrationBook
{
    partial class Backup_Restore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_Restore));
            this.btnRestore = new ns1.SiticoneButton();
            this.btnBackup = new ns1.SiticoneButton();
            this.siticonePictureBox1 = new ns1.SiticonePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnRestore.BorderRadius = 4;
            this.btnRestore.BorderThickness = 1;
            this.btnRestore.CheckedState.Parent = this.btnRestore;
            this.btnRestore.CustomImages.Parent = this.btnRestore;
            this.btnRestore.FillColor = System.Drawing.Color.White;
            this.btnRestore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.HoveredState.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoveredState.Parent = this.btnRestore;
            this.btnRestore.Location = new System.Drawing.Point(355, 456);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShadowDecoration.Parent = this.btnRestore;
            this.btnRestore.Size = new System.Drawing.Size(166, 45);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "بازیابی اطلاعات";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnBackup.BorderRadius = 4;
            this.btnBackup.BorderThickness = 1;
            this.btnBackup.CheckedState.Parent = this.btnBackup;
            this.btnBackup.CustomImages.Parent = this.btnBackup;
            this.btnBackup.FillColor = System.Drawing.Color.White;
            this.btnBackup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.HoveredState.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoveredState.Parent = this.btnBackup;
            this.btnBackup.Location = new System.Drawing.Point(355, 396);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ShadowDecoration.Parent = this.btnBackup;
            this.btnBackup.Size = new System.Drawing.Size(166, 45);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "تهیه فایل پشتیبان";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(285, 81);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(300, 308);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 9;
            this.siticonePictureBox1.TabStop = false;
            // 
            // Backup_Restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePictureBox1);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnRestore);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Backup_Restore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(867, 538);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneButton btnRestore;
        private ns1.SiticoneButton btnBackup;
        private ns1.SiticonePictureBox siticonePictureBox1;
    }
}
