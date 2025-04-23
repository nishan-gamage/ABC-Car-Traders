namespace ABC_Car_Sale
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            txtOrder_Id = new TextBox();
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtQuantity = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            btnDashboard = new Button();
            btnCustomers = new Button();
            btnVehicles = new Button();
            btnReports = new Button();
            txtParts = new Button();
            txtSearch = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtOrder_Id
            // 
            txtOrder_Id.BackColor = SystemColors.Control;
            txtOrder_Id.BorderStyle = BorderStyle.None;
            txtOrder_Id.Location = new Point(107, 324);
            txtOrder_Id.Multiline = true;
            txtOrder_Id.Name = "txtOrder_Id";
            txtOrder_Id.Size = new Size(218, 23);
            txtOrder_Id.TabIndex = 25;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = SystemColors.Control;
            txtCustomerName.BorderStyle = BorderStyle.None;
            txtCustomerName.Location = new Point(107, 385);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(218, 23);
            txtCustomerName.TabIndex = 26;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Location = new Point(107, 444);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 23);
            txtAddress.TabIndex = 27;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.Control;
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Location = new Point(105, 505);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(218, 23);
            txtPhoneNumber.TabIndex = 28;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.Control;
            txtQuantity.BorderStyle = BorderStyle.None;
            txtQuantity.Location = new Point(105, 565);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 23);
            txtQuantity.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(284, 613);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 34;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(180, 613);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 33;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Transparent;
            btnInsert.BackgroundImageLayout = ImageLayout.Stretch;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.Transparent;
            btnInsert.Location = new Point(77, 613);
            btnInsert.Margin = new Padding(0);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 32;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(426, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 392);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Location = new Point(105, 79);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(134, 30);
            btnDashboard.TabIndex = 36;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.BackgroundImageLayout = ImageLayout.Stretch;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.Transparent;
            btnCustomers.Location = new Point(598, 79);
            btnCustomers.Margin = new Padding(0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(134, 30);
            btnCustomers.TabIndex = 37;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Transparent;
            btnVehicles.BackgroundImageLayout = ImageLayout.Stretch;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.ForeColor = Color.Transparent;
            btnVehicles.Location = new Point(264, 79);
            btnVehicles.Margin = new Padding(0);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(134, 30);
            btnVehicles.TabIndex = 38;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Transparent;
            btnReports.Location = new Point(756, 79);
            btnReports.Margin = new Padding(0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(134, 30);
            btnReports.TabIndex = 39;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // txtParts
            // 
            txtParts.BackColor = Color.Transparent;
            txtParts.BackgroundImageLayout = ImageLayout.Stretch;
            txtParts.FlatAppearance.BorderSize = 0;
            txtParts.FlatStyle = FlatStyle.Flat;
            txtParts.ForeColor = Color.Transparent;
            txtParts.Location = new Point(426, 79);
            txtParts.Margin = new Padding(0);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(134, 30);
            txtParts.TabIndex = 40;
            txtParts.UseVisualStyleBackColor = false;
            txtParts.Click += txtParts_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(598, 27);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 23);
            txtSearch.TabIndex = 41;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(859, 33);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 42;
            label3.Text = "..";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(958, 24);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 43;
            label1.Text = "..";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(913, 30);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 44;
            label2.Text = "..";
            label2.Click += label2_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 700);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(txtParts);
            Controls.Add(btnReports);
            Controls.Add(btnVehicles);
            Controls.Add(btnCustomers);
            Controls.Add(btnDashboard);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtQuantity);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(txtOrder_Id);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrder_Id;
        private TextBox txtCustomerName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtQuantity;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dataGridView1;
        private Button btnDashboard;
        private Button btnCustomers;
        private Button btnVehicles;
        private Button btnReports;
        private Button txtParts;
        private TextBox txtSearch;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}