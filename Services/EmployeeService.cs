using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;

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
            return _dbContext.Employees.ToList();
        }

        public Employee GetById(Guid id)
        {
            return _dbContext.Employees.Find(id);
        }

        public string Update(Guid id, Employee item)
        {
            var existingItem = _dbContext.Employees.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Name = item.Name;
            existingItem.SurName = item.SurName;
            existingItem.Birthday = item.Birthday;
            existingItem.Position = item.Position;
            existingItem.IsHired = item.IsHired;
            existingItem.TerminationDate = item.TerminationDate;


            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
