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
    public partial class UcSignUp : UserControl
    {
        private DataAccess Da { get; set; }
        private string NewUserId { get; set; }
        private string NewRoleId { get; set; }

        public UcSignUp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            GenerateUserID();
            GenerateRoleID();
            this.ClearAll();
        }

        #region ID Generation Methods
        private void GenerateUserID()
        {
            try
            {
                string sql = "SELECT UserId FROM Users ORDER BY UserId DESC";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                
                if (dt.Rows.Count > 0)
                {
                    string lastUserId = dt.Rows[0]["UserId"].ToString();
                    string[] parts = lastUserId.Split('-');
                    int number = Convert.ToInt32(parts[1]);
                    this.NewUserId = "p-" + (++number).ToString("D2");
                }
                else
                {
                    this.NewUserId = "p-01";
                }
                
                this.txtUserId.Text = this.NewUserId;
            }
            catch (Exception)
            {
                this.NewUserId = "p-01";
                this.txtUserId.Text = this.NewUserId;
            }
        }

        private void GenerateRoleID()
        {
            try
            {
                string sql = "SELECT RoleId FROM Role ORDER BY RoleId DESC";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                
                if (dt.Rows.Count > 0)
                {
                    string lastRoleId = dt.Rows[0]["RoleId"].ToString();
                    string[] parts = lastRoleId.Split('-');
                    int number = Convert.ToInt32(parts[1]);
                    this.NewRoleId = "r-" + (++number).ToString("D2");
                }
                else
                {
                    this.NewRoleId = "r-01";
                }
            }
            catch (Exception)
            {
                this.NewRoleId = "r-01";
            }
        }
        #endregion

        #region Button Event Handlers
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAllFields() || IsUsernameExists(txtUserName.Text.Trim()))
                {
                    return;
                }

                string selectedRole = cmbUserSelect.Text.ToLower();
                string userName = txtUserName.Text.Trim();
                string password = txtPassword.Text;

                string roleInsertSql = $"INSERT INTO Role (RoleId, Role) VALUES ('{NewRoleId}', '{selectedRole}')";
                
                string usersSql = $"INSERT INTO Users (UserId, RoleId, UserName, Password) VALUES ('{NewUserId}', '{NewRoleId}', '{userName}', '{password}')";

                if (this.Da.ExecuteDMLQuery(roleInsertSql) > 0 && this.Da.ExecuteDMLQuery(usersSql) > 0)
                {
                    MessageBox.Show($"Account created successfully!\nUser ID: {NewUserId}\nRole ID: {NewRoleId}\nUsername: {userName}\nRole: {selectedRole}", 
                        "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    GenerateUserID();
                    GenerateRoleID();
                    this.ClearAll();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Please try again.", 
                        "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message, 
                    "Account Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        #endregion

        #region Validation Methods
        private bool ValidateAllFields()
        {
            if (cmbUserSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an account type.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!IsValidPassword(txtPassword.Text))
            {
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password.Contains(" "))
            {
                MessageBox.Show("Password cannot contain spaces.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsUsernameExists(string username)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM Users WHERE UserName = '{username}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                int count = Convert.ToInt32(dt.Rows[0][0]);
                
                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", 
                        "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        #endregion

        #region Utility Methods
        private void ClearAll()
        {
            try
            {
                cmbUserSelect.SelectedIndex = 0;
                txtUserName.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing form: " + ex.Message);
            }
        }
        #endregion
    }
}