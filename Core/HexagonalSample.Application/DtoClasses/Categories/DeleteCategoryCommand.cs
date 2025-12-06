using MediatR;

namespace HexagonalSample.Application.DtoClasses.Categories
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}

