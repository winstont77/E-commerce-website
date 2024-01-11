using E_commerce_website.Database;
using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Repositories.CartRepositoy;

namespace E_commerce_website.Repositories.CartRepository
{
    public class CartRepository : ICartRepostory
    {
        ICartRepostory _cartRepository;
        DbTable _dbTable;
        public CartRepository
        (
            ICartRepostory cartRepostory,
            DbTable dbTable
        )
        {
            _cartRepository = cartRepostory;
            _dbTable = dbTable;
        }

        public List<Cart> Read()
        {
            IEnumerable<Cart> result = _dbTable.Carts;
            return result.ToList();
        }

        public void Create(Cart cart)
        {
            _dbTable.Carts.Add(cart);
            _dbTable.SaveChanges();
        }
    }
}
