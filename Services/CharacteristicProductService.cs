using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CharacteristicProductService : ICharacteristicProductService
    {
        IPostgreSQLRepository<CharacteristicProduct> _repository;

        public CharacteristicProductService(IPostgreSQLRepository<CharacteristicProduct> repository)
        {
            _repository = repository;
        }
        public string Create(CharacteristicProduct item)
        {
            if (string.IsNullOrEmpty(item.Description))
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

        public IQueryable<CharacteristicProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public CharacteristicProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, CharacteristicProduct item)
        {
            throw new NotImplementedException();
        }
    }
}
