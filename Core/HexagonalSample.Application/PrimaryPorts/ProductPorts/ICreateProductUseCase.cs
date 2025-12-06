using HexagonalSample.Application.DtoClasses.Products;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.ProductPorts
{
    public interface ICreateProductUseCase : IRequestHandler<CreateProductCommand, Unit>
    {
        Task ExecuteAsync(CreateProductCommand command);
    }
}
