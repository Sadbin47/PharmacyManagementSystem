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
        private DataSet Ds { get; set; }
        private string Sql { get; set; }

        public FormSalesman()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                PopulateGridView();
                GenerateMedicineID();
                InitializeSortOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvMedicineList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message);
            }
        }

        private void PopulateGridView(string sql = "SELECT * FROM Medicine")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineList.AutoGenerateColumns = false;
                this.dgvMedicineList.DataSource = this.Ds.Tables[0];
                
                this.lblSubTitle.Text = $"Total Records: {this.Ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void GenerateMedicineID()
        {
            try
            {
                this.Sql = "SELECT * FROM Medicine ORDER BY MedicineId DESC";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                
                int newId = 1;
                if (dt.Rows.Count > 0)
                {
                    newId = Convert.ToInt32(dt.Rows[0]["MedicineId"]) + 1;
                }
                
                this.txtMedID.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating ID: " + ex.Message);
                this.txtMedID.Text = "1";
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
                    "ExpiryDate",
                    "UnitAvailable"
                });
                sortComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing sort options: " + ex.Message);
            }
        }

        private void ClearAll()
        {
            try
            {
                this.txtMedID.Clear();
                this.txtMedID.ReadOnly = true;
                this.txtName.Clear();
                this.cmbCatagory.SelectedIndex = -1;
                this.txtUnitPrice.Clear();
                this.txtUnitCost.Clear();
                this.txtBatchNo.Clear();
                this.txtManuFacturer.Clear();
                this.txtUnitAvailable.Clear();
                this.dtpExpiryDate.Value = DateTime.Now.AddYears(1);
                this.txtSearch.Clear();
                GenerateMedicineID();
                this.txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing form: " + ex.Message);
            }
        }

        private bool IsValidToSave()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitCost.Text) ||
                    string.IsNullOrWhiteSpace(txtBatchNo.Text) ||
                    string.IsNullOrWhiteSpace(txtManuFacturer.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitAvailable.Text) ||
                    cmbCatagory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Price.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitPrice.Focus();
                    return false;
                }

                if (!decimal.TryParse(txtUnitCost.Text, out decimal unitCost) || unitCost < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Cost.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitCost.Focus();
                    return false;
                }

                if (!int.TryParse(txtBatchNo.Text, out int batchNumber) || batchNumber <= 0)
                {
                    MessageBox.Show("Please enter a valid Batch Number.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBatchNo.Focus();
                    return false;
                }

                if (!int.TryParse(txtUnitAvailable.Text, out int unitAvailable) || unitAvailable < 0)
                {
                    MessageBox.Show("Please enter a valid Unit Available quantity.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUnitAvailable.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during validation: " + ex.Message);
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave()) return;

                this.Sql = "SELECT * FROM Medicine WHERE MedicineId = '" + this.txtMedID.Text + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    // Update existing record
                    this.Sql = "UPDATE Medicine SET " +
                              "Name = '" + txtName.Text.Trim() + "', " +
                              "Category = '" + cmbCatagory.Text + "', " +
                              "UnitPrice = '" + txtUnitPrice.Text + "', " +
                              "UnitCost = '" + txtUnitCost.Text + "', " +
                              "BatchNumber = '" + txtBatchNo.Text + "', " +
                              "Manufacturer = '" + txtManuFacturer.Text.Trim() + "', " +
                              "ExpiryDate = '" + dtpExpiryDate.Value.ToString("yyyy-MM-dd") + "', " +
                              "UnitAvailable = '" + txtUnitAvailable.Text + "' " +
                              "WHERE MedicineId = '" + txtMedID.Text + "'";

                    int count = this.Da.ExecuteDMLQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(txtName.Text + " has been updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Medicine update failed");
                    }
                }
                else
                {
                    this.Sql = "INSERT INTO Medicine (MedicineId, Name, Category, UnitPrice, UnitCost, BatchNumber, Manufacturer, ExpiryDate, UnitAvailable) " +
                              "VALUES ('" + txtMedID.Text + "', " +
                              "'" + txtName.Text.Trim() + "', " +
                              "'" + cmbCatagory.Text + "', " +
                              "'" + txtUnitPrice.Text + "', " +
                              "'" + txtUnitCost.Text + "', " +
                              "'" + txtBatchNo.Text + "', " +
                              "'" + txtManuFacturer.Text.Trim() + "', " +
                              "'" + dtpExpiryDate.Value.ToString("yyyy-MM-dd") + "', " +
                              "'" + txtUnitAvailable.Text + "')";

                    int count = this.Da.ExecuteDMLQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(txtName.Text + " has been added successfully");
                        this.GenerateMedicineID();
                    }
                    else
                    {
                        MessageBox.Show("Medicine insertion failed");
                    }
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during saving\n\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicineList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a medicine to delete.");
                    return;
                }

                string id = dgvMedicineList.CurrentRow.Cells["medicineId"].Value.ToString();
                string name = dgvMedicineList.CurrentRow.Cells["name"].Value.ToString();

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete '{name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    this.Sql = "DELETE FROM Medicine WHERE MedicineId = '" + id + "'";
                    int count = this.Da.ExecuteDMLQuery(this.Sql);
                    
                    if (count == 1)
                    {
                        MessageBox.Show(name + " has been deleted");
                    }
                    else
                    {
                        MessageBox.Show("Medicine deletion failed");
                    }
                    this.PopulateGridView();
                    this.ClearAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during deletion\n" + ex.Message);
            }
        }

        private void btnShowALL_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateGridView();
                this.txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing all records: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            PopulateGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.PopulateGridView();
                    return;
                }

                this.Sql = "SELECT * FROM Medicine WHERE " +
                          "Name LIKE '" + txtSearch.Text + "%' OR " +
                          "Category LIKE '" + txtSearch.Text + "%' OR " +
                          "Manufacturer LIKE '" + txtSearch.Text + "%'";
                this.PopulateGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during search\n" + exc.Message);
            }
        }

        private void dgvMedicineList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMedicineList.CurrentRow != null)
            {
                try
                {
                    this.txtMedID.ReadOnly = true;
                    this.txtMedID.Text = dgvMedicineList.CurrentRow.Cells["medicineId"].Value?.ToString();
                    this.txtName.Text = dgvMedicineList.CurrentRow.Cells["name"].Value?.ToString();
                    this.cmbCatagory.Text = dgvMedicineList.CurrentRow.Cells["category"].Value?.ToString();
                    this.txtUnitPrice.Text = dgvMedicineList.CurrentRow.Cells["unitprice"].Value?.ToString();
                    this.txtUnitCost.Text = dgvMedicineList.CurrentRow.Cells["unitcost"].Value?.ToString();
                    this.txtBatchNo.Text = dgvMedicineList.CurrentRow.Cells["batchnumber"].Value?.ToString();
                    this.txtManuFacturer.Text = dgvMedicineList.CurrentRow.Cells["manufacturer"].Value?.ToString();
                    this.txtUnitAvailable.Text = dgvMedicineList.CurrentRow.Cells["unitavailable"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medicine details: " + ex.Message);
                }
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sortComboBox.SelectedItem != null)
                {
                    var sortColumn = sortComboBox.SelectedItem.ToString();
                    var sql = "SELECT * FROM Medicine ORDER BY " + sortColumn;
                    this.PopulateGridView(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting data: " + ex.Message);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    control.Visible = false;
                }
                
                UcSell sell = new UcSell();
                sell.Size = new Size(1075, 551);
                sell.Dock = DockStyle.Fill;
                this.Controls.Add(sell);
                sell.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sell module: " + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin.Logout();
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
