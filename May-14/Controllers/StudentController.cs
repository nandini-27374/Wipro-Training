using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is the Index for StudentController";
        }
        public string GetStudentName()
        {
            return "Student Name is Nandini";
        }

        public string GetStudentNumber()
        {
            return "Student Number is 9030688749";
        }
    }
}