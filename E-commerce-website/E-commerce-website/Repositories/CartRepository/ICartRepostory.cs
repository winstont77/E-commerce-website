using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.CartRepositoy
{
    public interface ICartRepostory
    {
        public List<Cart> Read();
        public void Create(Cart cart);
    }
}
