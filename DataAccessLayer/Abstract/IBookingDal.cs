using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        List<Booking> GetListWithBookingByApproval(int id);
        List<Booking> GetListWithBookingByAccepted(int id);
        List<Booking> GetListWithBookingByPass(int id);
    }
}
