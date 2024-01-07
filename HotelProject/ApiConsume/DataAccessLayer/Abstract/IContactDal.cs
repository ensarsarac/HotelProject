using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
         int GetContactCount();
         int GetSendMessageCount(string mail);
    }
}
