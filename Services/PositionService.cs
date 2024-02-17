using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class PositionService : IPositionService
    {
        IPostgreSQLRepository<Position> _repository;

        public PositionService(IPostgreSQLRepository<Position> repository)
        {
            _repository = repository;
        }
        public string Create(Position item)
        {
            if (string.IsNullOrEmpty(item.Title))
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

        public IEnumerable<Position> GetAll()
        {
            return _repository.GetAll();
        }

        public Position GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, Position item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
               
                _item.Title = item.Title;
                _item.Description = item.Description;
                

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
