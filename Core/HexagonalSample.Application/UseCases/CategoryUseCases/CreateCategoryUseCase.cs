using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class CreateCategoryUseCase : IRequestHandler<CreateCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _repository;

        public CreateCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new()
            {
                CategoryName = request.Name,
                Description = request.Description
            };

            category.CreatedDate = DateTime.Now;
            await _repository.CreateAsync(category);
            return Unit.Value;
        }
    }
}
