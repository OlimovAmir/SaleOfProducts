using SaleOfProducts.Models;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;
using System.Linq;

namespace SaleOfProducts.Services.Service
{
    public class IncomeItemService : IIncomeItemService
    {
        IPostgreSQLRepository<IncomeItem> _repository;
        private readonly ILogger<IncomeItem> _logger;

        public IncomeItemService(IPostgreSQLRepository<IncomeItem> repository, ILogger<IncomeItem> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public string Create(IncomeItem item)
        {
            _logger.LogInformation("Starting creation of a new IncomeItem.");

            if (string.IsNullOrEmpty(item.Name))
            {
                _logger.LogWarning("Failed to create IncomeItem: Name is empty.");
                return "The name cannot be empty";
            }

            if (item.CashIncomeId == Guid.Empty)
            {
                _logger.LogWarning("Failed to create IncomeItem: CashIncomeId is empty.");
                return "The CashIncomeId cannot be empty";
            }

            try
            {
                _repository.Create(item);
                _logger.LogInformation($"Successfully created new IncomeItem with ID: {item.Id}");
                return $"Created new item with this ID: {item.Id}";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create IncomeItem.");
                throw;
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

        public IQueryable<IncomeItem> GetAll()
        {
            return _repository.GetAll();
        }

        public IncomeItem GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, IncomeItem item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.Name = item.Name;


                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
