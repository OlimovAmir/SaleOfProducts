using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IGroupProductService
    {
        IQueryable<GroupProduct> GetAll();
        GroupProduct GetById(Guid id);
        string Create(GroupProduct item);
        string Update(Guid id, GroupProduct item);
        string Delete(Guid id);
    }
}
