using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllWithUnit();
        IEnumerable<Product> GetAll();
        Product GetById(Guid id);
        string Create(Product item);
        string Update(Guid id, Product item);
        string Delete(Guid id);
    }
}
