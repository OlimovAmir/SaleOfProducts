using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Npgsql;
using SaleOfProducts.Auth;
using SaleOfProducts.Infrastructure;
using SaleOfProducts.Repositories;
using SaleOfProducts.Services;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.AspNetCore.OData;
using SaleOfProducts.Models;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace SaleOfProducts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMyAuth();

            NpgsqlConnection.GlobalTypeMapper.EnableDynamicJson();

            builder.Services.AddDbContext<MemoryContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DbPostgres"))
                       .LogTo(Console.WriteLine, LogLevel.Information)
                       .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            builder.Services.AddLogging();

            // Add services to the container.
            builder.Services.AddControllers()
                .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles)
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddOData(opt =>
                {
                    opt.AddRouteComponents("odata", GetEdmModel()).Select().Expand().Filter().OrderBy().Count().SetMaxTop(100);
                });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", builder =>
                {
                    builder.WithOrigins("http://localhost:7121", "https://localhost:7121", "http://localhost:3000", "https://localhost:7267")
                           .AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowCredentials();
                });
            });

            // Swagger configuration
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SaleOfProduct application APIs", Version = "v1" });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                };
                c.AddSecurityDefinition("Bearer", securityScheme);

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { securityScheme, new List<string>() }
                });
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
            builder.Services.AddMyServicesProduct();
            builder.Services.AddScoped(typeof(IPostgreSQLRepository<>), typeof(PostgreSQLRepository<>));

            var app = builder.Build();

            // Apply migrations at startup
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MemoryContext>();
                context.Database.Migrate();
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SaleOfProduct application APIs v1");
                });
            }

            app.UseCors("AllowLocalhost"); // Apply CORS middleware
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            app.MapGet("MyMinAPI", (string name) => $"Hello {name}");

            app.Run();
        }

        private static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();
            odataBuilder.EntitySet<GroupProduct>("GroupProducts");
            return odataBuilder.GetEdmModel();
        }
    }
}
