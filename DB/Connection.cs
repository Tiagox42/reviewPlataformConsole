using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.DB
{
    public class Connection
    {

        SqlConnection con = new SqlConnection();
        public Connection()
        {
            con.ConnectionString = "";

        }

        public SqlConnection Conect()
        {
            return;
        }

        public void Disconnect()
        {

        }
    }
}
