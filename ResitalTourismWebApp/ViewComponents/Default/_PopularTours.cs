using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.ViewComponents.Default
{
    public class _PopularTours : ViewComponent
    {
       TourManager tourManager = new TourManager(new EfTourDal());
        public IViewComponentResult Invoke()
        {
            var values = tourManager.TGetList();
            return View(values);
        }
    }
}
