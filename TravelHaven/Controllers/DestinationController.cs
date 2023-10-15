using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelHaven.Controllers
{
    public class DestinationController : Controller
    {
        // GET: /<controller>/
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            var values = destinationManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}

