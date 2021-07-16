using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AlimentosTFOQ.Models;

namespace AlimentosTFOQ.Repository
{
    public class EstoqueRepository
    {
        public List<Estoque> GetEstoque()
        {
            Conexao banco = new Conexao();

            List<Estoque> lista = new List<Estoque>();

            lista = banco.Estoque.ToList();
            
            return lista;
        }
    }
}

