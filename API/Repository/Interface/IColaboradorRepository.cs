using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    public interface IColaboradorRepository
    {
        Colaborador Login(string login, string senha);
    }
}
