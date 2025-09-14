using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagementSystem
{
    public partial class UcsalesInfo : UserControl
    {
        public UcsalesInfo()
        {
            InitializeComponent();
        }

        private void UcsalesInfo_Load(object sender, EventArgs e)
        {
            LoadSalesInfo();
        }

        private void LoadSalesInfo()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-6KO70LE\MYSERVER;Initial Catalog=C# PROJECT;User ID=sa;Password=Tahsin164";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT SaleDetailID, SaleID, MedicineID, Quantity, UnitPrice, Subtotal FROM SalesDetails";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    con.Open();
                    MessageBox.Show("Connected!");
                    con.Close();

                    adapter.Fill(dt);
                    MessageBox.Show("Rows fetched: " + dt.Rows.Count); // debug

                    // ✅ Fix: clear any designer-generated columns
                    dgvSalesInfo.Columns.Clear();
                    dgvSalesInfo.AutoGenerateColumns = false;

                    // Bind DataTable
                    dgvSalesInfo.DataSource = dt;

                    // ✅ Add columns manually with nice headers
                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Sale Detail ID",
                        DataPropertyName = "SaleDetailID",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Sale ID",
                        DataPropertyName = "SaleID",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Medicine ID",
                        DataPropertyName = "MedicineID",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Quantity",
                        DataPropertyName = "Quantity",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Unit Price",
                        DataPropertyName = "UnitPrice",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });

                    dgvSalesInfo.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Subtotal",
                        DataPropertyName = "Subtotal",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales info: " + ex.Message);
            }
        }
    }
}
