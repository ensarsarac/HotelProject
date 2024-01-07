using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.ContactDto;
using HotelProjectWebUI.Dtos.SendMessage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    public class ContactAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserManager<AppUser> _userManager;

        public ContactAdminController(IHttpClientFactory httpClientFactory, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27845/api/Contact");
           
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultContactDto>>(readData);
                return View(jsonData.OrderByDescending(x=>x.Date).ToList());
            }           
            return View();
        }

        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessageDto model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            model.SenderMail = user.Email;
            model.SenderName = user.Name + " " + user.Surname;
            model.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("http://localhost:27845/api/SendMessage", content);
                if (responseMessage.IsSuccessStatusCode)
                {
                    SendMail(model.ReceiverMail,model);
                    return RedirectToAction("Sendbox");
                }
            }

            return View(model);
        }
        public void SendMail(string mail,CreateSendMessageDto model)
        {
            var email = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ensar.src94@gmail.com");
            email.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", mail.ToString());
            email.To.Add(mailboxAddressTo);

            email.Subject = model.Title;
            email.Body = new TextPart(TextFormat.Html) { Text = model.Content };

            var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, false);
            smtp.Authenticate("ensar.src94@gmail.com", "xccr dtae knyq rqvy");
            smtp.Send(email);
            smtp.Disconnect(true);
        }

        [HttpGet]
        public async Task<IActionResult> Sendbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27845/api/SendMessage");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultSendMessageDto>>(readData);
                var values = jsonData.Where(x => x.SenderMail == user.Email).OrderByDescending(x => x.Date).ToList();
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetMailById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:27845/api/Contact/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ResultContactDto>(readData);
                return View(jsonData);
            }
            return View();            
        }

        public async Task<IActionResult> SendBoxReadMailById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:27845/api/SendMessage/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var readData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<ResultSendMessageDto>(readData);
                return View(jsonData);
            }
            return View();
        }

        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }
    
        
    
    }
}
