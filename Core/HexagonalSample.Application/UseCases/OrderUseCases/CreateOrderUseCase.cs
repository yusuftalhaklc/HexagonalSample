using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.PrimaryPorts.OrderPorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderUseCases
{
    public class CreateOrderUseCase : ICreateOrderUseCase
    {
        private readonly IOrderRepository _repository;

        public CreateOrderUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateOrderCommand command)
        {
            Order order = new()
            {
                ShippingAddress = command.ShippingAddress,
                AppUserId = command.AppUserId,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            };

            await _repository.CreateAsync(order);
        }
    }
}
