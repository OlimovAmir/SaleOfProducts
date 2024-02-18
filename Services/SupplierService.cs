using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class SupplierService : ISupplierService
    {
        IPostgreSQLRepository<Supplier> _repository;

        public SupplierService(IPostgreSQLRepository<Supplier> repository)
        {
            _repository = repository;
        }

        public string Create(Supplier item)
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

        public IEnumerable<Supplier> GetAll()
        {
            return _repository.GetAll();
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
