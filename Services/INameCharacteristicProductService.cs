using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface INameCharacteristicProductService
    {
        IQueryable<NameCharacteristicProduct> GetAll();
        NameCharacteristicProduct GetById(Guid id);
        string Create(NameCharacteristicProduct item);
        string Update(Guid id, NameCharacteristicProduct item);
        string Delete(Guid id);
    }
}
