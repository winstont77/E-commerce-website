using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class WomenController : Controller
    {
        [HttpGet(Name = "Women")]
        public IActionResult Women()
        {
            return View();
        }
    }
}
