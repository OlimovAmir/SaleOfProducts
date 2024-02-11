using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllWithPosition(); // Добавленный метод
        IEnumerable<Employee> GetAll();
        Employee GetById(Guid id);
        string Create(Employee item);
        string Update(Guid id, Employee item);
        string Delete(Guid id);
    }
}
