using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class FormSalesman : Form
    {
        private DataAccess Da { get; set; }

        public FormSalesman()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                this.InitializeSortOptions();
                this.PopulateGridView();
                this.AutoIdGenerate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Form Load and Initialization
        private void FormSalesman_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvMedicineList.ClearSelection();
                this.SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSortOptions()
        {
            try
            {
                sortComboBox.Items.Clear();
                sortComboBox.Items.AddRange(new string[] 
                {
                    "MedicineId",
                    "Name", 
                    "Category",
                    "UnitPrice",
                    "UnitCost",
                    "BatchNumber",
                    "Manufacturer",
                    "ExpiryDate"
                });
                sortComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing sort options: {ex.Message}", "Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                // Map DataGridView columns to database columns
                dgvMedicineList.Columns["medicineId"].DataPropertyName = "MedicineId";
                dgvMedicineList.Columns["name"].DataPropertyName = "Name";
                dgvMedicineList.Columns["category"].DataPropertyName = "Category";
                dgvMedicineList.Columns["unitprice"].DataPropertyName = "UnitPrice";
                dgvMedicineList.Columns["unitcost"].DataPropertyName = "UnitCost";
                dgvMedicineList.Columns["batchnumber"].DataPropertyName = "BatchNumber";
                dgvMedicineList.Columns["manufacturer"].DataPropertyName = "Manufacturer";
                dgvMedicineList.Columns["expirydate"].DataPropertyName = "ExpiryDate";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Setup Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Auto ID Generation
        private void AutoIdGenerate()
        {
            try
            {
                var query = "SELECT MAX(MedicineId) FROM Medicine";
                var dt = this.Da.ExecuteQueryTable(query);
                
                int newId = 1;
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    newId = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }
                
                this.txtMedID.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating auto ID: {ex.Message}", "ID Generation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMedID.Text = "1"; // Default fallback
            }
        }
        #endregion

        #region Data Display Methods
        private void PopulateGridView(string sql = "SELECT * FROM Medicine")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineList.AutoGenerateColumns = false;
                this.dgvMedicineList.DataSource = ds.Tables[0];
                
                // Update status
                this.lblSubTitle.Text = $"Total Records: {ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Data Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Event Handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if medicine ID already exists
                var checkQuery = $"SELECT COUNT(*) FROM Medicine WHERE MedicineId = {txtMedID.Text}";
                var checkResult = this.Da.ExecuteQueryTable(checkQuery);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                string sql;
                string operation;

                if (count > 0)
                {
                    // Update existing record
                    sql = $@"UPDATE Medicine SET 
                            Name = '{txtName.Text.Trim()}',
                            Category = '{cmbCatagory.Text}',
                            UnitPrice = {decimal.Parse(txtUnitPrice.Text)},
                            UnitCost = {decimal.Parse(txtUnitCost.Text)},
                            BatchNumber = {int.Parse(txtBatchNo.Text)},
                            Manufacturer = '{txtManuFacturer.Text.Trim()}',
                            ExpiryDate = '{dtpExpiryDate.Value:yyyy-MM-dd}'
                            WHERE MedicineId = {int.Parse(txtMedID.Text)}";
                    operation = "updated";
                }
                else
                {
                    // Insert new record
                    sql = $@"INSERT INTO Medicine (MedicineId, Name, Category, UnitPrice, UnitCost, BatchNumber, Manufacturer, ExpiryDate)
                            VALUES ({int.Parse(txtMedID.Text)}, 
                                   '{txtName.Text.Trim()}', 
                                   '{cmbCatagory.Text}', 
                                   {decimal.Parse(txtUnitPrice.Text)}, 
                                   {decimal.Parse(txtUnitCost.Text)}, 
                                   {int.Parse(txtBatchNo.Text)}, 
                                   '{txtManuFacturer.Text.Trim()}', 
                                   '{dtpExpiryDate.Value:yyyy-MM-dd}')";
                    operation = "added";
                }

                int result = this.Da.ExecuteDMLQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show($"Medicine {operation} successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.PopulateGridView();
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to {operation.Replace("ed", "")} medicine.", "Operation Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for ID, Unit Price, Unit Cost, and Batch Number.", 
                    "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving medicine: {ex.Message}", "Save Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicineList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a medicine to delete.", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvMedicineList.SelectedRows[0];
                var medicineId = selectedRow.Cells["medicineId"].Value.ToString();
                var medicineName = selectedRow.Cells["name"].Value.ToString();

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete medicine '{medicineName}' (ID: {medicineId})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var sql = $"DELETE FROM Medicine WHERE MedicineId = {medicineId}";
                    int result = this.Da.ExecuteDMLQuery(sql);

                    if (result > 0)
                    {
                        MessageBox.Show("Medicine deleted successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.PopulateGridView();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete medicine.", "Delete Failed", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting medicine: {ex.Message}", "Delete Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulateGridView();
                this.txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all records: {ex.Message}", "Display Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a search term.", "Search Input Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var searchTerm = txtSearch.Text.Trim();
                var sql = $@"SELECT * FROM Medicine WHERE 
                           Name LIKE '%{searchTerm}%' OR 
                           Category LIKE '%{searchTerm}%' OR 
                           Manufacturer LIKE '%{searchTerm}%' OR
                           CAST(MedicineId AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(BatchNumber AS NVARCHAR) LIKE '%{searchTerm}%'";

                this.PopulateGridView(sql);

                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show($"No medicines found matching '{searchTerm}'.", "No Results", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing search: {ex.Message}", "Search Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Handlers
        private void dgvMedicineList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicineList.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvMedicineList.SelectedRows[0];
                    
                    txtMedID.Text = selectedRow.Cells["medicineId"].Value?.ToString() ?? "";
                    txtName.Text = selectedRow.Cells["name"].Value?.ToString() ?? "";
                    cmbCatagory.Text = selectedRow.Cells["category"].Value?.ToString() ?? "";
                    txtUnitPrice.Text = selectedRow.Cells["unitprice"].Value?.ToString() ?? "";
                    txtUnitCost.Text = selectedRow.Cells["unitcost"].Value?.ToString() ?? "";
                    txtBatchNo.Text = selectedRow.Cells["batchnumber"].Value?.ToString() ?? "";
                    txtManuFacturer.Text = selectedRow.Cells["manufacturer"].Value?.ToString() ?? "";
                    
                    if (DateTime.TryParse(selectedRow.Cells["expirydate"].Value?.ToString(), out DateTime expiryDate))
                    {
                        dtpExpiryDate.Value = expiryDate;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected record: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sortComboBox.SelectedItem != null)
                {
                    var sortColumn = sortComboBox.SelectedItem.ToString();
                    var sql = $"SELECT * FROM Medicine ORDER BY {sortColumn}";
                    this.PopulateGridView(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sorting data: {ex.Message}", "Sort Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.PopulateGridView(); // Show all if search is empty
                    return;
                }

                var searchTerm = txtSearch.Text.Trim();
                var sql = $@"SELECT * FROM Medicine WHERE 
                           Name LIKE '%{searchTerm}%' OR 
                           Category LIKE '%{searchTerm}%' OR 
                           Manufacturer LIKE '%{searchTerm}%' OR
                           CAST(MedicineId AS NVARCHAR) LIKE '%{searchTerm}%' OR
                           CAST(BatchNumber AS NVARCHAR) LIKE '%{searchTerm}%'";

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                // Don't show error for real-time search to avoid interrupting user typing
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        private void ClearAll()
        {
            try
            {
                txtName.Clear();
                txtUnitPrice.Clear();
                txtUnitCost.Clear();
                txtBatchNo.Clear();
                txtManuFacturer.Clear();
                txtSearch.Clear();
                
                cmbCatagory.SelectedIndex = -1;
                dtpExpiryDate.Value = DateTime.Now.AddYears(1); // Default to 1 year from now
                
                dgvMedicineList.ClearSelection();
                this.AutoIdGenerate();
                
                // Focus on first input
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing form: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidToSave()
        {
            try
            {
                // Check required text fields
                if (string.IsNullOrWhiteSpace(txtMedID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitCost.Text) ||
                    string.IsNullOrWhiteSpace(txtBatchNo.Text) ||
                    string.IsNullOrWhiteSpace(txtManuFacturer.Text) ||
                    cmbCatagory.SelectedIndex == -1)
                {
                    return false;
                }

                // Validate numeric fields
                if (!int.TryParse(txtMedID.Text, out int medicineId) || medicineId <= 0)
                {
                    MessageBox.Show("Please enter a valid Medicine ID (positive integer).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMedID.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price (non-negative decimal).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitPrice.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtUnitCost.Text, out decimal unitCost) || unitCost < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Cost (non-negative decimal).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitCost.Focus();
                    return false;
                }

                if (!int.TryParse(txtBatchNo.Text, out int batchNumber) || batchNumber <= 0)
                {
                    MessageBox.Show("Please enter a valid Batch Number (positive integer).", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBatchNo.Focus();
                    return false;
                }

                // Validate expiry date
                if (dtpExpiryDate.Value <= DateTime.Now)
                {
                    var result = MessageBox.Show("The expiry date is in the past. Do you want to continue?", 
                        "Expiry Date Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        dtpExpiryDate.Focus();
                        return false;
                    }
                }

                // Business logic validation
                if (unitPrice < unitCost)
                {
                    var result = MessageBox.Show("Unit Price is less than Unit Cost. This may result in loss. Continue?", 
                        "Price Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        txtUnitPrice.Focus();
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

        #endregion

        #region Sell Button
        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                UcSell sell = new UcSell();
                sell.Size = new Size(1075, 551); // Set the intended size
                sell.Dock = DockStyle.Fill; // Make it fill the form
                this.Controls.Clear();
                this.Controls.Add(sell);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sell module: {ex.Message}", "Navigation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Exit and Logout
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Clear the logged-in user
            FormLogin.Logout();
            
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
        #endregion
    }
}
