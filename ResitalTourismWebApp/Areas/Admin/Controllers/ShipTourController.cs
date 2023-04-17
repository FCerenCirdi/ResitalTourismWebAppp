using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShipTourController : Controller
    {
        ShipTourManager shipTourManager = new ShipTourManager(new EfShipTourDal());
        public IActionResult Index()
        {
            var shiptours = shipTourManager.TGetList();
            return View(shiptours);
        }
        [HttpGet]
        public IActionResult AddShip()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddShip(ShipTour ship)
        {
            shipTourManager.TAdd(ship);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteShip(int id)
        {
            var ships = shipTourManager.TGetByID(id);
            shipTourManager.TDelete(ships);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateShip(int id)
        {
            var ships = shipTourManager.TGetByID(id);
            return View(ships);
        }
        [HttpPost]
        public IActionResult UpdateShip(ShipTour ship)
        {
            shipTourManager.TUpdate(ship);
            return RedirectToAction("Index");
        }
    }
}
