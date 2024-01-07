using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class WidgetDashboardPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WidgetDashboardPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var respenseMessage = await client.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardStaffCount");
            var dataread = await respenseMessage.Content.ReadAsStringAsync();
            var jsonData = JsonConvert.DeserializeObject(dataread);
            ViewBag.v = jsonData;

            var client2 = _httpClientFactory.CreateClient();
            var respenseMessage2 = await client2.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardBookingCount");
            var dataread2 = await respenseMessage2.Content.ReadAsStringAsync();
            var jsonData2 = JsonConvert.DeserializeObject(dataread2);
            ViewBag.v2 = jsonData2;

            var respenseMessage3 = await client.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardUserCount");
            var dataread3 = await respenseMessage3.Content.ReadAsStringAsync();
            var jsonData3 = JsonConvert.DeserializeObject(dataread3);
            ViewBag.v3 = jsonData3;

            var respenseMessage4 = await client.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardRoomCount");
            var dataread4 = await respenseMessage4.Content.ReadAsStringAsync();
            var jsonData4 = JsonConvert.DeserializeObject(dataread4);
            ViewBag.v4 = jsonData4;

            return View();
        }
    }
}
