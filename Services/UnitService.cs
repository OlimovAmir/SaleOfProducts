using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class UnitService : IUnitService
    {
        private readonly MemoryContext _dbContext;

        public UnitService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(Unit item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The description cannot be empty";
            }

            _dbContext.Units.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }

        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.Units.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.Units.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
        }

        public IEnumerable<Unit> GetAll()
        {
            return _dbContext.Units.ToList();
        }

        public Unit GetById(Guid id)
        {
            return _dbContext.Units.Find(id);
        }

        public string Update(Guid id, Unit item)
        {
            var existingItem = _dbContext.Units.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Name = item.Name;
            

            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
