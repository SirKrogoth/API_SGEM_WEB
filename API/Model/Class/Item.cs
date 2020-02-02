using API.Model.Base;
using API.Repository.Interface;
using EntityFrameworkCore.Triggers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Class
{
    public class Item : BaseEntity
    {
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
