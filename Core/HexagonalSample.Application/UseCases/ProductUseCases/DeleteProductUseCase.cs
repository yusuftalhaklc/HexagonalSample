using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using HexagonalSample.Domain.SecondaryPorts;

namespace HexagonalSample.Application.UseCases.ProductUseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository _repository;

        public DeleteProductUseCase(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(DeleteProductCommand command)
        {
            var product = await _repository.GetByIdAsync(command.Id);
            if (product == null)
                throw new Exception($"Product with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}

