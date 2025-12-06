using HexagonalSample.Application.DtoClasses.OrderDetails;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderDetailPorts
{
    public interface IUpdateOrderDetailUseCase : IRequestHandler<UpdateOrderDetailCommand, Unit>
    {
        Task ExecuteAsync(UpdateOrderDetailCommand command);
    }
}
