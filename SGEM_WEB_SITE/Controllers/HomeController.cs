using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SGEM_WEB_SITE.Areas.Cliente.Models;

namespace SGEM_WEB_SITE.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient client;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm]Colaborador colaborador)
        {
            try
            {
                if (client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://localhost:58722");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                }

                var contentString = new StringContent(JsonConvert.SerializeObject(colaborador), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"/api/Colaborador/v1", contentString);

                if (response.IsSuccessStatusCode)
                {
                    TempData["TESTE"] = "HOJE SIM!!!! BEM VINDO ";

                    return new RedirectResult(Url.Action(nameof(Index)));
                }
                else
                {
                    TempData["TESTE"] = "HOJE NAO!!!!";

                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception e)
            {
                TempData["TESTE"] = "ERRO: " + e.Message;

                return RedirectToAction(nameof(Index));
            }
        }
    }
}