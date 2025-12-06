using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.PrimaryPorts.OrderDetailPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderDetailUseCases
{
    public class GetOrderDetailByIdUseCase : IGetOrderDetailByIdUseCase
    {
        private readonly IOrderDetailRepository _repository;

        public GetOrderDetailByIdUseCase(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<OrderDetailResult> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<OrderDetailResult> ExecuteAsync(GetOrderDetailByIdQuery query)
        {
            var orderDetail = await _repository.GetByIdAsync(query.Id);
            if (orderDetail == null)
                throw new Exception($"OrderDetail with id {query.Id} not found");

            return new OrderDetailResult
            {
                Id = orderDetail.Id,
                OrderId = orderDetail.OrderId,
                ProductId = orderDetail.ProductId,
                ProductName = orderDetail.Product?.ProductName,
                CreatedDate = orderDetail.CreatedDate,
                UpdatedDate = orderDetail.UpdatedDate
            };
        }
    }
}
