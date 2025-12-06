using MediatR;

namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class UpdateOrderDetailCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
