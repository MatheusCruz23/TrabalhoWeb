using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdicionarPedido()
        {
            return View();
        }

        public ActionResult EditarPedidos()
        {
            return View();
        }

        public ActionResult ExcluirPedido()
        {
            return View();
        }
    }
}