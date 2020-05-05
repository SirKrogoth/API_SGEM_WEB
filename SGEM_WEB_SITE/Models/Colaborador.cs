using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SGEM_WEB_SITE.Models
{
    public class Colaborador
    {
        public int Codigo { get; set; }
        public int CodEmpresa { get; set; }
        public string Nome { get; set; }
        public char Idade { get; set; }        
        public string Login { get; set; }
        public string Senha { get; set; }        
        public bool AdministradorEmpresa { get; set; }
        
        //Parametros utilizados para administração do sistema
        public bool AdministradorSistema { get; set; }
    }
}
