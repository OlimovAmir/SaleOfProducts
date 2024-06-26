﻿using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;
using SaleOfProducts.Models.BaseClassModels;

namespace SaleOfProducts.Infrastructure
{
    public class MemoryContext : DbContext
    {

        public MemoryContext(DbContextOptions<MemoryContext> options) : base(options)
        {
            Database.Migrate();
            Database.EnsureCreated();
        }


        public DbSet<CashExpense> CashExpenses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<IncomeItem> IncomeItems { get; set; }
        public DbSet<CashIncome> CashIncomes { get; set; }

        public DbSet<GroupProduct> GroupProducts { get; set; }
        public DbSet<NameCharacteristicProduct> NameCharacteristicProducts { get; set; }

        public DbSet<ValueCharacteristicProduct> ValueCharacteristicProducts { get; set; }

        public DbSet<PurchaseProduct> PurchaseProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseEntity>();

            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id); // Указание первичного ключа для Employee

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Position)
                .WithMany()
                .HasForeignKey(e => e.PositionId);


            modelBuilder.Entity<Unit>()
                .HasKey(u => u.Id); // Указание первичного ключа для сущности Unit

            modelBuilder.Entity<Position>()
                .HasKey(u => u.Id); // Указание первичного ключа для сущности Position

           

            modelBuilder.Entity<Product>()
                .HasKey(e => e.Id); // Указание первичного ключа для Product           


            modelBuilder.Entity<Supplier>()
               .HasKey(e => e.Id); // Указание первичного ключа для Supplier

            modelBuilder.Entity<User>()
               .HasKey(e => e.Id); // Указание первичного ключа для User

            //---------------------------------------------------------------------------


            modelBuilder.Entity<CashExpense>()
               .HasKey(p => p.Id); // Указываем, что Id является первичным ключом

            modelBuilder.Entity<CashExpense>()
            .HasMany(c => c.ExpenseItems)
            .WithMany(); // Устанавливаем связь многие ко многим

            modelBuilder.Entity<ExpenseItem>()
               .HasKey(p => p.Id); // Указываем, что Id является первичным ключом


            // Конфигурация для отношений один ко многим между CashIncome и IncomeItem
            modelBuilder.Entity<IncomeItem>()
             .HasKey(e => e.Id); // Указание первичного ключа для IncomeItem

            modelBuilder.Entity<CashIncome>()
          .HasKey(ci => ci.Id); // Установка первичного ключа


            modelBuilder.Entity<IncomeItem>()
            .HasMany(i => i.CashIncomes)
            .WithOne(ci => ci.IncomeItem)
            .HasForeignKey(ci => ci.IncomeItemId);

            //--------------------------------------------------------------------------------------

            modelBuilder.Entity<GroupProduct>()
             .HasKey(p => p.Id); // Указываем, что Id является первичным ключом

            modelBuilder.Entity<NameCharacteristicProduct>()
             .HasKey(p => p.Id);

            modelBuilder.Entity<NameCharacteristicProduct>()
            .HasKey(ncp => ncp.NameCharacteristicProductId);

            modelBuilder.Entity<NameCharacteristicProduct>()
                .HasMany(ncp => ncp.GroupProducts)
                .WithMany(p => p.NameCharacteristicProducts)
                .UsingEntity(j => j.ToTable("Product_NameCharacteristicProduct"));            

            

            modelBuilder.Entity<ValueCharacteristicProduct>()
            .HasKey(ncp => ncp.ValueCharacteristicProductId);

            modelBuilder.Entity<ValueCharacteristicProduct>()
                .HasMany(ncp => ncp.NameCharacteristicProducts)
                .WithMany(p => p.ValueCharacteristicProducts)
                .UsingEntity(j => j.ToTable("NameValueCharacteristicProduct"));


            // Таблица PurchaseProducts





            base.OnModelCreating(modelBuilder);
        }
    }
}
