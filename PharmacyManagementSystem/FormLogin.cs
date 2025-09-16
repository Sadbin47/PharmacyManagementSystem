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

        public static string LoggedInUserId { get; private set; } = string.Empty;

        public FormLogin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT s.UserId, s.Password, r.Role " + "FROM Users s " + "INNER JOIN Role r ON s.RoleId = r.RoleID " + 
                "WHERE s.UserId = '" + this.txtUserId.Text + "' AND s.Password = '" + this.txtPassword.Text + "'";

            DataTable dt = this.Da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Role"].ToString().ToLower();
                string userId = dt.Rows[0]["UserId"].ToString();

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
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUserId.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void Logout()
        {
            LoggedInUserId = string.Empty;
        }

        public static bool IsUserLoggedIn()
        {
            return !string.IsNullOrEmpty(LoggedInUserId);
        }
    }
}
