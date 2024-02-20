using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class IncomeItemService : IIncomeItemService
    {
        IPostgreSQLRepository<IncomeItem> _repository;

        public IncomeItemService(IPostgreSQLRepository<IncomeItem> repository)
        {
            _repository = repository;
        }
        public string Create(IncomeItem item)
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

        public IEnumerable<IncomeItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public IncomeItem GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(Guid id, IncomeItem item)
        {
            throw new NotImplementedException();
        }
    }
}
