﻿using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Models;
using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public class ProductService : IProductService
    {
        IPostgreSQLRepository<Product> _repository;

        public ProductService(IPostgreSQLRepository<Product> repository)
        {
            _repository = repository;
        }

        public string Create(Product item)
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

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Product> GetAllWithUnit()
        {
            // Загрузка данных должности вместе с данными сотрудников
            //return _dbContext.Products.Include(e => e.Unit).ToList();
            return _repository.GetAll();
        }

        public Product GetById(Guid id)
        {
            return _dbContext.Products.Find(id);
        }

        public string Update(Guid id, Product item)
        {
            var existingItem = _dbContext.Products.Find(id);
            if (existingItem == null)
            {
                return "Item not found";
            }

            existingItem.Name = item.Name;
            existingItem.Unit = item.Unit;
            existingItem.Price = item.Price;
            existingItem.Quantity = item.Quantity;


            _dbContext.SaveChanges();

            return "Item updated";
        }
    }
}
