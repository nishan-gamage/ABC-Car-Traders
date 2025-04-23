namespace ABC_Car_Sale
{
    partial class User_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Register));
            btnRegister = new Button();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(164, 484);
            btnRegister.Margin = new Padding(0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 27);
            btnRegister.TabIndex = 10;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Location = new Point(109, 363);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '•';
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 9;
            txtEmail.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(108, 302);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(218, 23);
            txtUsername.TabIndex = 8;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(109, 424);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(218, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
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
            label4.TabIndex = 38;
            label4.Text = "..";
            label4.Click += label4_Click;
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
            label2.TabIndex = 37;
            label2.Text = "..";
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
            label1.TabIndex = 36;
            label1.Text = "..";
            label1.Click += label1_Click;
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
            label3.TabIndex = 35;
            label3.Text = "..";
            label3.Click += label3_Click;
            // 
            // User_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 661);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Register";
            Load += User_Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}