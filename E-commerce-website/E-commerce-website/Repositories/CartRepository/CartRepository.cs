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
        public void CreateCart(Cart cart)
        {
            _dbTable.Carts.Add( cart );
        }

        public IQueryable<Cart> GetCart(User user)
        {
            throw new NotImplementedException();
        }
    }
}
