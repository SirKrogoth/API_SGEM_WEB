using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Base
{
    public class BaseEntity
    {
        [Key]
        public long Codigo { get; set; }
    }
}
