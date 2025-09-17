namespace PharmacyManagementSystem
{
    partial class FormSalesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesman));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSellItems = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowALL = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.pnledit = new System.Windows.Forms.Panel();
            this.txtUnitAvailable = new System.Windows.Forms.TextBox();
            this.lblUnitAvailable = new System.Windows.Forms.Label();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.txtManuFacturer = new System.Windows.Forms.TextBox();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lvlManuFacturer = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.pnledit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlHeader.Controls.Add(this.logoImageBox);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.accentPanel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1432, 123);
            this.pnlHeader.TabIndex = 4;
            // 
            // logoImageBox
            // 
            this.logoImageBox.BackColor = System.Drawing.Color.Transparent;
            this.logoImageBox.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.logoImageBox.Location = new System.Drawing.Point(40, 25);
            this.logoImageBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoImageBox.Name = "logoImageBox";
            this.logoImageBox.Size = new System.Drawing.Size(80, 74);
            this.logoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImageBox.TabIndex = 0;
            this.logoImageBox.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(147, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 54);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "◆ Salesman Panel";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblSubTitle.Location = new System.Drawing.Point(153, 80);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(574, 28);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Manage System • Inventory Management\' • Analytics Dashboard";
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accentPanel.Location = new System.Drawing.Point(0, 117);
            this.accentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(1432, 6);
            this.accentPanel.TabIndex = 3;
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.lblInfo);
            this.pnlCRUD.Controls.Add(this.btnLogOut);
            this.pnlCRUD.Controls.Add(this.btnSellItems);
            this.pnlCRUD.Controls.Add(this.btnClear);
            this.pnlCRUD.Controls.Add(this.searchLabel);
            this.pnlCRUD.Controls.Add(this.sortLabel);
            this.pnlCRUD.Controls.Add(this.btnAdd);
            this.pnlCRUD.Controls.Add(this.txtSearch);
            this.pnlCRUD.Controls.Add(this.btnShowALL);
            this.pnlCRUD.Controls.Add(this.sortComboBox);
            this.pnlCRUD.Controls.Add(this.btnDelete);
            this.pnlCRUD.Location = new System.Drawing.Point(483, 123);
            this.pnlCRUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(663, 304);
            this.pnlCRUD.TabIndex = 9;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblInfo.Location = new System.Drawing.Point(247, 4);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(351, 23);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "(Search By Name/Category/Manufacturer)";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(389, 236);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(133, 43);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellItems
            // 
            this.btnSellItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSellItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellItems.FlatAppearance.BorderSize = 0;
            this.btnSellItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellItems.ForeColor = System.Drawing.Color.White;
            this.btnSellItems.Location = new System.Drawing.Point(4, 209);
            this.btnSellItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSellItems.Name = "btnSellItems";
            this.btnSellItems.Size = new System.Drawing.Size(148, 43);
            this.btnSellItems.TabIndex = 10;
            this.btnSellItems.Text = "💵 Sell Items";
            this.btnSellItems.UseVisualStyleBackColor = false;
            this.btnSellItems.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(4, 159);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "⬜ Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.searchLabel.Location = new System.Drawing.Point(161, 4);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(68, 23);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search:";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sortLabel.Location = new System.Drawing.Point(161, 90);
            this.sortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(74, 23);
            this.sortLabel.TabIndex = 3;
            this.sortLabel.Text = "Sort By:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(4, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(167, 31);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnShowALL
            // 
            this.btnShowALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnShowALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowALL.FlatAppearance.BorderSize = 0;
            this.btnShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowALL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowALL.ForeColor = System.Drawing.Color.White;
            this.btnShowALL.Location = new System.Drawing.Point(4, 58);
            this.btnShowALL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowALL.Name = "btnShowALL";
            this.btnShowALL.Size = new System.Drawing.Size(148, 43);
            this.btnShowALL.TabIndex = 8;
            this.btnShowALL.Text = "🔄 Show All";
            this.btnShowALL.UseVisualStyleBackColor = false;
            this.btnShowALL.Click += new System.EventHandler(this.btnShowALL_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(167, 117);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(239, 33);
            this.sortComboBox.TabIndex = 4;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(4, 108);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "🗑️ Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            this.dgvMedicineList.AllowUserToDeleteRows = false;
            this.dgvMedicineList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicineList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dgvMedicineList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineId,
            this.name,
            this.category,
            this.unitprice,
            this.unitcost,
            this.batchnumber,
            this.manufacturer,
            this.expirydate,
            this.unitavailable});
            this.dgvMedicineList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMedicineList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMedicineList.Location = new System.Drawing.Point(0, 468);
            this.dgvMedicineList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RowHeadersWidth = 62;
            this.dgvMedicineList.RowTemplate.Height = 28;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(1432, 300);
            this.dgvMedicineList.TabIndex = 13;
            this.dgvMedicineList.DoubleClick += new System.EventHandler(this.dgvMedicineList_DoubleClick);
            // 
            // pnledit
            // 
            this.pnledit.Controls.Add(this.txtUnitAvailable);
            this.pnledit.Controls.Add(this.lblUnitAvailable);
            this.pnledit.Controls.Add(this.cmbCatagory);
            this.pnledit.Controls.Add(this.dtpExpiryDate);
            this.pnledit.Controls.Add(this.txtManuFacturer);
            this.pnledit.Controls.Add(this.txtBatchNo);
            this.pnledit.Controls.Add(this.txtUnitCost);
            this.pnledit.Controls.Add(this.txtUnitPrice);
            this.pnledit.Controls.Add(this.txtName);
            this.pnledit.Controls.Add(this.txtMedID);
            this.pnledit.Controls.Add(this.lblExpiryDate);
            this.pnledit.Controls.Add(this.lvlManuFacturer);
            this.pnledit.Controls.Add(this.lblBatchNo);
            this.pnledit.Controls.Add(this.lblUnitCost);
            this.pnledit.Controls.Add(this.lblUnitPrice);
            this.pnledit.Controls.Add(this.lblCatagory);
            this.pnledit.Controls.Add(this.lblName);
            this.pnledit.Controls.Add(this.lblMedicineID);
            this.pnledit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnledit.Location = new System.Drawing.Point(0, 123);
            this.pnledit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnledit.Name = "pnledit";
            this.pnledit.Size = new System.Drawing.Size(464, 345);
            this.pnledit.TabIndex = 14;
            // 
            // txtUnitAvailable
            // 
            this.txtUnitAvailable.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitAvailable.Location = new System.Drawing.Point(205, 311);
            this.txtUnitAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitAvailable.Name = "txtUnitAvailable";
            this.txtUnitAvailable.Size = new System.Drawing.Size(220, 27);
            this.txtUnitAvailable.TabIndex = 48;
            // 
            // lblUnitAvailable
            // 
            this.lblUnitAvailable.AutoSize = true;
            this.lblUnitAvailable.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitAvailable.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitAvailable.Location = new System.Drawing.Point(40, 311);
            this.lblUnitAvailable.Name = "lblUnitAvailable";
            this.lblUnitAvailable.Size = new System.Drawing.Size(108, 21);
            this.lblUnitAvailable.TabIndex = 47;
            this.lblUnitAvailable.Text = "Unit Available";
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.AutoCompleteCustomSource.AddRange(new string[] {
            "Tablets",
            "Liquids",
            "Injections ",
            "Creams",
            "Inhalers"});
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Tablets",
            "Liquids",
            "Injections ",
            "Creams",
            "Inhalers"});
            this.cmbCatagory.Location = new System.Drawing.Point(205, 82);
            this.cmbCatagory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(220, 28);
            this.cmbCatagory.TabIndex = 46;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CalendarFont = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.CustomFormat = "dd-MM-yyyy";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(205, 276);
            this.dtpExpiryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExpiryDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(220, 27);
            this.dtpExpiryDate.TabIndex = 45;
            // 
            // txtManuFacturer
            // 
            this.txtManuFacturer.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManuFacturer.Location = new System.Drawing.Point(205, 229);
            this.txtManuFacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManuFacturer.Name = "txtManuFacturer";
            this.txtManuFacturer.Size = new System.Drawing.Size(220, 27);
            this.txtManuFacturer.TabIndex = 44;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.Location = new System.Drawing.Point(205, 193);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(220, 27);
            this.txtBatchNo.TabIndex = 43;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(205, 155);
            this.txtUnitCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(220, 27);
            this.txtUnitCost.TabIndex = 42;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(205, 117);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(220, 27);
            this.txtUnitPrice.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(205, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 27);
            this.txtName.TabIndex = 40;
            // 
            // txtMedID
            // 
            this.txtMedID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedID.Location = new System.Drawing.Point(205, 7);
            this.txtMedID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.ReadOnly = true;
            this.txtMedID.Size = new System.Drawing.Size(220, 27);
            this.txtMedID.TabIndex = 39;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblExpiryDate.Location = new System.Drawing.Point(40, 276);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(87, 21);
            this.lblExpiryDate.TabIndex = 38;
            this.lblExpiryDate.Text = "ExpiryDate";
            // 
            // lvlManuFacturer
            // 
            this.lvlManuFacturer.AutoSize = true;
            this.lvlManuFacturer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlManuFacturer.ForeColor = System.Drawing.SystemColors.Window;
            this.lvlManuFacturer.Location = new System.Drawing.Point(40, 236);
            this.lvlManuFacturer.Name = "lvlManuFacturer";
            this.lvlManuFacturer.Size = new System.Drawing.Size(110, 21);
            this.lvlManuFacturer.TabIndex = 37;
            this.lvlManuFacturer.Text = "ManuFacturer";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBatchNo.Location = new System.Drawing.Point(37, 197);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(112, 21);
            this.lblBatchNo.TabIndex = 36;
            this.lblBatchNo.Text = "Batch Number";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitCost.Location = new System.Drawing.Point(40, 159);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(75, 21);
            this.lblUnitCost.TabIndex = 35;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitPrice.Location = new System.Drawing.Point(40, 121);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(75, 21);
            this.lblUnitPrice.TabIndex = 34;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCatagory.Location = new System.Drawing.Point(40, 82);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(72, 21);
            this.lblCatagory.TabIndex = 33;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(40, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name";
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedicineID.Location = new System.Drawing.Point(40, 11);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(96, 21);
            this.lblMedicineID.TabIndex = 31;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // medicineId
            // 
            this.medicineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medicineId.DataPropertyName = "MedicineId";
            this.medicineId.HeaderText = "Medicine ID";
            this.medicineId.MinimumWidth = 8;
            this.medicineId.Name = "medicineId";
            this.medicineId.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitprice.DataPropertyName = "UnitPrice";
            this.unitprice.HeaderText = "UnitPrice";
            this.unitprice.MinimumWidth = 6;
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // unitcost
            // 
            this.unitcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitcost.DataPropertyName = "UnitCost";
            this.unitcost.HeaderText = "UnitCost";
            this.unitcost.MinimumWidth = 6;
            this.unitcost.Name = "unitcost";
            this.unitcost.ReadOnly = true;
            // 
            // batchnumber
            // 
            this.batchnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.batchnumber.DataPropertyName = "BatchNumber";
            this.batchnumber.HeaderText = "BatchNumber";
            this.batchnumber.MinimumWidth = 6;
            this.batchnumber.Name = "batchnumber";
            this.batchnumber.ReadOnly = true;
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturer.DataPropertyName = "Manufacturer";
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 6;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // expirydate
            // 
            this.expirydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirydate.DataPropertyName = "ExpiryDate";
            this.expirydate.HeaderText = "ExpiryDate";
            this.expirydate.MinimumWidth = 6;
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            // 
            // unitavailable
            // 
            this.unitavailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitavailable.DataPropertyName = "UnitAvailable";
            this.unitavailable.HeaderText = "Unit Available";
            this.unitavailable.MinimumWidth = 6;
            this.unitavailable.Name = "unitavailable";
            this.unitavailable.ReadOnly = true;
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1432, 768);
            this.Controls.Add(this.pnledit);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSalesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalesman";
            this.Load += new System.EventHandler(this.FormSalesman_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.pnledit.ResumeLayout(false);
            this.pnledit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox logoImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowALL;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvMedicineList;
        private System.Windows.Forms.Panel pnledit;
        private System.Windows.Forms.TextBox txtUnitAvailable;
        private System.Windows.Forms.Label lblUnitAvailable;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.TextBox txtManuFacturer;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMedID;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lvlManuFacturer;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSellItems;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitavailable;
    }
}