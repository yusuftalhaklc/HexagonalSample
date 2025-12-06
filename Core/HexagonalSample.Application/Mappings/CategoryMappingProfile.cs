using AutoMapper;
using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.DtoClasses.Requests;

namespace HexagonalSample.Application.Mappings
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<CreateCategoryRequest, CreateCategoryCommand>();
            CreateMap<UpdateCategoryRequest, UpdateCategoryCommand>();
        }
    }
}
