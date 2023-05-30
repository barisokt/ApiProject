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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public List<Staff> GetList()
        {
            return _staffDal.GetList();
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public void TIDelete(Staff t)
        {
            _staffDal.IDelete(t);
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
