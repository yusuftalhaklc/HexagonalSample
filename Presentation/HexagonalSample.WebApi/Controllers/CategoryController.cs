using AutoMapper;
using HexagonalSample.Application.DtoClasses.Categories;
using HexagonalSample.Application.DtoClasses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    //Dikkat ettiyseniz artık Composition Root normal şartlardaki gibi bu katmanda degildir...BUrası sadece bir Controller kütüphanesidir...Geliştirme bu alanda yapılacaktır...Middleware girişlerinden burasının haberi yoktur...Bu size Persistence'tan tamamen izole olmayı saglar..Ve geliştirirken kullanmamanız gereken , Encapsulation'i bozacak tiplerden uzak bir alan saglar...

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoryController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
        {
            try
            {
                var command = _mapper.Map<CreateCategoryCommand>(request);
                await _mediator.Send(command);
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
                var command = _mapper.Map<UpdateCategoryCommand>(request);
                command.Id = id;
                await _mediator.Send(command);
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

                await _mediator.Send(command);
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

                var result = await _mediator.Send(query);
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
                var results = await _mediator.Send(query);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
