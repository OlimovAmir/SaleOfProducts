using Microsoft.EntityFrameworkCore;
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
        //public DbSet<ExpenseItem> ExpenseItems { get; set; }
        //public DbSet<IncomeItem> IncomeItems { get; set; }
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

            modelBuilder.Entity<Product>()
                .HasOne(e => e.Unit)
                .WithMany()
                .HasForeignKey(e => e.UnitId);

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

            //modelBuilder.Entity<IncomeItem>()
            // .HasKey(e => e.Id); // Указание первичного ключа для IncomeItem

            base.OnModelCreating(modelBuilder);
        }
    }
}
