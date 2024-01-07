using E_commerce_website.Database;
using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Repositories.UserRepository;
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

        [HttpPost(Name = "GetOneUser")]
        public User GetOneUser(string userName)
        {
            return _userService.GetOneUser(userName);
            //return _dbTable.Users.Where(i => i.Name == userName).First();
            //return new User { Id = 1, Name = userName, Email = "winsotn@gmail.com", Password = "123"};
        }
    }
}
