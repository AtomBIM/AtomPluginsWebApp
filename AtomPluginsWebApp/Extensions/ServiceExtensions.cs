using AtomPluginsDB;
using AtomPluginsWebAPI.Filters;
using AtomPluginsWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AtomPluginsWebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        public static void ConfigureApiBehavior(this IServiceCollection services)
        {
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }

        public static void ConfigureFilters(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString, b =>
            {
                b.EnableRetryOnFailure();
            }));
        }

        public static void ConfigureModelsServices(this IServiceCollection services)
        {
            services.AddScoped<MonitoringService>();
            services.AddScoped<LogsService>();
        }
    }
}
