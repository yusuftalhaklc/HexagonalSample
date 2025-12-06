using MediatR;

namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class CreateOrderDetailCommand : IRequest<Unit>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
