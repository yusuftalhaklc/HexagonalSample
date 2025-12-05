using HexagonalSample.Application.DtoClasses.Categories;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IGetAllCategoriesUseCase
    {
        Task<List<CategoryResult>> ExecuteAsync(GetAllCategoriesQuery query);
    }
}

