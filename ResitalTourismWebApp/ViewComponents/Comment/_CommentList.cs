using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ResitalTourismWebApp.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager= new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetTourById(id);
            return View(values);
        }
    }
}
