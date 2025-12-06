using MediatR;

namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class UpdateOrderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;
        public int? AppUserId { get; set; }
    }
}
