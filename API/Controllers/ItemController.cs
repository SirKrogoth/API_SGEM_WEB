using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Interface;
using API.Data.VO;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ItemController : ControllerBase
    {
        private IItemBusiness _itemBusiness;

        public ItemController(IItemBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        [HttpGet]
        public string Get()
        {
            return "TESTE DO JOAO";
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post([FromBody] ItemVO itemVO)
        {
            if (itemVO == null)
                return BadRequest();
            else
                return new ObjectResult(_itemBusiness.Create(itemVO));
        }
    }
}