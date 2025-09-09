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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private Timer timer;
        private void FormLoading_Load(object sender, EventArgs e)
        {
            timer = new Timer();

            timer.Interval = 200;

            timer.Tick += Timer_Tick;

            pbLoading.Value = 0;
            pbLoading.Maximum = 100;

            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            pbLoading.Value += 5;
            if (pbLoading.Value >= pbLoading.Maximum)
            {
                timer.Stop();
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}
