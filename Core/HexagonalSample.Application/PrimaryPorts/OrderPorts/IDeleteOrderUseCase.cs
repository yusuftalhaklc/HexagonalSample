using HexagonalSample.Application.DtoClasses.Orders;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderPorts
{
    public interface IDeleteOrderUseCase : IRequestHandler<DeleteOrderCommand, Unit>
    {
        Task ExecuteAsync(DeleteOrderCommand command);
    }
}
