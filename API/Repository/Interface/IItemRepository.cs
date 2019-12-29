using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    public interface IItemRepository
    {
        Item Create(Item item);
        Item FindById(long id);
        List<Item> FindAll();
        Item Update(Item item);
        void Delete(long id);
    }
}
