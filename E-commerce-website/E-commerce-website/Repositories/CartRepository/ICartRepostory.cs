using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.CartRepositoy
{
    public interface ICartRepostory
    {
        public void CreateCart(Cart cart);
        public IQueryable<Cart> GetCart(User user);
    }
}
