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
    }
}
