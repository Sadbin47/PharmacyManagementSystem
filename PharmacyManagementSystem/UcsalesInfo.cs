using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class UcsalesInfo : UserControl
    {
        private DataAccess Da { get; set; }

        public UcsalesInfo()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                this.SetupDataGridView();
                this.InitializeEvents();
                this.LoadSalesInfo();
                this.UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Sales Info form: {ex.Message}\n\nThe edit form may not work properly without a database connection.", "Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Initialize events even if database fails
                try
                {
                    this.InitializeEvents();
                }
                catch (Exception evtEx)
                {
                    MessageBox.Show($"Failed to initialize events: {evtEx.Message}", "Event Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region Form Load and Initialization
        private void UcsalesInfo_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvSalesInfo.ClearSelection();
                this.LoadSalesInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Sales Info form: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeEvents()
        {
            try
            {
                // Wire up event handlers
                this.btnRefresh.Click += btnRefresh_Click;
                this.btnDelete.Click += btnDelete_Click;
                this.btnSave.Click += btnSave_Click;
                this.dgvSalesInfo.DoubleClick += dgvSalesInfo_DoubleClick;
                this.txtSearch.TextChanged += txtSearch_TextChanged;
                
                // Wire up auto-calculation events
                this.txtQuantity.TextChanged += txtQuantity_TextChanged;
                this.txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
                
                // Show the save button by default
                this.btnSave.Visible = true;
                this.pnlControls.Height = 280; // Expand to show edit form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing events: {ex.Message}", "Event Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                // Map DataGridView columns to database columns
                dgvSalesInfo.Columns["SaleDetailID"].DataPropertyName = "SaleDetailID";
                dgvSalesInfo.Columns["SaleID"].DataPropertyName = "SaleID";
                dgvSalesInfo.Columns["MedicineID"].DataPropertyName = "MedicineID";
                dgvSalesInfo.Columns["Quantity"].DataPropertyName = "Quantity";
                dgvSalesInfo.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
                dgvSalesInfo.Columns["Subtotal"].DataPropertyName = "Subtotal";

                // Enhance DataGridView appearance
                dgvSalesInfo.EnableHeadersVisualStyles = false;
                dgvSalesInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
                dgvSalesInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvSalesInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvSalesInfo.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dgvSalesInfo.DefaultCellStyle.ForeColor = Color.White;
                dgvSalesInfo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 89, 182);
                dgvSalesInfo.DefaultCellStyle.SelectionForeColor = Color.White;
                dgvSalesInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(70, 70, 70);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Setup Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Data Display Methods
        private void LoadSalesInfo(string sql = "SELECT SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal FROM SalesDetails")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvSalesInfo.AutoGenerateColumns = false;
                this.dgvSalesInfo.DataSource = ds.Tables[0];
                
                // Update subtitle with record count and timestamp
                this.lblSubTitle.Text = $"Total Records: {ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
                
                // Update statistics
                this.UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales data: {ex.Message}", "Data Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics()
        {
            try
            {
                // Get total records count
                var countQuery = "SELECT COUNT(*) FROM SalesDetails";
                var countResult = this.Da.ExecuteQueryTable(countQuery);
                int totalRecords = Convert.ToInt32(countResult.Rows[0][0]);
                this.lblRecordCountValue.Text = totalRecords.ToString();

                // Get total sales value
                var totalQuery = "SELECT ISNULL(SUM(Subtotal), 0) FROM SalesDetails";
                var totalResult = this.Da.ExecuteQueryTable(totalQuery);
                decimal totalSales = Convert.ToDecimal(totalResult.Rows[0][0]);
                this.lblTotalSalesValue.Text = totalSales.ToString("C");

                // Calculate average sale value
                decimal avgSale = totalRecords > 0 ? totalSales / totalRecords : 0;
                this.lblAvgSaleValue.Text = avgSale.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating statistics: {ex.Message}", "Statistics Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                // Set default values on error
                this.lblRecordCountValue.Text = "0";
                this.lblTotalSalesValue.Text = "$0.00";
                this.lblAvgSaleValue.Text = "$0.00";
            }
        }
        #endregion

        #region Button Event Handlers
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadSalesInfo();
                this.txtSearch.Clear();
                this.ClearEditForm();
                
                MessageBox.Show("Sales data refreshed successfully!", "Refresh Complete", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing sales data: {ex.Message}", "Refresh Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesInfo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a sales record to delete.", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvSalesInfo.SelectedRows[0];
                var saleDetailId = selectedRow.Cells["SaleDetailID"].Value.ToString();
                var saleId = selectedRow.Cells["SaleID"].Value.ToString();
                var medicineId = selectedRow.Cells["MedicineID"].Value.ToString();

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete this sales record?\n\nSale Detail ID: {saleDetailId}\nSale ID: {saleId}\nMedicine ID: {medicineId}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var sql = $"DELETE FROM SalesDetails WHERE SaleDetailID = {saleDetailId}";
                    int result = this.Da.ExecuteDMLQuery(sql);

                    if (result > 0)
                    {
                        MessageBox.Show("Sales record deleted successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadSalesInfo();
                        this.ClearEditForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete sales record.", "Delete Failed", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting sales record: {ex.Message}", "Delete Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all required fields with valid data.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sanitize inputs to prevent SQL injection
                string saleDetailId = txtSaleDetailsId.Text.Trim().Replace("'", "''");
                string saleId = txtSaleId.Text.Trim().Replace("'", "''");
                string medicineId = txtMedicineId.Text.Trim().Replace("'", "''");
                decimal quantity = decimal.Parse(txtQuantity.Text.Trim());
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Trim());
                decimal subtotal = decimal.Parse(txtSubtotal.Text.Trim());

                // Check if sale detail ID already exists
                var checkQuery = $"SELECT COUNT(*) FROM SalesDetails WHERE SaleDetailID = {saleDetailId}";
                var checkResult = this.Da.ExecuteQueryTable(checkQuery);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                string sql;
                string operation;

                if (count > 0)
                {
                    // Update existing record
                    sql = $@"UPDATE SalesDetails SET 
                            SaleID = {saleId},
                            MedicineID = {medicineId},
                            Quantity = {quantity},
                            UnitPrice = {unitPrice},
                            Subtotal = {subtotal}
                            WHERE SaleDetailID = {saleDetailId}";
                    operation = "updated";
                }
                else
                {
                    // Insert new record
                    sql = $@"INSERT INTO SalesDetails (SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal)
                            VALUES ({saleDetailId}, {saleId}, {medicineId}, {quantity}, {unitPrice}, {subtotal})";
                    operation = "added";
                }

                int result = this.Da.ExecuteDMLQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show($"Sales record {operation} successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadSalesInfo();
                    this.ClearEditForm();
                }
                else
                {
                    MessageBox.Show($"Failed to {operation.Replace("ed", "")} sales record.", "Operation Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for all numeric fields.", 
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving sales record: {ex.Message}", "Save Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Handlers
        private void dgvSalesInfo_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesInfo.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvSalesInfo.SelectedRows[0];
                    
                    // Load data into edit form controls
                    txtSaleDetailsId.Text = selectedRow.Cells["SaleDetailID"].Value?.ToString() ?? "";
                    txtSaleId.Text = selectedRow.Cells["SaleID"].Value?.ToString() ?? "";
                    txtMedicineId.Text = selectedRow.Cells["MedicineID"].Value?.ToString() ?? "";
                    txtQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString() ?? "";
                    txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value?.ToString() ?? "";
                    txtSubtotal.Text = selectedRow.Cells["Subtotal"].Value?.ToString() ?? "";
                    
                    // Focus on first editable field
                    txtSaleId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected record for editing: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Real-time search functionality
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.LoadSalesInfo(); // Show all if search is empty
                    return;
                }

                var searchTerm = txtSearch.Text.Trim().Replace("'", "''"); // Prevent SQL injection
                var sql = $@"SELECT SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal 
                           FROM SalesDetails WHERE 
                           CAST(SaleDetailID AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(SaleID AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(MedicineID AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(Quantity AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(UnitPrice AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(Subtotal AS NVARCHAR) LIKE '%{searchTerm}%'";

                this.LoadSalesInfo(sql);
            }
            catch (Exception ex)
            {
                // Don't show error for real-time search to avoid interrupting user typing
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        private void ClearEditForm()
        {
            try
            {
                // Clear all edit form fields
                txtSaleDetailsId.Clear();
                txtSaleId.Clear();
                txtMedicineId.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                txtSubtotal.Clear();
                
                dgvSalesInfo.ClearSelection();
                
                // Keep edit form visible - don't hide it
                // Edit form stays visible for continuous use
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing edit form: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidToSave()
        {
            try
            {
                // Check required text fields
                if (string.IsNullOrWhiteSpace(txtSaleDetailsId.Text) ||
                    string.IsNullOrWhiteSpace(txtSaleId.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicineId.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtSubtotal.Text))
                {
                    return false;
                }

                // Validate numeric fields
                if (!int.TryParse(txtSaleDetailsId.Text, out int saleDetailId) || saleDetailId <= 0)
                {
                    MessageBox.Show("Please enter a valid Sale Detail ID (positive integer).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSaleDetailsId.Focus();
                    return false;
                }

                if (!int.TryParse(txtSaleId.Text, out int saleId) || saleId <= 0)
                {
                    MessageBox.Show("Please enter a valid Sale ID (positive integer).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSaleId.Focus();
                    return false;
                }

                if (!int.TryParse(txtMedicineId.Text, out int medicineId) || medicineId <= 0)
                {
                    MessageBox.Show("Please enter a valid Medicine ID (positive integer).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMedicineId.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid Quantity (positive number).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price (non-negative number).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitPrice.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtSubtotal.Text, out decimal subtotal) || subtotal < 0)
                {
                    MessageBox.Show("Please enter a valid Subtotal (non-negative number).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSubtotal.Focus();
                    return false;
                }

                // Business logic validation
                decimal expectedSubtotal = quantity * unitPrice;
                if (Math.Abs(subtotal - expectedSubtotal) > 0.01m) // Allow small floating point differences
                {
                    var result = MessageBox.Show($"Subtotal ({subtotal:C}) doesn't match calculated value ({expectedSubtotal:C}). Continue anyway?", 
                        "Subtotal Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        txtSubtotal.Focus();
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during validation: {ex.Message}", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Auto-calculate subtotal when quantity or unit price changes
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSubtotal();
        }

        private void CalculateSubtotal()
        {
            try
            {
                if (decimal.TryParse(txtQuantity.Text, out decimal quantity) && 
                    decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
                {
                    decimal subtotal = quantity * unitPrice;
                    txtSubtotal.Text = subtotal.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating subtotal: {ex.Message}", "Calculation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Public Methods for External Access
        /// <summary>
        /// Public method to refresh sales data from external forms
        /// </summary>
        public void RefreshSalesData()
        {
            this.LoadSalesInfo();
        }

        /// <summary>
        /// Public method to search sales data from external forms
        /// </summary>
        /// <param name="searchTerm">Term to search for</param>
        public void SearchSalesData(string searchTerm)
        {
            this.txtSearch.Text = searchTerm;
        }

        /// <summary>
        /// Public method to manually show the edit form for testing
        /// </summary>
        public void ShowEditFormForTesting()
        {
            try
            {
                // Show save button
                this.btnSave.Visible = true;
                
                // Update control layout
                this.pnlControls.Height = 280;
                
                // Populate with test data
                txtSaleDetailsId.Text = "1";
                txtSaleId.Text = "1";
                txtMedicineId.Text = "1";
                txtQuantity.Text = "1";
                txtUnitPrice.Text = "10.00";
                txtSubtotal.Text = "10.00";
                
                MessageBox.Show("Edit form shown with test data!", "Test Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing edit form: {ex.Message}", "Test Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
