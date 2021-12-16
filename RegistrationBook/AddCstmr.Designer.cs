namespace RegistrationBook
{
    partial class AddCstmr
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.siticoneDragControl1 = new ns1.SiticoneDragControl(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDCstmrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstmridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natnlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.howDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdctnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmpnynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscrptnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new ns1.SiticoneButton();
            this.txtmobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtphone = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNtnalid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtprdctName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPrice = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSrch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHow = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCmpnyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtFamily = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDscrptn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcstmrid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cRUDCstmrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 80);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(139, 38);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // cRUDCstmrBindingSource
            // 
            this.cRUDCstmrBindingSource.DataSource = typeof(BussinessEntity.CRUD_Cstmr);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.cstmridDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.natnlidDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.howDataGridViewTextBoxColumn,
            this.prdctnameDataGridViewTextBoxColumn,
            this.cmpnynameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dscrptnDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.cRUDCstmrBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.RowHeadersWidth = 62;
            this.dataGridViewX1.RowTemplate.Height = 28;
            this.dataGridViewX1.Size = new System.Drawing.Size(930, 301);
            this.dataGridViewX1.TabIndex = 13;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            this.dataGridViewX1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            this.familyDataGridViewTextBoxColumn.Width = 150;
            // 
            // cstmridDataGridViewTextBoxColumn
            // 
            this.cstmridDataGridViewTextBoxColumn.DataPropertyName = "cstmrid";
            this.cstmridDataGridViewTextBoxColumn.HeaderText = "شناسه مشتری";
            this.cstmridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cstmridDataGridViewTextBoxColumn.Name = "cstmridDataGridViewTextBoxColumn";
            this.cstmridDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstmridDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "شماره همراه";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // natnlidDataGridViewTextBoxColumn
            // 
            this.natnlidDataGridViewTextBoxColumn.DataPropertyName = "natnlid";
            this.natnlidDataGridViewTextBoxColumn.HeaderText = "شماره ملی";
            this.natnlidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.natnlidDataGridViewTextBoxColumn.Name = "natnlidDataGridViewTextBoxColumn";
            this.natnlidDataGridViewTextBoxColumn.ReadOnly = true;
            this.natnlidDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "تلفن ثابت";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // howDataGridViewTextBoxColumn
            // 
            this.howDataGridViewTextBoxColumn.DataPropertyName = "how";
            this.howDataGridViewTextBoxColumn.HeaderText = "نوع خدمات";
            this.howDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.howDataGridViewTextBoxColumn.Name = "howDataGridViewTextBoxColumn";
            this.howDataGridViewTextBoxColumn.ReadOnly = true;
            this.howDataGridViewTextBoxColumn.Width = 150;
            // 
            // prdctnameDataGridViewTextBoxColumn
            // 
            this.prdctnameDataGridViewTextBoxColumn.DataPropertyName = "prdctname";
            this.prdctnameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
            this.prdctnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prdctnameDataGridViewTextBoxColumn.Name = "prdctnameDataGridViewTextBoxColumn";
            this.prdctnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prdctnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cmpnynameDataGridViewTextBoxColumn
            // 
            this.cmpnynameDataGridViewTextBoxColumn.DataPropertyName = "cmpnyname";
            this.cmpnynameDataGridViewTextBoxColumn.HeaderText = "نام شرکت";
            this.cmpnynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cmpnynameDataGridViewTextBoxColumn.Name = "cmpnynameDataGridViewTextBoxColumn";
            this.cmpnynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cmpnynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "هزینه دریافت شده";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // dscrptnDataGridViewTextBoxColumn
            // 
            this.dscrptnDataGridViewTextBoxColumn.DataPropertyName = "dscrptn";
            this.dscrptnDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.dscrptnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dscrptnDataGridViewTextBoxColumn.Name = "dscrptnDataGridViewTextBoxColumn";
            this.dscrptnDataGridViewTextBoxColumn.ReadOnly = true;
            this.dscrptnDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoveredState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoveredState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(415, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(108, 38);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "جدید";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtmobile
            // 
            // 
            // 
            // 
            this.txtmobile.Border.Class = "TextBoxBorder";
            this.txtmobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmobile.Location = new System.Drawing.Point(5, 312);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PreventEnterBeep = true;
            this.txtmobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmobile.Size = new System.Drawing.Size(224, 36);
            this.txtmobile.TabIndex = 3;
            this.txtmobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmobile.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtmobile.WatermarkText = "شماره همراه";
            // 
            // txtphone
            // 
            // 
            // 
            // 
            this.txtphone.Border.Class = "TextBoxBorder";
            this.txtphone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtphone.Location = new System.Drawing.Point(473, 354);
            this.txtphone.Name = "txtphone";
            this.txtphone.PreventEnterBeep = true;
            this.txtphone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtphone.Size = new System.Drawing.Size(224, 36);
            this.txtphone.TabIndex = 5;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtphone.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtphone.WatermarkText = "تلفن ثابت";
            // 
            // txtNtnalid
            // 
            // 
            // 
            // 
            this.txtNtnalid.Border.Class = "TextBoxBorder";
            this.txtNtnalid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNtnalid.Location = new System.Drawing.Point(709, 354);
            this.txtNtnalid.Name = "txtNtnalid";
            this.txtNtnalid.PreventEnterBeep = true;
            this.txtNtnalid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNtnalid.Size = new System.Drawing.Size(224, 36);
            this.txtNtnalid.TabIndex = 4;
            this.txtNtnalid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNtnalid.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNtnalid.WatermarkText = "شماره ملی";
            // 
            // txtprdctName
            // 
            // 
            // 
            // 
            this.txtprdctName.Border.Class = "TextBoxBorder";
            this.txtprdctName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtprdctName.Location = new System.Drawing.Point(4, 354);
            this.txtprdctName.Name = "txtprdctName";
            this.txtprdctName.PreventEnterBeep = true;
            this.txtprdctName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtprdctName.Size = new System.Drawing.Size(224, 36);
            this.txtprdctName.TabIndex = 7;
            this.txtprdctName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprdctName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtprdctName.WatermarkText = "نام کالا";
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.Border.Class = "TextBoxBorder";
            this.txtPrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrice.Location = new System.Drawing.Point(473, 396);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PreventEnterBeep = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(224, 36);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPrice.WatermarkText = "هزینه دریافت شده";
            // 
            // txtSrch
            // 
            // 
            // 
            // 
            this.txtSrch.Border.Class = "TextBoxBorder";
            this.txtSrch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSrch.Location = new System.Drawing.Point(241, 455);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.PreventEnterBeep = true;
            this.txtSrch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSrch.Size = new System.Drawing.Size(454, 36);
            this.txtSrch.TabIndex = 11;
            this.txtSrch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSrch.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSrch.WatermarkText = "جستجو";
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            // 
            // txtHow
            // 
            // 
            // 
            // 
            this.txtHow.Border.Class = "TextBoxBorder";
            this.txtHow.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHow.Location = new System.Drawing.Point(239, 354);
            this.txtHow.Name = "txtHow";
            this.txtHow.PreventEnterBeep = true;
            this.txtHow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHow.Size = new System.Drawing.Size(223, 36);
            this.txtHow.TabIndex = 6;
            this.txtHow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHow.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtHow.WatermarkText = "نوع خدمات(حضوری ، مغازه)";
            // 
            // txtCmpnyName
            // 
            // 
            // 
            // 
            this.txtCmpnyName.Border.Class = "TextBoxBorder";
            this.txtCmpnyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCmpnyName.Location = new System.Drawing.Point(709, 396);
            this.txtCmpnyName.Name = "txtCmpnyName";
            this.txtCmpnyName.PreventEnterBeep = true;
            this.txtCmpnyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCmpnyName.Size = new System.Drawing.Size(224, 36);
            this.txtCmpnyName.TabIndex = 8;
            this.txtCmpnyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCmpnyName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtCmpnyName.WatermarkText = "نام شرکت / اداره";
            // 
            // txtFamily
            // 
            // 
            // 
            // 
            this.txtFamily.Border.Class = "TextBoxBorder";
            this.txtFamily.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFamily.Location = new System.Drawing.Point(474, 312);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.PreventEnterBeep = true;
            this.txtFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFamily.Size = new System.Drawing.Size(224, 36);
            this.txtFamily.TabIndex = 1;
            this.txtFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFamily.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFamily.WatermarkText = "نام خانوادگی";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtName.Location = new System.Drawing.Point(709, 312);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(224, 36);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.WatermarkText = "نام";
            // 
            // txtDscrptn
            // 
            // 
            // 
            // 
            this.txtDscrptn.Border.Class = "TextBoxBorder";
            this.txtDscrptn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDscrptn.Location = new System.Drawing.Point(3, 396);
            this.txtDscrptn.Name = "txtDscrptn";
            this.txtDscrptn.PreventEnterBeep = true;
            this.txtDscrptn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDscrptn.Size = new System.Drawing.Size(459, 36);
            this.txtDscrptn.TabIndex = 10;
            this.txtDscrptn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDscrptn.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDscrptn.WatermarkText = "توضیحات";
            // 
            // txtcstmrid
            // 
            // 
            // 
            // 
            this.txtcstmrid.Border.Class = "TextBoxBorder";
            this.txtcstmrid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcstmrid.Location = new System.Drawing.Point(239, 312);
            this.txtcstmrid.Name = "txtcstmrid";
            this.txtcstmrid.PreventEnterBeep = true;
            this.txtcstmrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcstmrid.Size = new System.Drawing.Size(223, 36);
            this.txtcstmrid.TabIndex = 2;
            this.txtcstmrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcstmrid.WatermarkImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtcstmrid.WatermarkText = "شناسه مشتری";
            // 
            // AddCstmr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.txtcstmrid);
            this.Controls.Add(this.txtDscrptn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtCmpnyName);
            this.Controls.Add(this.txtHow);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtprdctName);
            this.Controls.Add(this.txtNtnalid);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCstmr";
            this.Size = new System.Drawing.Size(936, 556);
            this.Load += new System.EventHandler(this.AddCstmr_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cRUDCstmrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ns1.SiticoneDragControl siticoneDragControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.BindingSource cRUDCstmrBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstmridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn natnlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn howDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdctnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmpnynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscrptnDataGridViewTextBoxColumn;
        private ns1.SiticoneButton btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtphone;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNtnalid;
        private DevComponents.DotNetBar.Controls.TextBoxX txtprdctName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSrch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHow;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCmpnyName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFamily;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDscrptn;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcstmrid;
    }
}
