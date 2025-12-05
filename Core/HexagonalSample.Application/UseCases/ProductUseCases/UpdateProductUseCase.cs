using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using HexagonalSample.Domain.SecondaryPorts;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class UpdateProductUseCase : IUpdateProductUseCase
    {
        private readonly IProductRepository _repository;

        public UpdateProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(UpdateProductCommand command)
        {
            var product = await _repository.GetByIdAsync(command.Id);
            if (product == null)
                throw new Exception($"Product with id {command.Id} not found");

            product.ProductName = command.Name;
            product.UnitPrice = command.Price;
            product.CategoryId = command.CategoryId;
            product.UpdatedDate = DateTime.Now;

            await _repository.UpdateAsync(product);
        }
    }
}

