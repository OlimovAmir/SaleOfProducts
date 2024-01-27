using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Repositories
{
    public class MemoryRepositiry<T> : IMemoryRepositiry<T> where T : BaseEntity
    {
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
            throw new NotImplementedException();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T item)
        {
            throw new NotImplementedException();
        }
    }


}
