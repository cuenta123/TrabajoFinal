using System;
using System.Collections.Generic;

namespace LinqToSql
{
   public interface ICreate
    {
        void InsertSQL(List<Generic> entity);
    }
}
