using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.PrimaryPorts.CategoryPorts;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    //Dikkat ettiyseniz artık Composition Root normal şartlardaki gibi bu katmanda degildir...BUrası sadece bir Controller kütüphanesidir...Geliştirme bu alanda yapılacaktır...Middleware girişlerinden burasının haberi yoktur...Bu size Persistence'tan tamamen izole olmayı saglar..Ve geliştirirken kullanmamanız gereken , Encapsulation'i bozacak tiplerden uzak bir alan saglar...

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICreateCategoryUseCase _createCategoryUseCase;
        private readonly IUpdateCategoryUseCase _updateCategoryUseCase;
        private readonly IDeleteCategoryUseCase _deleteCategoryUseCase;
        private readonly IGetCategoryByIdUseCase _getCategoryByIdUseCase;
        private readonly IGetAllCategoriesUseCase _getAllCategoriesUseCase;

        public CategoryController(
            ICreateCategoryUseCase createCategoryUseCase,
            IUpdateCategoryUseCase updateCategoryUseCase,
            IDeleteCategoryUseCase deleteCategoryUseCase,
            IGetCategoryByIdUseCase getCategoryByIdUseCase,
            IGetAllCategoriesUseCase getAllCategoriesUseCase)
        {
            _createCategoryUseCase = createCategoryUseCase;
            _updateCategoryUseCase = updateCategoryUseCase;
            _deleteCategoryUseCase = deleteCategoryUseCase;
            _getCategoryByIdUseCase = getCategoryByIdUseCase;
            _getAllCategoriesUseCase = getAllCategoriesUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
        {
            try
            {
                CreateCategoryCommand command = new()
                {
                    Name = request.Name,
                    Description = request.Description
                };

                await _createCategoryUseCase.ExecuteAsync(command);
                return Ok("Category created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] UpdateCategoryRequest request)
        {
            try
            {
                UpdateCategoryCommand command = new()
                {
                    Id = id,
                    Name = request.Name,
                    Description = request.Description
                };

                await _updateCategoryUseCase.ExecuteAsync(command);
                return Ok("Category updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                DeleteCategoryCommand command = new()
                {
                    Id = id
                };

                await _deleteCategoryUseCase.ExecuteAsync(command);
                return Ok("Category deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                GetCategoryByIdQuery query = new()
                {
                    Id = id
                };

                var result = await _getCategoryByIdUseCase.ExecuteAsync(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            try
            {
                GetAllCategoriesQuery query = new();
                var results = await _getAllCategoriesUseCase.ExecuteAsync(query);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public record CreateCategoryRequest(string Name, string Description);
        public record UpdateCategoryRequest(string Name, string Description);
    }
}
