namespace InventorySystem
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
            gridOrders = new DataGridView();
            btnSearch = new Button();
            btnSearchClear = new Button();
            tbSearch = new TextBox();
            gridCustomers = new DataGridView();
            gridProducts = new DataGridView();
            btnSearchCustomer = new Button();
            btnClearCustomer = new Button();
            tbSearchCustomer = new TextBox();
            btnSearchProduct = new Button();
            btnClearProduct = new Button();
            tbSearchProduct = new TextBox();
            groupBox1 = new GroupBox();
            tbProdID = new TextBox();
            label8 = new Label();
            tbCusID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbPrice = new TextBox();
            tbOrderID = new TextBox();
            label3 = new Label();
            btnClear = new Button();
            btnUpsert = new Button();
            label1 = new Label();
            tbQuantity = new TextBox();
            btnHome = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridOrders
            // 
            gridOrders.AllowUserToAddRows = false;
            gridOrders.AllowUserToDeleteRows = false;
            gridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridOrders.BackgroundColor = Color.Khaki;
            gridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrders.Dock = DockStyle.Bottom;
            gridOrders.Location = new Point(0, 1126);
            gridOrders.Margin = new Padding(9, 10, 9, 10);
            gridOrders.Name = "gridOrders";
            gridOrders.ReadOnly = true;
            gridOrders.RowHeadersWidth = 123;
            gridOrders.Size = new Size(2317, 528);
            gridOrders.TabIndex = 0;
            gridOrders.CellClick += SelectOrder;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(1180, 1032);
            btnSearch.Margin = new Padding(9, 10, 9, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(149, 74);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += SearchOrder;
            // 
            // btnSearchClear
            // 
            btnSearchClear.Location = new Point(1105, 1024);
            btnSearchClear.Margin = new Padding(9, 10, 9, 10);
            btnSearchClear.Name = "btnSearchClear";
            btnSearchClear.Size = new Size(66, 74);
            btnSearchClear.TabIndex = 8;
            btnSearchClear.Text = "X";
            btnSearchClear.UseVisualStyleBackColor = true;
            btnSearchClear.Click += ClearOrderSearch;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(712, 1037);
            tbSearch.Margin = new Padding(9, 10, 9, 10);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search...";
            tbSearch.Size = new Size(375, 55);
            tbSearch.TabIndex = 7;
            // 
            // gridCustomers
            // 
            gridCustomers.AllowUserToAddRows = false;
            gridCustomers.AllowUserToDeleteRows = false;
            gridCustomers.BackgroundColor = Color.Khaki;
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.Location = new Point(603, 209);
            gridCustomers.Margin = new Padding(9, 10, 9, 10);
            gridCustomers.Name = "gridCustomers";
            gridCustomers.ReadOnly = true;
            gridCustomers.RowHeadersWidth = 123;
            gridCustomers.Size = new Size(737, 698);
            gridCustomers.TabIndex = 10;
            gridCustomers.CellClick += SelectCustomer;
            // 
            // gridProducts
            // 
            gridProducts.AllowUserToAddRows = false;
            gridProducts.AllowUserToDeleteRows = false;
            gridProducts.BackgroundColor = Color.Khaki;
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Location = new Point(1378, 209);
            gridProducts.Margin = new Padding(9, 10, 9, 10);
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.RowHeadersWidth = 123;
            gridProducts.Size = new Size(921, 700);
            gridProducts.TabIndex = 11;
            gridProducts.CellClick += SelectProduct;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.Khaki;
            btnSearchCustomer.Location = new Point(1174, 919);
            btnSearchCustomer.Margin = new Padding(9, 10, 9, 10);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(180, 74);
            btnSearchCustomer.TabIndex = 14;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += SearchCustomer;
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.Location = new Point(1090, 910);
            btnClearCustomer.Margin = new Padding(9, 10, 9, 10);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(66, 74);
            btnClearCustomer.TabIndex = 13;
            btnClearCustomer.Text = "X";
            btnClearCustomer.UseVisualStyleBackColor = true;
            btnClearCustomer.Click += ClearCustomerSearch;
            // 
            // tbSearchCustomer
            // 
            tbSearchCustomer.Location = new Point(603, 929);
            tbSearchCustomer.Margin = new Padding(9, 10, 9, 10);
            tbSearchCustomer.Name = "tbSearchCustomer";
            tbSearchCustomer.PlaceholderText = "Search Customer...";
            tbSearchCustomer.Size = new Size(459, 55);
            tbSearchCustomer.TabIndex = 12;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.Khaki;
            btnSearchProduct.Location = new Point(2062, 919);
            btnSearchProduct.Margin = new Padding(9, 10, 9, 10);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(180, 74);
            btnSearchProduct.TabIndex = 17;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += SearchProduct;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Location = new Point(1978, 919);
            btnClearProduct.Margin = new Padding(9, 10, 9, 10);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(66, 74);
            btnClearProduct.TabIndex = 16;
            btnClearProduct.Text = "X";
            btnClearProduct.UseVisualStyleBackColor = true;
            btnClearProduct.Click += ClearProductSearch;
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.Location = new Point(1497, 936);
            tbSearchProduct.Margin = new Padding(9, 10, 9, 10);
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.PlaceholderText = "Search Product...";
            tbSearchProduct.Size = new Size(463, 55);
            tbSearchProduct.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbProdID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tbCusID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbPrice);
            groupBox1.Controls.Add(tbOrderID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnUpsert);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbQuantity);
            groupBox1.Location = new Point(34, 216);
            groupBox1.Margin = new Padding(9, 10, 9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 10, 9, 10);
            groupBox1.Size = new Size(466, 758);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // tbProdID
            // 
            tbProdID.Location = new Point(174, 246);
            tbProdID.Margin = new Padding(9, 10, 9, 10);
            tbProdID.Name = "tbProdID";
            tbProdID.PlaceholderText = "1001";
            tbProdID.ReadOnly = true;
            tbProdID.Size = new Size(261, 55);
            tbProdID.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 256);
            label8.Margin = new Padding(9, 0, 9, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 48);
            label8.TabIndex = 13;
            label8.Text = "ProdID";
            // 
            // tbCusID
            // 
            tbCusID.Location = new Point(174, 154);
            tbCusID.Margin = new Padding(9, 10, 9, 10);
            tbCusID.Name = "tbCusID";
            tbCusID.PlaceholderText = "1001";
            tbCusID.ReadOnly = true;
            tbCusID.Size = new Size(261, 55);
            tbCusID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 163);
            label7.Margin = new Padding(9, 0, 9, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 48);
            label7.TabIndex = 11;
            label7.Text = "CusID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 365);
            label6.Margin = new Padding(9, 0, 9, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 48);
            label6.TabIndex = 10;
            label6.Text = "Unit Price";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(231, 422);
            tbPrice.Margin = new Padding(9, 10, 9, 10);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "999";
            tbPrice.Size = new Size(210, 55);
            tbPrice.TabIndex = 9;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(174, 61);
            tbOrderID.Margin = new Padding(9, 10, 9, 10);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.PlaceholderText = "1001";
            tbOrderID.Size = new Size(261, 55);
            tbOrderID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 70);
            label3.Margin = new Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 48);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Location = new Point(17, 666);
            btnClear.Margin = new Padding(9, 10, 9, 10);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(426, 74);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpsert
            // 
            btnUpsert.BackColor = Color.Khaki;
            btnUpsert.Location = new Point(17, 573);
            btnUpsert.Margin = new Padding(9, 10, 9, 10);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(426, 74);
            btnUpsert.TabIndex = 4;
            btnUpsert.Text = "Insert / Update";
            btnUpsert.UseVisualStyleBackColor = false;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 365);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 48);
            label1.TabIndex = 2;
            label1.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(20, 422);
            tbQuantity.Margin = new Padding(9, 10, 9, 10);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.PlaceholderText = "999";
            tbQuantity.Size = new Size(187, 55);
            tbQuantity.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Khaki;
            btnHome.Location = new Point(54, 1011);
            btnHome.Margin = new Padding(9, 10, 9, 10);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(423, 74);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 151);
            label2.Margin = new Padding(9, 0, 9, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 48);
            label2.TabIndex = 20;
            label2.Text = "Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1378, 151);
            label4.Margin = new Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new Size(159, 48);
            label4.TabIndex = 21;
            label4.Text = "Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 1037);
            label5.Margin = new Padding(9, 0, 9, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 48);
            label5.TabIndex = 22;
            label5.Text = "Orders";
            label5.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Khaki;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.FromArgb(64, 64, 0);
            label9.Location = new Point(722, -1);
            label9.Margin = new Padding(9, 0, 9, 0);
            label9.Name = "label9";
            label9.Size = new Size(856, 81);
            label9.TabIndex = 44;
            label9.Text = "Inventory Management System";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(2317, 1654);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(btnSearchProduct);
            Controls.Add(btnClearProduct);
            Controls.Add(tbSearchProduct);
            Controls.Add(btnSearchCustomer);
            Controls.Add(btnClearCustomer);
            Controls.Add(tbSearchCustomer);
            Controls.Add(gridProducts);
            Controls.Add(gridCustomers);
            Controls.Add(btnSearch);
            Controls.Add(btnSearchClear);
            Controls.Add(tbSearch);
            Controls.Add(gridOrders);
            Margin = new Padding(9, 10, 9, 10);
            MaximumSize = new Size(2353, 1757);
            MinimumSize = new Size(2353, 1757);
            Name = "Orders";
            Text = "Orders";
            Load += LoadOrders;
            ((System.ComponentModel.ISupportInitialize)gridOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridOrders;
        private Button btnSearch;
        private Button btnSearchClear;
        private TextBox tbSearch;
        private DataGridView gridCustomers;
        private DataGridView gridProducts;
        private Button btnSearchCustomer;
        private Button btnClearCustomer;
        private TextBox tbSearchCustomer;
        private Button btnSearchProduct;
        private Button btnClearProduct;
        private TextBox tbSearchProduct;
        private GroupBox groupBox1;
        private TextBox tbOrderID;
        private Label label3;
        private Button btnClear;
        private Button btnUpsert;
        private Label label1;
        private TextBox tbQuantity;
        private Button btnHome;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox tbProdID;
        private Label label8;
        private TextBox tbCusID;
        private Label label7;
        private Label label6;
        private TextBox tbPrice;
        private Label label9;
    }
}