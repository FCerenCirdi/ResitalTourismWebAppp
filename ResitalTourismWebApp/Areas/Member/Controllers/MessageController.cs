using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
