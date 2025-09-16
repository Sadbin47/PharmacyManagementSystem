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
    public partial class UcSell : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable cartTable;
        private string Sql { get; set; }

        public UcSell()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                InitializeCart();
                PopulateMedicineGrid();
                ClearAll();
                AutoCaptureSalesmanID();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing form: " + ex.Message);
            }
        }

        private void AutoCaptureSalesmanID()
        {
            txtSalesmanID.Text = FormLogin.IsUserLoggedIn() && !string.IsNullOrEmpty(FormLogin.LoggedInUserId) 
                ? FormLogin.LoggedInUserId : "1";
            txtCustomerName.Text = "Random";
        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("MedicineId", typeof(int));
            cartTable.Columns.Add("Name", typeof(string));
            cartTable.Columns.Add("UnitPrice", typeof(float));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Total", typeof(float));
            
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = cartTable;
            
            // Bind cart columns properly
            if (this.dgvCart.Columns.Count > 0)
            {
                this.dgvCart.Columns["cartMedicineId"].DataPropertyName = "MedicineId";
                this.dgvCart.Columns["cartName"].DataPropertyName = "Name";
                this.dgvCart.Columns["cartUnitPrice"].DataPropertyName = "UnitPrice";
                this.dgvCart.Columns["cartQuantity"].DataPropertyName = "Quantity";
                this.dgvCart.Columns["cartTotal"].DataPropertyName = "Total";
            }
        }

        private void PopulateMedicineGrid(string sql = "SELECT * FROM Medicine")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineList.AutoGenerateColumns = false;
                this.dgvMedicineList.DataSource = this.Ds.Tables[0];
                this.lblSubTitle.Text = $"Total Available Medicines: {this.Ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }

        private void UpdateTotalAmount()
        {
            try
            {
                float total = cartTable.AsEnumerable().Sum(row => (float)row["Total"]);
                txtTotalAmount.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total: " + ex.Message);
            }
        }

        private void ClearAll()
        {
            try
            {
                txtMedID.Clear();
                txtName.Clear();
                txtUnitPrice.Clear();
                cmbCatagory.SelectedIndex = -1;
                txtQuantity.Text = "1";
                dgvMedicineList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing form: " + ex.Message);
            }
        }

        private bool IsValidToAdd()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMedID.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please select a medicine and enter quantity.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity greater than 0.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQuantity.Focus();
                    return false;
                }

                if (!float.TryParse(txtUnitPrice.Text, out float price) || price <= 0)
                {
                    MessageBox.Show("Please select a valid medicine with a valid price.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return CheckInventoryAvailability(int.Parse(txtMedID.Text), quantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during validation: " + ex.Message);
                return false;
            }
        }

        private bool CheckInventoryAvailability(int medicineId, int requestedQuantity)
        {
            try
            {
                this.Sql = "SELECT UnitAvailable FROM Medicine WHERE MedicineId = '" + medicineId + "'";
                DataTable result = this.Da.ExecuteQueryTable(this.Sql);
                
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Medicine not found in database.");
                    return false;
                }

                int availableUnits = Convert.ToInt32(result.Rows[0]["UnitAvailable"]);
                int alreadyInCart = cartTable.AsEnumerable()
                    .Where(row => Convert.ToInt32(row["MedicineId"]) == medicineId)
                    .Sum(row => Convert.ToInt32(row["Quantity"]));

                if (availableUnits <= 0)
                {
                    MessageBox.Show("This medicine is out of stock (0 units available).");
                    return false;
                }

                if (requestedQuantity + alreadyInCart > availableUnits)
                {
                    MessageBox.Show($"Insufficient stock. Available: {availableUnits}, Already in cart: {alreadyInCart}, Requested: {requestedQuantity}");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking inventory: " + ex.Message);
                return false;
            }
        }

        private bool IsValidToProcessSale()
        {
            try
            {
                if (cartTable.Rows.Count == 0)
                {
                    MessageBox.Show("Cart is empty. Please add items before processing sale.");
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || 
                    string.IsNullOrWhiteSpace(txtSalesmanID.Text) ||
                    cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all sale information (Customer Name, Salesman ID, Payment Method).");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during sale validation: " + ex.Message);
                return false;
            }
        }

        private int GenerateId(string sql)
        {
            try
            {
                DataTable result = this.Da.ExecuteQueryTable(sql);
                return result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value 
                    ? Convert.ToInt32(result.Rows[0][0]) : 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating ID: " + ex.Message);
                return new Random().Next(1000, 9999);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToAdd()) return;

                int medicineId = int.Parse(txtMedID.Text);
                string name = txtName.Text;
                float unitPrice = float.Parse(txtUnitPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                var existingRow = cartTable.AsEnumerable()
                    .FirstOrDefault(row => Convert.ToInt32(row["MedicineId"]) == medicineId);

                if (existingRow != null)
                {
                    int newQuantity = Convert.ToInt32(existingRow["Quantity"]) + quantity;
                    existingRow["Quantity"] = newQuantity;
                    existingRow["Total"] = unitPrice * newQuantity;
                }
                else
                {
                    var newRow = cartTable.NewRow();
                    newRow["MedicineId"] = medicineId;
                    newRow["Name"] = name;
                    newRow["UnitPrice"] = unitPrice;
                    newRow["Quantity"] = quantity;
                    newRow["Total"] = unitPrice * quantity;
                    cartTable.Rows.Add(newRow);
                }

                // Refresh the cart display
                dgvCart.Refresh();
                UpdateTotalAmount();
                MessageBox.Show(name + " has been added to cart successfully");
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during adding to cart\n\n" + ex.Message);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.CurrentRow == null)
                {
                    MessageBox.Show("Please select an item to remove.");
                    return;
                }

                var confirmResult = MessageBox.Show("Remove selected item from cart?", "Confirm Remove", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
                    dgvCart.Refresh();
                    UpdateTotalAmount();
                    MessageBox.Show("Item removed from cart.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during removal\n" + ex.Message);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Clear entire cart?", "Confirm Clear Cart", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    cartTable.Clear();
                    dgvCart.Refresh();
                    UpdateTotalAmount();
                    MessageBox.Show("Cart cleared successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during clearing cart\n" + ex.Message);
            }
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToProcessSale()) return;

                float totalAmount = float.Parse(txtTotalAmount.Text);
                var confirmResult = MessageBox.Show(
                    $"Process sale for:\nCustomer: {txtCustomerName.Text}\nTotal: ${totalAmount:F2}\nPayment: {cmbPaymentMethod.Text}?", 
                    "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int saleId = GenerateId("SELECT ISNULL(MAX(SaleId), 0) + 1 FROM Sales");

                    this.Sql = "INSERT INTO Sales (SaleId, SaleDate, SalesmanID, CustomerName, TotalAmount, PaymentMethod) " +
                              "VALUES ('" + saleId + "', " +
                              "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                              "'" + txtSalesmanID.Text + "', " +
                              "'" + txtCustomerName.Text + "', " +
                              "'" + totalAmount.ToString("F2") + "', " +
                              "'" + cmbPaymentMethod.Text + "')";

                    int saleResult = this.Da.ExecuteDMLQuery(this.Sql);

                    if (saleResult == 1)
                    {
                        foreach (DataRow row in cartTable.Rows)
                        {
                            int detailId = GenerateId("SELECT ISNULL(MAX(SaleDetailID), 0) + 1 FROM SalesDetails");
                            int medicineId = Convert.ToInt32(row["MedicineId"]);
                            int quantity = Convert.ToInt32(row["Quantity"]);

                            this.Sql = "INSERT INTO SalesDetails (SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal) " +
                                      "VALUES ('" + detailId + "', " +
                                      "'" + saleId + "', " +
                                      "'" + medicineId + "', " +
                                      "'" + quantity + ", " +
                                      "'" + ((float)row["UnitPrice"]).ToString("F2") + "', " +
                                      "'" + ((float)row["Total"]).ToString("F2") + "')";
                            
                            this.Da.ExecuteDMLQuery(this.Sql);

                            this.Sql = "UPDATE Medicine SET UnitAvailable = UnitAvailable - " + quantity + 
                                      " WHERE MedicineId = " + medicineId;
                            this.Da.ExecuteDMLQuery(this.Sql);
                        }

                        MessageBox.Show("Sale has been processed successfully!");
                        cartTable.Clear();
                        UpdateTotalAmount();
                        txtCustomerName.Text = "Walk-in Customer";
                        if (cmbPaymentMethod.Items.Count > 0)
                            cmbPaymentMethod.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Sale processing failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during sale processing\n\n" + ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateMedicineGrid();
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error showing all records: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormSalesman salesmanForm = new FormSalesman();
                salesmanForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error going back: " + ex.Message);
            }
        }

        private void dgvMedicineList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMedicineList.CurrentRow != null)
            {
                try
                {
                    this.txtMedID.Text = dgvMedicineList.CurrentRow.Cells["medicineId"].Value?.ToString();
                    this.txtName.Text = dgvMedicineList.CurrentRow.Cells["name"].Value?.ToString();
                    this.cmbCatagory.Text = dgvMedicineList.CurrentRow.Cells["category"].Value?.ToString();
                    this.txtUnitPrice.Text = dgvMedicineList.CurrentRow.Cells["unitprice"].Value?.ToString();
                    this.txtQuantity.Text = "1";

                    string unitAvailable = dgvMedicineList.CurrentRow.Cells["unitavailable"].Value?.ToString();
                    if (!string.IsNullOrEmpty(unitAvailable))
                    {
                        int available = Convert.ToInt32(unitAvailable);
                        if (available <= 0)
                        {
                            MessageBox.Show("This medicine is out of stock (0 units available).");
                        }
                        else if (available <= 5)
                        {
                            MessageBox.Show($"Low stock warning: Only {available} units available.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medicine details: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.PopulateMedicineGrid();
                    return;
                }

                this.Sql = "SELECT * FROM Medicine WHERE " +
                          "Name LIKE '" + txtSearch.Text + "%' OR " +
                          "Category LIKE '" + txtSearch.Text + "%' OR " +
                          "Manufacturer LIKE '" + txtSearch.Text + "%'";
                this.PopulateMedicineGrid(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred during search\n" + exc.Message);
            }
        }
    }
}