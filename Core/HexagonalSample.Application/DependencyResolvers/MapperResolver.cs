using AutoMapper;
using HexagonalSample.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace HexagonalSample.Application.DependencyResolvers
{
    public static class MapperResolver
    {
        public static void AddMapperServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CategoryMappingProfile).Assembly);
        }
    }
}
