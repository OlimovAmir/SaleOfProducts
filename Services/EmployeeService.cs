using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly MemoryContext _dbContext;

        public EmployeeService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(Employee item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The description cannot be empty";
            }

            _dbContext.Employees.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }

        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.Employees.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.Employees.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
