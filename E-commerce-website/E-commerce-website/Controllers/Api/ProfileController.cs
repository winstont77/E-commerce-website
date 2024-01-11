using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Services.ProfileService;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_website.Controllers.Api
{
    [Route("Api/[controller]")]
    public class ProfileController
    {
        private IProfileService _profileService;
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpPost("Login")]
        public ResponseData Login([FromBody] UserLogin userLogin)
        {
            //return _userService.Login(userLogin.Name, userLogin.Password);
            return new ResponseData() { Jwt = _profileService.Login(userLogin.Name, userLogin.Password) };
        }

        [HttpPost("Signup")]
        public ResponseData Signup([FromBody] User user)
        {
            return new ResponseData() { Jwt = _profileService.Signup(user) };
        }
        public class UserLogin
        {
            public string Name { get; set; }
            public string Password { get; set; }
        }

        public class ResponseData
        {
            public string Jwt { get; set; }
        }
    }
}
