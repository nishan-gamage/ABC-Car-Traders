using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Sale
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DashboardForm = new Dashboard();
            DashboardForm.Show();
            this.Hide();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicle VehicleForm = new Vehicle();
            VehicleForm.Show();
            this.Hide();
        }

        private void txtParts_Click(object sender, EventArgs e)
        {
            Parts PartForm = new Parts();
            PartForm.Show();
            this.Hide();
        }

        private void txtOrders_Click(object sender, EventArgs e)
        {
            Orders OrderForm = new Orders();
            OrderForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
