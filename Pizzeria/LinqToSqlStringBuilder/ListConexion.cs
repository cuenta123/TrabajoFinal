using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlStringBuilder
{
   public static class ListConexion
    {
        public static String GetDataSource()
        {
            return "Data Source=ANGEL;Initial Catalog=Pizzeria;Integrated Security=True;Pooling=False";
        }
    }
}
