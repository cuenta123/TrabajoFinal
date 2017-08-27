using LinqToSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlStringBuilder
{
  public  class CreateDeleteSQL
    {     
            StringBuilder sql;
            String table;

            public String CreateSQL(List<Generic> entity)
            {
                table = entity.ElementAt(0).type.Name;
                sql = new StringBuilder();
                sql.Append("Delete From ");
                sql.Append(table);             
                SQLStringBuilder(entity);
                return sql.ToString();
            }


            private void SQLStringBuilder(List<Generic> listGeneric)
            {
                sql.Append(" Where Id = ");
                List<PropertyInfo> listapropiedades = listGeneric.ElementAt(0).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList();
                sql.Append(listapropiedades.ElementAt(0).GetValue(listGeneric.ElementAt(0).Obj) );            
            }

        }
    
}
