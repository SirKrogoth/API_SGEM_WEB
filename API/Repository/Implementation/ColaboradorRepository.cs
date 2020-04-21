using API.Model.Class;
using API.Model.Context;
using API.Repository.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Implementation
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private MysqlContext _repository;


        public ColaboradorRepository(MysqlContext mysqlContext)
        {
            _repository = mysqlContext;
        }

        public Colaborador Login(string login, string senha)
        {
            Colaborador colaborador = _repository.Colaborador.Where(m => m.Login == login && m.Senha == senha).FirstOrDefault();

            return colaborador;
        }
    }
}
