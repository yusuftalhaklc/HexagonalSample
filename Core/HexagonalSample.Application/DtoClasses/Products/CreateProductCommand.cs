using MediatR;

namespace HexagonalSample.Application.DtoClasses.Products
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
    }
}
