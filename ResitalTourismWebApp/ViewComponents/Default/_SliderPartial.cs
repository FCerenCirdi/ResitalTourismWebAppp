using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
