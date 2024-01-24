using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public class SupplierService : ISupplierService
    {
        static Dictionary<Guid, Supplier> Items = new Dictionary<Guid, Supplier>();
        public string Create(Supplier item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The name cannot be empty";
            }
            else
            {
                Items.Add(item.Id, item);
                return $"Created new item with this ID: {item.Id}";
            }
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
            throw new NotImplementedException();
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
