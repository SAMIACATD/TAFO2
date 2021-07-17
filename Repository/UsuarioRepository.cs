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
        public List<Usuario> GetUsuario()
        {
            Conexao banco = new Conexao();

            List<Usuario> lista = new List<Usuario>();

            lista = banco.Usuario.ToList();

            return lista;
        }

        internal List<Usuario> GetAlimentos()
        {
            throw new NotImplementedException();
        }

        internal List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        internal void AddUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}