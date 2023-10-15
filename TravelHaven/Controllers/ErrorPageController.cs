using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelHaven.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error403()
        {
            return View();
        }
        public IActionResult Error408()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
        public IActionResult Error501()
        {
            return View();
        }
        public IActionResult Error502()
        {
            return View();
        }
    }
}

