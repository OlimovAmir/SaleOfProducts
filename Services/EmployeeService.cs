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
            var result = _repository.Delete(id);
            if (result)
                return "Item deleted";
            else
                return "Item not found";
        }

        public IEnumerable<Employee> GetAll()
        {
            //return _dbContext.Employees.ToList();
            return _repository.GetAll();
        }

        public IEnumerable<Employee> GetAllWithPosition()
        {
            var employees = _repository.GetAll().ToList();
            foreach (var employee in employees)
            {
                employee.Position = _positionRepository.GetById(employee.PositionId); // Предполагается, что есть метод GetById в репозитории должностей (_positionRepository)
            }
            return employees;
        }

        public Employee GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, Employee item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;
                _item.SurName = item.SurName;
                _item.Birthday = item.Birthday;
                _item.Position = item.Position;
                _item.IsHired = item.IsHired;
                _item.TerminationDate = item.TerminationDate;

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }         

            return "Item updated";
        }
    }
}
