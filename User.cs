using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class User : Form
    {
        SqlConnection? Con = null;
        DBUtil dBUtil = new DBUtil();
        public User()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;

            Con = new SqlConnection(connect);
        }

        void popularate()
        {
            dBUtil.popularate(Con, dgvUser, "UserTbl");
        }

        private void User_Load(object sender, EventArgs e)
        {
            popularate();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells);

            txtUsername.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtNumber.Text = dgvUser.Rows[dgvUser.CurrentCell.RowIndex].Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertValueString = $"'{txtUsername.Text}', '{txtFullName.Text}', '{txtPassword.Text}', '{txtNumber.Text}'";
            dBUtil.insertDB(Con, "UserTbl", insertValueString, "User successfully added");
            popularate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateValueString = $"Ufullname='{txtFullName.Text}', Upassword='{txtPassword.Text}', Uphone='{txtNumber.Text}' where Uname='{txtUsername.Text}'";
            dBUtil.updateDB(Con, "UserTbl", updateValueString, "User successfully updated");
            popularate();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dBUtil.deleteDB(Con, "UserTbl", $"Uname= '{txtUsername.Text}'", "User successfully deleted");
            popularate();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            popularate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
