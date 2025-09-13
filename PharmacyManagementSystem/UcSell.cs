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
        private DataTable cartDataTable;
        private List<CartItem> cartItems;

        public UcSell()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                this.InitializeCart();
                this.PopulateMedicineGrid();
                this.PopulateCartGrid();
                this.ClearForm();
                this.AutoCaptureSalesmanID();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Auto Capture Salesman ID
        private void AutoCaptureSalesmanID()
        {
            try
            {
                if (FormLogin.IsUserLoggedIn() && !string.IsNullOrEmpty(FormLogin.LoggedInUserId))
                {
                    txtSalesmanID.Text = FormLogin.LoggedInUserId;
                }
                else
                {
                    txtSalesmanID.Text = "1"; // Default fallback
                }
                
                // Set default customer name
                txtCustomerName.Text = "Walk-in Customer";
                
                // Set default payment method
                if (cmbPaymentMethod.Items.Count > 0)
                {
                    cmbPaymentMethod.SelectedIndex = 0; // Default to CASH
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting salesman ID: {ex.Message}", "Auto-Capture Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalesmanID.Text = "1"; // Default fallback
            }
        }
        #endregion

        #region Cart Item Class
        public class CartItem
        {
            public int MedicineId { get; set; }
            public string Name { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal Total => UnitPrice * Quantity;
        }
        #endregion

        #region Cart Management
        private void InitializeCart()
        {
            try
            {
                cartItems = new List<CartItem>();
                
                // Create DataTable for cart
                cartDataTable = new DataTable();
                cartDataTable.Columns.Add("MedicineId", typeof(int));
                cartDataTable.Columns.Add("Name", typeof(string));
                cartDataTable.Columns.Add("UnitPrice", typeof(decimal));
                cartDataTable.Columns.Add("Quantity", typeof(int));
                cartDataTable.Columns.Add("Total", typeof(decimal));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing cart: {ex.Message}", "Cart Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToCart(int medicineId, string name, decimal unitPrice, int quantity)
        {
            try
            {
                // Check if item already exists in cart
                var existingItem = cartItems.FirstOrDefault(item => item.MedicineId == medicineId);
                
                if (existingItem != null)
                {
                    // Update existing item quantity
                    existingItem.Quantity += quantity;
                }
                else
                {
                    // Add new item to cart
                    cartItems.Add(new CartItem
                    {
                        MedicineId = medicineId,
                        Name = name,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    });
                }
                
                RefreshCartDisplay();
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item to cart: {ex.Message}", "Cart Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCartDisplay()
        {
            try
            {
                cartDataTable.Clear();
                
                foreach (var item in cartItems)
                {
                    cartDataTable.Rows.Add(
                        item.MedicineId,
                        item.Name,
                        item.UnitPrice,
                        item.Quantity,
                        item.Total
                    );
                }
                
                // Ensure DataGridView is properly bound
                if (dgvCart.DataSource == null)
                {
                    dgvCart.AutoGenerateColumns = false;
                    dgvCart.DataSource = cartDataTable;
                    
                    // Set up column bindings
                    if (dgvCart.Columns["cartMedicineId"] != null)
                        dgvCart.Columns["cartMedicineId"].DataPropertyName = "MedicineId";
                    if (dgvCart.Columns["cartName"] != null)
                        dgvCart.Columns["cartName"].DataPropertyName = "Name";
                    if (dgvCart.Columns["cartUnitPrice"] != null)
                        dgvCart.Columns["cartUnitPrice"].DataPropertyName = "UnitPrice";
                    if (dgvCart.Columns["cartQuantity"] != null)
                        dgvCart.Columns["cartQuantity"].DataPropertyName = "Quantity";
                    if (dgvCart.Columns["cartTotal"] != null)
                        dgvCart.Columns["cartTotal"].DataPropertyName = "Total";
                }
                
                dgvCart.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing cart display: {ex.Message}", "Display Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Data Display Methods
        private void PopulateMedicineGrid(string sql = "SELECT * FROM Medicine")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvMedicineList.AutoGenerateColumns = false;
                this.dgvMedicineList.DataSource = ds.Tables[0];
                
                this.lblSubTitle.Text = $"Available Medicines: {ds.Tables[0].Rows.Count} • Last Updated: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine data: {ex.Message}", "Data Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateCartGrid()
        {
            try
            {
                // Set up the cart DataGridView properly
                this.dgvCart.AutoGenerateColumns = false;
                this.dgvCart.DataSource = cartDataTable;
                
                // Bind columns properly to DataTable columns
                if (dgvCart.Columns["cartMedicineId"] != null)
                    dgvCart.Columns["cartMedicineId"].DataPropertyName = "MedicineId";
                if (dgvCart.Columns["cartName"] != null)
                    dgvCart.Columns["cartName"].DataPropertyName = "Name";
                if (dgvCart.Columns["cartUnitPrice"] != null)
                    dgvCart.Columns["cartUnitPrice"].DataPropertyName = "UnitPrice";
                if (dgvCart.Columns["cartQuantity"] != null)
                    dgvCart.Columns["cartQuantity"].DataPropertyName = "Quantity";
                if (dgvCart.Columns["cartTotal"] != null)
                    dgvCart.Columns["cartTotal"].DataPropertyName = "Total";
                
                this.UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing cart: {ex.Message}", "Cart Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalAmount()
        {
            try
            {
                decimal total = cartItems.Sum(item => item.Total);
                txtTotalAmount.Text = total.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}", "Calculation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Button Event Handlers
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.PopulateMedicineGrid();
                this.txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all records: {ex.Message}", "Display Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToAdd())
                {
                    return;
                }

                int medicineId = int.Parse(txtMedID.Text);
                string name = txtName.Text;
                decimal unitPrice = decimal.Parse(txtUnitPrice.Text);
                int quantity = int.Parse(txtQuantity.Text);

                AddToCart(medicineId, name, unitPrice, quantity);

                MessageBox.Show($"Added {name} (Qty: {quantity}) to cart.", 
                    "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Add Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an item to remove.", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Remove selected item from cart?", "Confirm Remove", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var selectedRow = dgvCart.SelectedRows[0];
                    int medicineId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    
                    // Remove from cart items list
                    var itemToRemove = cartItems.FirstOrDefault(item => item.MedicineId == medicineId);
                    if (itemToRemove != null)
                    {
                        cartItems.Remove(itemToRemove);
                        RefreshCartDisplay();
                        UpdateTotalAmount();
                        
                        MessageBox.Show("Item removed from cart.", "Item Removed", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing from cart: {ex.Message}", "Remove Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cartItems.Clear();
                    RefreshCartDisplay();
                    UpdateTotalAmount();
                    
                    MessageBox.Show("Cart cleared successfully.", "Cart Cleared", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing cart: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (cartItems.Count == 0)
                {
                    MessageBox.Show("Cart is empty. Please add items before processing sale.", "Empty Cart", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || 
                    string.IsNullOrWhiteSpace(txtSalesmanID.Text) ||
                    cmbPaymentMethod.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all sale information (Customer Name, Salesman ID, Payment Method).", 
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalAmount = cartItems.Sum(item => item.Total);
                string customerName = txtCustomerName.Text.Trim();
                string salesmanId = txtSalesmanID.Text.Trim(); // Fix: Use string for salesmanId
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

                var confirmResult = MessageBox.Show(
                    $"Process sale for:\nCustomer: {customerName}\nTotal: ${totalAmount:F2}\nPayment: {paymentMethod}?", 
                    "Confirm Sale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    if (ProcessSaleTransaction(salesmanId, customerName, totalAmount, paymentMethod))
                    {
                        MessageBox.Show("Sale processed successfully!", "Sale Complete", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        // Clear cart and form after successful sale
                        cartItems.Clear();
                        RefreshCartDisplay();
                        UpdateTotalAmount();
                        ClearSaleForm();
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Data format error: {ex.Message}\nPlease check all numeric fields.", "Format Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing sale: {ex.Message}", "Sale Processing Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // Find the parent form and remove this user control
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Controls.Remove(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error going back: {ex.Message}", "Navigation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Sale Processing
        private bool ProcessSaleTransaction(string salesmanId, string customerName, decimal totalAmount, string paymentMethod)
        {
            try
            {
                // Generate sale ID
                int saleId = GenerateSaleId();
                DateTime saleDate = DateTime.Now;

                // Escape single quotes in strings to prevent SQL injection
                string safeSalesmanId = salesmanId.Replace("'", "''");
                string safeCustomerName = customerName.Replace("'", "''");
                string safePaymentMethod = paymentMethod.Replace("'", "''");
                string safeTotalAmount = totalAmount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

                // Insert into Sales table - Note: SalesmanID now treated as string
                string salesSql = $@"INSERT INTO Sales (SaleId, SaleDate, SalesmanID, CustomerName, TotalAmount, PaymentMethod) 
                                   VALUES ({saleId}, '{saleDate:yyyy-MM-dd HH:mm:ss}', '{safeSalesmanId}', '{safeCustomerName}', {safeTotalAmount}, '{safePaymentMethod}')";

                int salesResult = this.Da.ExecuteDMLQuery(salesSql);

                if (salesResult > 0)
                {
                    // Insert sale details for each cart item
                    bool allDetailsInserted = true;
                    
                    foreach (var item in cartItems)
                    {
                        int saleDetailId = GenerateSaleDetailId();
                        
                        // Convert values to safe strings
                        string safeMedicineId = item.MedicineId.ToString();
                        string safeQuantity = item.Quantity.ToString();
                        string safeUnitPrice = item.UnitPrice.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                        string safeSubtotal = item.Total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                        
                        // Fixed: Use correct table name 'SalesDetails' and column name 'SaleDetailID'
                        string detailSql = $@"INSERT INTO SalesDetails (SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal) 
                                            VALUES ({saleDetailId}, {saleId}, {safeMedicineId}, {safeQuantity}, {safeUnitPrice}, {safeSubtotal})";
                        
                        int detailResult = this.Da.ExecuteDMLQuery(detailSql);
                        if (detailResult <= 0)
                        {
                            allDetailsInserted = false;
                            break;
                        }
                    }

                    if (!allDetailsInserted)
                    {
                        MessageBox.Show("Error inserting sale details. Please contact system administrator.", 
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Error processing sale. Please try again.", "Sale Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Data format error in sale processing: {ex.Message}", "Format Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error during sale processing: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                    txtQuantity.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected record: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var searchTerm = txtSearch.Text.Trim();
                var sql = $@"SELECT * FROM Medicine WHERE 
                           Name LIKE '%{searchTerm}%' OR 
                           Category LIKE '%{searchTerm}%' OR 
                           CAST(MedicineId AS NVARCHAR) LIKE '%{searchTerm}%'";

                this.PopulateMedicineGrid(sql);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        private void ClearForm()
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
                MessageBox.Show($"Error clearing form: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearSaleForm()
        {
            try
            {
                txtCustomerName.Text = "Walk-in Customer";
                // Don't clear salesman ID as it's auto-captured
                if (cmbPaymentMethod.Items.Count > 0)
                {
                    cmbPaymentMethod.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing sale form: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Please select a medicine and enter quantity.", "Missing Information", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity greater than 0.", "Invalid Quantity", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price <= 0)
                {
                    MessageBox.Show("Please select a valid medicine with a valid price.", "Invalid Price", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!int.TryParse(txtMedID.Text, out int medicineId) || medicineId <= 0)
                {
                    MessageBox.Show("Please select a valid medicine.", "Invalid Medicine", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
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

        private int GenerateSaleId()
        {
            try
            {
                var query = "SELECT ISNULL(MAX(SaleId), 0) + 1 FROM Sales";
                var result = this.Da.ExecuteQueryTable(query);
                
                if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
                {
                    if (int.TryParse(result.Rows[0][0].ToString(), out int saleId))
                    {
                        return saleId;
                    }
                }
                
                // Fallback to timestamp-based ID if database query fails
                return DateTime.Now.Millisecond + new Random().Next(1000, 9999);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error generating Sale ID: {ex.Message}");
                return DateTime.Now.Millisecond + new Random().Next(1000, 9999);
            }
        }

        private int GenerateSaleDetailId()
        {
            try
            {
                // Fixed: Use correct table name 'SalesDetails' and column name 'SaleDetailID'
                var query = "SELECT ISNULL(MAX(SaleDetailID), 0) + 1 FROM SalesDetails";
                var result = this.Da.ExecuteQueryTable(query);
                
                if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
                {
                    if (int.TryParse(result.Rows[0][0].ToString(), out int saleDetailId))
                    {
                        return saleDetailId;
                    }
                }
                
                // Fallback to timestamp-based ID if database query fails
                return DateTime.Now.Millisecond + new Random().Next(10000, 99999);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error generating Sale Detail ID: {ex.Message}");
                return DateTime.Now.Millisecond + new Random().Next(10000, 99999);
            }
        }
        #endregion
    }
}
