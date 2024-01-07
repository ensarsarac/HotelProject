using HotelProjectWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class DashboardSocialMedia : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardSocialMedia(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/ensarsrc"),
                Headers =
    {
        { "X-RapidAPI-Key", "a506d0b55amshcfb29f2e4989817p174e30jsn4ef35ad88098" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<DashboardSocialMediaInsta>(body);
                ViewBag.followers = jsonData.followers;
                ViewBag.following = jsonData.following;
            }
            return View();
        }
    }
}
