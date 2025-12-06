using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class UpdateProductUseCase : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _repository;

        public UpdateProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if (product == null)
                throw new Exception($"Product with id {request.Id} not found");

            product.ProductName = request.Name;
            product.UnitPrice = request.Price;
            product.CategoryId = request.CategoryId;
            product.UpdatedDate = DateTime.Now;

            await _repository.UpdateAsync(product);
            return Unit.Value;
        }
    }
}

