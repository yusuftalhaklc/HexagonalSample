using HexagonalSample.Application.DtoClasses.Products;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IDeleteProductUseCase : IRequestHandler<DeleteProductCommand, Unit>
    {
        Task ExecuteAsync(DeleteProductCommand command);
    }
}

