using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    [AllowAnonymous]
    public class BookingController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:27845/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var data =await responseMessage.Content.ReadAsStringAsync();
                var jsonData = JsonConvert.DeserializeObject<List<ResultRoomDto>>(data);
                ViewBag.v = new SelectList(jsonData,"RoomID","Title");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto model)
        {
            model.Status = "Onay Bekliyor";
            TempData["mail"] = model.Mail;
            string bilgiler = $"Adınız:{model.Name}\nGiriş Tarihi:{model.CheckIn}\nÇıkış Tarihi:{model.CheckOut}\nOda:{model.RoomID}" +
                $"\nÇocuk Sayısı:{model.ChildCount}\nYetişkin Sayısı:{model.AdultCount}\nDurum:{model.Status}";
            TempData["bilgiler"] = bilgiler;
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index","Booking",model);
            }
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:27845/api/Booking", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                SendMail();
                return RedirectToAction("Index","Default");
            }

            return View(model);
        }

        public void SendMail()
        {
            var mail = TempData["mail"];
            string bilgiler = (string)TempData["bilgiler"];
            var email = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ensar.src94@gmail.com");
            email.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mail.ToString());
            email.To.Add(mailboxAddressTo);

            email.Subject = "Rezervasyon Bilgileri";
            email.Body = new TextPart(TextFormat.Html) { Text = bilgiler };

            var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, false);
            smtp.Authenticate("ensar.src94@gmail.com", "xccr dtae knyq rqvy");
            smtp.Send(email);
            smtp.Disconnect(true);
        }


    }
}
