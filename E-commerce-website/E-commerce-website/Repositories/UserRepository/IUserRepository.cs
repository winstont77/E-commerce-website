using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public List<User> Read();

        public void Create(User user);

        public User Update(User user);

        public void Delete(User user);
    }
}
