using HexagonalSample.Application.DtoClasses.Products;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IGetAllProductsUseCase
    {
        Task<List<ProductResult>> ExecuteAsync(GetAllProductsQuery query);
    }
}

