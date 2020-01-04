using API.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.VO
{
    public class ItemVO
    {
        public long Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Preco { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
