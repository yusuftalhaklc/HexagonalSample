using MediatR;

namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class GetAllOrderDetailsQuery : IRequest<List<OrderDetailResult>>
    {
    }
}
