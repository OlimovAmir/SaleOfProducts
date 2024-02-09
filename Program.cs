
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services;

namespace SaleOfProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<MemoryContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DbPostgres")));

            // Add services to the container.

            builder.Services.AddControllersWithViews();
                        
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddScoped<ICashExpenseService, CashExpenseService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ISupplierService, SupplierService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            
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
