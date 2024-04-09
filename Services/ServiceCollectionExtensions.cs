using SaleOfProducts.Repositories;

namespace SaleOfProducts.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMyServices(this IServiceCollection service)
        {
            //service.AddScoped<AuthService>();


            service.AddScoped(typeof(IPostgreSQLRepository<>), typeof(PostgreSQLRepository<>));
        }
    }
}
