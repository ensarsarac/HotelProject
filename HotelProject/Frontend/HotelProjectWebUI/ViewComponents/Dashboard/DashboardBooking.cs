using HotelProjectWebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class DashboardBooking: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardBooking(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardGetBookingList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readdata = await responseMessage.Content.ReadAsStringAsync();
                var jsondata = JsonConvert.DeserializeObject<List<ResultBookingDto>>(readdata);
                return View(jsondata);
            }
            return View();
        }
    }
}
