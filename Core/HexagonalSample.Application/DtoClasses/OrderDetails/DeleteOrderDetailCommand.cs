using MediatR;

namespace HexagonalSample.Application.DtoClasses.OrderDetails
{
    public class DeleteOrderDetailCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
