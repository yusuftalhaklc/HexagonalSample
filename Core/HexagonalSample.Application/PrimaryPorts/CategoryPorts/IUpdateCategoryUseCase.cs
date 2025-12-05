using HexagonalSample.Application.DtoClasses.Categories;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IUpdateCategoryUseCase
    {
        Task ExecuteAsync(UpdateCategoryCommand command);
    }
}

