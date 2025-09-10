using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBCRUDN;

namespace PharmacyManagementSystem
{
    public partial class FormManager : Form
    {
        private DataAccess Da { get; set; }
        public FormManager()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            LoadDashboard();
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnlInfoPlace.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlInfoPlace.Controls.Add(userControl);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            UcDashboard dashboard = new UcDashboard();
            LoadUserControl(dashboard);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UcSignUp addUser = new UcSignUp();
            LoadUserControl(addUser);
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            UcViewUser viewUser = new UcViewUser();
            // Pass the DataAccess instance to load user data
            viewUser.LoadUserData(this.Da);
            LoadUserControl(viewUser);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
