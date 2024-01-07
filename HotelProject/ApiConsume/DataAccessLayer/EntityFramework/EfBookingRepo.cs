using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfBookingRepo:EfGenericRepo<Booking>,IBookingDal
    {
        public EfBookingRepo(Context context):base(context)
        {

        }

        public void BookingStatusChangeApproved(int id)
        {
            Context context = new Context();
            var value = context.Bookings.Where(x => x.BookingID == id).FirstOrDefault();
            value.Status = "Onaylandı";
            SendMail(value);
            context.SaveChanges();
        }

        public void BookingStatusChangeCanceled(int id)
        {
            Context context = new Context();
            var value = context.Bookings.Where(x => x.BookingID == id).FirstOrDefault();
            value.Status = "İptal Edildi";
            SendMail(value);
            context.SaveChanges();
        }

        public void BookingStatusChangeWaiting(int id)
        {
            Context context = new Context();
            var value = context.Bookings.Where(x => x.BookingID == id).FirstOrDefault();
            value.Status = "Onay Bekliyor";
            SendMail(value);
            context.SaveChanges();
        }

        public List<Booking> GetListWithInclude()
        {
            Context context = new Context();
            var values = context.Bookings.Include(x => x.Room).ToList();
            return values;
        }
        public void SendMail(Booking model)
        {
            var email = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ensar.src94@gmail.com");
            email.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("Kullanıcı", model.Mail);
            email.To.Add(mailboxAddressTo);

            string bilgiler = $"Giriş Tarihi: {model.CheckIn}\n Çıkış Tarihi: {model.CheckOut}\n Yetişkin Sayısı: {model.AdultCount}\n Çocuk Sayısı: {model.ChildCount}\n Oda ID: {model.RoomID}\n, Özel istek:{model.SpecialRequest} rezervasyonunuz durumu : {model.Status}";

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
