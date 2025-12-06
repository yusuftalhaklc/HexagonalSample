using MediatR;

namespace HexagonalSample.Application.DtoClasses.Categories
{
    public class GetCategoryByIdQuery : IRequest<CategoryResult>
    {
        public int Id { get; set; }
    }
}

