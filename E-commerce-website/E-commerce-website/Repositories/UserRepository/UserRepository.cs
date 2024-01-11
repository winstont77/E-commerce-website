using E_commerce_website.Database;
using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DbTable _dbTable;

        public UserRepository(DbTable dbTable)
        {   
            _dbTable = dbTable;
        }
        public List<User> Read()
        {
            IEnumerable<User> result = _dbTable.Users;
            return result.ToList();
        }

        public void Create(User user)
        {
            _dbTable.Users.Add(user);
            _dbTable.SaveChanges();
        }

        public User Update(User user)
        {
            _dbTable.Users.Where(u => u.Id == user.Id).First().Name = user.Name;
            _dbTable.Users.Where(u => u.Id == user.Id).First().Password = user.Password;
            _dbTable.Users.Where(u => u.Id == user.Id).First().Email = user.Email;
            _dbTable.SaveChanges();
            return _dbTable.Users.Where(u => u.Id == user.Id).First();
        }

        public void Delete(User user)
        {
            var targetUser = _dbTable.Users.Where(u => u.Id == user.Id).First();
            _dbTable.Users.Remove(targetUser);
            _dbTable.SaveChanges();
        }
    }
}
