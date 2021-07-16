using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlimentosTFOQ.Models;
using AlimentosTFOQ.Repository;

namespace AlimentosTFOQ.Controllers
{
    public class EstoqueController : Controller
    {
        public ActionResult Index()
        {
            EstoqueRepository repository = new EstoqueRepository();

            List<Estoque> lista = repository.GetEstoque();

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