using MediatR;

namespace HexagonalSample.Application.DtoClasses.Products
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}

