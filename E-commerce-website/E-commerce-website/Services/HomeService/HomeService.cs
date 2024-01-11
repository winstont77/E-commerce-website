using E_commerce_website.Models.DatabaseEntity;
using E_commerce_website.Repositories.ProductRepository;

namespace E_commerce_website.Services.HomeService
{
    public class HomeService : IHomeService
    {
        private IProductRepository _productRepository;

        public HomeService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllCategoryProducts()
        {
            var dictionary = _productRepository.Read().GroupBy(product => product.Title)
                .ToDictionary(group => group.Key, group => group.ToList());

            List<Product> products = dictionary
                .Where(kvp => kvp.Value.Any()).Select(kvp => kvp.Value.First()).ToList();

            return products;
        }
    }
}
