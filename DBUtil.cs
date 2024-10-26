using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    internal class DBUtil : IDBUtil
    {
        public int popularate(SqlConnection Con, DataGridView dgv, String table)
            {
                int rowCount = 0;
                try
                {
                    Con.Open();
                    string Myquery = "select * from " + table;
                    SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    var ds = new DataSet();
                    da.Fill(ds);
                    dgv.DataSource = ds.Tables[0];
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                rowCount = ds.Tables[0].Rows.Count;
                    
            
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                Con.Close();
                return rowCount;
            }

        public void insertDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                Console.WriteLine("insert into " + tbl + " values(" + tblColumns + ")");
                SqlCommand cmd = new SqlCommand("insert into " + tbl + " values(" + tblColumns + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg);
                Con.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Con.Close();

            }
        }

        public void updateDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                Console.WriteLine("update " + tbl + " set " + tblColumns);
                SqlCommand cmd = new SqlCommand("update " + tbl + " set " + tblColumns, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg);
                Con.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Con.Close();
            }
        }

        public void deleteDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                string Myquary = "delete from " + tbl + " where " + tblColumns;
                Console.WriteLine(Myquary);
                SqlCommand cmd = new SqlCommand(Myquary, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg);
                Con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Con.Close();
            }
        }

        public bool countDB(SqlConnection Con, string tbl, string tblColumns, string msg)
        {
            try
            {
                Con.Open();
                string Myquary = "select count(*) from " + tbl + " where " + tblColumns;
                SqlDataAdapter sda = new SqlDataAdapter(Myquary, Con);
                DataTable dt = new DataTable();
                Console.WriteLine(Myquary);
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show(msg);
                    Con.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    Con.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Con.Close();
                return false;
            }
        }

        public void searchDB(DataGridView dgv, string searchString)
        {
            if(dgv != null && dgv.Rows.Count > 0)
            {
                DataTable dataTable = (DataTable)dgv.DataSource;
                //search across all columns
                var result = dataTable.AsEnumerable().Where(row => row.ItemArray.Any(field => field.ToString().Contains(searchString)));
                //var result = dataTable.AsEnumerable().Where(row => row.Field<string>(1).Contains(searchString));
                try
                {
                    dgv.DataSource = result.CopyToDataTable();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
