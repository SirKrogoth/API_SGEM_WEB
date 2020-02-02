using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    public interface IItemLog
    {
        Task<bool> SaveChange();
        void Add(ItemLog item);
        void Create(ItemLog item);
        //Item Create(Item item);
    }
}
