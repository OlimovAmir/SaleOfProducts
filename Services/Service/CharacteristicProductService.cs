using SaleOfProducts.Models;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;

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
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }

        public IQueryable<CharacteristicProduct> GetAll()
        {
            return _repository.GetAll();
        }

        public CharacteristicProduct GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, CharacteristicProduct item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null && item is not null) // Проверяем исходный объект и объект для обновления на null
            {
                _item.Name = item.Name;
                _item.Description = item.Description;
                _item.Price = item.Price;
                _item.Specifications = item.Specifications ?? _item.Specifications; // Используем либо переданные спецификации, либо оставляем текущие

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item not found or update failed";
        }
    }
}
