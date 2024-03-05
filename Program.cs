using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services;
using System.Text.Json.Serialization;

namespace SaleOfProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            NpgsqlConnection.GlobalTypeMapper.EnableDynamicJson();

            builder.Services.AddDbContext<MemoryContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DbPostgres"))

            //.UseLazyLoadingProxies()
          .LogTo(Console.Write, LogLevel.Information)
          .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            builder.Services.AddLogging(l =>
            {
                //l.ClearProviders();
                //l.AddConsole();
            });
            // Add services to the container.

            builder.Services.AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000") // Разрешение запроса от фронтенд домен
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddScoped<ICashExpenseService, CashExpenseService>();

            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IUnitService, UnitService>();
            builder.Services.AddScoped<IPositionService, PositionService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ISupplierService, SupplierService>();
            builder.Services.AddScoped<ICashExpenseService, CashExpenseService>();
            builder.Services.AddScoped<IExpenseItemService, ExpenseItemService>();
            builder.Services.AddScoped<IIncomeItemService, IncomeItemService>();
            builder.Services.AddScoped<ICharacteristicProductService, CharacteristicProductService>();
            builder.Services.AddScoped<IGroupProductService, GroupProductService>();
            builder.Services.AddScoped<INameCharacteristicProductService, NameCharacteristicProductService>();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           

            builder.Services.AddScoped(typeof(IPostgreSQLRepository<>), typeof(PostgreSQLRepository<>));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<MemoryContext>();
                context.Database.Migrate();

                //TODO -- NoTracking
                //var bank = context.Banks.First();
                //var oldName = bank.Name;
                //context.Attach(bank);
                //bank.Name = "Test";
                ////context.Update(bank);
                //context.SaveChanges();

                //bank.Name = oldName;
                //context.SaveChanges();

                //TODO - LazyLoadingProxies
                //var bank = context.Banks.First();
                //var name = bank.Name;
                //var branchs = bank.Branchs;


                //TODO: Lazy loading for spesific properties
                //var branch = context.Branchs.First();
                //var address = branch.Address;
                //var bank = branch.Bank;
                //var bank2 = branch.Bank;
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors("AllowLocalhost"); // Применяем CORS middleware

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
