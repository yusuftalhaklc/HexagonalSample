using HexagonalSample.Application.DtoClasses.Products;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IGetAllProductsUseCase : IRequestHandler<GetAllProductsQuery, List<ProductResult>>
    {
        Task<List<ProductResult>> ExecuteAsync(GetAllProductsQuery query);
    }
}

