using SaleOfProducts.Models;

namespace SaleOfProducts.Services.IService
{
    public interface INameCharacteristicProductService : IBaseService<NameCharacteristicProduct>
    {
        IQueryable<NameCharacteristicProduct> GetAllWithCharacteristic(); // Добавленный метод
    }
}
