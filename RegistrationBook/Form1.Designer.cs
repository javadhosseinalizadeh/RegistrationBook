namespace RegistrationBook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneShadowForm1 = new ns1.SiticoneShadowForm(this.components);
            this.btnFclty = new ns1.SiticoneButton();
            this.btnAddCstmr = new ns1.SiticoneButton();
            this.siticonePanel1 = new ns1.SiticonePanel();
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.siticoneControlBox4 = new ns1.SiticoneControlBox();
            this.siticoneButton7 = new ns1.SiticoneButton();
            this.siticoneControlBox6 = new ns1.SiticoneControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new ns1.SiticoneDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFclty
            // 
            this.btnFclty.Animated = false;
            this.btnFclty.ButtonMode = ns5.ButtonMode.RadioButton;
            this.btnFclty.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnFclty.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFclty.CheckedState.Parent = this.btnFclty;
            this.btnFclty.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnFclty.CustomImages.Parent = this.btnFclty;
            this.btnFclty.FillColor = System.Drawing.Color.White;
            this.btnFclty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFclty.ForeColor = System.Drawing.Color.Black;
            this.btnFclty.HoveredState.Parent = this.btnFclty;
            this.btnFclty.Location = new System.Drawing.Point(9, 282);
            this.btnFclty.Name = "btnFclty";
            this.btnFclty.PressedDepth = 0;
            this.btnFclty.ShadowDecoration.Parent = this.btnFclty;
            this.btnFclty.Size = new System.Drawing.Size(214, 45);
            this.btnFclty.TabIndex = 0;
            this.btnFclty.Text = "پشتیبان گیری";
            this.btnFclty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFclty.TextOffset = new System.Drawing.Point(3, 2);
            this.btnFclty.Click += new System.EventHandler(this.btnFclty_Click);
            // 
            // btnAddCstmr
            // 
            this.btnAddCstmr.Animated = false;
            this.btnAddCstmr.ButtonMode = ns5.ButtonMode.RadioButton;
            this.btnAddCstmr.Checked = true;
            this.btnAddCstmr.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAddCstmr.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddCstmr.CheckedState.Parent = this.btnAddCstmr;
            this.btnAddCstmr.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAddCstmr.CustomImages.Parent = this.btnAddCstmr;
            this.btnAddCstmr.FillColor = System.Drawing.Color.White;
            this.btnAddCstmr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddCstmr.ForeColor = System.Drawing.Color.Black;
            this.btnAddCstmr.HoveredState.BorderColor = System.Drawing.Color.Black;
            this.btnAddCstmr.HoveredState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnAddCstmr.HoveredState.FillColor = System.Drawing.Color.Black;
            this.btnAddCstmr.HoveredState.ForeColor = System.Drawing.Color.Black;
            this.btnAddCstmr.HoveredState.Parent = this.btnAddCstmr;
            this.btnAddCstmr.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddCstmr.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddCstmr.Location = new System.Drawing.Point(10, 231);
            this.btnAddCstmr.Name = "btnAddCstmr";
            this.btnAddCstmr.PressedDepth = 0;
            this.btnAddCstmr.ShadowDecoration.Parent = this.btnAddCstmr;
            this.btnAddCstmr.Size = new System.Drawing.Size(214, 45);
            this.btnAddCstmr.TabIndex = 0;
            this.btnAddCstmr.Text = "تعریف مشتریان";
            this.btnAddCstmr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddCstmr.TextOffset = new System.Drawing.Point(3, 2);
            this.btnAddCstmr.Click += new System.EventHandler(this.btnAddCstmr_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.White;
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox4);
            this.siticonePanel1.Controls.Add(this.siticoneButton7);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox6);
            this.siticonePanel1.Controls.Add(this.btnFclty);
            this.siticonePanel1.Controls.Add(this.btnAddCstmr);
            this.siticonePanel1.FillColor = System.Drawing.Color.White;
            this.siticonePanel1.Location = new System.Drawing.Point(1020, 3);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Depth = 5;
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.siticonePanel1.Size = new System.Drawing.Size(227, 603);
            this.siticonePanel1.TabIndex = 13;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.siticoneButton1.BorderRadius = 4;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.White;
            this.siticoneButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoveredState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(52, 499);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(166, 45);
            this.siticoneButton1.TabIndex = 6;
            this.siticoneButton1.Text = "خروج";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneControlBox4
            // 
            this.siticoneControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox4.ControlBoxType = ns5.ControlBoxType.MinimizeBox;
            this.siticoneControlBox4.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox4.HoveredState.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneControlBox4.Location = new System.Drawing.Point(119, 9);
            this.siticoneControlBox4.Name = "siticoneControlBox4";
            this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox4.TabIndex = 4;
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.BorderColor = System.Drawing.SystemColors.Highlight;
            this.siticoneButton7.BorderRadius = 4;
            this.siticoneButton7.BorderThickness = 1;
            this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
            this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
            this.siticoneButton7.FillColor = System.Drawing.Color.White;
            this.siticoneButton7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.siticoneButton7.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton7.HoveredState.ForeColor = System.Drawing.Color.White;
            this.siticoneButton7.HoveredState.Parent = this.siticoneButton7;
            this.siticoneButton7.Location = new System.Drawing.Point(45, 694);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
            this.siticoneButton7.Size = new System.Drawing.Size(166, 45);
            this.siticoneButton7.TabIndex = 5;
            this.siticoneButton7.Text = "خروج";
            // 
            // siticoneControlBox6
            // 
            this.siticoneControlBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox6.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox6.HoveredState.Parent = this.siticoneControlBox6;
            this.siticoneControlBox6.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siticoneControlBox6.Location = new System.Drawing.Point(174, 9);
            this.siticoneControlBox6.Name = "siticoneControlBox6";
            this.siticoneControlBox6.ShadowDecoration.Parent = this.siticoneControlBox6;
            this.siticoneControlBox6.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox6.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 51);
            this.panel1.TabIndex = 7;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1017, 548);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 609);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.siticonePanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.SiticoneShadowForm siticoneShadowForm1;
        public ns1.SiticoneButton btnFclty;
        public ns1.SiticoneButton btnAddCstmr;
        private ns1.SiticonePanel siticonePanel1;
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneControlBox siticoneControlBox4;
        private ns1.SiticoneButton siticoneButton7;
        private ns1.SiticoneControlBox siticoneControlBox6;
        private System.Windows.Forms.Panel panel1;
        private ns1.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.Panel panel2;
    }
}

