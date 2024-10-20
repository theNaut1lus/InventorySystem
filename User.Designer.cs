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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 28);
            label1.TabIndex = 1;
            label1.Text = "Inventory Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 374);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Users";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.ForeColor = Color.LimeGreen;
            button2.Location = new Point(104, 234);
            button2.Name = "button2";
            button2.Size = new Size(87, 43);
            button2.TabIndex = 3;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(6, 234);
            button1.Name = "button1";
            button1.Size = new Size(92, 43);
            button1.TabIndex = 2;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 151);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(271, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 52);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(271, 31);
            textBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.MistyRose;
            button3.ForeColor = Color.MediumBlue;
            button3.Location = new Point(197, 234);
            button3.Name = "button3";
            button3.Size = new Size(87, 43);
            button3.TabIndex = 4;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 98);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Full Name";
            textBox3.Size = new Size(271, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 197);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Phone Number";
            textBox4.Size = new Size(271, 31);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(314, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(456, 330);
            dataGridView1.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(104, 325);
            button4.Name = "button4";
            button4.Size = new Size(87, 43);
            button4.TabIndex = 8;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "User";
            Text = "User";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}