using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public List<User> Read();
    }
}
