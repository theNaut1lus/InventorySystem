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
    public partial class Customer : Form
    {
        SqlConnection? dbCon = null;
        DBUtil dBUtil = new();

        public Customer()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;
            dbCon = new SqlConnection(connect);
        }

        private void PopulateData()
        {
            dBUtil.popularate(dbCon, gridCustomer, "CustomerTbl");
        }

        private void LoadCustomers(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void UpsertCustomer(object sender, EventArgs e)
        {
            if (tbCusID.Text == "")
            {
                dBUtil.insertDB(dbCon, "CustomerTbl", $"{tbCusID.Text}, '{tbCusName.Text}', '{tbCusPhone.Text}'", "Customer inserted successfully!");
            } else
            {
                dBUtil.updateDB(dbCon, "CustomerTbl", $"CusName='{tbCusName.Text}', CusPhone='{tbCusPhone.Text}' where CusID='{tbCusID.Text}'", "Customer updated successfully!");
            }

            PopulateData();
        }

        private void SelectCustomer(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(gridCustomer.Rows[gridCustomer.CurrentCell.RowIndex].Cells.ToString());
            var row = gridCustomer.Rows[gridCustomer.CurrentCell.RowIndex].Cells;
            tbCusID.Text = row[0].Value.ToString();
            tbCusID.ReadOnly = true;
            tbCusName.Text = row[1].Value.ToString();
            tbCusPhone.Text = row[2].Value.ToString();
        }

        private void Search(object sender, EventArgs e)
        {
            dBUtil.searchDB(gridCustomer, tbSearch.Text);
        }

        private void ClearSearch(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            PopulateData();
        }

        private void SetCustomer(object sender, EventArgs e)
        {
            btnUpsert.Text = tbCusID.Text == "" ? "Insert" : "Update";
        }

        private void ClearCustomer(object sender, EventArgs e)
        {
            tbCusID.Text = "";
            tbCusID.ReadOnly = false;
            tbCusName.Text = "";
            tbCusPhone.Text = "";
        }
    }
}
