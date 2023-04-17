using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HotelManager:IHotelService
    {
        IHotelDal _hotelDal;

        public HotelManager(IHotelDal hotelDal)
        {
            _hotelDal = hotelDal;
        }

        public void TAdd(Hotel t)
        {
            _hotelDal.Insert(t);
        }

        public void TDelete(Hotel t)
        {
            _hotelDal.Delete(t);
        }

        public Hotel TGetByID(int id)
        {
            return _hotelDal.GetById(id);
        }

        public List<Hotel> TGetList()
        {
           return _hotelDal.GetList();
        }

        public void TUpdate(Hotel t)
        {
            _hotelDal.Update(t);
        }
    }
}
