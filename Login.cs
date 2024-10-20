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
    public partial class Login : Form
    {
        SqlConnection? Con = null;
        DBUtil dBUtil = new DBUtil();
        public Login()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;

            Con = new SqlConnection(connect);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginString = $"Uname='{txtUsername.Text}' and Upassword='{txtPassword.Text}'";
            bool loginStatus = dBUtil.countDB(Con, "UserTbl", loginString, "Login Successful");
            if (loginStatus)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            
        }
    }
}
