using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Controllers
{
    public class ShipTourController : Controller
    {
        ShipTourManager shipTourManager = new ShipTourManager(new EfShipTourDal());
        public IActionResult Index()
        {
            var values = shipTourManager.TGetList();
            return View(values);
        }
    }
}
