namespace InventorySystem
{
    partial class Login
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(140, 157);
            groupBox1.Margin = new Padding(9, 10, 9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 10, 9, 10);
            groupBox1.Size = new Size(857, 960);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.ForeColor = Color.LimeGreen;
            btnClear.Location = new Point(469, 483);
            btnClear.Margin = new Padding(9, 10, 9, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(197, 80);
            btnClear.TabIndex = 3;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.ForeColor = Color.IndianRed;
            btnLogin.Location = new Point(141, 483);
            btnLogin.Margin = new Padding(9, 10, 9, 10);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(208, 80);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(17, 358);
            txtPassword.Margin = new Padding(9, 10, 9, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(767, 71);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(17, 157);
            txtUsername.Margin = new Padding(9, 10, 9, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(767, 71);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(121, 9);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(856, 81);
            label1.TabIndex = 43;
            label1.Text = "Inventory Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1097, 1155);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(9, 10, 9, 10);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private Label label1;
    }
}