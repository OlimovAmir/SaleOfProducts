using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;

namespace SaleOfProducts.Services
{
    public class CashIncomeService : ICashIncomeService
    {
        IPostgreSQLRepository<CashIncome> _repository;
        private readonly ILogger<CashIncome> _logger;

        public CashIncomeService(IPostgreSQLRepository<CashIncome> repository, ILogger<CashIncome> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public string Create(CashIncome item)
        {
            _logger.LogInformation("Starting creation of a new CashIncome item.");

            if (string.IsNullOrEmpty(item.Description))
            {
                _logger.LogWarning("Failed to create CashIncome item: Description is empty.");
                return "The description cannot be empty";
            }
            else
            {
                try
                {
                    _repository.Create(item);
                    _logger.LogInformation($"Successfully created new CashIncome item with ID: {item.Id}");
                    return $"Created new item with this ID: {item.Id}";
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to create CashIncome item.");
                    throw;
                }
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

        public IQueryable<CashIncome> GetAll()
        {
            return _repository.GetAll().Include(o => o.IncomeItems);
        }

        public CashIncome GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public string Update(Guid id, CashIncome item)
        {
            var _item = _repository.GetById(id);
            if (_item is not null)
            {
                _item.TransactionDate = item.TransactionDate;
                _item.IncomeItems = item.IncomeItems;
                _item.Description = item.Description;
                _item.Amount = item.Amount;

                var result = _repository.Update(_item);
                if (result)
                    return "Item updated";
            }

            return "Item updated";
        }
    }
}
