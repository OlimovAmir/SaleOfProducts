using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAll();
        Supplier GetById(Guid id);
        string Create(Supplier worker);
        string Update(Guid id, Supplier item);
        string Delete(Guid id);
    }
}
