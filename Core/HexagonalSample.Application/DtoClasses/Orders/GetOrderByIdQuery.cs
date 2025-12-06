using MediatR;

namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class GetOrderByIdQuery : IRequest<OrderResult>
    {
        public int Id { get; set; }
    }
}
