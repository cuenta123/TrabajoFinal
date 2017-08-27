using LinqToSql;
using Pizzeria.Models;
using System;
using System.Web.Mvc;

namespace Pizzeria.Controllers
{
    public class HomeController : Controller
    {

        GenericDaoEntityFramework gdao;
        [HttpGet]
        public ActionResult Index()
        {
            gdao = new GenericDaoEntityFramework();
            return View();
        }

        [HttpPost]
        public ActionResult Index(String Usuario, String Contraseña)
        {
            Login g = new Login();
            g.login(Usuario, Contraseña);
            return RedirectToAction("Index","Pizzas");
        }

        [HttpGet]
        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Usuario u)
        {
            if (u == null)
            {
                throw new Exception("Usuario Nulo");
            }

            u.Id = Guid.NewGuid();
            gdao = new GenericDaoEntityFramework();
            gdao.InsertSQL(Generic.ToGeneric(u));
            return RedirectToAction("Index", "Pizzas");
        }


    }
}