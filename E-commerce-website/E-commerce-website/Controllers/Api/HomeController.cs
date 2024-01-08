using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers.Api
{
    [Route("/Api/[controller]")]
    public class HomeController
    {
        public IUserService _userService;
        public HomeController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public User Login([FromBody]UserLogin userLogin)
        {
            return _userService.Login(userLogin.Name, userLogin.Password);
        }

        public class UserLogin
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }
    }
}
