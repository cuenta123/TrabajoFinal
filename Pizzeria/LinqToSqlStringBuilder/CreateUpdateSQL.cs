using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LinqToSql
{
    public class CreateUpdateSQL
    {
        StringBuilder sql;
        String table;

        public String CreateSQL(List<Generic> entity)
        {
            table = entity.ElementAt(0).type.Name;
            sql = new StringBuilder();
            sql.Append("Update ");
            sql.Append(table);
            sql.Append(" set ");
            SQLStringBuilderPropertyAndValues(entity);
            SQLStringBuilderWhere(entity);
            return sql.ToString();
        }


        private void SQLStringBuilderPropertyAndValues(List<Generic> listGeneric)
        { 
            //TODO: Coger a partir de la segunda propiedad
            int contador = 0;
            int lastComma = 0;
            var listapropiedades = listGeneric.ElementAt(0).type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).ToList();
            listapropiedades.ForEach(num => { sql.Append(num.Name + " = "+ listapropiedades.ElementAt(contador).GetValue(listGeneric.ElementAt(0).Obj) + ","); contador++; });
            lastComma = sql.ToString().LastIndexOf(',');
            sql.Remove(lastComma, 1);
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
