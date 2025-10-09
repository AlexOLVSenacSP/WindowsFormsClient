using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassLibraryUser
{
    public class ConnClass
    {
        //Propriedades
        private const string Server = "TAU0712134W11-1\\SQLEXPRESS";
        private const string Database  = "DB_Library";
        private const string User = "senac";
        private const string Password = "senac";

        //string de conexão
        protected string StrConn = $"Data Source={Server}; Initial Catalog={Database}; User Id={User}; Password={Password}; encrypt = false"; 

        //Metodo para conectar com Banco de Dados.
        public SqlConnection GetConnection ()
        {
            SqlConnection _conn = new SqlConnection(StrConn);
            return _conn;
        }


    }
}
