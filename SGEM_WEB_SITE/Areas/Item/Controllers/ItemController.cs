using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGEM_WEB_SITE.Areas.Item.Controllers
{
    [Area("Item")]
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastrarItem()
        {
            return View();
        }
    }
}