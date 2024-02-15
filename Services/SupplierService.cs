using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly MemoryContext _dbContext;

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
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            Items.Remove(id);

            return "Item deleted";
        }

        public IEnumerable<Supplier> GetAll()
        {
            return Items.Values;
        }

        public Supplier GetById(Guid id)
        {
            return Items.SingleOrDefault(w => w.Key == id).Value;
        }

        public string Update(Guid id, Supplier item)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            _item.Name = item.Name;
            _item.INN = item.INN;
            _item.Address = item.Address;
            _item.State = item.State;
            _item.Phone = item.Phone;
            return "Item updated";
        }
    }
}
