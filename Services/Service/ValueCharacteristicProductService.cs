using SaleOfProducts.Models;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Services.Service
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
            return _repository.GetById(id);
        }

        public string Update(Guid id, ValueCharacteristicProduct item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;


                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
