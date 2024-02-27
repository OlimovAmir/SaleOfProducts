using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class NameCharacteristicProductService : INameCharacteristicProductService
    {
        IPostgreSQLRepository<NameCharacteristicProduct> _repository;

        public NameCharacteristicProductService(IPostgreSQLRepository<NameCharacteristicProduct> repository)
        {
            _repository = repository;
        }

        public string Create(NameCharacteristicProduct item)
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

        public IQueryable<NameCharacteristicProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public NameCharacteristicProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, NameCharacteristicProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
