
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class CashExpenseService : ICashExpenseService
    {
        static Dictionary<Guid, CashExpenseService> Items = new Dictionary<Guid, CashExpenseService>();
        public string Create(CashExpenseService item)
        {
            if (string.IsNullOrEmpty(item))
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
            throw new NotImplementedException();
        }

        public IEnumerable<CashExpenseService> GetAll()
        {
            throw new NotImplementedException();
        }

        public CashExpenseService GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, CashExpenseService item)
        {
            throw new NotImplementedException();
        }
    }
}
