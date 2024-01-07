using HotelProjectBusinessLayer.Abstract;
using HotelProjectBusinessLayer.Concrete;
using HotelProjectDataAccessLayer.EntityFramework;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminUsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var values = _httpClientFactory.CreateClient();
            var responseMessage = await values.GetAsync("http://localhost:27845/api/AppUser");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData =await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultAppUserDto>>(readData);
                return View(jsonData);
            }
            return View();
        }
    }
}
