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
    public class DashboardLinkedin : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fensar-sarac%2F&include_skills=false"),
				Headers =
	{
		{ "X-RapidAPI-Key", "a506d0b55amshcfb29f2e4989817p174e30jsn4ef35ad88098" },
		{ "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var jsonData = JsonConvert.DeserializeObject<DashboardLinkedinViewModel>(body);
				ViewBag.followers = jsonData.data.followers_count;
				ViewBag.connection = jsonData.data.connections_count;
			}
			return View();
        }
    }
}
