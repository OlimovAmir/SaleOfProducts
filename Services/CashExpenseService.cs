using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CashExpenseService : ICashExpenseService
    {
        
        private readonly MemoryContext _dbContext;

        public CashExpenseService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(CashExpense item)
        {
            if (string.IsNullOrEmpty(item.Description))
            {
                return "The description cannot be empty";
            }

            _dbContext.CashExpenses.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }



        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.CashExpenses.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.CashExpenses.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
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
