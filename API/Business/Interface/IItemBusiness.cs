using API.Data.VO;
using API.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace API.Business.Interface
{
    public interface IItemBusiness
    {
        ItemVO Create(ItemVO itemVO);
        ItemVO FindById(long codigo);
        ItemVO Update(ItemVO item);
        void Delete(long codigo);
        List<ItemVO> FindAll();
    }
}
