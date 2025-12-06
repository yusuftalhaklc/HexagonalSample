using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class GetCategoryByIdUseCase : IRequestHandler<GetCategoryByIdQuery, CategoryResult>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByIdUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if (category == null)
                throw new Exception($"Category with id {request.Id} not found");

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

