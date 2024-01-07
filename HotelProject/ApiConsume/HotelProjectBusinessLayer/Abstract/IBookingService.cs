using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectBusinessLayer.Abstract
{
    public interface IBookingService: IGenericService<Booking>
    {
        List<Booking> TGetListWithInclude();
        void TBookingStatusChangeApproved(int id);
        void TBookingStatusChangeCanceled(int id);
        void TBookingStatusChangeWaiting(int id);
    }
}
