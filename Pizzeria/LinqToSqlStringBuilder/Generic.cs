﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
   public class Generic
    {
        public Object Obj { get; set; }
        public Type type { get; set; }

        /// <summary>
        /// Convierte una lista de objetos a Object y devuelve
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<Generic> ToGeneric(IEnumerable<Object> list)
        {
            return list.Select(c => new Generic { Obj = c, type = c.GetType() }).ToList();
        }

        public static Generic ToGeneric(Object objeto)
        {
            return new Generic { Obj = objeto, type = objeto.GetType() };
        }
    }

    }
