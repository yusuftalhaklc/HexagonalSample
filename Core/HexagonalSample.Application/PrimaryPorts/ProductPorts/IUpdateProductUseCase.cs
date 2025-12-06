using HexagonalSample.Application.DtoClasses.Products;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface IUpdateProductUseCase : IRequestHandler<UpdateProductCommand, Unit>
    {
        Task ExecuteAsync(UpdateProductCommand command);
    }
}

