using HotelProjectWebUI.Dtos.StaffDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.Dashboard
{
    public class DashboardStaff : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardStaff(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //http://localhost:27845/api/DashboardWidgets/DashboardGetStaffList
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27845/api/DashboardWidgets/DashboardGetStaffList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readdata = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultStaffDto>>(readdata);
                return View(jsonData);
            }
            return View();
        }
    }
}
