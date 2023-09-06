using System;
using System.Linq;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelHaven.ViewComponents.Default
{
	public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            return View();
        }

    }
}

