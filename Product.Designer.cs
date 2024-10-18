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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, -4);
            label1.Name = "label1";
            label1.Size = new Size(207, 48);
            label1.TabIndex = 0;
            label1.Text = "Product List";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(3, 61);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(363, 56);
            cboCategory.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(409, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(225, 69);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(691, 61);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(225, 69);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 136);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 123;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(720, 450);
            dgvProduct.TabIndex = 4;
            dgvProduct.CellContentClick += dgvProduct_CellContentClick;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(12, 626);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(189, 48);
            lblProductID.TabIndex = 5;
            lblProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(262, 626);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(300, 55);
            txtProductID.TabIndex = 6;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(12, 750);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(249, 48);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(267, 750);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(300, 55);
            txtProductName.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 968);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(301, 968);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(225, 69);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 968);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 69);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 633);
            label2.Name = "label2";
            label2.Size = new Size(98, 48);
            label2.TabIndex = 12;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 757);
            label3.Name = "label3";
            label3.Size = new Size(201, 48);
            label3.TabIndex = 13;
            label3.Text = "Description";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(862, 633);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(300, 55);
            txtPrice.TabIndex = 14;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(859, 757);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(300, 55);
            txtDesc.TabIndex = 15;
            // 
            // cboCat
            // 
            cboCat.FormattingEnabled = true;
            cboCat.Location = new Point(859, 884);
            cboCat.Name = "cboCat";
            cboCat.Size = new Size(363, 56);
            cboCat.TabIndex = 16;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(650, 884);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(163, 48);
            lblCategory.TabIndex = 17;
            lblCategory.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 876);
            label4.Name = "label4";
            label4.Size = new Size(155, 48);
            label4.TabIndex = 18;
            label4.Text = "Quantity";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(267, 869);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(300, 55);
            txtQty.TabIndex = 19;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 1085);
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
            Controls.Add(label1);
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}