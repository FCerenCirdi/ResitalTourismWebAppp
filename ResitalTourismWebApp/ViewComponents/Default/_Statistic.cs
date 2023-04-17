using DataAccessLayer.Concrete;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ResitalTourismWebApp.ViewComponents.Default
{
    public class _Statistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Tours.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
