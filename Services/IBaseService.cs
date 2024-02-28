using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(Guid id);

        string Create(TEntity item);

        string Update(Guid id, TEntity item);

        string Delete(Guid id);
    }
}
