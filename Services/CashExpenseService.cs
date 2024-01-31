
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
            throw new NotImplementedException();
        }

        public IEnumerable<CashExpense> GetAll()
        {
            throw new NotImplementedException();
        }

        public CashExpense GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, CashExpense item)
        {
            throw new NotImplementedException();
        }
    }
}
