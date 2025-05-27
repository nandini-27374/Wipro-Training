using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Amazon Clone!";
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
    }
}
