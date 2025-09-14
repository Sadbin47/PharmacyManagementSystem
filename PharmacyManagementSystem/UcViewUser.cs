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
    public partial class UcViewUser : UserControl
    {
        private DataAccess Da { get; set; }

        public UcViewUser()
        {
            InitializeComponent();
            try
            {
                this.Da = new DataAccess();
                this.SetupDataGridView();
                this.InitializeEvents();
                this.ClearAll();
                // Auto-load users on startup as requested
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Form Load and Initialization
        private void InitializeEvents()
        {
            try
            {
                // Wire up event handlers
                this.btnShowALL.Click += btnShowALL_Click;
                this.btnDelete.Click += btnDelete_Click;
                this.btnSave.Click += btnSave_Click;
                this.dgvUsers.DoubleClick += dgvUsers_DoubleClick;
                this.tbSearch.TextChanged += tbSearch_TextChanged;
                this.Load += UcViewUser_Load;
                
                // Initially hide the save button - only show when editing
                this.btnSave.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing events: {ex.Message}", "Event Initialization Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UcViewUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvUsers.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                // Map DataGridView columns to database columns
                dgvUsers.Columns["UserId"].DataPropertyName = "UserId";
                dgvUsers.Columns["UserName"].DataPropertyName = "UserName";
                dgvUsers.Columns["Password"].DataPropertyName = "Password";
                dgvUsers.Columns["Role"].DataPropertyName = "Role";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Setup Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Data Display Methods
        private void PopulateGridView(string sql = "SELECT UserId, UserName, Password, Role FROM SignIn")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvUsers.AutoGenerateColumns = false;
                this.dgvUsers.DataSource = ds.Tables[0];
                
                // Update status in title
                this.lblTitle.Text = $"💊 View User ({ds.Tables[0].Rows.Count} users)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Data Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Button Event Handlers
        private void btnShowALL_Click(object sender, EventArgs e)
        {
            try
            {
                // Show all users and clear search/form
                this.PopulateGridView();
                this.tbSearch.Clear();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all records: {ex.Message}", "Display Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a user to delete.", "Selection Required", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvUsers.SelectedRows[0];
                var userId = selectedRow.Cells["UserId"].Value.ToString();
                var userName = selectedRow.Cells["UserName"].Value.ToString();

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete user '{userName}' (ID: {userId})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var sql = $"DELETE FROM SignIn WHERE UserId = '{userId.Replace("'", "''")}'";
                    int result = this.Da.ExecuteDMLQuery(sql);

                    if (result > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.PopulateGridView();
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Delete Failed", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Delete Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToSave())
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sanitize inputs to prevent SQL injection
                string userId = txtUserId.Text.Trim().Replace("'", "''");
                string userName = txtUserName.Text.Trim().Replace("'", "''");
                string password = txtPassword.Text.Trim().Replace("'", "''");
                string role = cmbUserSelect.Text.Replace("'", "''");

                // Check if user ID already exists
                var checkQuery = $"SELECT COUNT(*) FROM SignIn WHERE UserId = '{userId}'";
                var checkResult = this.Da.ExecuteQueryTable(checkQuery);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                string sql;
                string operation;

                if (count > 0)
                {
                    // Update existing record
                    sql = $@"UPDATE SignIn SET 
                            UserName = '{userName}',
                            Password = '{password}',
                            Role = '{role}'
                            WHERE UserId = '{userId}'";
                    operation = "updated";
                }
                else
                {
                    // Insert new record
                    sql = $@"INSERT INTO SignIn (UserId, UserName, Password, Role)
                            VALUES ('{userId}', '{userName}', '{password}', '{role}')";
                    operation = "added";
                }

                int result = this.Da.ExecuteDMLQuery(sql);
                if (result > 0)
                {
                    MessageBox.Show($"User {operation} successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.PopulateGridView();
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show($"Failed to {operation.Replace("ed", "")} user.", "Operation Failed", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Save Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Handlers
        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvUsers.SelectedRows[0];
                    
                    // Load data into form controls for editing
                    txtUserId.Text = selectedRow.Cells["UserId"].Value?.ToString() ?? "";
                    txtUserName.Text = selectedRow.Cells["UserName"].Value?.ToString() ?? "";
                    txtPassword.Text = selectedRow.Cells["Password"].Value?.ToString() ?? "";
                    
                    // Set role in combobox
                    string role = selectedRow.Cells["Role"].Value?.ToString() ?? "";
                    if (cmbUserSelect.Items.Contains(role))
                    {
                        cmbUserSelect.Text = role;
                    }
                    
                    // Show save button when editing
                    this.btnSave.Visible = true;
                    
                    // Focus on first editable field
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading selected record: {ex.Message}", "Load Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Automatic search functionality as requested
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    this.PopulateGridView(); // Show all if search is empty
                    return;
                }

                var searchTerm = tbSearch.Text.Trim().Replace("'", "''"); // Prevent SQL injection
                var sql = $@"SELECT UserId, UserName, Password, Role FROM SignIn WHERE 
                           UserName LIKE '%{searchTerm}%' OR 
                           Role LIKE '%{searchTerm}%' OR
                           UserId LIKE '%{searchTerm}%'";

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
                // Clear all form fields
                txtUserId.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                
                // Don't clear search box when called from other buttons
                if (this.ActiveControl != tbSearch)
                {
                    tbSearch.Clear();
                }
                
                cmbUserSelect.SelectedIndex = -1;
                dgvUsers.ClearSelection();
                
                // Hide save button when clearing
                this.btnSave.Visible = false;
                
                // Focus on first input
                txtUserId.Focus();
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
                if (string.IsNullOrWhiteSpace(txtUserId.Text) ||
                    string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbUserSelect.SelectedIndex == -1)
                {
                    return false;
                }

                // Validate User ID
                if (txtUserId.Text.Trim().Length < 2)
                {
                    MessageBox.Show("User ID must be at least 2 characters long.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserId.Focus();
                    return false;
                }

                // Validate Username
                if (txtUserName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username must be at least 3 characters long.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return false;
                }

                // Validate Password
                if (txtPassword.Text.Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
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
        #endregion

        #region Legacy Methods (kept for compatibility)
        // Keep the old method name for any external references
        public void LoadSignInData()
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // This method is now handled by tbSearch_TextChanged for real-time search
            // But keep it for any existing button references
            tbSearch_TextChanged(sender, e);
        }
        #endregion
    }
}