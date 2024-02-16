using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Repositories
{
    public interface IPostgreSQLRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        bool Create(T item);
        bool Update(T item);
        bool Delete(Guid id);
    }
}
