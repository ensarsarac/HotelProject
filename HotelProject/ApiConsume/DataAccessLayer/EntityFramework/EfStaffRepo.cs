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
    public class EfStaffRepo: EfGenericRepo<Staff>,IStaffDal
    {
        public EfStaffRepo(Context context):base(context)
        {

        }
    }
}
