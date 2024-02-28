using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class ValueCharacteristicProductService : IValueCharacteristicProductService
    {
        IPostgreSQLRepository<ValueCharacteristicProduct> _repository;

        public ValueCharacteristicProductService(IPostgreSQLRepository<ValueCharacteristicProduct> repository)
        {
            _repository = repository;
        }
        public string Create(ValueCharacteristicProduct item)
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

        public IQueryable<ValueCharacteristicProduct> GetAll()
        {
            return _repository.GetAll();
        }

        public ValueCharacteristicProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, ValueCharacteristicProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
