using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Sale
{
    public partial class User_Register : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";
        public User_Register()
        {
            InitializeComponent();
        }

        private void User_Register_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Name, Email, Password) VALUES (@Username, @Email, @Password)", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

            this.Hide();
            UserLogin loginForm = new UserLogin();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
