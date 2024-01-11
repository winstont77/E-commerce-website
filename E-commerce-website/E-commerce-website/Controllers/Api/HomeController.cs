using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Services.HomeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers.Api
{
    [Route("Api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet("GetAllCategoryProducts")]
        public List<Product> GetAllCategoryProducts()
        {
            return _homeService.GetAllCategoryProducts();
        }
    }
}
