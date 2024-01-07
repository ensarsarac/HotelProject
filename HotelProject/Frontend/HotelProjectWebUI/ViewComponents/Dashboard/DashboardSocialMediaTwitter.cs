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
    public class DashboardSocialMediaTwitter : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=ensarsrcc"),
				Headers =
	{
		{ "X-RapidAPI-Key", "a506d0b55amshcfb29f2e4989817p174e30jsn4ef35ad88098" },
		{ "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var jsonData = JsonConvert.DeserializeObject<DashboardSocialMediaTwitterProperty>(body);
				ViewBag.followers = jsonData.data.user_info.followers_count;
				ViewBag.friend = jsonData.data.user_info.friends_count;
			}
			return View();
        }
    }
}
