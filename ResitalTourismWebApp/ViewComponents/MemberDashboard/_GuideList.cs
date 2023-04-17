﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ResitalTourismWebApp.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var values= guideManager.TGetList();
            return View(values);
            
        }

    }
}
