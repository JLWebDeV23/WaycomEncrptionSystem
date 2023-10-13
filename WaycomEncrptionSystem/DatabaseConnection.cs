using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WaycomEncrptionSystem
{
    internal class DatabaseConnection
    {   
        public static SqlConnection db_Connect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MR6LV9LS\SQLEXPRESS01;Initial Catalog=PVT;Integrated Security=True");
            return conn;
        }
        
    }
}
