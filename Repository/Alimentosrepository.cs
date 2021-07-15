using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AlimentosTFOQ.Models;

namespace AlimentosTFOQ.Repository
{
    public class AlimentosRepository
    {
        public List<Alimentos> GetAlimetos()
        {
            Conexao banco = new Conexao();

            List<Alimentos> lista = new List<Alimentos>();

            lista = banco.Alimentos.ToList();

            return lista;
        }
}