using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ICashExpenseService
    {
        IEnumerable<CashExpenseService> GetAll();
        CashExpenseService GetById(Guid id);
        string Create(CashExpenseService worker);
        string Update(Guid id, CashExpenseService item);
        string Delete(Guid id);
    }
}
