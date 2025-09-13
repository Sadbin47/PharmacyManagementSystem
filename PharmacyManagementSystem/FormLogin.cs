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
    public partial class FormLogin : Form
    {
        private DataAccess Da { get; set; }
        
        // Static property to track logged-in user
        public static string LoggedInUserId { get; private set; } = string.Empty;
        
        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter both User ID and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "select userId, password, role from SignIn where userId = '" + this.txtUserId.Text + "' and password = '" + this.txtPassword.Text + "'";
                
                DataTable dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["role"].ToString().ToLower();
                    string userId = dt.Rows[0]["userId"].ToString();
                    
                    // Set the logged-in user ID
                    LoggedInUserId = userId;
                    
                    this.Hide();
                    
                    if (role == "manager")
                    {
                        FormManager managerForm = new FormManager();
                        managerForm.Show();
                    }
                    else if (role == "salesman")
                    {
                        FormSalesman salesmanForm = new FormSalesman();
                        salesmanForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown user role. Please contact administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUserId.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// Clear the logged-in user when logging out
        /// </summary>
        public static void Logout()
        {
            LoggedInUserId = string.Empty;
        }
        
        /// <summary>
        /// Check if a user is currently logged in
        /// </summary>
        public static bool IsUserLoggedIn()
        {
            return !string.IsNullOrEmpty(LoggedInUserId);
        }
    }
}
