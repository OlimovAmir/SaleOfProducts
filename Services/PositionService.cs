using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class PositionService : IPositionService
    {
        private readonly MemoryContext _dbContext;

        public PositionService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string Create(Position item)
        {
            if (string.IsNullOrEmpty(item.Title))
            {
                return "The description cannot be empty";
            }

            _dbContext.Positions.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }

        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.Positions.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.Positions.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
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
