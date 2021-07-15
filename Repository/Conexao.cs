using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AlimentosTFOQ.Models;

namespace AlimentosTFOQ.Repository
{
    public class Conexao : DbContext 
    {
        public Conexao() : base("tfoqConnectionString")
        {

        }

        public DbSet<Alimentos> Alimentos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }

}