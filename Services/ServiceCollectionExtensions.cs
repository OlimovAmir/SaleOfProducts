using SaleOfProducts.Repositories;
using SaleOfProducts.Services.IService;
using SaleOfProducts.Services.Service;

namespace SaleOfProducts.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyServicesProduct(this IServiceCollection service)
        {

            service.AddScoped<ICashExpenseService, CashExpenseService>();
            service.AddScoped<IEmployeeService, EmployeeService>();
            service.AddScoped<IUnitService, UnitService>();
            service.AddScoped<IPositionService, PositionService>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<ISupplierService, SupplierService>();
            service.AddScoped<ICashExpenseService, CashExpenseService>();
            service.AddScoped<IExpenseItemService, ExpenseItemService>();
            service.AddScoped<IIncomeItemService, IncomeItemService>();
            service.AddScoped<ICashIncomeService, CashIncomeService>();

            service.AddScoped<IGroupProductService, GroupProductService>();
            service.AddScoped<INameCharacteristicProductService, NameCharacteristicProductService>();
            service.AddScoped<IValueCharacteristicProductService, ValueCharacteristicProductService>();

            service.AddScoped(typeof(IPostgreSQLRepository<>), typeof(PostgreSQLRepository<>));
        }
    }
}
