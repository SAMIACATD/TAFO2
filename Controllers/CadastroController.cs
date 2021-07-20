using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlimentosTFOQ.Models;

namespace AlimentosTFOQ.Controllers
{
    public class CadastroController : Controller
    {
        private static readonly List<GrupoProdutoModel> grupoProdutoModels = new List<GrupoProdutoModel>()
        {
            new GrupoProdutoModel() {Id=1, Nome="Grãos", Ativo=true},
            new GrupoProdutoModel() {Id=2, Nome="laticínios", Ativo=true},
            new GrupoProdutoModel() {Id=3, Nome="Farinhas", Ativo=true},
            new GrupoProdutoModel() {Id=4, Nome="Enlatados", Ativo=false}
        };
        private static readonly List<GrupoProdutoModel> _ListaGrupoProduto = grupoProdutoModels;

        public ActionResult GrupoProduto(_ListaGrupoProduto) => View();

        public ActionResult MarcaProduto()
        {
            return View();
        }

        public ActionResult UnidadeMedida()
        {
            return View();
        }

        public ActionResult Produto()
        {
            return View();
        }

        public ActionResult Fornecedor()
        {
            return View();
        }

    }
        
}
