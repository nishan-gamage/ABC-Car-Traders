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
using System.Windows.Forms.VisualStyles;

namespace ABC_Car_Sale
{
    public partial class Customers : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Customers()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void Customers_Load(object sender, EventArgs e)
        {

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Customers (ID, FirstName, LastName, Address, OrderType) VALUES (@ID, @FirstName, @LastName, @Address, @OrderType)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtCustomer_Id.Text));
                        cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@OrderType", cmbOrderType.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer inserted successfully.");
                        ClearFields();
                        LoadCustomers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate ComboBox with predefined order types
            cmbOrderType.Items.Add("New Order");
            cmbOrderType.Items.Add("Repeat Order");
            cmbOrderType.Items.Add("Return Order");
            cmbOrderType.Items.Add("Replacement Order");
            cmbOrderType.Items.Add("Pre-Order");
            cmbOrderType.Items.Add("Subscription Order");
            cmbOrderType.Items.Add("Custom Order");

            // Optionally, load existing customers from database
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Customers SET FirstName = @FirstName, LastName = @LastName, Address = @Address, OrderType = @OrderType WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtCustomer_Id.Text));
                        cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@OrderType", cmbOrderType.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer updated successfully.");
                        ClearFields();
                        LoadCustomers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Customers WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtCustomer_Id.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer deleted successfully.");
                        ClearFields();
                        LoadCustomers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Customers WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtCustomer_Id.Text));

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtFname.Text = reader["FirstName"].ToString();
                            txtLname.Text = reader["LastName"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            cmbOrderType.Text = reader["OrderType"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM Customers";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtCustomer_Id.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }
    }
}

