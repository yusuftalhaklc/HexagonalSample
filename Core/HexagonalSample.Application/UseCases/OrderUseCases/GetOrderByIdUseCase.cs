using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.PrimaryPorts.OrderPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderUseCases
{
    public class GetOrderByIdUseCase : IGetOrderByIdUseCase
    {
        private readonly IOrderRepository _repository;

        public GetOrderByIdUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<OrderResult> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<OrderResult> ExecuteAsync(GetOrderByIdQuery query)
        {
            var order = await _repository.GetByIdAsync(query.Id);
            if (order == null)
                throw new Exception($"Order with id {query.Id} not found");

            return new OrderResult
            {
                Id = order.Id,
                ShippingAddress = order.ShippingAddress,
                AppUserId = order.AppUserId,
                AppUserName = order.AppUser?.UserName,
                CreatedDate = order.CreatedDate,
                UpdatedDate = order.UpdatedDate
            };
        }
    }
}
