using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
