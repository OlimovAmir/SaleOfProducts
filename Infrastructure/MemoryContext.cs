using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;

namespace SaleOfProducts.Infrastructure
{
    public class MemoryContext : DbContext
    {

        public MemoryContext(DbContextOptions<MemoryContext> options)
            : base(options)
        {
            Database.Migrate();
            Database.EnsureCreated();
        }
        public DbSet<CashExpense> CashExpenses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Position> Positions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CashExpense>()
                .HasKey(p => p.Id); // Указываем, что Id является первичным ключом
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id); // Указание первичного ключа для Employee
            modelBuilder.Entity<Unit>()
                .HasKey(u => u.Id); // Указание первичного ключа для сущности Unit
            modelBuilder.Entity<Position>()
                .HasKey(u => u.Id); // Указание первичного ключа для сущности Position

            base.OnModelCreating(modelBuilder);
        }
    }
}
