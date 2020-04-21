using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.VO;
using API.Model.Class;
using API.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //[ApiController]
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        
        public ColaboradorController(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }


        [HttpPost]
        public IActionResult Login([FromBody]ColaboradorVO colaboradorVO)
        {
            Colaborador colaboradorDB = _colaboradorRepository.Login(colaboradorVO.Login, colaboradorVO.Senha);

            if(colaboradorDB != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
