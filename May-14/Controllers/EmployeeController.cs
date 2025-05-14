using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "This is employee Index";
        }

        public string Firstname()
        {
            return "My first name is Gurikani";
        }

        public string Lastname()
        {
            return "My Last name is Nandini";
        }
    }
}