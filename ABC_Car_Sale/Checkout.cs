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
    public partial class Checkout : Form
    {
        private string connectionString = "Data Source=DESKTOP-81HPSRG;Initial Catalog=abc_car;Integrated Security=True;";

        public Checkout()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtQuantity.Clear();
        }


        public Checkout(string vehicleID, string brand, string model, string color, string price)
        {
            InitializeComponent();

            // Display the vehicle details on the Checkout form
            lblVehicleID.Text = vehicleID;
            lblBrand.Text = brand;
            lblModel.Text = model;
            lblColor.Text = color;
            lblPrice.Text = price;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // You can add order submission logic here
            MessageBox.Show("Order submitted successfully!");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserDashboard UDashboardForm = new UserDashboard();
            UDashboardForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Parts U_PartsForm = new User_Parts();
            U_PartsForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Vehicle U_VehicleForm = new User_Vehicle();
            U_VehicleForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
                MessageBox.Show("Your Order is Successfull!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ClearFields(); // Clear text boxes after insertion

                this.Invoke((MethodInvoker)delegate
                {
                    User_Vehicle User_Vehicle = new User_Vehicle();
                    User_Vehicle.Show();
                    this.Hide(); // Optionally hide the current form
                });
            }
        }


        public void ShareDetailsForm(string vehicleID, string brand, string model, string color, string price)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void SaveOrderToDatabase(string vehicleID, string email, string firstName, string lastName, string address)
        {

        }

        private void txtBillSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblVehicleID_Click(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}

