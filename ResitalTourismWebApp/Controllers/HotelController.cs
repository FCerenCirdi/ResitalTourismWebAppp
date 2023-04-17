using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Controllers
{
    public class HotelController : Controller
    {
        HotelManager hotelManager = new HotelManager(new EfHotelDal());
        public IActionResult Index()
        {
            var values = hotelManager.TGetList();
            return View(values);
        }

      
    }
}
