using API.Model.Class;
using API.Model.Context;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Implementation
{
    public class ItemRepository : IItemRepository
    {
        private MysqlContext _repository;

        public ItemRepository(MysqlContext mysqlContext)
        {
            _repository = mysqlContext;
        }

        public Item Create(Item item)
        {
            try
            {
                _repository.Add(item);
                _repository.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<Item> FindAll()
        {
            throw new NotImplementedException();
        }

        public Item FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Item Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}