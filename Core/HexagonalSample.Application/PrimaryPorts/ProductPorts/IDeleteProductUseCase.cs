using HexagonalSample.Application.DtoClasses.Products;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IDeleteProductUseCase
    {
        Task ExecuteAsync(DeleteProductCommand command);
    }
}

