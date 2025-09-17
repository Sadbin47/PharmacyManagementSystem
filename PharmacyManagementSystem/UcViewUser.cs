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
               
                this.btnShowALL.Click += btnShowALL_Click;
                this.btnDelete.Click += btnDelete_Click;
                this.btnSave.Click += btnSave_Click;
                this.dgvUsers.DoubleClick += dgvUsers_DoubleClick;
                this.tbSearch.TextChanged += tbSearch_TextChanged;
                this.Load += UcViewUser_Load;
                
                
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
                
                dgvUsers.Columns["UserId"].DataPropertyName = "UserId";
                dgvUsers.Columns["UserName"].DataPropertyName = "UserName";
                dgvUsers.Columns["Password"].DataPropertyName = "Password";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Setup Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Data Display Methods
        private void PopulateGridView(string sql = "SELECT UserId, UserName, Password FROM Users")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                this.dgvUsers.AutoGenerateColumns = false;
                this.dgvUsers.DataSource = ds.Tables[0];
                
                
                this.lblTitle.Text = $"💊 View User ({ds.Tables[0].Rows.Count} Users)";
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
                    var sql = $"DELETE FROM Users WHERE UserId = '{userId.Replace("'", "''")}'";
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

                
                string userId = txtUserId.Text.Trim().Replace("'", "''");
                string userName = txtUserName.Text.Trim().Replace("'", "''");
                string password = txtPassword.Text.Trim().Replace("'", "''");
                

               
                var checkQuery = $"SELECT COUNT(*) FROM Users WHERE UserId = '{userId}'";
                var checkResult = this.Da.ExecuteQueryTable(checkQuery);
                int count = Convert.ToInt32(checkResult.Rows[0][0]);

                string sql;
                string operation;

                if (count > 0)
                {
                    
                    sql = $@"UPDATE Users SET 
                            UserName = '{userName}',
                            Password = '{password}',
                        
                            WHERE UserId = '{userId}'";
                    operation = "updated";
                }
                else
                {
                    
                    sql = $@"INSERT INTO Users (UserId, UserName, Password)
                            VALUES ('{userId}', '{userName}', '{password}')";
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
                    
                  
                    txtUserId.Text = selectedRow.Cells["UserId"].Value?.ToString() ?? "";
                    txtUserName.Text = selectedRow.Cells["UserName"].Value?.ToString() ?? "";
                    txtPassword.Text = selectedRow.Cells["Password"].Value?.ToString() ?? "";
                    
                    
                    
                    
                    
                    this.btnSave.Visible = true;
                    
                    
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
                
                if (string.IsNullOrWhiteSpace(tbSearch.Text))
                {
                    this.PopulateGridView(); 
                    return;
                }

                var searchTerm = tbSearch.Text.Trim().Replace("'", "''"); 
                var sql = $@"SELECT UserId, UserName, Password FROM Users WHERE 
                           UserName LIKE '%{searchTerm}%' OR                
                           UserId LIKE '%{searchTerm}%'";

                this.PopulateGridView(sql);
            }
            catch (Exception ex)
            {
                
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }
        #endregion

        #region Utility Methods
        private void ClearAll()
        {
            try
            {
                
                txtUserId.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                
                
                if (this.ActiveControl != tbSearch)
                {
                    tbSearch.Clear();
                }
                
                
                dgvUsers.ClearSelection();
                
                
                this.btnSave.Visible = false;
                
                
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

                if (string.IsNullOrWhiteSpace(txtUserId.Text) ||
                    string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) )
                    
                {
                    return false;
                }

                
                if (txtUserId.Text.Trim().Length < 2)
                {
                    MessageBox.Show("User ID must be at least 2 characters long.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserId.Focus();
                    return false;
                }

               
                if (txtUserName.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username must be at least 3 characters long.", "Validation Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return false;
                }

                
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
        
        public void LoadSignInData()
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            tbSearch_TextChanged(sender, e);
        }
        #endregion
    }
}