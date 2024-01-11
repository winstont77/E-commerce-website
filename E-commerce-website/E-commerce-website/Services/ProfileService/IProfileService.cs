using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Services.ProfileService
{
    public interface IProfileService
    {
        public string Login(string userName, string userPassword);

        public string Signup(User user);

        public User Detail(string userName);

        public User Edit(User user);

        public string Delete(User user);
    }
}
