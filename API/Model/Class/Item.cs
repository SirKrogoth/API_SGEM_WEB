﻿using API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Class
{
    public class Item : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Preco { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
