using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class ManController : Controller
    {
        [HttpGet(Name = "Man")]
        public IActionResult Man()
        {
            return View();
        }
    }
}
