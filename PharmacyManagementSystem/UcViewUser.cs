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
        public UcViewUser()
        {
            InitializeComponent();
        }

        public void LoadUserData(DataAccess da)
        {
            try
            {
                string sql = "select * from SignIn;";
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0)
                {
                    dgvUsers.DataSource = ds.Tables[0];
                    dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
