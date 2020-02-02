using API.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Class
{
    public class ItemLog : BaseEntity
    {
        [Required]
        [MinLength(4)]
        [MaxLength(100)]
        public string Registro { get; set; }
        public string Tipo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
