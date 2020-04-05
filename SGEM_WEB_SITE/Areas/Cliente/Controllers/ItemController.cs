﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SGEM_WEB_SITE.Areas.Item.Models;
using SGEM_WEB_SITE.Libraries.Lang;
using X.PagedList;

namespace SGEM_WEB_SITE.Areas.Item.Controllers
{
    [Area("Cliente")]
    public class ItemController : Controller
    {
        private static readonly HttpClient client = new HttpClient();   
        
        public async Task<IActionResult> Index()
        {
            try
            {
                List<ItemObj> listaItemObj = new List<ItemObj>();

                client.BaseAddress = new Uri("http://localhost:58722");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var responseMessage = await client.GetStringAsync($"/api/Item//v1");
                
                List<ItemObj> lista = JsonConvert.DeserializeObject<List<ItemObj>>(responseMessage);

                return View(lista);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> Index(int codigo = 1)
        //{
        //    var itemObj = "";
        //    client.BaseAddress = new Uri("http://localhost:58722");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    HttpResponseMessage responseMessage = await client.GetAsync("/api/Item//v1/consultarItemPorCodigo/" + codigo);

        //    if (responseMessage.IsSuccessStatusCode)
        //    {
        //        itemObj = await responseMessage.Content.ReadAsStringAsync();
        //    }

        //    return View(itemObj);
        //}

        public IActionResult CadastrarItem()
        {
            return View();
        }

        public IActionResult AtualizarItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarItemAsync([FromForm] ItemObj itemObj)
        {
            try
            {
                //TODO - Criar uma configuração para guardar esta informação
                client.BaseAddress = new Uri("http://localhost:58722");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                itemObj.Cadastro = DateTime.Today;

                var contentString = new StringContent(JsonConvert.SerializeObject(itemObj), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage responseMessage = await client.PostAsync($"/api/Item/v1/", contentString);

                //Verificando se item foi salvo no banco de dados
                if (responseMessage.IsSuccessStatusCode)
                {
                    TempData["MSG_SUCESSO"] = Message.MSG_SUCESSO_001;

                    return RedirectToAction(nameof(CadastrarItem));
                }
                else
                {
                    TempData["MSG_ERRO"] = Message.MSG_ERRO_001 + responseMessage.StatusCode.ToString();
                    return RedirectToAction(nameof(CadastrarItem));
                }
            }
            catch (Exception e)
            {
                TempData["MSG_ERRO"] = Message.MSG_ERRO_001 + e.Message;
                return RedirectToAction(nameof(CadastrarItem));
            }
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