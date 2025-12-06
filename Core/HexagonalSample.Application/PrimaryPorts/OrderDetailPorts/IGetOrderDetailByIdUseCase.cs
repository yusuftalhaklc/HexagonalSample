using HexagonalSample.Application.DtoClasses.OrderDetails;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderDetailPorts
{
    public interface IGetOrderDetailByIdUseCase : IRequestHandler<GetOrderDetailByIdQuery, OrderDetailResult>
    {
        Task<OrderDetailResult> ExecuteAsync(GetOrderDetailByIdQuery query);
    }
}
