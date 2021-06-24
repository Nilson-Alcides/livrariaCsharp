using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Conexao
    {
        public static SqlConnection conexao { get; set; }

        public static SqlConnection GetConexao()
        {
            conexao = new SqlConnection("Data Source = (local); Initial Catalog = Livraria; User ID = sa; Password = 361190");
            return conexao;            
        }
    }
}
