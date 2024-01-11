using E_commerce_website.Database;
using E_commerce_website.Models.DatabaseEntity;

namespace E_commerce_website.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbTable _dbTable;

        public ProductRepository(DbTable dbTable)
        {
            _dbTable = dbTable;
        }

        public List<Product> Read()
        {
            IEnumerable<Product> result = _dbTable.Products;
            return result.ToList();
        }
    }
}
