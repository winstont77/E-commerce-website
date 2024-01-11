using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Services.HomeService
{
    public interface IHomeService
    {
        public List<Product> GetAllCategoryProducts();
    }
}
