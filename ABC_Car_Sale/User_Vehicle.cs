using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABC_Car_Sale.Checkout;

namespace ABC_Car_Sale
{
    public partial class User_Vehicle : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";
        string selectedVehicleID, selectedBrand, selectedModel, selectedColor, selectedPrice;

        public User_Vehicle()
        {
            InitializeComponent();
        }

        private void User_Vehicle_Load(object sender, EventArgs e)
        {
            // You can load vehicles here if needed on form load
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string vehicleID = selectedRow.Cells["ID"].Value.ToString();
                string brand = selectedRow.Cells["Brand"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                string color = selectedRow.Cells["Color"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                // Instantiate the Checkout form and pass the selected vehicle details
                Checkout checkoutForm = new Checkout(vehicleID, brand, model, color, price);
                checkoutForm.Show();
                this.Hide(); // Optionally hide the current form
            }
            else
            {
                MessageBox.Show("Please select a vehicle first.");
            }


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e) // Proceed Button
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get selected row details
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string vehicleID = selectedRow.Cells["ID"].Value.ToString();
                string brand = selectedRow.Cells["Brand"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                string color = selectedRow.Cells["Color"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                // Pass the selected data to the Checkout form
                Checkout checkoutForm = new Checkout(vehicleID, brand, model, color, price);
                checkoutForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a vehicle first.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle the cell click event here
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
