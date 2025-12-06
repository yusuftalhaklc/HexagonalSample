using HexagonalSample.Application.DtoClasses.Orders;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderPorts
{
    public interface IUpdateOrderUseCase : IRequestHandler<UpdateOrderCommand, Unit>
    {
        Task ExecuteAsync(UpdateOrderCommand command);
    }
}
