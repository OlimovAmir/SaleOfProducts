using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class PositionServise : IPositionServise
    {
        private readonly MemoryContext _dbContext;

        public PositionServise(MemoryContext dbContext)
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
            throw new NotImplementedException();
        }

        public string Update(Guid id, Position item)
        {
            throw new NotImplementedException();
        }
    }
}
