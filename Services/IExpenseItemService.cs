using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IExpenseItemService
    {
        IEnumerable<ExpenseItem> GetAll();
        ExpenseItem GetById(Guid id);
        string Create(ExpenseItem item);
        string Update(Guid id, ExpenseItem item);
        string Delete(Guid id);
    }
}
