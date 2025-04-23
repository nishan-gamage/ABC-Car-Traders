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
    public partial class Vehicle : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Vehicle()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Vehicles";
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
                string query = "INSERT INTO Vehicles (Brand, Model, Color, Price) VALUES (@Brand, @Model, @Color, @Price)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                ClearFields();
                LoadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Vehicles SET Brand = @Brand, Model = @Model, Color = @Color, Price = @Price WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                cmd.Parameters.AddWithValue("@Color", txtColor.Text);
                cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);  // Use the ID to locate the record

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully");

                    ClearFields();  // Clear the text fields after updating
                    LoadData();     // Refresh the DataGridView
                }
                else
                {
                    MessageBox.Show("No record found with the given ID.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM Vehicles WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                ClearFields();
                LoadData();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Vehicles WHERE Brand LIKE @SearchText OR Model LIKE @SearchText OR Color LIKE @SearchText";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchText", "%" + txtSearch.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Vehicles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                txtID.Text = row.Cells["ID"].Value.ToString();
                txtBrand.Text = row.Cells["Brand"].Value.ToString();
                txtModel.Text = row.Cells["Model"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();


            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard DashboardForm = new Dashboard();
            DashboardForm.Show();
            this.Hide();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            Parts PartForm = new Parts();
            PartForm.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers CustomerForm = new Customers();
            CustomerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders OrderForm = new Orders();
            OrderForm.Show();
            this.Hide();
        }
    }
}
