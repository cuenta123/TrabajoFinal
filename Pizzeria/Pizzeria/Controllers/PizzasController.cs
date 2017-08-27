using LinqToSql;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pizzeria.Controllers
{
    [Authorize]
    public class PizzasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {          
            return View();
        }

        [HttpGet]
        public ActionResult PizzaDetail(Guid Id)
        {
            if (Id == null)
            {
                throw new Exception("Excepcion Lanzada");
            }

            GenericDaoEntityFramework gdao = new GenericDaoEntityFramework();
            var pizza = gdao.GetSQL(Id, new Pizza().GetType());
            return View(pizza.Obj);
        }

        [HttpGet]
        public ActionResult Add()
        {      
            return View();
        }

        [HttpPost]
        public ActionResult Add(HttpPostedFileBase file, string Nombre, String Precio )
        {
            decimal precio;
            if(Nombre==null || Nombre == "")
            {
                throw new Exception("Nombre vacio o nulo");
            }

            if(Precio == null || Precio == "" )
            {
                throw new Exception("Precio vacio o nulo");
            }

            if (decimal.TryParse(Precio,out precio) == false)
            {
                throw new Exception("Precio no valido");
            }

            if (file == null)
            {
                throw new Exception("Fichero nulo");
            }

            String ruta =  UploadFile.Upload(file, this.Server);
            Pizza p = new Pizza() {Id = Guid.NewGuid(), Nombre=Nombre, Precio = precio, Foto = ruta};
            GenericDaoEntityFramework gdao  = new GenericDaoEntityFramework();
            gdao.InsertSQL(Generic.ToGeneric(p));
            return View();
        }
    }
}