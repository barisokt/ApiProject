using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        void TInsert(T t);
        void TIDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T TGetByID(int id);

    }
}
