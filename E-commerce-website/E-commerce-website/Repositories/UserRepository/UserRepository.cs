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
            UserRepository userRepository = new UserRepository ( _dbTable );
            IEnumerable<User> result = _dbTable.Users;
            return result.ToList();
        }
    }
}
