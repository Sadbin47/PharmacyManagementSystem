using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PharmacyManagementSystem
{
    public partial class UcSignUp : UserControl
    {
        private DataAccess Da { get; set; }

        // Database field length constraints
        private const int MAX_USERNAME_LENGTH = 30;
        private const int MAX_USERID_LENGTH = 50;

        public UcSignUp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.InitializeEvents();
            this.ClearAll();
        }

        #region Event Initialization
        private void InitializeEvents()
        {
            this.btnCancel.Click += btnCancel_Click;
            this.txtUserId.Leave += txtUserId_Leave;
            this.txtUserName.Leave += txtUserName_Leave;
            this.txtPassword.Leave += txtPassword_Leave;
            this.txtConfirmPassword.Leave += txtConfirmPassword_Leave;
        }
        #endregion

        #region Button Event Handlers
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAllFields())
                {
                    return;
                }

                // Check if UserId already exists
                if (IsUserIdExists(txtUserId.Text.Trim()))
                {
                    MessageBox.Show("User ID already exists. Please choose a different User ID.", 
                        "User ID Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserId.Focus();
                    return;
                }

                // Check if username already exists
                if (IsUsernameExists(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", 
                        "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                // Create user account
                string sql = string.Format("INSERT INTO SignIn (UserId, UserName, Password, Role) VALUES ('{0}', '{1}', '{2}', '{3}')",
                    txtUserId.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text, cmbUserSelect.Text);

                int result = this.Da.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Account created successfully!\nUser ID: " + txtUserId.Text + "\nUsername: " + txtUserName.Text + "\nRole: " + cmbUserSelect.Text, 
                        "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                MessageBox.Show("Please enter a User ID.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserId.Focus();
                return false;
            }

            if (cmbUserSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an account type.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUserSelect.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please confirm your password.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            // Basic field validation
            if (!IsValidUserId(txtUserId.Text.Trim()))
            {
                MessageBox.Show("User ID must follow the format p-XX (like p-01, p-02, etc.)", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserId.Focus();
                return false;
            }

            if (!IsValidUsername(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Username must be 3-" + MAX_USERNAME_LENGTH + " characters long and contain only letters, numbers, and underscores.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidUserId(string userId)
        {
            if (userId.Length < 4 || userId.Length > MAX_USERID_LENGTH)
                return false;

            // Check if it follows p-XX format (p- followed by at least 2 digits)
            string pattern = @"^p-\d{2,}$";
            return Regex.IsMatch(userId, pattern);
        }

        private bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > MAX_USERNAME_LENGTH)
                return false;

            string pattern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(username, pattern);
        }
        #endregion

        #region Real-time Validation Event Handlers
        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                string userId = txtUserId.Text.Trim();
                if (!IsValidUserId(userId))
                {
                    txtUserId.BackColor = Color.FromArgb(60, 30, 30);
                }
                else
                {
                    txtUserId.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                string username = txtUserName.Text.Trim();
                if (!IsValidUsername(username))
                {
                    txtUserName.BackColor = Color.FromArgb(60, 30, 30);
                }
                else
                {
                    txtUserName.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (txtPassword.Text.Length < 6)
                {
                    txtPassword.BackColor = Color.FromArgb(60, 30, 30);
                }
                else
                {
                    txtPassword.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    txtConfirmPassword.BackColor = Color.FromArgb(60, 30, 30);
                }
                else
                {
                    txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }
        #endregion

        #region Database Helper Methods
        private bool IsUserIdExists(string userId)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM SignIn WHERE UserId = '" + userId + "'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking User ID: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private bool IsUsernameExists(string username)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM SignIn WHERE UserName = '" + username + "'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking username: " + ex.Message, "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtUserId.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                // Reset background colors
                txtUserId.BackColor = Color.FromArgb(30, 30, 30);
                txtUserName.BackColor = Color.FromArgb(30, 30, 30);
                txtPassword.BackColor = Color.FromArgb(30, 30, 30);
                txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);

                txtUserId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing form: " + ex.Message, "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
