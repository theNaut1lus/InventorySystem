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
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
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
            groupBox1.Location = new Point(34, 205);
            groupBox1.Margin = new Padding(9, 10, 9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 10, 9, 10);
            groupBox1.Size = new Size(2217, 1197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users";
            // 
            // rtxtSearch
            // 
            rtxtSearch.Location = new Point(17, 80);
            rtxtSearch.Margin = new Padding(9, 10, 9, 10);
            rtxtSearch.Name = "rtxtSearch";
            rtxtSearch.Size = new Size(358, 90);
            rtxtSearch.TabIndex = 13;
            rtxtSearch.Text = "";
            rtxtSearch.TextChanged += richTextBox1_TextChanged;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Khaki;
            btnClearSearch.Font = new Font("Segoe UI", 10F);
            btnClearSearch.ForeColor = Color.Gray;
            btnClearSearch.Location = new Point(620, 77);
            btnClearSearch.Margin = new Padding(9, 10, 9, 10);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(203, 102);
            btnClearSearch.TabIndex = 12;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.Gray;
            btnSearch.Location = new Point(400, 77);
            btnSearch.Margin = new Padding(9, 10, 9, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(203, 102);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(1434, 77);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(265, 70);
            label2.TabIndex = 9;
            label2.Text = "User Table";
            // 
            // button4
            // 
            button4.BackColor = Color.Khaki;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(309, 1040);
            button4.Margin = new Padding(9, 10, 9, 10);
            button4.Name = "button4";
            button4.Size = new Size(249, 138);
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
            dgvUser.BackgroundColor = Color.Khaki;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(897, 166);
            dgvUser.Margin = new Padding(9, 10, 9, 10);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 123;
            dgvUser.Size = new Size(1303, 1011);
            dgvUser.TabIndex = 7;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(17, 691);
            txtNumber.Margin = new Padding(9, 10, 9, 10);
            txtNumber.Name = "txtNumber";
            txtNumber.PlaceholderText = "Phone Number";
            txtNumber.Size = new Size(798, 77);
            txtNumber.TabIndex = 6;
            txtNumber.TextChanged += textBox4_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(17, 374);
            txtFullName.Margin = new Padding(9, 10, 9, 10);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(798, 77);
            txtFullName.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.ForeColor = Color.MediumBlue;
            btnClear.Location = new Point(574, 810);
            btnClear.Margin = new Padding(9, 10, 9, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(249, 138);
            btnClear.TabIndex = 4;
            btnClear.Text = "DELETE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Khaki;
            btnEdit.ForeColor = Color.LimeGreen;
            btnEdit.Location = new Point(309, 810);
            btnEdit.Margin = new Padding(9, 10, 9, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(249, 138);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Khaki;
            btnAdd.ForeColor = Color.IndianRed;
            btnAdd.Location = new Point(17, 810);
            btnAdd.Margin = new Padding(9, 10, 9, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(263, 138);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(17, 544);
            txtPassword.Margin = new Padding(9, 10, 9, 10);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(798, 77);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(17, 227);
            txtUsername.Margin = new Padding(9, 10, 9, 10);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(798, 77);
            txtUsername.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Khaki;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(64, 64, 0);
            label3.Location = new Point(760, 9);
            label3.Margin = new Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new Size(856, 81);
            label3.TabIndex = 43;
            label3.Text = "Inventory Management System";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(2286, 1440);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Margin = new Padding(9, 10, 9, 10);
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
        private Label label3;
    }
}