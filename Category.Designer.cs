namespace InventorySystem
{
    partial class Category
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
            txtCatalogID = new TextBox();
            DGCategory = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtCatalogName = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DGCategory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(3, -7);
            label1.Name = "label1";
            label1.Size = new Size(163, 48);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // txtCatalogID
            // 
            txtCatalogID.Location = new Point(307, 1027);
            txtCatalogID.Name = "txtCatalogID";
            txtCatalogID.Size = new Size(300, 55);
            txtCatalogID.TabIndex = 1;
            // 
            // DGCategory
            // 
            DGCategory.ColumnHeadersHeight = 69;
            DGCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGCategory.Location = new Point(12, 44);
            DGCategory.Margin = new Padding(10, 9, 10, 9);
            DGCategory.Name = "DGCategory";
            DGCategory.RowHeadersWidth = 123;
            DGCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGCategory.Size = new Size(1026, 729);
            DGCategory.TabIndex = 33;
            DGCategory.CellContentClick += DGCategory_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 1034);
            label2.Name = "label2";
            label2.Size = new Size(186, 48);
            label2.TabIndex = 34;
            label2.Text = "Catalog ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 1110);
            label3.Name = "label3";
            label3.Size = new Size(246, 48);
            label3.TabIndex = 35;
            label3.Text = "Catalog Name";
            // 
            // txtCatalogName
            // 
            txtCatalogName.Location = new Point(304, 1103);
            txtCatalogName.Name = "txtCatalogName";
            txtCatalogName.Size = new Size(436, 55);
            txtCatalogName.TabIndex = 36;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 1251);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(225, 69);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(304, 1251);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(225, 69);
            btnEdit.TabIndex = 38;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(572, 1251);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(225, 69);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 1362);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtCatalogName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DGCategory);
            Controls.Add(txtCatalogID);
            Controls.Add(label1);
            Name = "Category";
            Text = "Category";
            Load += Category_Load;
            ((System.ComponentModel.ISupportInitialize)DGCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCatalogID;
        private DataGridView DGCategory;
        private Label label2;
        private Label label3;
        private TextBox txtCatalogName;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}