using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal static class DBConnection
    {
        public static string Connection
        {
            get
            {
                //change the connection string to your own local SQL Server connection string
                var dataDirectory = AppDomain.CurrentDomain.GetData("DataDirectory")?.ToString();
                return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dataDirectory}db\\inventorydb.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}
