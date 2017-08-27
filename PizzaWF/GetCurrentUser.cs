using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
  public static class GetCurrentUser
    {      
       public static Guid Id;
       public static void SelectIdbyNick(String user)
        {
            //
            MydbContex db = new MydbContex();
            var usuario = db.Usuario.Where(num => num.Email.Equals(user)).ToList();
            //Consulta equivalente con sql extension 
            //  var usuario2 = (from user3 in db.Usuario  where user3.Email.Equals(user) select  user3.Id );

         Id = usuario.ElementAt(0).Id;
        } 

    }
}
