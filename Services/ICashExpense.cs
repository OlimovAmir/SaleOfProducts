using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ICashExpense
    {
        IEnumerable<CashExpense> GetAll();
        CashExpense GetById(Guid id);
        string Create(CashExpense worker);
        string Update(Guid id, CashExpense item);
        string Delete(Guid id);
    }
}
