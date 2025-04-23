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
    public partial class UserDashboard : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public UserDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Vehicle U_VehicleForm = new User_Vehicle();
            U_VehicleForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User_Parts U_PartsForm = new User_Parts();
            U_PartsForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserLogin ULoginForm = new UserLogin();
            ULoginForm.Show();
            this.Hide();
        }
    }
}
