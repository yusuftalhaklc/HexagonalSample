using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.PrimaryPorts.OrderPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderUseCases
{
    public class GetAllOrdersUseCase : IGetAllOrdersUseCase
    {
        private readonly IOrderRepository _repository;

        public GetAllOrdersUseCase(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<OrderResult>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<List<OrderResult>> ExecuteAsync(GetAllOrdersQuery query)
        {
            var orders = await _repository.GetAllAsync();

            return orders.Select(o => new OrderResult
            {
                Id = o.Id,
                ShippingAddress = o.ShippingAddress,
                AppUserId = o.AppUserId,
                AppUserName = o.AppUser?.UserName,
                CreatedDate = o.CreatedDate,
                UpdatedDate = o.UpdatedDate
            }).ToList();
        }
    }
}
