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
    public partial class Orders : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Orders()
        {
            InitializeComponent();
        }

        private void User_Vehicle_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void ClearFields()
        {
            txtOrder_Id.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtQuantity.Clear();
        }

        private void Orders_Load(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Orders ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchText", "%" + txtSearch.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Orders (CustomerName, Address, PhoneNumber, Quantity) VALUES (@CustomerName, @Address, @PhoneNumber, @Quantity)", con);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Inserted Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView();  // Refresh the DataGridView
                ClearFields(); // Clear text boxes after insertion
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Orders SET CustomerName = @CustomerName, Address = @Address, PhoneNumber = @PhoneNumber, Quantity = @Quantity WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", txtOrder_Id.Text);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Updated Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView();  // Refresh the DataGridView
                ClearFields(); // Clear text boxes after update
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE ID = @ID", con);
                cmd.Parameters.AddWithValue("@ID", txtOrder_Id.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Deleted Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataGridView();  // Refresh the DataGridView
                ClearFields(); // Clear text boxes after deletion
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtOrder_Id.Text = row.Cells["ID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
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

        private void txtParts_Click(object sender, EventArgs e)
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

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}
