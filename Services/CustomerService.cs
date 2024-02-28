using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CustomerService : ICustomerService
    {
        IPostgreSQLRepository<Customer> _repository;

        public CustomerService(IPostgreSQLRepository<Customer> repository)
        {
            _repository = repository;
        }

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

        public IQueryable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, Customer item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;
                _item.INN = item.INN;
                _item.Address = item.Address;
                _item.State = item.State;
                _item.Phone = item.Phone;

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
           
        }
    }
}
