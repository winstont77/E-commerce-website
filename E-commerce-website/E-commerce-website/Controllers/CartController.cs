using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class CartController : Controller
    {
        [HttpGet(Name = "Cart")]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
