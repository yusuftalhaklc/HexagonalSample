using HexagonalSample.Application.DtoClasses.Products;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IGetProductByIdUseCase : IRequestHandler<GetProductByIdQuery, ProductResult>
    {
        Task<ProductResult> ExecuteAsync(GetProductByIdQuery query);
    }
}

