using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class DBUtil : IDBUtil
    {
        public void popularate(SqlConnection Con, DataGridView dgv, String table)
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from " + table;
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        public void insertDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into " + tbl + " values(" + tblColumns + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg);
                Con.Close();

            }
            catch
            {


            }
        }

        public void updateDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update " + tbl + " set " + tblColumns, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg);
                Con.Close();

            }
            catch
            {


            }
        }

        public void deleteDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            Con.Open();
            string Myquary = "delete from "+ tbl +" where "+ tblColumns;
            SqlCommand cmd = new SqlCommand(Myquary, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show(msg);
            Con.Close();
        }
    }
}
