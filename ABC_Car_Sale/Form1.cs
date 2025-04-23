using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Sale
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();


                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateLogin(string username, string password)
        {
            bool isValid = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM tbl_login WHERE username=@username AND password=@password", con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isValid = count == 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
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

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password visibility based on the checkbox state
            txtPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserLogin LoginForm = new UserLogin();
            LoginForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
