using SaleOfProducts.Models;

namespace SaleOfProducts.Services.IService
{
    public interface IGroupProductService : IBaseService<GroupProduct>
    {
        IQueryable<object> GetAllWithCharacteristics();
    }
}
