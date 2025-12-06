using HexagonalSample.Application.DtoClasses.Categories;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IDeleteCategoryUseCase : IRequestHandler<DeleteCategoryCommand, Unit>
    {
        Task ExecuteAsync(DeleteCategoryCommand command);
    }
}

