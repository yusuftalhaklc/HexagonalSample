using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class UpdateCategoryUseCase : IUpdateCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(UpdateCategoryCommand command)
        {
            var category = await _repository.GetByIdAsync(command.Id);
            if (category == null)
                throw new Exception($"Category with id {command.Id} not found");

            category.CategoryName = command.Name;
            category.Description = command.Description;
            category.UpdatedDate = DateTime.Now;
            category.Status = Domain.Enums.DataStatus.Updated;

            await _repository.UpdateAsync(category);
        }
    }
}

