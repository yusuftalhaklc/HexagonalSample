using HexagonalSample.Application.DtoClasses.Categories;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.CategoryPorts
{
    public interface IGetAllCategoriesUseCase : IRequestHandler<GetAllCategoriesQuery, List<CategoryResult>>
    {
        Task<List<CategoryResult>> ExecuteAsync(GetAllCategoriesQuery query);
    }
}

