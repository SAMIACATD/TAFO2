using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlimentosTFOQ.Models
{
    public class Usuario
    {
        
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(15)]
        public string CPF { get; set; }

        [MaxLength(12)]
        public string Celular { get; set; }

        [MaxLength(20)]
        public string Cidade { get; set; }

        public DateTime DataCadastro { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Login { get; set; }

        [Key]
        public bool AbrirLogin { get; internal set; }

        [Key]
        public int Senha { get; internal set; }

        public char Ativo { get; internal set; }

    }
}