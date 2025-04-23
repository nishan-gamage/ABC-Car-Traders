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
    public partial class Parts : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Parts()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Parts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Parts WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
                ClearFields();
                LoadData();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Parts (Brand, Model, Color, Price) VALUES (@Brand, @Model, @Color, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
                ClearFields();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Parts SET Brand = @Brand, Model = @Model, Color = @Color, Price = @Price WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Updated Successfully");

                    ClearFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Parts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming you have text fields named txtID, txtBrand, txtModel, txtColor, and txtPrice
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Parts WHERE Brand LIKE @SearchText OR Model LIKE @SearchText OR Color LIKE @SearchText";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchText", "%" + txtSearch.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers CustomerForm = new Customers();
            CustomerForm.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders OrderForm = new   Orders();
            OrderForm.Show();
            this.Hide();
        }
    }
}
