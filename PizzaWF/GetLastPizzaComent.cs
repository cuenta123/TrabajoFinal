using System;
using System.Linq;

namespace Pizzeria
{
  public static class GetLastPizzaComent
    {
        public static Comentario GetComment(Guid idPizza)
        {
            MydbContex db = new MydbContex();
            var comment = db.Comentario.Where(num => num.Pizza == idPizza).OrderByDescending(num => num.Fecha).ToList();
            try
            {
                return comment.ElementAt(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("Pizza sin comentarios");
            }
        }
    }
}
