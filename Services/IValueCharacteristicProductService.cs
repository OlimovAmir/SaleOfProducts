using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IValueCharacteristicProductService
    {
        IQueryable<ValueCharacteristicProduct> GetAll();
        ValueCharacteristicProduct GetById(Guid id);
        string Create(ValueCharacteristicProduct item);
        string Update(Guid id, ValueCharacteristicProduct item);
        string Delete(Guid id);
    }
}
