﻿using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface ICashIncomeService
    {
        IEnumerable<CashIncome> GetAll();
        CashIncome GetById(Guid id);
        string Create(CashIncome worker);
        string Update(Guid id, CashIncome item);
        string Delete(Guid id);
    }
}
