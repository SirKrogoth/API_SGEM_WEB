using System;
using System.ComponentModel.DataAnnotations;

namespace SGEM_WEB_SITE.Areas.Item.Models
{
    public class ItemObj 
    {
        public long Codigo { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(100)]
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Preco { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }


        //static Item()
        //{
        //    Triggers<Item>.Inserted += e =>
        //    {
        //        ItemLog log = new ItemLog();

        //        log.Registro = "Inserido o Item " + e.Entity.Descricao + ".";
        //        log.Tipo = "Brinquedo";
        //        log.DataCadastro = DateTime.Now;

        //    };
        //}
    }
}
