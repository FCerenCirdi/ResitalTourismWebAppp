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
   public class BookingManager : IBookingService
    {
        IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public List<Booking> GetListWithBookingByAccepted(int id)
        {
            return _bookingDal.GetListWithBookingByAccepted(id);
        }

        public List<Booking> GetListWithBookingByApproval(int id)
        {
            return _bookingDal.GetListWithBookingByApproval(id);
        }

        public List<Booking> GetListWithBookingByPass(int id)
        {
            return _bookingDal.GetListWithBookingByPass(id);
        }

        public void TAdd(Booking t)
        {
            _bookingDal.Insert(t);
        }

        public void TDelete(Booking t)
        {
            throw new NotImplementedException();
        }

        public Booking TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Booking t)
        {
            throw new NotImplementedException();
        }
    }
}
