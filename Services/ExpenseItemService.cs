using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class ExpenseItemService : IExpenseItemService
    {
        IPostgreSQLRepository<ExpenseItem> _repository;

        public ExpenseItemService(IPostgreSQLRepository<ExpenseItem> repository)
        {
            _repository = repository;
        }
        public string Create(ExpenseItem item)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExpenseItem GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, ExpenseItem item)
        {
            throw new NotImplementedException();
        }
    }
}
