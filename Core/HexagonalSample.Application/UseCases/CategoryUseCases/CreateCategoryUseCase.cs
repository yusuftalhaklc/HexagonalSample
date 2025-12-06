using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class CreateCategoryUseCase : ICreateCategoryUseCase
    {
        private readonly ICategoryRepository _repository;

        public CreateCategoryUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateCategoryCommand command)
        {
            Category category = new()
            {
                CategoryName = command.Name,
                Description = command.Description,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            };

            await _repository.CreateAsync(category);
        }
    }
}
