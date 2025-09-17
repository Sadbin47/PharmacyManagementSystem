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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UcSignUp signUp = new UcSignUp();
            LoadUserControl(signUp);
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            UcViewUser viewUser = new UcViewUser();
            
            LoadUserControl(viewUser);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalesInfo_Click(object sender, EventArgs e)
        {
            UcsalesInfo salesInfo = new UcsalesInfo();
            LoadUserControl(salesInfo);
        }

        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManagerLogout_Click(object sender, EventArgs e)
        {
            FormLogin.Logout();
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
