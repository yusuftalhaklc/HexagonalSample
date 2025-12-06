using MediatR;

namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class GetOrderDetailByIdQuery : IRequest<OrderDetailResult>
    {
        public int Id { get; set; }
    }
}
