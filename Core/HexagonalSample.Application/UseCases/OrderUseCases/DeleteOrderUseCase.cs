using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.PrimaryPorts.OrderPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderUseCases
{
    public class DeleteOrderUseCase : IDeleteOrderUseCase
    {
        private readonly IOrderRepository _repository;

        public DeleteOrderUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(DeleteOrderCommand command)
        {
            var order = await _repository.GetByIdAsync(command.Id);
            if (order == null)
                throw new Exception($"Order with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}
