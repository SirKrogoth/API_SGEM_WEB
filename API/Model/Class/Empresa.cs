using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Class
{
    public class Empresa
    {
        [Key]
        public int Cnpj { get; set; }
        public string RazaoSocial { get; set; }
    }
}
