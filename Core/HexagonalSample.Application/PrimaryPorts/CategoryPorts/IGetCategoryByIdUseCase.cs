using HexagonalSample.Application.DtoClasses.Categories;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IGetCategoryByIdUseCase : IRequestHandler<GetCategoryByIdQuery, CategoryResult>
    {
        Task<CategoryResult> ExecuteAsync(GetCategoryByIdQuery query);
    }
}

