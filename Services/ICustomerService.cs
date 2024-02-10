using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(Guid id);
        string Create(Customer item);
        string Update(Guid id, Customer item);
        string Delete(Guid id);
    }
}
