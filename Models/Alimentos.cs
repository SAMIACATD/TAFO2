using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlimentosTFOQ.Models
{
    public class Alimentos
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataValidade { get; set; }

        [MaxLength(50)]
        public string Marca { get; set; }

        [MaxLength(15)]
        public string UnidadeMedida { get; set; }

        [MaxLength(50)]
        public string Estoqueatual { get; set; }
    }
}