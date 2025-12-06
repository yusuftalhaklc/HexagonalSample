using HexagonalSample.Application.UseCases.CategoryUseCases;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalSample.Application.DependencyResolvers
{
    public static class MediatRResolver
    {
        public static void AddMediatRServices(this IServiceCollection services)
        {
         
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateCategoryUseCase).Assembly));
        }
    }
}
