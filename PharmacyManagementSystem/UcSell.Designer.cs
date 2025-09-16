namespace PharmacyManagementSystem
{
    partial class UcSell
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
            this.pnlSalesModule = new System.Windows.Forms.Panel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtSalesmanID = new System.Windows.Forms.TextBox();
            this.lblSalesmanID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnProcessSale = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cartMedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlSalesModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalesModule
            // 
            this.pnlSalesModule.Controls.Add(this.lblSearch);
            this.pnlSalesModule.Controls.Add(this.lblPaymentMethod);
            this.pnlSalesModule.Controls.Add(this.txtSalesmanID);
            this.pnlSalesModule.Controls.Add(this.lblSalesmanID);
            this.pnlSalesModule.Controls.Add(this.txtCustomerName);
            this.pnlSalesModule.Controls.Add(this.lblCustomerName);
            this.pnlSalesModule.Controls.Add(this.btnProcessSale);
            this.pnlSalesModule.Controls.Add(this.cmbPaymentMethod);
            this.pnlSalesModule.Controls.Add(this.txtTotalAmount);
            this.pnlSalesModule.Controls.Add(this.lblTotalAmount);
            this.pnlSalesModule.Controls.Add(this.btnClearCart);
            this.pnlSalesModule.Controls.Add(this.btnRemoveFromCart);
            this.pnlSalesModule.Controls.Add(this.dgvCart);
            this.pnlSalesModule.Controls.Add(this.lblCart);
            this.pnlSalesModule.Controls.Add(this.btnClear);
            this.pnlSalesModule.Controls.Add(this.txtQuantity);
            this.pnlSalesModule.Controls.Add(this.lblQuantity);
            this.pnlSalesModule.Controls.Add(this.btnShowAll);
            this.pnlSalesModule.Controls.Add(this.btnBack);
            this.pnlSalesModule.Controls.Add(this.txtSearch);
            this.pnlSalesModule.Controls.Add(this.cmbCatagory);
            this.pnlSalesModule.Controls.Add(this.txtUnitPrice);
            this.pnlSalesModule.Controls.Add(this.txtName);
            this.pnlSalesModule.Controls.Add(this.txtMedID);
            this.pnlSalesModule.Controls.Add(this.lblCatagory);
            this.pnlSalesModule.Controls.Add(this.lblName);
            this.pnlSalesModule.Controls.Add(this.lblMedicineID);
            this.pnlSalesModule.Controls.Add(this.lblUnitPrice);
            this.pnlSalesModule.Controls.Add(this.btnAdd);
            this.pnlSalesModule.Controls.Add(this.dgvMedicineList);
            this.pnlSalesModule.Controls.Add(this.pnlHeader);
            this.pnlSalesModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesModule.Location = new System.Drawing.Point(0, 0);
            this.pnlSalesModule.Name = "pnlSalesModule";
            this.pnlSalesModule.Size = new System.Drawing.Size(1075, 551);
            this.pnlSalesModule.TabIndex = 0;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPaymentMethod.Location = new System.Drawing.Point(490, 392);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(60, 17);
            this.lblPaymentMethod.TabIndex = 156;
            this.lblPaymentMethod.Text = "Payment";
            // 
            // txtSalesmanID
            // 
            this.txtSalesmanID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesmanID.Location = new System.Drawing.Point(598, 357);
            this.txtSalesmanID.Name = "txtSalesmanID";
            this.txtSalesmanID.Size = new System.Drawing.Size(100, 23);
            this.txtSalesmanID.TabIndex = 155;
            // 
            // lblSalesmanID
            // 
            this.lblSalesmanID.AutoSize = true;
            this.lblSalesmanID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesmanID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSalesmanID.Location = new System.Drawing.Point(490, 360);
            this.lblSalesmanID.Name = "lblSalesmanID";
            this.lblSalesmanID.Size = new System.Drawing.Size(80, 17);
            this.lblSalesmanID.TabIndex = 154;
            this.lblSalesmanID.Text = "Salesman ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(598, 328);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 23);
            this.txtCustomerName.TabIndex = 153;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerName.Location = new System.Drawing.Point(490, 327);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(102, 17);
            this.lblCustomerName.TabIndex = 152;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnProcessSale
            // 
            this.btnProcessSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnProcessSale.FlatAppearance.BorderSize = 0;
            this.btnProcessSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessSale.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProcessSale.ForeColor = System.Drawing.Color.White;
            this.btnProcessSale.Location = new System.Drawing.Point(493, 460);
            this.btnProcessSale.Name = "btnProcessSale";
            this.btnProcessSale.Size = new System.Drawing.Size(205, 40);
            this.btnProcessSale.TabIndex = 151;
            this.btnProcessSale.Text = "💳 Process Sale";
            this.btnProcessSale.UseVisualStyleBackColor = false;
            this.btnProcessSale.Click += new System.EventHandler(this.btnProcessSale_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "CASH",
            "CARD"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(598, 386);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(80, 23);
            this.cmbPaymentMethod.TabIndex = 157;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(598, 415);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 29);
            this.txtTotalAmount.TabIndex = 150;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalAmount.Location = new System.Drawing.Point(489, 423);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(96, 21);
            this.lblTotalAmount.TabIndex = 149;
            this.lblTotalAmount.Text = "💰 Total: ৳";
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(938, 324);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(99, 30);
            this.btnClearCart.TabIndex = 148;
            this.btnClearCart.Text = "🗑️ Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(847, 323);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(85, 30);
            this.btnRemoveFromCart.TabIndex = 147;
            this.btnRemoveFromCart.Text = "❌ Remove";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartMedicineId,
            this.cartName,
            this.cartUnitPrice,
            this.cartQuantity,
            this.cartTotal});
            this.dgvCart.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCart.Location = new System.Drawing.Point(567, 148);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 25;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(470, 170);
            this.dgvCart.TabIndex = 146;
            // 
            // cartMedicineId
            // 
            this.cartMedicineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartMedicineId.HeaderText = "ID";
            this.cartMedicineId.Name = "cartMedicineId";
            this.cartMedicineId.ReadOnly = true;
            // 
            // cartName
            // 
            this.cartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartName.HeaderText = "Medicine";
            this.cartName.Name = "cartName";
            this.cartName.ReadOnly = true;
            // 
            // cartUnitPrice
            // 
            this.cartUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartUnitPrice.HeaderText = "Unit Price";
            this.cartUnitPrice.Name = "cartUnitPrice";
            this.cartUnitPrice.ReadOnly = true;
            // 
            // cartQuantity
            // 
            this.cartQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartQuantity.HeaderText = "Quantity";
            this.cartQuantity.Name = "cartQuantity";
            this.cartQuantity.ReadOnly = true;
            // 
            // cartTotal
            // 
            this.cartTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cartTotal.HeaderText = "Total";
            this.cartTotal.Name = "cartTotal";
            this.cartTotal.ReadOnly = true;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCart.ForeColor = System.Drawing.Color.Orange;
            this.lblCart.Location = new System.Drawing.Point(563, 118);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(146, 21);
            this.lblCart.TabIndex = 145;
            this.lblCart.Text = "🛒 Shopping Cart";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(418, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 144;
            this.btnClear.Text = "🗑️ Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(120, 257);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 23);
            this.txtQuantity.TabIndex = 143;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.lblQuantity.Location = new System.Drawing.Point(30, 260);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 142;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(216, 271);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(90, 28);
            this.btnShowAll.TabIndex = 141;
            this.btnShowAll.Text = "📋 Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(945, 464);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 36);
            this.btnBack.TabIndex = 140;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(120, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 139;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Items.AddRange(new object[] {
            "Tablets",
            "Liquids",
            "Injections",
            "Creams",
            "Inhalers"});
            this.cmbCatagory.Location = new System.Drawing.Point(120, 225);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(100, 23);
            this.cmbCatagory.TabIndex = 137;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(310, 222);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(80, 23);
            this.txtUnitPrice.TabIndex = 136;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(290, 191);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 23);
            this.txtName.TabIndex = 135;
            // 
            // txtMedID
            // 
            this.txtMedID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedID.Location = new System.Drawing.Point(120, 193);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.Size = new System.Drawing.Size(100, 23);
            this.txtMedID.TabIndex = 134;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCatagory.Location = new System.Drawing.Point(30, 225);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(61, 17);
            this.lblCatagory.TabIndex = 132;
            this.lblCatagory.Text = "Category";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(240, 197);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 17);
            this.lblName.TabIndex = 131;
            this.lblName.Text = "Name";
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedicineID.Location = new System.Drawing.Point(30, 197);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(78, 17);
            this.lblMedicineID.TabIndex = 130;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitPrice.Location = new System.Drawing.Point(240, 222);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 17);
            this.lblUnitPrice.TabIndex = 133;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(312, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 129;
            this.btnAdd.Text = "➕ Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.expirydate,
            this.unitavailable});
            this.dgvMedicineList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMedicineList.Location = new System.Drawing.Point(30, 320);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RowHeadersWidth = 25;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(450, 206);
            this.dgvMedicineList.TabIndex = 128;
            this.dgvMedicineList.DoubleClick += new System.EventHandler(this.dgvMedicineList_DoubleClick);
            // 
            // medicineId
            // 
            this.medicineId.DataPropertyName = "MedicineId";
            this.medicineId.HeaderText = "ID";
            this.medicineId.Name = "medicineId";
            this.medicineId.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Medicine Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "Category";
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.DataPropertyName = "UnitPrice";
            this.unitprice.HeaderText = "Price";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // expirydate
            // 
            this.expirydate.DataPropertyName = "ExpiryDate";
            this.expirydate.HeaderText = "Expiry Date";
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            // 
            // unitavailable
            // 
            this.unitavailable.DataPropertyName = "UnitAvailable";
            this.unitavailable.HeaderText = "Stock";
            this.unitavailable.Name = "unitavailable";
            this.unitavailable.ReadOnly = true;
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
            this.pnlHeader.Size = new System.Drawing.Size(1075, 100);
            this.pnlHeader.TabIndex = 127;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblTitle.Location = new System.Drawing.Point(110, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "💊 Sales Module";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblSubTitle.Location = new System.Drawing.Point(115, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(380, 21);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Process Sales • Manage Cart • Transaction Processing";
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accentPanel.Location = new System.Drawing.Point(0, 95);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(1075, 5);
            this.accentPanel.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblSearch.Location = new System.Drawing.Point(116, 118);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 19);
            this.lblSearch.TabIndex = 158;
            this.lblSearch.Text = "🔍 Quick Search";
            // 
            // UcSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.pnlSalesModule);
            this.Name = "UcSell";
            this.Size = new System.Drawing.Size(1075, 551);
            this.pnlSalesModule.ResumeLayout(false);
            this.pnlSalesModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesModule;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtSalesmanID;
        private System.Windows.Forms.Label lblSalesmanID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMedID;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMedicineList;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitavailable;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox logoImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartMedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartTotal;
        private System.Windows.Forms.Label lblSearch;
    }
}
