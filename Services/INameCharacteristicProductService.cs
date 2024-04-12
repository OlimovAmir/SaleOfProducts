using SaleOfProducts.Models;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Services
{
    public interface INameCharacteristicProductService : IBaseService<NameCharacteristicProduct>
    {
        IQueryable<NameCharacteristicProduct> GetAllWithCharacteristic(); // Добавленный метод
    }
}
