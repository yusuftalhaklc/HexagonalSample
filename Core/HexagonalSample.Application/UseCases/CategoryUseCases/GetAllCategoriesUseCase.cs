using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.CategoryUseCases
{
    public class GetAllCategoriesUseCase : IRequestHandler<GetAllCategoriesQuery, List<CategoryResult>>
    {
        private readonly ICategoryRepository _repository;

        public GetAllCategoriesUseCase(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CategoryResult>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();

            return categories.Select(c => new CategoryResult
            {
                Id = c.Id,
                CategoryName = c.CategoryName,
                Description = c.Description,
                CreatedDate = c.CreatedDate,
                UpdatedDate = c.UpdatedDate
            }).ToList();
        }
    }
}

