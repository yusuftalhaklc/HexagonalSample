using HexagonalSample.Application.DtoClasses.OrderDetails;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderDetailPorts
{
    public interface ICreateOrderDetailUseCase : IRequestHandler<CreateOrderDetailCommand, Unit>
    {
        Task ExecuteAsync(CreateOrderDetailCommand command);
    }
}
