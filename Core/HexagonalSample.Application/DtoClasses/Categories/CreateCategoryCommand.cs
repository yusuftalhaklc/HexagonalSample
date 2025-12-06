using MediatR;

namespace HexagonalSample.Application.DtoClasses.Categories
{
    public class CreateCategoryCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
