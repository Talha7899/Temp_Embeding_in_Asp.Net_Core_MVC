using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template_Embeding.Models;

namespace Template_Embeding.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }
    }
}
