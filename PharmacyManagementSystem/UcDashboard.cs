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
    public partial class UcDashboard : UserControl
    {
        private DataAccess Da { get; set; }
        private Timer refreshTimer;

        public UcDashboard()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            this.Da = new DataAccess();
            LoadLiveCounts();
            SetupAutoRefresh();
        }

        private void LoadLiveCounts()
        {
            try
            {
                // Get manager count
                var managersQuery = "SELECT COUNT(*) FROM SignIn WHERE Role = 'manager'";
                var managers = this.Da.ExecuteQueryTable(managersQuery);
                lblManagerCount.Text = managers.Rows[0][0].ToString();

                // Get salesman count
                var salesmenQuery = "SELECT COUNT(*) FROM SignIn WHERE Role = 'salesman'";
                var salesmen = this.Da.ExecuteQueryTable(salesmenQuery);
                lblSalesmanCount.Text = salesmen.Rows[0][0].ToString();

                // Get medicines count
                try
                {
                    var medicinesQuery = "SELECT COUNT(*) FROM Medicine";
                    var medicines = this.Da.ExecuteQueryTable(medicinesQuery);
                    lblMedicineCount.Text = medicines.Rows[0][0].ToString();
                }
                catch
                {
                    lblMedicineCount.Text = "0";
                }
            }
            catch (Exception ex)
            {
                lblManagerCount.Text = "0";
                lblSalesmanCount.Text = "0";
                lblMedicineCount.Text = "0";
                System.Diagnostics.Debug.WriteLine($"Error loading counts: {ex.Message}");
            }
        }

        private void SetupAutoRefresh()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 5000; // Refresh every 5 seconds
            refreshTimer.Tick += (s, e) => LoadLiveCounts();
            refreshTimer.Start();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            refreshTimer?.Stop();
            refreshTimer?.Dispose();
            base.OnHandleDestroyed(e);
        }
    }
}
