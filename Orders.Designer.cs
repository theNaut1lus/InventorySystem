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
            gridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrders.Dock = DockStyle.Bottom;
            gridOrders.Location = new Point(0, 334);
            gridOrders.Name = "gridOrders";
            gridOrders.ReadOnly = true;
            gridOrders.Size = new Size(831, 247);
            gridOrders.TabIndex = 0;
            gridOrders.CellClick += SelectOrder;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(769, 305);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(52, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += SearchOrder;
            // 
            // btnSearchClear
            // 
            btnSearchClear.Location = new Point(740, 305);
            btnSearchClear.Name = "btnSearchClear";
            btnSearchClear.Size = new Size(23, 23);
            btnSearchClear.TabIndex = 8;
            btnSearchClear.Text = "X";
            btnSearchClear.UseVisualStyleBackColor = true;
            btnSearchClear.Click += ClearOrderSearch;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(600, 305);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search...";
            tbSearch.Size = new Size(134, 23);
            tbSearch.TabIndex = 7;
            // 
            // gridCustomers
            // 
            gridCustomers.AllowUserToAddRows = false;
            gridCustomers.AllowUserToDeleteRows = false;
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.Location = new Point(211, 31);
            gridCustomers.Name = "gridCustomers";
            gridCustomers.ReadOnly = true;
            gridCustomers.Size = new Size(307, 218);
            gridCustomers.TabIndex = 10;
            gridCustomers.CellClick += SelectCustomer;
            // 
            // gridProducts
            // 
            gridProducts.AllowUserToAddRows = false;
            gridProducts.AllowUserToDeleteRows = false;
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Location = new Point(524, 31);
            gridProducts.Name = "gridProducts";
            gridProducts.ReadOnly = true;
            gridProducts.Size = new Size(297, 218);
            gridProducts.TabIndex = 11;
            gridProducts.CellClick += SelectProduct;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.Location = new Point(455, 255);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(63, 23);
            btnSearchCustomer.TabIndex = 14;
            btnSearchCustomer.Text = "Search";
            btnSearchCustomer.UseVisualStyleBackColor = true;
            btnSearchCustomer.Click += SearchCustomer;
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.Location = new Point(426, 255);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(23, 23);
            btnClearCustomer.TabIndex = 13;
            btnClearCustomer.Text = "X";
            btnClearCustomer.UseVisualStyleBackColor = true;
            btnClearCustomer.Click += ClearCustomerSearch;
            // 
            // tbSearchCustomer
            // 
            tbSearchCustomer.Location = new Point(211, 256);
            tbSearchCustomer.Name = "tbSearchCustomer";
            tbSearchCustomer.PlaceholderText = "Search Customer...";
            tbSearchCustomer.Size = new Size(209, 23);
            tbSearchCustomer.TabIndex = 12;
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(758, 255);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(63, 23);
            btnSearchProduct.TabIndex = 17;
            btnSearchProduct.Text = "Search";
            btnSearchProduct.UseVisualStyleBackColor = true;
            btnSearchProduct.Click += SearchProduct;
            // 
            // btnClearProduct
            // 
            btnClearProduct.Location = new Point(729, 255);
            btnClearProduct.Name = "btnClearProduct";
            btnClearProduct.Size = new Size(23, 23);
            btnClearProduct.TabIndex = 16;
            btnClearProduct.Text = "X";
            btnClearProduct.UseVisualStyleBackColor = true;
            btnClearProduct.Click += ClearProductSearch;
            // 
            // tbSearchProduct
            // 
            tbSearchProduct.Location = new Point(524, 256);
            tbSearchProduct.Name = "tbSearchProduct";
            tbSearchProduct.PlaceholderText = "Search Product...";
            tbSearchProduct.Size = new Size(199, 23);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 237);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order";
            // 
            // tbProdID
            // 
            tbProdID.Location = new Point(61, 77);
            tbProdID.Name = "tbProdID";
            tbProdID.PlaceholderText = "1001";
            tbProdID.ReadOnly = true;
            tbProdID.Size = new Size(94, 23);
            tbProdID.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 80);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 13;
            label8.Text = "ProdID";
            // 
            // tbCusID
            // 
            tbCusID.Location = new Point(61, 48);
            tbCusID.Name = "tbCusID";
            tbCusID.PlaceholderText = "1001";
            tbCusID.ReadOnly = true;
            tbCusID.Size = new Size(94, 23);
            tbCusID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 51);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 11;
            label7.Text = "CusID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 114);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Unit Price";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(81, 132);
            tbPrice.Name = "tbPrice";
            tbPrice.PlaceholderText = "999";
            tbPrice.Size = new Size(76, 23);
            tbPrice.TabIndex = 9;
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(61, 19);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.PlaceholderText = "1001";
            tbOrderID.Size = new Size(94, 23);
            tbOrderID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 22);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 208);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpsert
            // 
            btnUpsert.Location = new Point(6, 179);
            btnUpsert.Name = "btnUpsert";
            btnUpsert.Size = new Size(149, 23);
            btnUpsert.TabIndex = 4;
            btnUpsert.Text = "Insert / Update";
            btnUpsert.UseVisualStyleBackColor = true;
            btnUpsert.Click += btnUpsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 114);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(7, 132);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.PlaceholderText = "999";
            tbQuantity.Size = new Size(68, 23);
            tbQuantity.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 304);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(163, 23);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 20;
            label2.Text = "Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 9);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 21;
            label4.Text = "Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 312);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 22;
            label5.Text = "Orders";
            label5.Click += label5_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 581);
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
            MaximumSize = new Size(847, 620);
            MinimumSize = new Size(847, 620);
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
    }
}