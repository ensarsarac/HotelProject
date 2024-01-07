using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfSubscribeRepo: EfGenericRepo<Subscribe>,ISubscribeDal
    {
        public EfSubscribeRepo(Context context):base(context)
        {

        }
    }
}
