using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class SupplierService : ISupplierService
    {
        IPostgreSQLRepository<Supplier> _repository;

        public SupplierService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(Supplier item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The description cannot be empty";
            }

            _dbContext.Suppliers.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }

        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.Suppliers.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.Suppliers.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _dbContext.Suppliers.ToList();
        }

        public Supplier GetById(Guid id)
        {
            return _dbContext.Suppliers.Find(id);
        }

        public string Update(Guid id, Supplier item)
        {
            var existingItem = _dbContext.Suppliers.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Name = item.Name;
            existingItem.Address = item.Address;
            existingItem.State = item.State;
            existingItem.Status = item.Status;
            existingItem.INN = item.INN;
            existingItem.Phone = item.Phone;

            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
