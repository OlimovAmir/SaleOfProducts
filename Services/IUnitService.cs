using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IUnitService
    {
        IEnumerable<Unit> GetAll();
        Unit GetById(Guid id);
        string Create(Unit item);
        string Update(Guid id, Unit item);
        string Delete(Guid id);
    }
}
