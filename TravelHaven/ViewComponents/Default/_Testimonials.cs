using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelHaven.ViewComponents.Default
{
	public class _Testimonials : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}

