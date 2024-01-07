using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProjectWebUI.ViewComponents.ContactAdmin
{
    public class SideBarAdminContact : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserManager<AppUser> _userManager;

        public SideBarAdminContact(IHttpClientFactory httpClientFactory, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var client = _httpClientFactory.CreateClient();
            var value = await client.GetAsync("http://localhost:27845/api/Contact/GetContactCount");
            var read = await value.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject(read);
            ViewBag.v = data;

            var client2 = _httpClientFactory.CreateClient();
            var value2 = await client2.GetAsync($"http://localhost:27845/api/Contact/SendMessageCount/{user.Email}");
            var read2 = await value2.Content.ReadAsStringAsync();
            var data2 = JsonConvert.DeserializeObject(read2);
            ViewBag.v2 = data2;

            return View();
        }
    }
}
