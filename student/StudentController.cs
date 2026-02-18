using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            // Creating a student object
            Student student = new Student
            {
                Name = "shanell",
                USN = "NU24UCA066"
            };

            return View(student);
        }
    }
}
