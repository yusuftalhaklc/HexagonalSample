using HexagonalSample.Application.DtoClasses.Categories;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IUpdateCategoryUseCase : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        Task ExecuteAsync(UpdateCategoryCommand command);
    }
}

