using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlimentosTFOQ.Models;
using AlimentosTFOQ.Repository;

namespace AlimentosTFOQ.Controllers
{
    public class AlimentosController : Controller
    {
        public ActionResult Index()
        {
            AlimentosRepository repository = new AlimentosRepository();

            List<Alimentos> lista = repository.GetAlimetos();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
