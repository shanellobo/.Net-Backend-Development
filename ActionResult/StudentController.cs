using Microsoft.AspNetCore.Mvc;

namespace program3.Controllers
{
    public class StudentController : Controller
    {
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return Content("Student id is: " + id);
        }

        [Route("Marks/{id}/{subject}")]
        public IActionResult Marks(int id, string subject)
        {
            return Content("student id: " + id + ", subject: " + subject);
        }
    }
}
