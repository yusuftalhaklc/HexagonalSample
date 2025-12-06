using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.PrimaryPorts.OrderDetailPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderDetailUseCases
{
    public class DeleteOrderDetailUseCase : IDeleteOrderDetailUseCase
    {
        private readonly IOrderDetailRepository _repository;

        public DeleteOrderDetailUseCase(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(DeleteOrderDetailCommand command)
        {
            var orderDetail = await _repository.GetByIdAsync(command.Id);
            if (orderDetail == null)
                throw new Exception($"OrderDetail with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}
