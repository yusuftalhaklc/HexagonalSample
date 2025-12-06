using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class CreateProductUseCase : IRequestHandler<CreateProductCommand, Unit>
    {
        private readonly IProductRepository _repository;

        public CreateProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product()
            {
                ProductName = request.Name,
                UnitPrice = request.Price,
                CategoryId = request.CategoryId,
                CreatedDate = DateTime.Now
            };
           
            await _repository.CreateAsync(product);
            return Unit.Value;
        }
    }
}
