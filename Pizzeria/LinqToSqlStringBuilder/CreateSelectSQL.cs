using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LinqToSql
{
    public class CreateSelectSQL
    {
        StringBuilder sql;
        String table;

        public String CreateSQL(List<Generic> entity)
        {
            table = entity.ElementAt(0).type.Name;
            sql = new StringBuilder();
            sql.Append("Select ");
            SQLStringBuilderProperty(entity);
            SQLStringBuilderWhere(entity);
            return sql.ToString();
        }


        private void SQLStringBuilderProperty(List<Generic> listGeneric)
        {
            int lastComma = 0;
            listGeneric.ForEach(num => listGeneric.ElementAt(0).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList().ForEach(n => sql.Append(n.Name +",")));
            lastComma = sql.ToString().LastIndexOf(',');
            sql.Remove(lastComma, 1);                 
            sql.Append(" From "+table);
        }


        private void SQLStringBuilderWhere(List<Generic> listGeneric)
        {
            List<PropertyInfo> listapropiedades = listGeneric.ElementAt(0).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList();
            var firstValueField = listapropiedades.ElementAt(0).GetValue(listGeneric.ElementAt(0).Obj);
            sql.Append(" Where id = ");
            sql.Append(firstValueField);
        }

    }
}
