using MediatR;

namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class CreateOrderCommand : IRequest<Unit>
    {
        public string ShippingAddress { get; set; } = string.Empty;
        public int? AppUserId { get; set; }
    }
}
