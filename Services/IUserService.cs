using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        string Create(User item);
        string Update(Guid id, User item);
        string Delete(Guid id);
    }
}
