﻿namespace SaleOfProducts.Models
{
    public class Unit
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
