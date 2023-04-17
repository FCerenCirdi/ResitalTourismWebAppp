using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.ViewComponents.Default
{
    public class _ShipTours : ViewComponent
    {
        ShipTourManager shipTourManager = new ShipTourManager(new EfShipTourDal());
        public IViewComponentResult Invoke()
        {
            //var values = shipTourManager.TGetList();
            //ViewBag.image1=shipTourManager.
            return View();
        }
    }
}
