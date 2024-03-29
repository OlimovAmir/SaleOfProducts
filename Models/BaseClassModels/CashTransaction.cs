﻿namespace SaleOfProducts.Models.BaseClassModels
{
    public abstract class CashTransaction : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public double Amount { get; set; }
        public string Description { get; set; }

        // Конструктор
        public CashTransaction(double amount, string description)
        {
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} - {TransactionDate}: {Description}, Amount: {Amount}";
        }
    }
}
