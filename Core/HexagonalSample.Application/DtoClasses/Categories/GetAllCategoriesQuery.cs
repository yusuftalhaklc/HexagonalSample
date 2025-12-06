using MediatR;

namespace HexagonalSample.Application.DtoClasses.Categories
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryResult>>
    {
    }
}

