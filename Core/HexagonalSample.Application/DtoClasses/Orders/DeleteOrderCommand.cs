using MediatR;

namespace HexagonalSample.Application.DtoClasses.Orders
{
    public class DeleteOrderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
