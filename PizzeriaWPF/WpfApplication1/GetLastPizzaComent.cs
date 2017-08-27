using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1;

namespace Pizzeria
{
  public static class GetLastPizzaComent
    {
        public static Comentario GetComment(Guid idPizza)
        {
            MydbContex db = new MydbContex();
            var comment = db.Comentario.Where(num => num.Pizza == idPizza).OrderByDescending(num => num.Fecha).ToList();
            return comment.ElementAt(0);
        }
    }
}
