using HexagonalSample.Application.DtoClasses.Products;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IGetProductByIdUseCase
    {
        Task<ProductResult> ExecuteAsync(GetProductByIdQuery query);
    }
}

