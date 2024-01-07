using E_commerce_website.Database;
using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Repositories.UserRepository;

namespace E_commerce_website.Services.UserService
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetOneUser(string userName)
        {
            var result = _userRepository.Read();
            return result.Where(i=>i.Name==userName).First();
            //return new User { Id = 1, Name = userName, Email = "winsotn@gmail.com", Password = "123" };
        }
    }
}
