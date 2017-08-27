using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlStringBuilder
{
 public  class SqlConexion
    {
        SqlConnection conexion = null;

        public SqlConexion(String DataSource)
        {
            conexion = new SqlConnection(DataSource);
        }

        public void Open()
        {
            conexion.Open();
        }

        public void Close()
        {
            conexion.Close();
        }

        public SqlCommand CreateCommand()
        {
            return conexion.CreateCommand();
        }
    }
}
