using HexagonalSample.Application.DtoClasses.OrderDetails;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderDetailPorts
{
    public interface IDeleteOrderDetailUseCase : IRequestHandler<DeleteOrderDetailCommand, Unit>
    {
        Task ExecuteAsync(DeleteOrderDetailCommand command);
    }
}
