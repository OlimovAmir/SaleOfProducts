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
            throw new NotImplementedException();
        }

        public IQueryable<ValueCharacteristicProduct> GetAll()
        {
            throw new NotImplementedException();
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
