using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AlimentosTFOQ.Models;

namespace AlimentosTFOQ.Repository
{
    public class UsuarioRepository
    {
        public UsuarioRepository() : base("tfoqConnectionString")
        {

        }

        public DbSet<Alimentos> Alimentos { get; set; }
    }
}