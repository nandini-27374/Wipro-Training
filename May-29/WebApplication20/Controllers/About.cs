using Microsoft.AspNetCore.Mvc;

namespace WebApplication20.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
