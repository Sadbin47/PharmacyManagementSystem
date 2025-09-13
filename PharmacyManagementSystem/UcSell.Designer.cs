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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.accentPanel = new System.Windows.Forms.Panel();
            this.dgvMedicineList = new System.Windows.Forms.DataGridView();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMedID = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.medicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(776, 100);
            this.pnlHeader.TabIndex = 5;
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
            this.lblSubTitle.Size = new System.Drawing.Size(385, 21);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Manage System • Shop Control • Analytics Dashboard";
            // 
            // accentPanel
            // 
            this.accentPanel.BackColor = System.Drawing.Color.BlueViolet;
            this.accentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.accentPanel.Location = new System.Drawing.Point(0, 95);
            this.accentPanel.Name = "accentPanel";
            this.accentPanel.Size = new System.Drawing.Size(776, 5);
            this.accentPanel.TabIndex = 3;
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
            this.expirydate});
            this.dgvMedicineList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMedicineList.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMedicineList.Location = new System.Drawing.Point(0, 406);
            this.dgvMedicineList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.ReadOnly = true;
            this.dgvMedicineList.RowHeadersWidth = 62;
            this.dgvMedicineList.RowTemplate.Height = 28;
            this.dgvMedicineList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicineList.Size = new System.Drawing.Size(776, 262);
            this.dgvMedicineList.TabIndex = 14;
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
            this.cmbCatagory.Location = new System.Drawing.Point(163, 177);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(166, 23);
            this.cmbCatagory.TabIndex = 56;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(163, 205);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(166, 23);
            this.txtUnitPrice.TabIndex = 55;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(163, 146);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 23);
            this.txtName.TabIndex = 54;
            // 
            // txtMedID
            // 
            this.txtMedID.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedID.Location = new System.Drawing.Point(163, 116);
            this.txtMedID.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedID.Name = "txtMedID";
            this.txtMedID.ReadOnly = true;
            this.txtMedID.Size = new System.Drawing.Size(166, 23);
            this.txtMedID.TabIndex = 53;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUnitPrice.Location = new System.Drawing.Point(39, 208);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(61, 17);
            this.lblUnitPrice.TabIndex = 52;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCatagory.Location = new System.Drawing.Point(39, 177);
            this.lblCatagory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(61, 17);
            this.lblCatagory.TabIndex = 51;
            this.lblCatagory.Text = "Catagory";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(39, 149);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 17);
            this.lblName.TabIndex = 50;
            this.lblName.Text = "Name";
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineID.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMedicineID.Location = new System.Drawing.Point(39, 119);
            this.lblMedicineID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(78, 17);
            this.lblMedicineID.TabIndex = 49;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.BlueViolet;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(432, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "➕ Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(432, 166);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(100, 35);
            this.btnSell.TabIndex = 48;
            this.btnSell.Text = "🗑️ Sell";
            this.btnSell.UseVisualStyleBackColor = false;
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
            // expirydate
            // 
            this.expirydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirydate.DataPropertyName = "ExpiryDate";
            this.expirydate.HeaderText = "ExpiryDate";
            this.expirydate.Name = "expirydate";
            this.expirydate.ReadOnly = true;
            // 
            // UcSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMedID);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMedicineID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UcSell";
            this.Size = new System.Drawing.Size(776, 668);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox logoImageBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel accentPanel;
        private System.Windows.Forms.DataGridView dgvMedicineList;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMedID;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirydate;
    }
}
