namespace InventorySystem
{
    partial class Product
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
            cboCategory = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dgvProduct = new DataGridView();
            lblProductID = new Label();
            txtProductID = new TextBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            txtDesc = new TextBox();
            cboCat = new ComboBox();
            lblCategory = new Label();
            label4 = new Label();
            txtQty = new TextBox();
            btnHome = new Button();
            lblErrormsg = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(181, 100);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(363, 56);
            cboCategory.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Khaki;
            btnSearch.Location = new Point(574, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(225, 69);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Khaki;
            btnRefresh.Location = new Point(821, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(225, 69);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.BackgroundColor = Color.Khaki;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(20, 209);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 123;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(1319, 450);
            dgvProduct.TabIndex = 4;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(12, 732);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(189, 48);
            lblProductID.TabIndex = 5;
            lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(262, 732);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(300, 55);
            txtProductID.TabIndex = 6;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 856);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(249, 48);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(267, 856);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 55);
            txtProductName.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Khaki;
            btnAdd.Location = new Point(12, 1128);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Location = new Point(301, 1128);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(225, 69);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Khaki;
            btnDelete.Location = new Point(583, 1128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 69);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 739);
            label2.Name = "label2";
            label2.Size = new Size(98, 48);
            label2.TabIndex = 12;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 863);
            label3.Name = "label3";
            label3.Size = new Size(201, 48);
            label3.TabIndex = 13;
            label3.Text = "Description";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(862, 739);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 55);
            txtPrice.TabIndex = 14;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(859, 863);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(300, 55);
            txtDesc.TabIndex = 15;
            // 
            // cboCat
            // 
            cboCat.FormattingEnabled = true;
            cboCat.Location = new Point(859, 990);
            cboCat.Name = "cboCat";
            cboCat.Size = new Size(363, 56);
            cboCat.TabIndex = 16;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(650, 990);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(163, 48);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 975);
            label4.Name = "label4";
            label4.Size = new Size(155, 48);
            label4.TabIndex = 18;
            label4.Text = "Quantity";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(267, 975);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(300, 55);
            txtQty.TabIndex = 19;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Khaki;
            btnHome.Location = new Point(879, 1128);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(225, 69);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lblErrormsg
            // 
            lblErrormsg.AutoSize = true;
            lblErrormsg.ForeColor = Color.IndianRed;
            lblErrormsg.Location = new Point(57, 1061);
            lblErrormsg.Name = "lblErrormsg";
            lblErrormsg.Size = new Size(0, 48);
            lblErrormsg.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(181, -13);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(856, 81);
            label1.TabIndex = 42;
            label1.Text = "Inventory Management System";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1374, 1235);
            Controls.Add(label1);
            Controls.Add(lblErrormsg);
            Controls.Add(btnHome);
            Controls.Add(txtQty);
            Controls.Add(label4);
            Controls.Add(lblCategory);
            Controls.Add(cboCat);
            Controls.Add(txtDesc);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(txtProductID);
            Controls.Add(lblProductID);
            Controls.Add(dgvProduct);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(cboCategory);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboCategory;
        private Button btnSearch;
        private Button btnRefresh;
        private DataGridView dgvProduct;
        private Label lblProductID;
        private TextBox txtProductID;
        private Label lblProductName;
        private TextBox txtProductName;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtDesc;
        private ComboBox cboCat;
        private Label lblCategory;
        private Label label4;
        private TextBox txtQty;
        private Button btnHome;
        private Label lblErrormsg;
        private Label label1;
    }
}