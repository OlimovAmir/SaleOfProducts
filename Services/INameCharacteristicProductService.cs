﻿using SaleOfProducts.Models;

namespace SaleOfProducts.Services
{
    public interface INameCharacteristicProductService : IBaseService<NameCharacteristicProduct>
    {
        IQueryable<NameCharacteristicProduct> GetAllWithCharacteristic(); // Добавленный метод
    }
}
