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
    public partial class Product : Form
    {
        SqlConnection Con = null;
        DBUtil dBUtil = new DBUtil();
        public Product()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;

            Con = new SqlConnection(connect);
        }


        void popularate()
        {
             
            dBUtil.popularate(Con, dgvProduct, "ProductTbl");
            
        }

        void fillcatogary()
        {
            string query = "select * from CatogariesTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cboCategory.ValueMember = "CatName";
                cboCategory.DataSource = dt;
                cboCat.ValueMember = "CatName";
                cboCat.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void FilterByCatogary()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from ProductTbl where ProdCat='" + cboCategory.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        void fillSearchCombo()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from CatogariesTbl where CatName='" + cboCategory.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgvProduct.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillcatogary();
            popularate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterByCatogary();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            popularate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dBUtil.insertDB(Con, "ProductTbl", "'" +
                    txtProductID.Text + "','" + txtProductName.Text + "','" + txtQty.Text +
                    "','" + txtPrice.Text + "','" + txtDesc.Text + "','"
                    + cboCat.SelectedValue.ToString() + "'", "Product Successfully Added");
            popularate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dBUtil.updateDB(Con, "ProductTbl", "ProdName = '" +
                    txtProductName.Text + "',ProdQty='" + txtQty.Text + "',ProdPrice='" +
                    txtPrice.Text + "',ProdDisc='" + txtDesc.Text + "',ProdCat='" +
                    cboCat.SelectedValue.ToString() + "' where ProdId='" + txtProductID.Text + "'", "Product Successfully Updated");
            popularate();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dgvProduct.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.SelectedRows[0].Cells[1].Value.ToString();
            txtQty.Text = dgvProduct.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.SelectedRows[0].Cells[3].Value.ToString();
            txtDesc.Text = dgvProduct.SelectedRows[0].Cells[4].Value.ToString();
            cboCat.SelectedValue = dgvProduct.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Enter the Product ID");
            }
            else
            {
                dBUtil.deleteDB(Con, "ProductTbl", "ProdId='" + txtProductID.Text + "'", "Product Successfully Deleted");
                popularate();
            }
        }
    }
}
