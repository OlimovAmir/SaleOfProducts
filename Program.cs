
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services;

namespace SaleOfProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<MemoryContext>(o => o.UseSqlServer(connectionString));

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            

            builder.Services.AddScoped<MemoryContext>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ISupplierService, SupplierService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<ICashExpenseService, CashExpenseService>();
            builder.Services.AddSingleton(typeof(IMemoryRepository<>), typeof(MemoryRepository<>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
