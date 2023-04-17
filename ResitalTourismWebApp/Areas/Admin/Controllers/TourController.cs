using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using ResitalTourismWebApp.Views.ViewModels;
using System.Collections.Generic;

namespace ResitalTourismWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TourController : Controller
    {
        TourManager tourManager = new TourManager(new EfTourDal());
        
        public IActionResult Index()
        {
            var tours = tourManager.TGetList();
            return View(tours);
        }
        [HttpGet]
        public IActionResult AddTour()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTour (Tour tour)
        {
            tourManager.TAdd(tour);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTour(int id)
        {
            var tours = tourManager.TGetByID(id);
            tourManager.TDelete(tours);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTour(int id)
        {
            var tours = tourManager.TGetByID(id);
            return View(tours);
        }
        [HttpPost]
        public IActionResult UpdateTour(Tour tour)
        {
           tourManager.TUpdate(tour);
            return RedirectToAction("Index");
        }
    }
}
