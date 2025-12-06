using MediatR;

namespace HexagonalSample.Application.DtoClasses.Products
{
    public class GetAllProductsQuery : IRequest<List<ProductResult>>
    {
    }
}

