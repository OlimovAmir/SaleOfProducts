using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Services
{
    public interface IProductService:IBaseService<Product>
    {
        IQueryable<Product> GetAllWithUnit();
        
    }
}
