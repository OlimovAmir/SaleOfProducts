using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ICharacteristicProduct
    {
        IQueryable<CharacteristicProduct> GetAll();
        CharacteristicProduct GetById(Guid id);
        string Create(CharacteristicProduct item);
        string Update(Guid id, CharacteristicProduct item);
        string Delete(Guid id);
    }
}
