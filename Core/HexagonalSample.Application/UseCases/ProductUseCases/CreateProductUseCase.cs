using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class CreateProductUseCase : ICreateProductUseCase
    {
        private readonly IProductRepository _repository;

        public CreateProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateProductCommand command)
        {
            Product product = new Product()
            {
                ProductName = command.Name,
                UnitPrice = command.Price,
                CategoryId = command.CategoryId,
                CreatedDate = DateTime.Now
            };
           
            await _repository.CreateAsync(product);
        }
    }
}
