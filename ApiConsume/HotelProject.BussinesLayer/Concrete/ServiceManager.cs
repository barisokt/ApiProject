using HotelProject.BussinesLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _serviceDal;

        public ServiceManager(IServicesDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public List<Service> GetList()
        {
            return _serviceDal.GetList();
        }

        public Service TGetByID(int id)
        {
           return _serviceDal.GetByID(id);
        }

        public void TIDelete(Service t)
        {
            _serviceDal.IDelete(t);
        }

        public void TInsert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
