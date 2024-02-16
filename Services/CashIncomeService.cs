using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CashIncomeService : ICashIncomeService
    {
        IPostgreSQLRepository<CashIncome> _repository;

        public CashIncomeService(IPostgreSQLRepository<CashIncome> repository)
        {
            _repository = repository;
        }
        public string Create(CashIncome item)
        {
            if (string.IsNullOrEmpty(item.Source))
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

        public IEnumerable<CashIncome> GetAll()
        {
            return _repository.GetAll();
        }

        public CashIncome GetById(Guid id)
        {
            return Items.SingleOrDefault(w => w.Key == id).Value;
        }

        public string Update(Guid id, CashIncome item)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            _item.TransactionDate = item.TransactionDate;
            _item.Source = item.Source;
            _item.Description = item.Description;
            _item.Amount = item.Amount;

            return "Item updated";
        }
    }
}
