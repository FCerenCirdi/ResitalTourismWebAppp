using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalTourismWebApp.Areas.Member.Controllers
{
    [Area("Member")]
    public class BookingController : Controller
    {
        TourManager tourManager = new TourManager(new EfTourDal());
        ShipTourManager shipTourManager = new ShipTourManager(new EfShipTourDal());
        HotelManager hotelManager = new HotelManager(new EfHotelDal());
        BookingManager bookingManager= new BookingManager(new EfBookingDal());

        private readonly UserManager<AppUser> _userManager;

        public BookingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentBooking()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = bookingManager.GetListWithBookingByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyOldBooking()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = bookingManager.GetListWithBookingByPass(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalBooking()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
           var valuesList=  bookingManager.GetListWithBookingByApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewBooking()
        {
            List<SelectListItem> tourValues = (from x in tourManager.TGetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.TourId.ToString()
                                               }).ToList();

            List<SelectListItem> shipTourValues = (from x in shipTourManager.TGetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.ShipId.ToString()
                                                   }).ToList();

            List<SelectListItem> hotelValues = (from x in hotelManager.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.HotelId.ToString()
                                                }).ToList();

            ViewBag.TourValues = tourValues;
            ViewBag.ShipTourValues = shipTourValues;
            ViewBag.HotelValues = hotelValues;

            return View();
        }
        [HttpPost]
        public IActionResult NewBooking(Booking p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            bookingManager.TAdd(p);
            return RedirectToAction("MyCurrentBooking");
        }
    }
}
