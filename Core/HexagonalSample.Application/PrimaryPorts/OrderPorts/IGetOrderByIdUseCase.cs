using HexagonalSample.Application.DtoClasses.Orders;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderPorts
{
    public interface IGetOrderByIdUseCase : IRequestHandler<GetOrderByIdQuery, OrderResult>
    {
        Task<OrderResult> ExecuteAsync(GetOrderByIdQuery query);
    }
}
