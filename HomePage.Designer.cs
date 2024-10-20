namespace InventorySystem
{
    partial class HomePage
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
            button1 = new Button();
            listBox1 = new ListBox();
            btnOpen = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 28);
            label1.TabIndex = 1;
            label1.Text = "Inventory Management System";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(51, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 309);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(51, 260);
            button1.Name = "button1";
            button1.Size = new Size(81, 43);
            button1.TabIndex = 3;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listBox1.ForeColor = Color.IndianRed;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Items.AddRange(new object[] { "Products", "Users", "Customers", "Orders", "Categories" });
            listBox1.Location = new Point(51, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 193);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.MistyRose;
            btnOpen.ForeColor = Color.LimeGreen;
            btnOpen.Location = new Point(148, 260);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(82, 43);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "HomePage";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Button btnOpen;
    }
}