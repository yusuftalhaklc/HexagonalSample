using HexagonalSample.Application.DtoClasses.OrderDetails;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.OrderDetailPorts
{
    public interface IGetAllOrderDetailsUseCase : IRequestHandler<GetAllOrderDetailsQuery, List<OrderDetailResult>>
    {
        Task<List<OrderDetailResult>> ExecuteAsync(GetAllOrderDetailsQuery query);
    }
}
