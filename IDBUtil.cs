using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal interface IDBUtil
    {
        public int popularate(SqlConnection Con, DataGridView dgv, String table);
        public void insertDB(SqlConnection Con, string tbl, string tblColumns, string msg);
        public void updateDB(SqlConnection Con, string tbl, string tblColumns, string msg);
        public void deleteDB(SqlConnection Con, string tbl, string tblColumns, string msg);
    }
}
