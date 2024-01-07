using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfContactRepo: EfGenericRepo<Contact>,IContactDal
    {
        public EfContactRepo(Context context):base(context)
        {
        }       

        public int GetContactCount()
        {
            var context = new Context();
            var value = context.Contacts.Count();
            return value;
        }

        public int GetSendMessageCount(string mail)
        {
            var context = new Context();
            var value = context.SendMessages.Where(x=>x.SenderMail == mail).Count();
            return value;
        }
    }
}
