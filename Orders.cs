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
    public partial class Orders : Form
    {
        SqlConnection? dbCon = null;
        DBUtil dBUtil = new();

        public Orders()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;
            dbCon = new SqlConnection(connect);
        }

        private void PopulateData()
        {
            dBUtil.popularate(dbCon, gridOrders, "OrdersTbl");
            dBUtil.popularate(dbCon, gridCustomers, "CustomerTbl");
            dBUtil.popularate(dbCon, gridProducts, "ProductTbl");
        }

        private void LoadOrders(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            if (tbSearchCustomer.Text == "")
                dBUtil.popularate(dbCon, gridCustomers, "CustomerTbl");
            else dBUtil.searchDB(gridCustomers, tbSearchCustomer.Text);
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            if (tbSearchProduct.Text == "")
                dBUtil.popularate(dbCon, gridProducts, "ProductTbl");
            else dBUtil.searchDB(gridProducts, tbSearchProduct.Text);
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
                dBUtil.popularate(dbCon, gridOrders, "OrdersTbl");
            else dBUtil.searchDB(gridOrders, tbSearch.Text);
        }

        private void ClearCustomerSearch(object sender, EventArgs e)
        {
            tbSearchCustomer.Text = "";
            dBUtil.popularate(dbCon, gridCustomers, "CustomerTbl");
        }

        private void ClearProductSearch(object sender, EventArgs e)
        {
            tbSearchProduct.Text = "";
            dBUtil.popularate(dbCon, gridProducts, "ProductTbl");
        }

        private void ClearOrderSearch(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            dBUtil.popularate(dbCon, gridOrders, "OrdersTbl");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void SelectOrder(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(gridOrders.Rows[gridOrders.CurrentCell.RowIndex].Cells.ToString());
            var row = gridOrders.Rows[gridOrders.CurrentCell.RowIndex].Cells;

            dBUtil.popularate(dbCon, gridCustomers, "CustomerTbl");
            dBUtil.popularate(dbCon, gridProducts, "ProductTbl");
            dBUtil.searchDB(gridCustomers, row[1].Value.ToString() ?? "");
            dBUtil.searchDB(gridProducts, row[5].Value.ToString() ?? "");

            tbOrderID.Text = row[0].Value.ToString();
            tbOrderID.ReadOnly = true;
            tbCusID.Text = row[1].Value.ToString();
            tbCusID.ReadOnly = true;
            //date
            tbProdID.Text = row[5].Value.ToString();
            tbProdID.ReadOnly = true;
            tbQuantity.Text = row[6].Value.ToString();
            tbPrice.Text = gridProducts.Rows[0].Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOrderID.Text = "";
            tbOrderID.ReadOnly = false;
            tbCusID.Text = "";
            tbProdID.Text = "";

            tbQuantity.Text = "";
            tbPrice.Text = "";

            dBUtil.popularate(dbCon, gridCustomers, "CustomerTbl");
            dBUtil.popularate(dbCon, gridProducts, "ProductTbl");
        }

        private void SelectCustomer(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(gridCustomers.Rows[gridCustomers.CurrentCell.RowIndex].Cells.ToString());
            var row = gridCustomers.Rows[gridCustomers.CurrentCell.RowIndex].Cells;
            tbCusID.Text = row[0].Value.ToString();
        }

        private void SelectProduct(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(gridProducts.Rows[gridProducts.CurrentCell.RowIndex].Cells.ToString());
            var row = gridProducts.Rows[gridProducts.CurrentCell.RowIndex].Cells;
            tbProdID.Text = row[0].Value.ToString();
            tbPrice.Text = row[3].Value.ToString();

        }

        private void btnUpsert_Click(object sender, EventArgs e)
        {
            var cusName =
                gridCustomers.SelectedRows != null && gridCustomers.SelectedRows.Count > 0 ? gridCustomers.SelectedRows[0].Cells[1].Value.ToString() : gridCustomers.Rows[0].Cells[1].Value.ToString();

            int price = 0, quantity = 0, total = 0;
            try {
                price = Convert.ToInt32(tbPrice.Text);
                quantity = Convert.ToInt32(tbQuantity.Text);
                total = price * quantity;
            } 
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
                MessageBox.Show("Invalid format: " + error.Message, "Error", MessageBoxButtons.OK);
                return;
            }


            if (!tbOrderID.ReadOnly)
            {
                dBUtil.insertDB(dbCon, "OrdersTbl", $"{tbOrderID.Text}, {tbCusID.Text}, '{cusName}', GETDATE(), {total}, {tbProdID.Text}, {quantity}", "Order inserted successfully!");
            }
            else
            {
                dBUtil.updateDB(dbCon, "OrdersTbl", $"CustId={tbCusID.Text}, CustomerName='{cusName}', orderDate=GETDATE(), totAmount={total}, ProdId={tbProdID.Text}, quantity={quantity} where OrderId={tbOrderID.Text}", "Order updated successfully!");
            }

            PopulateData();
        }
    }
}
