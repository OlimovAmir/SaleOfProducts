using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class ProductService : IProductService
    {
        private readonly MemoryContext _dbContext;

        public ProductService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(Product item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The description cannot be empty";
            }

            _dbContext.Products.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, Product item)
        {
            throw new NotImplementedException();
        }
    }
}
