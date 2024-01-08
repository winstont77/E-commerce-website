using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_commerce_website.Controllers.Api
{
    [Route("/Api/[controller]")]
    public class HomeController
    {
        private IUserService _userService;
        public HomeController
        (
            IUserService userService
        ) 
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public User Login([FromBody]UserLogin userLogin)
        {
            //return _userService.Login(userLogin.Name, userLogin.Password);
            return new User() {Id = 1, Name = "winston", Email = "winston@gmail.com", Password = _userService.Login(userLogin.Name, userLogin.Password) };
        }

        public class UserLogin
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }
    }
}
