using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.PrimaryPorts.OrderPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderUseCases
{
    public class UpdateOrderUseCase : IUpdateOrderUseCase
    {
        private readonly IOrderRepository _repository;

        public UpdateOrderUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(UpdateOrderCommand command)
        {
            var order = await _repository.GetByIdAsync(command.Id);
            if (order == null)
                throw new Exception($"Order with id {command.Id} not found");

            order.ShippingAddress = command.ShippingAddress;
            order.AppUserId = command.AppUserId;
            order.UpdatedDate = DateTime.Now;
            order.Status = Domain.Enums.DataStatus.Updated;

            await _repository.UpdateAsync(order);
        }
    }
}
