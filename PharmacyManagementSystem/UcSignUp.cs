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
            this.txtEmail.Leave += txtEmail_Leave;
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

                // Check if username already exists
                if (IsUsernameExists(txtUserName.Text.Trim()))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", 
                        "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }

                // Check if email already exists
                if (IsEmailExists(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email already exists. Please use a different email address.", 
                        "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Generate new User ID
                int newUserId = GenerateNewUserId();

                // Create user account
                string sql = $@"INSERT INTO SignIn (UserId, UserName, Password, Role, Email, CreatedDate) 
                               VALUES ({newUserId}, '{txtUserName.Text.Trim()}', '{txtPassword.Text}', 
                                      '{cmbUserSelect.Text}', '{txtEmail.Text.Trim()}', '{DateTime.Now:yyyy-MM-dd HH:mm:ss}')";

                int result = this.Da.ExecuteDMLQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show($"Account created successfully!\nUser ID: {newUserId}\nUsername: {txtUserName.Text}\nRole: {cmbUserSelect.Text}", 
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
                MessageBox.Show($"Error creating account: {ex.Message}", 
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
            if (cmbUserSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an account type.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUserSelect.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter an email address.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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

            // Validate individual fields
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidUsername(txtUserName.Text.Trim()))
            {
                MessageBox.Show("Username must be 3-20 characters long and contain only letters, numbers, and underscores.", 
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }

            if (!IsValidPassword(txtPassword.Text))
            {
                MessageBox.Show("Password must be at least 6 characters long and contain at least one letter and one number.", 
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

        private bool IsValidEmail(string email)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 20)
                return false;

            string pattern = @"^[a-zA-Z0-9_]+$";
            return Regex.IsMatch(username, pattern);
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 6)
                return false;

            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);

            return hasLetter && hasDigit;
        }
        #endregion

        #region Real-time Validation Event Handlers
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text.Trim()))
                {
                    txtEmail.BackColor = Color.FromArgb(60, 30, 30);
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtEmail.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                if (!IsValidUsername(txtUserName.Text.Trim()))
                {
                    txtUserName.BackColor = Color.FromArgb(60, 30, 30);
                    MessageBox.Show("Username must be 3-20 characters long and contain only letters, numbers, and underscores.", 
                        "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!IsValidPassword(txtPassword.Text))
                {
                    txtPassword.BackColor = Color.FromArgb(60, 30, 30);
                    MessageBox.Show("Password must be at least 6 characters long and contain at least one letter and one number.", 
                        "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Passwords do not match.", "Password Mismatch", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }
        #endregion

        #region Database Helper Methods
        private bool IsUsernameExists(string username)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM SignIn WHERE UserName = '{username}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Assume it exists to prevent duplicate creation
            }
        }

        private bool IsEmailExists(string email)
        {
            try
            {
                string sql = $"SELECT COUNT(*) FROM SignIn WHERE Email = '{email}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Assume it exists to prevent duplicate creation
            }
        }

        private int GenerateNewUserId()
        {
            try
            {
                string sql = "SELECT MAX(UserId) FROM SignIn";
                DataTable dt = this.Da.ExecuteQueryTable(sql);
                
                int newId = 1;
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    newId = Convert.ToInt32(dt.Rows[0][0]) + 1;
                }
                
                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating user ID: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1; // Default fallback
            }
        }
        #endregion

        #region Utility Methods
        private void ClearAll()
        {
            try
            {
                cmbUserSelect.SelectedIndex = 0; // Default to first option
                txtEmail.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                // Reset background colors
                txtEmail.BackColor = Color.FromArgb(30, 30, 30);
                txtUserName.BackColor = Color.FromArgb(30, 30, 30);
                txtPassword.BackColor = Color.FromArgb(30, 30, 30);
                txtConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);

                // Focus on first field
                cmbUserSelect.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing form: {ex.Message}", "Clear Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
