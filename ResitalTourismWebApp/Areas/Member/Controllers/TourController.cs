using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResitalTourismWebApp.Views.ViewModels;

namespace ResitalTourismWebApp.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class TourController : Controller
    {
        private readonly TourManager _tourManager;
        private readonly ShipTourManager _shipTourManager;
        private readonly HotelManager _hotelManager;

        public TourController()
        {
            _tourManager = new TourManager(new EfTourDal());
            _shipTourManager = new ShipTourManager(new EfShipTourDal());
            _hotelManager = new HotelManager(new EfHotelDal());
        }

        public IActionResult Index()
        {
            var tours = _tourManager.TGetList();
            var shipTours = _shipTourManager.TGetList();
            var hotel = _hotelManager.TGetList();

            var viewModel = new TourViewModel
            {
                Tours = tours,
                ShipTours = shipTours,
                Hotels= hotel
            };

            return View(viewModel);
        }
    }
    }

