using HexagonalSample.Application.DtoClasses.Orders;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderPorts
{
    public interface ICreateOrderUseCase : IRequestHandler<CreateOrderCommand, Unit>
    {
        Task ExecuteAsync(CreateOrderCommand command);
    }
}
