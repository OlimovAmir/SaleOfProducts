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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CashExpense>()
                .HasKey(p => p.Id); // Указываем, что Id является первичным ключом

           base.OnModelCreating(modelBuilder);
        }
    }
}
