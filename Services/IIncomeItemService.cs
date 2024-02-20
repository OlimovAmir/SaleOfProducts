using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IIncomeItemService
    {
        IEnumerable<IncomeItem> GetAll();
        IncomeItem GetById(Guid id);
        string Create(IncomeItem item);
        string Update(Guid id, IncomeItem item);
        string Delete(Guid id);
    }
}
