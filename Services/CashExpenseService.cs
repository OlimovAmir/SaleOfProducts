using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CashExpenseService : ICashExpenseService
    {
        IPostgreSQLRepository<CashExpense> _repository;

        public CashExpenseService(IPostgreSQLRepository<CashExpense> repository)
        {
            _repository = repository;
        }

        public string Create(CashExpense item)
        {
            if (string.IsNullOrEmpty(item.Category))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
        }



        public string Delete(Guid id)
        {
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }

        public IEnumerable<CashExpense> GetAll()
        {
            return _dbContext.CashExpenses.ToList();
        }

        public CashExpense GetById(Guid id)
        {
            return _dbContext.CashExpenses.Find(id);
        }

        public string Update(Guid id, CashExpense item)
        {
            var existingItem = _dbContext.CashExpenses.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.TransactionDate = item.TransactionDate;
            existingItem.Category = item.Category;
            existingItem.Description = item.Description;
            existingItem.Amount = item.Amount;

            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
