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
    public partial class UserLogin : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public UserLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // SQL query to check if the username and password match
                    string query = "SELECT COUNT(1) FROM Users WHERE Name=@Name AND Password=@Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!");
                        // Redirect to the next form or dashboard page
                        UserDashboard dashboard = new UserDashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                // Show password
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                // Hide password
                txtPassword.UseSystemPasswordChar = false;
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {
            User_Register registerForm = new User_Register();
            registerForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            User_Register registerForm = new User_Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
