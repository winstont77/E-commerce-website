using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        public List<Product> Read();
    }
}
