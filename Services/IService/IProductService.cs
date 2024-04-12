using SaleOfProducts.Models;

namespace SaleOfProducts.Services.IService
{
    public interface IProductService : IBaseService<Product>
    {
        IQueryable<Product> GetAllWithUnit();

    }
}
