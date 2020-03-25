﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SGEM_WEB_SITE.Areas.Item.Models;

namespace SGEM_WEB_SITE.Areas.Item.Controllers
{
    [Area("Item")]
    public class ItemController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarItemAsync([FromForm] Models.ItemObj itemObj)
        {
            client.BaseAddress = new Uri("http://localhost:58722");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //var contentString = new StringContent(JsonConvert.SerializeObject(itemObj), System.Text.Encoding.UTF8, "application/json");

            //HttpResponseMessage responseMessage = await client.PostAsync("/api/Item//v1/Post/", contentString);

            return View(itemObj);
        }

        [HttpGet]
        public async Task<IActionResult> Index(int codigo = 1)
        {
            var itemObj = "";
            client.BaseAddress = new Uri("http://localhost:58722");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMessage = await client.GetAsync("/api/Item//v1/consultarItemPorCodigo/" + codigo);

            if (responseMessage.IsSuccessStatusCode)
            {
                itemObj = await responseMessage.Content.ReadAsStringAsync();
            }

            return View(itemObj);
        }

        [HttpGet]
        public async Task<IActionResult> Get(long codigo)
        {
            var itemObj = "";
            client.BaseAddress = new Uri("http://localhost:58722");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage responseMessage = await client.GetAsync("/api/Item//v1/consultarItemPorCodigo/" + codigo);

            if(responseMessage.IsSuccessStatusCode)
            {
                itemObj = await responseMessage.Content.ReadAsStringAsync();
            }

            return View(itemObj);
        }

        [HttpPost]
        public IActionResult Get()
        {
            return View();
        }        
    }
}