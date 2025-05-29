using Microsoft.AspNetCore.Mvc;

namespace WebApplication20.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
