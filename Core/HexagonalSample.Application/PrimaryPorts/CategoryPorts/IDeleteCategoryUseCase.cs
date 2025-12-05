using HexagonalSample.Application.DtoClasses.Categories;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IDeleteCategoryUseCase
    {
        Task ExecuteAsync(DeleteCategoryCommand command);
    }
}

