using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Class
{
    public class Colaborador
    {
        [Key]
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
