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
            btnClear = new Button();
            btnUpsert = new Button();
            label2 = new Label();
            label1 = new Label();
            tbSearch = new TextBox();
            btnSearchClear = new Button();
            btnSearch = new Button();
            btnHome = new Button();
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
            gridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomer.Location = new Point(181, 0);
            gridCustomer.Name = "gridCustomer";
            gridCustomer.ReadOnly = true;
            gridCustomer.Size = new Size(467, 356);
            gridCustomer.TabIndex = 0;
            gridCustomer.CellClick += SelectCustomer;
            // 
            // tbCusName
            // 
            tbCusName.Location = new Point(6, 81);
            tbCusName.Name = "tbCusName";
            tbCusName.PlaceholderText = "John Doe";
            tbCusName.Size = new Size(149, 23);
            tbCusName.TabIndex = 1;
            // 
            // tbCusPhone
            // 
            tbCusPhone.Location = new Point(6, 125);
            tbCusPhone.Name = "tbCusPhone";
            tbCusPhone.PlaceholderText = "0XXXXXXXXX";
            tbCusPhone.Size = new Size(149, 23);
            tbCusPhone.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCusID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpsert);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbCusPhone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbCusName);
            groupBox1.Location = new Point(12, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 218);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // tbCusID
            // 
            tbCusID.Location = new Point(6, 37);
            tbCusID.Name = "tbCusID";
            tbCusID.PlaceholderText = "1001";
            tbCusID.Size = new Size(149, 23);
            tbCusID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 19);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 183);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClearCustomer;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(6, 154);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(149, 23);
            btnUpsert.TabIndex = 4;
            btnUpsert.Text = "Insert / Update";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += UpsertCustomer;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(18, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search...";
            tbSearch.Size = new Size(123, 23);
            tbSearch.TabIndex = 4;
            tbSearch.KeyUp += OnSearchTextboxKeyUp;
            // 
            // btnSearchClear
            // 
            btnSearchClear.Location = new Point(147, 12);
            btnSearchClear.Name = "btnSearchClear";
            btnSearchClear.Size = new Size(23, 23);
            btnSearchClear.TabIndex = 5;
            btnSearchClear.Text = "X";
            btnSearchClear.UseVisualStyleBackColor = true;
            btnSearchClear.Click += ClearSearch;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(18, 41);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(152, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += Search;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 321);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(163, 23);
            btnHome.TabIndex = 7;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += ReturnHome;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 356);
            Controls.Add(btnHome);
            Controls.Add(btnSearch);
            Controls.Add(btnSearchClear);
            Controls.Add(tbSearch);
            Controls.Add(groupBox1);
            Controls.Add(gridCustomer);
            MinimumSize = new Size(664, 348);
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
    }
}