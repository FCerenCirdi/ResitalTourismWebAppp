using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelController : Controller
    {
        HotelManager hotelManager = new HotelManager(new EfHotelDal());
        public IActionResult Index()
        {
            var hotels = hotelManager.TGetList();
            return View(hotels);
        }
        [HttpGet]
        public IActionResult AddHotel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHotel(Hotel hotel)
        {
            hotelManager.TAdd(hotel);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHotel(int id)
        { var hotels = hotelManager.TGetByID(id);
            hotelManager.TDelete(hotels);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateHotel(int id)
        {
            var hotels = hotelManager.TGetByID(id);
            return View(hotels);
        }
        [HttpPost]
        public IActionResult UpdateHotel(Hotel hotel)
        {
           hotelManager.TUpdate(hotel);
            return RedirectToAction("Index");
        }
    }
}
