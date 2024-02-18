using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class UnitService : IUnitService
    {
        IPostgreSQLRepository<Unit> _repository;

        public UnitService(IPostgreSQLRepository<Unit> repository)
        {
            _repository = repository;
        }

        public string Create(Unit item)
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

        public IEnumerable<Unit> GetAll()
        {
            return _repository.GetAll();
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
