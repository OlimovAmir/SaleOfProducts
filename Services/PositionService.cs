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
            return _dbContext.Positions.ToList();
        }

        public Position GetById(Guid id)
        {
            return _dbContext.Positions.Find(id);
        }

        public string Update(Guid id, Position item)
        {
            var existingItem = _dbContext.Positions.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Title = item.Title;
            existingItem.Description = item.Description;
            
            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
