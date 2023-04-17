using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Controllers
{
    public class TourController : Controller
    {
        TourManager tourManager = new TourManager(new EfTourDal());
        public IActionResult Index()
        {
            var values = tourManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult TourDetails(int id)
        {
            ViewBag.i=id;
            var values = tourManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult TourDetails(Tour p)
        {
            return View();
        }
    }
}
