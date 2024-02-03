using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Models;

namespace SaleOfProducts.Repositories
{
    public class MemoryContext:DbContext
    {
        public MemoryContext(DbContextOptions<MemoryContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Client> Clients { get; set; }
    }
}
