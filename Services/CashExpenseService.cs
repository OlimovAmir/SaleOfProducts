using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class CashExpenseService : ICashExpenseService
    {
        static Dictionary<Guid, CashExpense> Items = new Dictionary<Guid, CashExpense>();
        private readonly MemoryContext _dbContext;

        public CashExpenseService(MemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(CashExpense item)
        {
            if (string.IsNullOrEmpty(item.Description))
            {
                return "The description cannot be empty";
            }

            _dbContext.CashExpenses.Add(item);
            _dbContext.SaveChanges();

            return $"Created new item with this ID: {item.Id}";
        }



        public string Delete(Guid id)
        {
            var itemToDelete = _dbContext.CashExpenses.Find(id);
            if (itemToDelete == null)
            {
                return "Item not found";
            }

            _dbContext.CashExpenses.Remove(itemToDelete);
            _dbContext.SaveChanges();

            return "Item deleted";
        }

        public IEnumerable<CashExpense> GetAll()
        {
            return _dbContext.CashExpenses.ToList();
        }

        public CashExpense GetById(Guid id)
        {
            return _dbContext.CashExpenses.Find(id);
        }

        public string Update(Guid id, CashExpense item)
        {
            var _item = Items.SingleOrDefault(w => w.Key == id).Value;
            if (_item is null)
            {
                return "Item not found";
            }
            _item.TransactionDate = item.TransactionDate;
            _item.Category = item.Category;
            _item.Description = item.Description;
            _item.Amount = item.Amount;
           
            return "Item updated";
        }
    }
}
