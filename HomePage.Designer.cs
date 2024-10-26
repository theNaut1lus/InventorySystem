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
            groupBox1 = new GroupBox();
            btnOpen = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(146, 128);
            groupBox1.Margin = new Padding(9, 10, 9, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(9, 10, 9, 10);
            groupBox1.Size = new Size(809, 989);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Khaki;
            btnOpen.ForeColor = Color.LimeGreen;
            btnOpen.Location = new Point(423, 832);
            btnOpen.Margin = new Padding(9, 10, 9, 10);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(234, 138);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(146, 832);
            button1.Margin = new Padding(9, 10, 9, 10);
            button1.Name = "button1";
            button1.Size = new Size(231, 138);
            button1.TabIndex = 3;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Khaki;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listBox1.ForeColor = Color.DarkGoldenrod;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 65;
            listBox1.Items.AddRange(new object[] { "Products", "Users", "Customers", "Orders", "Categories" });
            listBox1.Location = new Point(146, 179);
            listBox1.Margin = new Padding(9, 10, 9, 10);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(504, 589);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Khaki;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(121, 9);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(856, 81);
            label1.TabIndex = 43;
            label1.Text = "Inventory Management System";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1097, 1155);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(9, 10, 9, 10);
            Name = "HomePage";
            Text = "HomePage";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Button btnOpen;
        private Label label1;
    }
}