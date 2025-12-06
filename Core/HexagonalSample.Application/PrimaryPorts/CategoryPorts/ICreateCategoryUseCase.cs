using HexagonalSample.Application.DtoClasses.Categories;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface ICreateCategoryUseCase : IRequestHandler<CreateCategoryCommand, Unit>
    {
        Task ExecuteAsync(CreateCategoryCommand command);
    }
}
