using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using HexagonalSample.Application.UseCases.CategoryUseCases;
using HexagonalSample.Application.UseCases.ProductUseCases;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalSample.Application.DependencyResolvers
{
    public static class UseCaseResolver
    {
        public static void AddUseCaseServices(this IServiceCollection services)
        {
            // Category UseCases
            services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();
            services.AddScoped<IUpdateCategoryUseCase, UpdateCategoryUseCase>();
            services.AddScoped<IDeleteCategoryUseCase, DeleteCategoryUseCase>();
            services.AddScoped<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddScoped<IGetAllCategoriesUseCase, GetAllCategoriesUseCase>();

            // Product UseCases
            services.AddScoped<ICreateProductUseCase, CreateProductUseCase>();
            services.AddScoped<IUpdateProductUseCase, UpdateProductUseCase>();
            services.AddScoped<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddScoped<IGetProductByIdUseCase, GetProductByIdUseCase>();
            services.AddScoped<IGetAllProductsUseCase, GetAllProductsUseCase>();
        }
    }
}

