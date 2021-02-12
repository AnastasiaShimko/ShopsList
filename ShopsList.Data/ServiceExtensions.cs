using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopsList.Business.Interfaces;
using ShopsList.Data.Repository;

namespace ShopsList.Data
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IShopRepository, ShopRepository>();
            return services;
        }
    }
}
