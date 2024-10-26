namespace InventorySystem
{
    partial class Customer
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
            gridCustomer = new DataGridView();
            tbCusName = new TextBox();
            tbCusPhone = new TextBox();
            groupBox1 = new GroupBox();
            tbCusID = new TextBox();
            label3 = new Label();
            btnUpsert = new Button();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            tbSearch = new TextBox();
            btnSearchClear = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridCustomer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridCustomer
            // 
            gridCustomer.AllowUserToAddRows = false;
            gridCustomer.AllowUserToDeleteRows = false;
            gridCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCustomer.BackgroundColor = Color.Khaki;
            gridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomer.Location = new Point(655, 223);
            gridCustomer.Margin = new Padding(9, 10, 9, 10);
            gridCustomer.Name = "gridCustomer";
            gridCustomer.ReadOnly = true;
            gridCustomer.RowHeadersWidth = 123;
            gridCustomer.Size = new Size(879, 1001);
            gridCustomer.TabIndex = 0;
            gridCustomer.CellClick += SelectCustomer;
            // 
            // tbCusName
            // 
            tbCusName.Location = new Point(17, 259);
            tbCusName.Margin = new Padding(9, 10, 9, 10);
            tbCusName.Name = "tbCusName";
            tbCusName.PlaceholderText = "John Doe";
            tbCusName.Size = new Size(418, 55);
            tbCusName.TabIndex = 1;
            // 
            // tbCusPhone
            // 
            tbCusPhone.Location = new Point(17, 400);
            tbCusPhone.Margin = new Padding(9, 10, 9, 10);
            tbCusPhone.Name = "tbCusPhone";
            tbCusPhone.PlaceholderText = "0XXXXXXXXX";
            tbCusPhone.Size = new Size(418, 55);
            tbCusPhone.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCusID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUpsert);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbCusPhone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbCusName);
            groupBox1.Location = new Point(43, 413);
            groupBox1.Margin = new Padding(9, 10, 9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 10, 9, 10);
            groupBox1.Size = new Size(466, 595);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // tbCusID
            // 
            tbCusID.Location = new Point(17, 118);
            tbCusID.Margin = new Padding(9, 10, 9, 10);
            tbCusID.Name = "tbCusID";
            tbCusID.PlaceholderText = "1001";
            tbCusID.Size = new Size(418, 55);
            tbCusID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 61);
            label3.Margin = new Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 48);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // btnUpsert
            // 
            btnUpsert.BackColor = Color.Khaki;
            btnUpsert.Location = new Point(3, 488);
            btnUpsert.Margin = new Padding(9, 10, 9, 10);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(426, 74);
            btnUpsert.TabIndex = 4;
            btnUpsert.Text = "Insert / Update";
            btnUpsert.UseVisualStyleBackColor = false;
            btnUpsert.Click += UpsertCustomer;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 342);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 48);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 202);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 48);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Location = new Point(43, 1000);
            btnClear.Margin = new Padding(9, 10, 9, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(426, 74);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += ClearCustomer;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(63, 233);
            tbSearch.Margin = new Padding(9, 10, 9, 10);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search...";
            tbSearch.Size = new Size(344, 55);
            tbSearch.TabIndex = 4;
            tbSearch.KeyUp += OnSearchTextboxKeyUp;
            // 
            // btnSearchClear
            // 
            btnSearchClear.Location = new Point(433, 223);
            btnSearchClear.Margin = new Padding(9, 10, 9, 10);
            btnSearchClear.Name = "btnSearchClear";
            btnSearchClear.Size = new Size(66, 74);
            btnSearchClear.TabIndex = 5;
            btnSearchClear.Text = "X";
            btnSearchClear.UseVisualStyleBackColor = true;
            btnSearchClear.Click += ClearSearch;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(60, 308);
            btnSearch.Margin = new Padding(9, 10, 9, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(434, 74);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += Search;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Khaki;
            btnHome.Location = new Point(43, 1103);
            btnHome.Margin = new Padding(9, 10, 9, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(425, 67);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += ReturnHome;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Khaki;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.FromArgb(64, 64, 0);
            label4.Location = new Point(533, -4);
            label4.Margin = new Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new Size(856, 81);
            label4.TabIndex = 44;
            label4.Text = "Inventory Management System";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1794, 1252);
            Controls.Add(label4);
            Controls.Add(btnHome);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnSearchClear);
            Controls.Add(tbSearch);
            Controls.Add(groupBox1);
            Controls.Add(gridCustomer);
            Margin = new Padding(9, 10, 9, 10);
            MinimumSize = new Size(1830, 887);
            Name = "Customer";
            Text = "Customer";
            Load += LoadCustomers;
            ((System.ComponentModel.ISupportInitialize)gridCustomer).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridCustomer;
        private TextBox tbCusName;
        private TextBox tbCusPhone;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnUpsert;
        private TextBox tbSearch;
        private Button btnSearchClear;
        private Button btnClear;
        private Button btnSearch;
        private Label label3;
        private TextBox tbCusID;
        private Button btnHome;
        private Label label4;
    }
}