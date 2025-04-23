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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Vehicle VehicleForm = new Vehicle();
            VehicleForm.Show();
            this.Hide();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            Parts PartForm = new Parts();
            PartForm.Show();
            this.Hide();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers CustomerForm = new Customers();
            CustomerForm.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders OrderForm = new Orders();
            OrderForm.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Settings SettingsForm = new Settings();
            SettingsForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
