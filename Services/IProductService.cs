﻿using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IProductService:IBaseService<Product>
    {
        IQueryable<Product> GetAllWithUnit();
        
    }
}
