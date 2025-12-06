using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.PrimaryPorts.OrderDetailPorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderDetailUseCases
{
    public class CreateOrderDetailUseCase : ICreateOrderDetailUseCase
    {
        private readonly IOrderDetailRepository _repository;

        public CreateOrderDetailUseCase(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateOrderDetailCommand command)
        {
            OrderDetail orderDetail = new()
            {
                OrderId = command.OrderId,
                ProductId = command.ProductId,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            };

            await _repository.CreateAsync(orderDetail);
        }
    }
}
