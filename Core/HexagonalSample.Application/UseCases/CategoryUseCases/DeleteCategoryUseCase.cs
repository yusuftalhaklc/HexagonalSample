using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public DeleteCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(DeleteCategoryCommand command)
        {
            var category = await _repository.GetByIdAsync(command.Id);
            if (category == null)
                throw new Exception($"Category with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}

