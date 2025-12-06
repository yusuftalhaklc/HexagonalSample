using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.PrimaryPorts.OrderDetailPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderDetailUseCases
{
    public class UpdateOrderDetailUseCase : IUpdateOrderDetailUseCase
    {
        private readonly IOrderDetailRepository _repository;

        public UpdateOrderDetailUseCase(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(UpdateOrderDetailCommand command)
        {
            var orderDetail = await _repository.GetByIdAsync(command.Id);
            if (orderDetail == null)
                throw new Exception($"OrderDetail with id {command.Id} not found");

            orderDetail.OrderId = command.OrderId;
            orderDetail.ProductId = command.ProductId;
            orderDetail.UpdatedDate = DateTime.Now;
            orderDetail.Status = Domain.Enums.DataStatus.Updated;

            await _repository.UpdateAsync(orderDetail);
        }
    }
}
