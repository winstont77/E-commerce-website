using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        [HttpGet(Name = "Profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
