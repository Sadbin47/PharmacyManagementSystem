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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.sortLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowALL = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnledit = new System.Windows.Forms.Panel();
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
            this.btnSellItems = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.pnledit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
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
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 100);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(110, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "◆ Salesman Panel";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblSubTitle.Location = new System.Drawing.Point(115, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(459, 21);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Manage System • Inventory Management\' • Analytics Dashboard";
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accentPanel.Location = new System.Drawing.Point(0, 95);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(760, 5);
            this.accentPanel.TabIndex = 3;
            // 
            // pnlCRUD
            // 
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
            this.pnlCRUD.Location = new System.Drawing.Point(362, 100);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(395, 267);
            this.pnlCRUD.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(3, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 35);
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
            this.searchLabel.Location = new System.Drawing.Point(121, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(58, 19);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search:";
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sortLabel.Location = new System.Drawing.Point(121, 73);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(62, 19);
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
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 35);
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
            this.txtSearch.Location = new System.Drawing.Point(125, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 27);
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
            this.btnShowALL.Location = new System.Drawing.Point(3, 47);
            this.btnShowALL.Name = "btnShowALL";
            this.btnShowALL.Size = new System.Drawing.Size(111, 35);
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
            this.sortComboBox.Location = new System.Drawing.Point(125, 95);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(180, 28);
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
            this.btnDelete.Location = new System.Drawing.Point(3, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
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
            this.expirydate});
            this.dgvMedicineList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMedicineList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMedicineList.Location = new System.Drawing.Point(0, 367);
            this.dgvMedicineList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RowHeadersWidth = 62;
            this.dgvMedicineList.RowTemplate.Height = 28;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(760, 262);
            this.dgvMedicineList.TabIndex = 13;
            this.dgvMedicineList.DoubleClick += new System.EventHandler(this.dgvMedicineList_DoubleClick);
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
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitprice.DataPropertyName = "UnitPrice";
            this.unitprice.HeaderText = "UnitPrice";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // unitcost
            // 
            this.unitcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitcost.DataPropertyName = "UnitCost";
            this.unitcost.HeaderText = "UnitCost";
            this.unitcost.Name = "unitcost";
            this.unitcost.ReadOnly = true;
            // 
            // batchnumber
            // 
            this.batchnumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.batchnumber.DataPropertyName = "BatchNumber";
            this.batchnumber.HeaderText = "BatchNumber";
            this.batchnumber.Name = "batchnumber";
            this.batchnumber.ReadOnly = true;
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturer.DataPropertyName = "Manufacturer";
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // expirydate
            // 
            this.expirydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirydate.DataPropertyName = "ExpiryDate";
            this.expirydate.HeaderText = "ExpiryDate";
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            // 
            // pnledit
            // 
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
            this.pnledit.Location = new System.Drawing.Point(0, 100);
            this.pnledit.Name = "pnledit";
            this.pnledit.Size = new System.Drawing.Size(348, 267);
            this.pnledit.TabIndex = 14;
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
            this.cmbCatagory.Location = new System.Drawing.Point(154, 67);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(166, 23);
            this.cmbCatagory.TabIndex = 46;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CalendarFont = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.CustomFormat = "dd-MM-yyyy";
            this.dtpExpiryDate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(154, 224);
            this.dtpExpiryDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(166, 23);
            this.dtpExpiryDate.TabIndex = 45;
            // 
            // txtManuFacturer
            // 
            this.txtManuFacturer.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManuFacturer.Location = new System.Drawing.Point(154, 186);
            this.txtManuFacturer.Margin = new System.Windows.Forms.Padding(2);
            this.txtManuFacturer.Name = "txtManuFacturer";
            this.txtManuFacturer.Size = new System.Drawing.Size(166, 23);
            this.txtManuFacturer.TabIndex = 44;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNo.Location = new System.Drawing.Point(154, 157);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(166, 23);
            this.txtBatchNo.TabIndex = 43;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(154, 126);
            this.txtUnitCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(166, 23);
            this.txtUnitCost.TabIndex = 42;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(154, 95);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(166, 23);
            this.txtUnitPrice.TabIndex = 41;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(154, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 23);
            this.txtName.TabIndex = 40;
            // 
            // txtMedID
            // 
            this.txtMedID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedID.Location = new System.Drawing.Point(154, 6);
            this.txtMedID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.ReadOnly = true;
            this.txtMedID.Size = new System.Drawing.Size(166, 23);
            this.txtMedID.TabIndex = 39;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblExpiryDate.Location = new System.Drawing.Point(30, 224);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(72, 17);
            this.lblExpiryDate.TabIndex = 38;
            this.lblExpiryDate.Text = "ExpiryDate";
            // 
            // lvlManuFacturer
            // 
            this.lvlManuFacturer.AutoSize = true;
            this.lvlManuFacturer.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlManuFacturer.ForeColor = System.Drawing.SystemColors.Window;
            this.lvlManuFacturer.Location = new System.Drawing.Point(30, 192);
            this.lvlManuFacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlManuFacturer.Name = "lvlManuFacturer";
            this.lvlManuFacturer.Size = new System.Drawing.Size(92, 17);
            this.lvlManuFacturer.TabIndex = 37;
            this.lvlManuFacturer.Text = "ManuFacturer";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBatchNo.Location = new System.Drawing.Point(28, 160);
            this.lblBatchNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(93, 17);
            this.lblBatchNo.TabIndex = 36;
            this.lblBatchNo.Text = "Batch Number";
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitCost.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitCost.Location = new System.Drawing.Point(30, 129);
            this.lblUnitCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(62, 17);
            this.lblUnitCost.TabIndex = 35;
            this.lblUnitCost.Text = "Unit Cost";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitPrice.Location = new System.Drawing.Point(30, 98);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(61, 17);
            this.lblUnitPrice.TabIndex = 34;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCatagory.Location = new System.Drawing.Point(30, 67);
            this.lblCatagory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(61, 17);
            this.lblCatagory.TabIndex = 33;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(30, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 17);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Name";
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedicineID.Location = new System.Drawing.Point(30, 9);
            this.lblMedicineID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(78, 17);
            this.lblMedicineID.TabIndex = 31;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // btnSellItems
            // 
            this.btnSellItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSellItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellItems.FlatAppearance.BorderSize = 0;
            this.btnSellItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellItems.ForeColor = System.Drawing.Color.White;
            this.btnSellItems.Location = new System.Drawing.Point(3, 170);
            this.btnSellItems.Name = "btnSellItems";
            this.btnSellItems.Size = new System.Drawing.Size(111, 35);
            this.btnSellItems.TabIndex = 10;
            this.btnSellItems.Text = "💵 Sell Items";
            this.btnSellItems.UseVisualStyleBackColor = false;
            this.btnSellItems.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(286, 224);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 35);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // logoImageBox
            // 
            this.logoImageBox.BackColor = System.Drawing.Color.Transparent;
            this.logoImageBox.Image = global::PharmacyManagementSystem.Properties.Resources.pngegg;
            this.logoImageBox.Location = new System.Drawing.Point(30, 20);
            this.logoImageBox.Name = "logoImageBox";
            this.logoImageBox.Size = new System.Drawing.Size(60, 60);
            this.logoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImageBox.TabIndex = 0;
            this.logoImageBox.TabStop = false;
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(760, 629);
            this.Controls.Add(this.pnledit);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSalesman";
            this.Load += new System.EventHandler(this.FormSalesman_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.pnledit.ResumeLayout(false);
            this.pnledit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.Panel pnledit;
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
    }
}