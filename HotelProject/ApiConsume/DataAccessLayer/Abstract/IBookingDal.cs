using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Abstract
{
    public interface IBookingDal: IGenericDal<Booking>
    {
        List<Booking> GetListWithInclude();
        void BookingStatusChangeApproved(int id);
        void BookingStatusChangeCanceled(int id);
        void BookingStatusChangeWaiting(int id);
    }
}
