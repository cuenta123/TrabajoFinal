using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
   public interface IDelete
    {
       void DeleteSQL(List<Generic> entity);      
    }
}
