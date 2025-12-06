using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class UpdateCategoryUseCase : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if (category == null)
                throw new Exception($"Category with id {request.Id} not found");

            category.CategoryName = request.Name;
            category.Description = request.Description;
            category.UpdatedDate = DateTime.Now;

            await _repository.UpdateAsync(category);
            return Unit.Value;
        }
    }
}

