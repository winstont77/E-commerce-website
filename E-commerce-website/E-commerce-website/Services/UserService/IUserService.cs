using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Services.UserService
{
    public interface IUserService
    {
        public User Login(string userName, string userPassword);
    }
}
