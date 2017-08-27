using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LinqToSql
{
    public class CreateInsertSQL
    {
        StringBuilder sql;
        String table;

        public String CreateSQL(Generic entity)
        {
            table = entity.type.Name;
            sql = new StringBuilder();
            sql.Append("Insert Into ");
            sql.Append(table);
            sql.Append(" (");
            List<Generic> listGeneric = new List<Generic>();
            listGeneric.Add(entity);
            SQLStringBuilderProperty(listGeneric);
            SQLStringBuilderValues(listGeneric);
            return sql.ToString();
        }


        private void SQLStringBuilderProperty(List<Generic> listGeneric)
        {
            int lastComma = 0;
            listGeneric.ForEach(num => listGeneric.ElementAt(0).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList().ForEach(n => sql.Append(n.Name +",")));
            lastComma = sql.ToString().LastIndexOf(',');
            sql.Remove(lastComma, 1);       
            sql.Append(')');
        }


        private void SQLStringBuilderValues(List<Generic> listGeneric)
        {
            int contador = 0;
            int lastComma = 0;
            sql.Append(" Values (");
            List<PropertyInfo> listapropiedades = listGeneric.ElementAt(contador).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList();        
            listapropiedades.ForEach(num => { sql.Append(listapropiedades.ElementAt(contador).GetValue(listGeneric.ElementAt(0).Obj)+","); contador++; });
            lastComma = sql.ToString().LastIndexOf(',');
            sql.Remove(lastComma, 1);
            sql.Append(")");
        }

    }
}
