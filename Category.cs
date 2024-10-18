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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=YLK-HOME\\SQLEXPRESS;Database=C:\\Users\\Administrator\\Documents\\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        void popularate()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from CatogariesTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                DGCategory.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            popularate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CatogariesTbl values('" + txtCatalogID.Text + "','" + txtCatalogName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CatogariesTbl set CatName='" +
                    txtCatalogName.Text + "' where CatId='" + txtCatalogID.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catogary Successfully Updated");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void DGCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCatalogID.Text = DGCategory.SelectedRows[0].Cells["CatId"].Value.ToString();
            txtCatalogName.Text = DGCategory.SelectedRows[0].Cells["CatName"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCatalogID.Text == "")
            {
                MessageBox.Show("Enter the Catogary ID Number");
            }
            else
            {
                Con.Open();
                string Myquary = "delete from CatogariesTbl where CatId='" + txtCatalogID.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquary, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Catogary Successfully Deleted");
                Con.Close();
                popularate();
            }
        }
    }
}
