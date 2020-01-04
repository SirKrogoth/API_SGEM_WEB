using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Business.Interface;
using API.Data.VO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ItemController : ControllerBase
    {
        private readonly IItemBusiness _itemBusiness;

        public ItemController(IItemBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        // GET: api/Item
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Item/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Item
        [HttpPost]
        public ActionResult Post([FromBody] ItemVO itemVO)
        {
            if (itemVO == null)
                return BadRequest();
            else
                return new ObjectResult(_itemBusiness.Create(itemVO));
        }

        // PUT: api/Item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
