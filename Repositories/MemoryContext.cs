﻿using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;

namespace SaleOfProducts.Repositories
{
    public class MemoryContext:DbContext
    {

        public MemoryContext(DbContextOptions<MemoryContext> options)
            : base(options)
        {
            Database.Migrate();
            Database.EnsureCreated();
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CashExpense> CashExpenses { get; set; }
    }
}
