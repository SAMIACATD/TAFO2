﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlimentosTFOQ.Models
{
    public class MarcaProdutoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}