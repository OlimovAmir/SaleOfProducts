using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CustomerService : ICustomerService
    {
        IPostgreSQLRepository<Customer> _repository;

        public string Create(Customer item)
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

        public IEnumerable<Customer> GetAll()
        {
            return Items.Values;
        }

        public Customer GetById(Guid id)
        {
            return Items.SingleOrDefault(w => w.Key == id).Value;
        }

        public string Update(Guid id, Customer item)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            _item.Name = item.Name;
            _item.INN = item.INN;
            _item.Address = item.Address;
            _item.State = item.State;
            _item.Phone = item.Phone;
            return "Item updated";
        }
    }
}
