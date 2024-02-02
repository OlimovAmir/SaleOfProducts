using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class CashIncomeService : ICashIncomeService
    {
        static Dictionary<Guid, CashIncome> Items = new Dictionary<Guid, CashIncome>();
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
            throw new NotImplementedException();
        }

        public CashIncome GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, CashIncome item)
        {
            throw new NotImplementedException();
        }
    }
}
