using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectDataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Insert(T t);
        void Remove(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
