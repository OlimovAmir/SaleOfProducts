﻿using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface IGroupProductService : IBaseService<GroupProduct>
    {
        IQueryable<GroupProduct> GetAllWithProduct();
    }
}
