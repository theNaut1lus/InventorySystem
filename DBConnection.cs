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
                return "Data Source=sidney;Initial Catalog=C:\\USERS\\ADMINISTRATOR\\DOCUMENTS\\INVENTORYDB.MDF;Integrated Security=True;Encrypt=False;";
            }
        }
    }
}
