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
    //[ApiController]
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
        [ProducesResponseType((200), Type = typeof(List<ItemVO>))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [ProducesResponseType((403))]
        public ActionResult Get()
        {
            return Ok(_itemBusiness.FindAll());
        }

        // GET: api/Item/5
        [HttpGet]
        [Route("consultarItemPorCodigo/{codigo}")]
        [ProducesResponseType((200), Type = typeof(ItemVO))]
        [ProducesResponseType((204))]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [ProducesResponseType((403))]
        public ActionResult Get(long codigo)
        {
            var item = _itemBusiness.FindById(codigo);

            if (item == null)
                return NotFound();
            else
                return Ok(item);
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
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [ProducesResponseType((403))]
        [ProducesResponseType((202), Type = typeof(ItemVO))]
        public IActionResult Put([FromBody] ItemVO itemVO)
        {
            if (itemVO == null)
                return BadRequest();
            else
            {
                var updateItem = _itemBusiness.Update(itemVO);

                if (updateItem == null)
                    return BadRequest();
                else
                    return new ObjectResult(updateItem);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Route("deletarItemPorCodigo/{codigo}")]
        [ProducesResponseType((400))]
        [ProducesResponseType((401))]
        [ProducesResponseType((403))]
        public IActionResult Delete(long codigo)
        {
            _itemBusiness.Delete(codigo);
            return NoContent();
        }        
    }
}