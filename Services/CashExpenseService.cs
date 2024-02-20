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
            if (string.IsNullOrEmpty(item.Description))
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
            return _repository.GetAll();
        }

        public CashExpense GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, CashExpense item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.TransactionDate = item.TransactionDate;
                _item.Description = item.Description;
                _item.Amount = item.Amount;

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

           return "Item updated";
        }
    }
}
