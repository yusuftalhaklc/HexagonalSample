using MediatR;

namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class GetAllOrdersQuery : IRequest<List<OrderResult>>
    {
    }
}
