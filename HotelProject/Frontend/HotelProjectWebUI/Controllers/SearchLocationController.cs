using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using HotelProjectWebUI.Models;

namespace HotelProjectWebUI.Controllers
{
    public class SearchLocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(string search)
        {
            List<SearchLocationViewModel> list = new List<SearchLocationViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={search}&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "a506d0b55amshcfb29f2e4989817p174e30jsn4ef35ad88098" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
                return View(values.FirstOrDefault());
            }
        }
    }
}
