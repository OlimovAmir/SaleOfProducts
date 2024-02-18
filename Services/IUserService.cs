using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        CashExpense GetById(Guid id);
        string Create(CashExpense item);
        string Update(Guid id, CashExpense item);
        string Delete(Guid id);
    }
}
