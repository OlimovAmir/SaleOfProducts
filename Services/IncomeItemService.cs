﻿using SaleOfProducts.Models;
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
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
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
