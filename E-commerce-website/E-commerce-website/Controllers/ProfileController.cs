using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        [HttpGet("Profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("Signup")]
        public IActionResult Signup()
        {
            return View();
        }
    }
}
