using MediatR;

namespace HexagonalSample.Application.DtoClasses.Products
{
    public class GetProductByIdQuery : IRequest<ProductResult>
    {
        public int Id { get; set; }
    }
}

