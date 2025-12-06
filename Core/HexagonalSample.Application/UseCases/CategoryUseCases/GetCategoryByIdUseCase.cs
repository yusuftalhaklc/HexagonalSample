using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByIdUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request);
        }

        public async Task<CategoryResult> ExecuteAsync(GetCategoryByIdQuery query)
        {
            var category = await _repository.GetByIdAsync(query.Id);
            if (category == null)
                throw new Exception($"Category with id {query.Id} not found");

            return new CategoryResult
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description,
                CreatedDate = category.CreatedDate,
                UpdatedDate = category.UpdatedDate
            };
        }
    }
}

