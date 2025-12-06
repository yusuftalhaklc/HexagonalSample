using HexagonalSample.Domain.SecondaryPorts;
using HexagonalSample.Persistence.EFRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalSample.Persistence.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryService(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IAppUserProfileRepository, AppUserProfileRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        }
    }
}
