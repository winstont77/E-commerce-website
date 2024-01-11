using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpGet("Product")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
