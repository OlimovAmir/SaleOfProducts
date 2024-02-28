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
            if (string.IsNullOrEmpty(item.Name))
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

        public IQueryable<ExpenseItem> GetAll()
        {
            return _repository.GetAll();
        }

        public ExpenseItem GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, ExpenseItem item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;
                

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
