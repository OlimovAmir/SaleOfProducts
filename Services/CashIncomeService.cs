using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class CashIncomeService : ICashIncomeService
    {
        
        public string Create(CashIncome item)
        {
            if (string.IsNullOrEmpty(item.Description))
            {
                return "The name cannot be empty";
            }
            else
            {
                Items.Add(item.Id, item);
                return $"Created new item with this ID: {item.Id}";
            }
        }

        public string Delete(Guid id)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            Items.Remove(id);

            return "Item deleted";
        }

        public IEnumerable<CashIncome> GetAll()
        {
            return Items.Values;
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
