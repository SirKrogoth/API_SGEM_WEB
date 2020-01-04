using API.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Business.Interface
{
    public interface IItemBusiness
    {
        ItemVO Create(ItemVO itemVO);
        List<ItemVO> FindAll();
        ItemVO FindById(long codigo);
        ItemVO Update(ItemVO item);
        void Delete(long codigo);
    }
}
