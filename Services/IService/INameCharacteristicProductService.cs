using SaleOfProducts.Models;

namespace SaleOfProducts.Services.IService
{
    public interface INameCharacteristicProductService : IBaseService<NameCharacteristicProduct>
    {
        IQueryable<object> GetAllWithCharacteristic(); // Добавленный метод
    }
}
