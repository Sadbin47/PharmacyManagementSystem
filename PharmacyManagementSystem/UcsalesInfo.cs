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
                
                this.btnRefresh.Click += btnRefresh_Click;
                this.btnDelete.Click += btnDelete_Click;
                this.btnSave.Click += btnSave_Click;
                this.dgvSalesInfo.DoubleClick += dgvSalesInfo_DoubleClick;
                this.txtSearch.TextChanged += txtSearch_TextChanged;
                
                
                this.txtQuantity.TextChanged += txtQuantity_TextChanged;
                this.txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
                
               
                this.btnSave.Visible = true;
                this.pnlControls.Height = 280; 
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
                
                dgvSalesInfo.Columns["SaleDetailID"].DataPropertyName = "SaleDetailID";
                dgvSalesInfo.Columns["SaleID"].DataPropertyName = "SaleID";
                dgvSalesInfo.Columns["MedicineID"].DataPropertyName = "MedicineID";
                dgvSalesInfo.Columns["Quantity"].DataPropertyName = "Quantity";
                dgvSalesInfo.Columns["UnitPrice"].DataPropertyName = "UnitPrice";
                dgvSalesInfo.Columns["Subtotal"].DataPropertyName = "Subtotal";

               
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
                
               
                this.lblSubTitle.Text = $"Total Records: {ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
                
              
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
                
                var countQuery = "SELECT COUNT(*) FROM SalesDetails";
                var countResult = this.Da.ExecuteQueryTable(countQuery);
                int totalRecords = Convert.ToInt32(countResult.Rows[0][0]);
                this.lblRecordCountValue.Text = totalRecords.ToString();

                
                var totalQuery = "SELECT ISNULL(SUM(Subtotal), 0) FROM SalesDetails";
                var totalResult = this.Da.ExecuteQueryTable(totalQuery);
                decimal totalSales = Convert.ToDecimal(totalResult.Rows[0][0]);
                this.lblTotalSalesValue.Text = totalSales.ToString("C");

                
                decimal avgSale = totalRecords > 0 ? totalSales / totalRecords : 0;
                this.lblAvgSaleValue.Text = avgSale.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating statistics: {ex.Message}", "Statistics Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
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

               
                string saleDetailId = txtSaleDetailsId.Text.Trim().Replace("'", "''");
                string saleId = txtSaleId.Text.Trim().Replace("'", "''");
                string medicineId = txtMedicineId.Text.Trim().Replace("'", "''");
                decimal quantity = decimal.Parse(txtQuantity.Text.Trim());
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Trim());
                decimal subtotal = decimal.Parse(txtSubtotal.Text.Trim());

                
                var checkQuery = $"SELECT COUNT(*) FROM SalesDetails WHERE SaleDetailID = {saleDetailId}";
                var checkResult = this.Da.ExecuteQueryTable(checkQuery);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                string sql;
                string operation;

                if (count > 0)
                {
                    
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

                   
                    if (selectedRow.Cells["SaleDetailID"].Value != null)
                        txtSaleDetailsId.Text = selectedRow.Cells["SaleDetailID"].Value.ToString();
                    else
                        txtSaleDetailsId.Text = "";

                   
                    if (selectedRow.Cells["SaleID"].Value != null)
                        txtSaleId.Text = selectedRow.Cells["SaleID"].Value.ToString();
                    else
                        txtSaleId.Text = "";

                   
                    if (selectedRow.Cells["MedicineID"].Value != null)
                        txtMedicineId.Text = selectedRow.Cells["MedicineID"].Value.ToString();
                    else
                        txtMedicineId.Text = "";

                   
                    if (selectedRow.Cells["Quantity"].Value != null)
                        txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                    else
                        txtQuantity.Text = "";

                  
                    if (selectedRow.Cells["UnitPrice"].Value != null)
                        txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value.ToString();
                    else
                        txtUnitPrice.Text = "";

                  
                    if (selectedRow.Cells["Subtotal"].Value != null)
                        txtSubtotal.Text = selectedRow.Cells["Subtotal"].Value.ToString();
                    else
                        txtSubtotal.Text = "";

                    
                    txtSaleId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected record for editing: {ex.Message}",
                    "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.LoadSalesInfo(); 
                    return;
                }

                var searchTerm = txtSearch.Text.Trim().Replace("'", "''"); 
                var sql = $@"SELECT SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal 
                           FROM SalesDetails WHERE
                           SaleDetailID = '{searchTerm}' OR
                           SaleID = '{searchTerm}' OR
                           MedicineID = '{searchTerm}' OR
                           Quantity = '{searchTerm}' OR
                           UnitPrice = '{searchTerm}' OR
                           Subtotal = '{searchTerm}' OR
                           CONVERT(NVARCHAR, SaleDetailID) LIKE '%{searchTerm}%' OR
                           CONVERT(NVARCHAR, SaleID) LIKE '%{searchTerm}%' OR
                           CONVERT(NVARCHAR, MedicineID) LIKE '%{searchTerm}%' OR
                           CONVERT(NVARCHAR, Quantity) LIKE '%{searchTerm}%' OR
                           CONVERT(NVARCHAR, UnitPrice) LIKE '%{searchTerm}%' OR
                           CONVERT(NVARCHAR, Subtotal) LIKE '%{searchTerm}%'";

                this.LoadSalesInfo(sql);
            }
            catch (Exception ex)
            {
             
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        private void ClearEditForm()
        {
            try
            {
                
                txtSaleDetailsId.Clear();
                txtSaleId.Clear();
                txtMedicineId.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                txtSubtotal.Clear();
                
                dgvSalesInfo.ClearSelection();
                
               
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
              
                if (string.IsNullOrWhiteSpace(txtSaleDetailsId.Text) ||
                    string.IsNullOrWhiteSpace(txtSaleId.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicineId.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtSubtotal.Text))
                {
                    return false;
                }

                
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

                
                decimal expectedSubtotal = quantity * unitPrice;
                if (Math.Abs(subtotal - expectedSubtotal) > 0.01m) 
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
        
        public void RefreshSalesData()
        {
            this.LoadSalesInfo();
        }

       
        
        public void SearchSalesData(string searchTerm)
        {
            this.txtSearch.Text = searchTerm;
        }

        
        public void ShowEditFormForTesting()
        {
            try
            {
                
                this.btnSave.Visible = true;
                
                
                this.pnlControls.Height = 280;
                
                
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
