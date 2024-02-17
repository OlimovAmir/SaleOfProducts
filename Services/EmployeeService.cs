using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class EmployeeService : IEmployeeService
    {
        IPostgreSQLRepository<Employee> _repository;

        public EmployeeService(IPostgreSQLRepository<Employee> repository)
        {
            _repository = repository;
        }

        public string Create(Employee item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                return "The name cannot be empty";
            }
            else
            {
                _repository.Create(item);
                return $"Created new item with this ID: {item.Id}";
            }
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

        public IEnumerable<Employee> GetAllWithPosition()
        {
            // Загрузка данных должности вместе с данными сотрудников
            return _dbContext.Employees.Include(e => e.Position).ToList();
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
