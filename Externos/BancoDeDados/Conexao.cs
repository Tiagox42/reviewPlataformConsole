using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reviewPlataformConsole.Externos.BancoDeDados
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor

        public Conexao() {
            con.ConnectionString = "";
        }

        //Metodo Conectar

        public SqlConnection Conectar()
        {

        }

        //Metodo Desconectar
        public void Desconectar()
        {

        }

    }
}
