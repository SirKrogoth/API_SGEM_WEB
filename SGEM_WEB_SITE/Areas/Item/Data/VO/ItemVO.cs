using System;


namespace SGEM_WEB_SITE.Areas.Item.Data.VO
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
