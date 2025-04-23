namespace ABC_Car_Sale
{
    partial class Parts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parts));
            btnDashboard = new Button();
            btnCustomers = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnVehicles = new Button();
            label3 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            txtPrice = new TextBox();
            txtColor = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            txtID = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Location = new Point(103, 80);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(134, 30);
            btnDashboard.TabIndex = 14;
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
            btnCustomers.Location = new Point(425, 80);
            btnCustomers.Margin = new Padding(0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(134, 30);
            btnCustomers.TabIndex = 16;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnOrders
            // 
            btnOrders.BackColor = Color.Transparent;
            btnOrders.BackgroundImageLayout = ImageLayout.Stretch;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.ForeColor = Color.Transparent;
            btnOrders.Location = new Point(597, 80);
            btnOrders.Margin = new Padding(0);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(134, 30);
            btnOrders.TabIndex = 17;
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Transparent;
            btnReports.Location = new Point(759, 80);
            btnReports.Margin = new Padding(0);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(134, 30);
            btnReports.TabIndex = 18;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnVehicles
            // 
            btnVehicles.BackColor = Color.Transparent;
            btnVehicles.BackgroundImageLayout = ImageLayout.Stretch;
            btnVehicles.FlatAppearance.BorderSize = 0;
            btnVehicles.FlatStyle = FlatStyle.Flat;
            btnVehicles.ForeColor = Color.Transparent;
            btnVehicles.Location = new Point(266, 80);
            btnVehicles.Margin = new Padding(0);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(134, 30);
            btnVehicles.TabIndex = 19;
            btnVehicles.UseVisualStyleBackColor = false;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(860, 33);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 20;
            label3.Text = "..";
            label3.Click += label3_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(598, 27);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(425, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 392);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = SystemColors.Control;
            txtPrice.BorderStyle = BorderStyle.None;
            txtPrice.Location = new Point(106, 564);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(218, 23);
            txtPrice.TabIndex = 28;
            // 
            // txtColor
            // 
            txtColor.BackColor = SystemColors.Control;
            txtColor.BorderStyle = BorderStyle.None;
            txtColor.Location = new Point(106, 504);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(218, 23);
            txtColor.TabIndex = 27;
            // 
            // txtModel
            // 
            txtModel.BackColor = SystemColors.Control;
            txtModel.BorderStyle = BorderStyle.None;
            txtModel.Location = new Point(106, 444);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(218, 23);
            txtModel.TabIndex = 26;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = SystemColors.Control;
            txtBrand.BorderStyle = BorderStyle.None;
            txtBrand.Location = new Point(106, 383);
            txtBrand.Multiline = true;
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(218, 23);
            txtBrand.TabIndex = 25;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Control;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(106, 324);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(218, 23);
            txtID.TabIndex = 24;
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
            btnDelete.TabIndex = 31;
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
            btnUpdate.TabIndex = 30;
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
            btnInsert.TabIndex = 29;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(958, 25);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 32;
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
            label2.Location = new Point(914, 30);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 33;
            label2.Text = "..";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(936, 30);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 34;
            label4.Text = "..";
            label4.Click += label4_Click;
            // 
            // Parts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 700);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Controls.Add(txtBrand);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label3);
            Controls.Add(btnVehicles);
            Controls.Add(btnReports);
            Controls.Add(btnOrders);
            Controls.Add(btnCustomers);
            Controls.Add(btnDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parts";
            Load += Parts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDashboard;
        private Button btnCustomers;
        private Button btnOrders;
        private Button btnReports;
        private Button btnVehicles;
        private Label label3;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private TextBox txtPrice;
        private TextBox txtColor;
        private TextBox txtModel;
        private TextBox txtBrand;
        private TextBox txtID;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}