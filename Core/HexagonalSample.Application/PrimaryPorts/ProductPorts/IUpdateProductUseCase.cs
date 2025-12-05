using HexagonalSample.Application.DtoClasses.Products;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IUpdateProductUseCase
    {
        Task ExecuteAsync(UpdateProductCommand command);
    }
}

