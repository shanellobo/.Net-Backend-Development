using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Register user)
        {
            if (ModelState.IsValid)
            {
                return Content(
                    $"Registration Successful\nname: {user.Name}\nEmail: {user.Email}\nAge: {user.Age}\n");
            }
            return View(user);
        }
    }
}
    
