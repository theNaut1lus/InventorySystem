namespace InventorySystem
{
    partial class User
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            rtxtSearch = new RichTextBox();
            btnClearSearch = new Button();
            btnSearch = new Button();
            label2 = new Label();
            button4 = new Button();
            dgvUser = new DataGridView();
            txtNumber = new TextBox();
            txtFullName = new TextBox();
            btnClear = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 28);
            label1.TabIndex = 1;
            label1.Text = "Inventory Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxtSearch);
            groupBox1.Controls.Add(btnClearSearch);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(dgvUser);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 374);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users";
            // 
            // rtxtSearch
            // 
            rtxtSearch.Location = new Point(6, 25);
            rtxtSearch.Name = "rtxtSearch";
            rtxtSearch.Size = new Size(128, 31);
            rtxtSearch.TabIndex = 13;
            rtxtSearch.Text = "";
            rtxtSearch.TextChanged += richTextBox1_TextChanged;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.MistyRose;
            btnClearSearch.Font = new Font("Segoe UI", 10F);
            btnClearSearch.ForeColor = Color.Gray;
            btnClearSearch.Location = new Point(217, 24);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(71, 32);
            btnClearSearch.TabIndex = 12;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MistyRose;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.Gray;
            btnSearch.Location = new Point(140, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(71, 32);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(502, 24);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 9;
            label2.Text = "User Table";
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(108, 325);
            button4.Name = "button4";
            button4.Size = new Size(87, 43);
            button4.TabIndex = 8;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(314, 52);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new Size(456, 316);
            dgvUser.TabIndex = 7;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(6, 216);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Phone Number";
            txtNumber.Size = new Size(282, 31);
            txtNumber.TabIndex = 6;
            txtNumber.TextChanged += textBox4_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(6, 117);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(282, 31);
            txtFullName.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MistyRose;
            btnClear.ForeColor = Color.MediumBlue;
            btnClear.Location = new Point(201, 253);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 43);
            btnClear.TabIndex = 4;
            btnClear.Text = "DELETE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MistyRose;
            btnEdit.ForeColor = Color.LimeGreen;
            btnEdit.Location = new Point(108, 253);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(87, 43);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MistyRose;
            btnAdd.ForeColor = Color.IndianRed;
            btnAdd.Location = new Point(6, 253);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(282, 31);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 71);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(282, 31);
            txtUsername.TabIndex = 0;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "User";
            Text = "User";
            Load += User_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnClear;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtNumber;
        private TextBox txtFullName;
        private Button button4;
        private DataGridView dgvUser;
        private Label label2;
        private Button btnClearSearch;
        private Button btnSearch;
        private RichTextBox rtxtSearch;
    }
}