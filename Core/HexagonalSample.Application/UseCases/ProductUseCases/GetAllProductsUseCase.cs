using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class GetAllProductsUseCase : IRequestHandler<GetAllProductsQuery, List<ProductResult>>
    {
        private readonly IProductRepository _repository;

        public GetAllProductsUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductResult>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();

            return products.Select(p => new ProductResult
            {
                Id = p.Id,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice,
                CategoryId = p.CategoryId,
                CategoryName = p.Category?.CategoryName,
                CreatedDate = p.CreatedDate,
                UpdatedDate = p.UpdatedDate
            }).ToList();
        }
    }
}

