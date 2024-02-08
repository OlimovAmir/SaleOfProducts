using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(Guid id);
        string Create(Employee worker);
        string Update(Guid id, Employee item);
        string Delete(Guid id);
    }
}
