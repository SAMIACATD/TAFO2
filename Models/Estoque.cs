using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlimentosTFOQ.Models
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(10)]
        public string EntradaEstoque { get; set; }

        [MaxLength(10)]
        public string SaidaEstoque { get; set; }

        [MaxLength(10)]
        public string EstoqueAtual { get; set; }
    }
}