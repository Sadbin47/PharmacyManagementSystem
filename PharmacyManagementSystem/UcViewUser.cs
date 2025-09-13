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
            this.Da = new DataAccess();

           
            this.btnShow.Click += btnShow_Click;
            this.btnSearch.Click += btnSearch_Click;

            this.PopulateUserGridView(); 
        }

        // Show all users
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateUserGridView();
            this.tbSearch.Clear();
        }

        // Search users by text
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var searchTerm = tbSearch.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Search Input Required",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sql = $@"SELECT * FROM SignIn WHERE 
                        UserName LIKE '%{searchTerm}%' OR
                        Role LIKE '%{searchTerm}%' OR
                        Password LIKE '%{searchTerm}%' OR
                        CAST(UserId AS NVARCHAR) LIKE '%{searchTerm}%'";

                var ds = this.Da.ExecuteQuery(sql);
                dgvUsers.AutoGenerateColumns = false; 
                dgvUsers.DataSource = ds.Tables[0];
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show($"No users found matching '{searchTerm}'.", "No Results",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error performing search: {ex.Message}", "Search Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Utility: Populate all users
        private void PopulateUserGridView(string sql = "SELECT * FROM SignIn")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);
                dgvUsers.AutoGenerateColumns = false; 
                dgvUsers.DataSource = ds.Tables[0];
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Data Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}