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
    public class BookingByCityController : Controller
    {
		[HttpGet]
		public async Task<IActionResult> Index(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-05-20&filter_by_currency=EUR&units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&dest_id={search}&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
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
					var jsonData = JsonConvert.DeserializeObject<HotelListViewModel>(body);
					return View(jsonData.results.ToList());
				}
            }
            else
            {
				var client = new HttpClient();
				var request = new HttpRequestMessage
				{
					Method = HttpMethod.Get,
					RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-05-20&filter_by_currency=EUR&units=metric&locale=en-gb&checkin_date=2024-05-19&dest_type=city&dest_id=-1456928&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
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
					var jsonData = JsonConvert.DeserializeObject<HotelListViewModel>(body);
					return View(jsonData.results.ToList());
				}
			}
        }

    }
}
