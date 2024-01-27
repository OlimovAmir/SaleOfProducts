using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Repositories
{
    public class MemoryRepositiry<T> : IMemoryRepositiry<T> where T : BaseEntity
    {
        Dictionary<Guid, T> _items = new Dictionary<Guid, T>();
        public bool Create(T item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return _items.Values;
        }

        public T GetById(Guid id)
        {
            return _items.SingleOrDefault(w => w.Key == id).Value;
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }


}
