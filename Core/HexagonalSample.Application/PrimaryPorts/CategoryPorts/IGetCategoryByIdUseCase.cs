using HexagonalSample.Application.DtoClasses.Categories;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IGetCategoryByIdUseCase
    {
        Task<CategoryResult> ExecuteAsync(GetCategoryByIdQuery query);
    }
}

