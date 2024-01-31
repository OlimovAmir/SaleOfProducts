
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class CashExpenseService : ICashExpenseService
    {
        static Dictionary<Guid, CashExpense> Items = new Dictionary<Guid, CashExpense>();

        public string Create(CashExpense item)
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

        public IEnumerable<CashExpense> GetAll()
        {
            return Items.Values;
        }

        public CashExpense GetById(Guid id)
        {
            return Items.SingleOrDefault(w => w.Key == id).Value;
        }

        public string Update(Guid id, CashExpense item)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            _item.TransactionDate = item.TransactionDate;
            _item.Category = item.Category;
            _item.Description = item.Description;
            _item.Amount = item.Amount;
           
            return "Item updated";
        }
    }
}
