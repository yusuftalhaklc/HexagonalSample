using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.PrimaryPorts.OrderDetailPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.OrderDetailUseCases
{
    public class GetAllOrderDetailsUseCase : IGetAllOrderDetailsUseCase
    {
        private readonly IOrderDetailRepository _repository;

        public GetAllOrderDetailsUseCase(IOrderDetailRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<OrderDetailResult>> Handle(GetAllOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<List<OrderDetailResult>> ExecuteAsync(GetAllOrderDetailsQuery query)
        {
            var orderDetails = await _repository.GetAllAsync();

            return orderDetails.Select(od => new OrderDetailResult
            {
                Id = od.Id,
                OrderId = od.OrderId,
                ProductId = od.ProductId,
                ProductName = od.Product?.ProductName,
                CreatedDate = od.CreatedDate,
                UpdatedDate = od.UpdatedDate
            }).ToList();
        }
    }
}
