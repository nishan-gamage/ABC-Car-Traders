namespace ABC_Car_Sale
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            txtusername = new TextBox();
            txtEmail = new TextBox();
            txtpassword = new TextBox();
            txtLogin = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.Location = new Point(104, 303);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(224, 23);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += txtName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(104, 363);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(104, 423);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(224, 23);
            txtpassword.TabIndex = 2;
            // 
            // txtLogin
            // 
            txtLogin.AutoSize = true;
            txtLogin.BackColor = Color.Transparent;
            txtLogin.Cursor = Cursors.Hand;
            txtLogin.FlatStyle = FlatStyle.Flat;
            txtLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLogin.ForeColor = Color.Transparent;
            txtLogin.Location = new Point(253, 575);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(48, 20);
            txtLogin.TabIndex = 5;
            txtLogin.Text = "Login";
            txtLogin.Click += txtLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(954, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(957, 24);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "..";
            label3.Click += label3_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(172, 489);
            btnRegister.Margin = new Padding(0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 23);
            btnRegister.TabIndex = 9;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(914, 30);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 10;
            label1.Text = "..";
            label1.Click += label1_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 700);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLogin);
            Controls.Add(txtpassword);
            Controls.Add(txtEmail);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtEmail;
        private TextBox txtpassword;
        private Label txtLogin;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private Label label1;
    }
}