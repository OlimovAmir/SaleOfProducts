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
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<IncomeItem> IncomeItems { get; set; }
        public DbSet<CashIncome> CashIncomes { get; set; }

        public DbSet<CharacteristicProduct> CharacteristicProducts { get; set; }
        public DbSet<GroupProduct> GroupProducts { get; set; }
        public DbSet<NameCharacteristicProduct> NameCharacteristicProducts { get; set; }
        public DbSet<ValueCharacteristicProduct> ValueCharacteristicProducts { get; set; }

        public DbSet<GroupProductNameCharacteristicProduct> GroupProductNameCharacteristicProducts { get; set; }
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

            modelBuilder.Entity<IncomeItem>()
             .HasKey(e => e.Id); // Указание первичного ключа для IncomeItem

            modelBuilder.Entity<CashIncome>()
               .HasKey(p => p.Id); // Указываем, что Id является первичным ключом

            modelBuilder.Entity<CashIncome>()
            .HasMany(c => c.IncomeItems)
            .WithMany(); // Устанавливаем связь многие ко многим

            modelBuilder.Entity<CharacteristicProduct>()
               .HasKey(p => p.Id); // Указываем, что Id является первичным ключом

            modelBuilder.Entity<GroupProduct>()
               .HasKey(p => p.Id); // Указываем, что Id является первичным ключом



            modelBuilder.Entity<ValueCharacteristicProduct>()
               .HasKey(p => p.Id);
            // Определение связи один к одному между ValueCharacteristicProduct и NameCharacteristicProduct
            modelBuilder.Entity<ValueCharacteristicProduct>()
                .HasOne(p => p.NameCharacteristicProduct)
                .WithOne()
                .HasForeignKey<ValueCharacteristicProduct>(p => p.NameCharacteristicProductId);


            //--------------------------------------------------------------------------------------
            modelBuilder.Entity<GroupProductNameCharacteristicProduct>()
              .HasKey(p => p.Id);

            modelBuilder.Entity<NameCharacteristicProduct>()
               .HasKey(p => p.Id);

            modelBuilder.Entity<NameCharacteristicProduct>()
                .HasKey(t => new { t.Name, t.GroupProductId });

            modelBuilder.Entity<NameCharacteristicProduct>()
                .HasMany(pt => pt.NameCharacteristicProductGroupProducts)
                .WithOne(p => p.NameCharacteristicProduct)
                .HasForeignKey(pt => pt.NameCharacteristicProductId);

            modelBuilder.Entity<GroupProductNameCharacteristicProduct>()
                .HasOne(pt => pt.GroupProduct)
                .WithMany(t => t.GroupProductNameCharacteristicProducts)
                .HasForeignKey(pt => pt.GroupProductId);

            //-----------------------------------------------------------------

            modelBuilder.Entity<ValueCharacteristicProduct>()
                .HasOne(vp => vp.NameCharacteristicProduct)
                .WithMany(np => np.ValueCharacteristicProducts)
                .HasForeignKey(vp => new { vp.NameCharacteristicProductId, vp.GroupProductId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
