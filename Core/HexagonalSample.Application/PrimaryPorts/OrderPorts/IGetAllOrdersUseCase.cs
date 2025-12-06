using HexagonalSample.Application.DtoClasses.Orders;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderPorts
{
    public interface IGetAllOrdersUseCase : IRequestHandler<GetAllOrdersQuery, List<OrderResult>>
    {
        Task<List<OrderResult>> ExecuteAsync(GetAllOrdersQuery query);
    }
}
