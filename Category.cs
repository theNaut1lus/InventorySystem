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
        SqlConnection Con = null;
        DBUtil dBUtil = new DBUtil();
        public Category()
        {
            InitializeComponent();
            string connect = DBConnection.Connection;
            Con = new SqlConnection(connect);
        }

        void popularate()
        {
            dBUtil.popularate(Con, DGCategory, "CatogariesTbl");
        }

        private void Category_Load(object sender, EventArgs e)
        {
            popularate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dBUtil.insertDB(Con, "CatogariesTbl", "'" + txtCatalogID.Text + "', '" + 
                txtCatalogName.Text + "'", "Category Successfully Added");
            popularate();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dBUtil.updateDB(Con, "CatogariesTbl", "CatName='" +
                    txtCatalogName.Text + "' where CatId='" + txtCatalogID.Text + "'", "Catogary Successfully Updated");
            popularate();
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
                dBUtil.deleteDB(Con, "CatogariesTbl", "CatId='" + txtCatalogID.Text + "'", "Catogary Successfully Deleted");
                popularate();
            }
        }
    }
}
