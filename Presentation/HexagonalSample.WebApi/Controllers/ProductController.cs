using HexagonalSample.Application.DtoClasses.Products;
using HexagonalSample.Application.PrimaryPorts.ProductPorts;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ICreateProductUseCase _createProductUseCase;
        private readonly IUpdateProductUseCase _updateProductUseCase;
        private readonly IDeleteProductUseCase _deleteProductUseCase;
        private readonly IGetProductByIdUseCase _getProductByIdUseCase;
        private readonly IGetAllProductsUseCase _getAllProductsUseCase;

        public ProductController(
            ICreateProductUseCase createProductUseCase,
            IUpdateProductUseCase updateProductUseCase,
            IDeleteProductUseCase deleteProductUseCase,
            IGetProductByIdUseCase getProductByIdUseCase,
            IGetAllProductsUseCase getAllProductsUseCase)
        {
            _createProductUseCase = createProductUseCase;
            _updateProductUseCase = updateProductUseCase;
            _deleteProductUseCase = deleteProductUseCase;
            _getProductByIdUseCase = getProductByIdUseCase;
            _getAllProductsUseCase = getAllProductsUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            try
            {
                CreateProductCommand command = new()
                {
                    Name = request.Name,
                    Price = request.Price,
                    CategoryId = request.CategoryId
                };

                await _createProductUseCase.ExecuteAsync(command);
                return Ok("Product created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductRequest request)
        {
            try
            {
                UpdateProductCommand command = new()
                {
                    Id = id,
                    Name = request.Name,
                    Price = request.Price,
                    CategoryId = request.CategoryId
                };

                await _updateProductUseCase.ExecuteAsync(command);
                return Ok("Product updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                DeleteProductCommand command = new()
                {
                    Id = id
                };

                await _deleteProductUseCase.ExecuteAsync(command);
                return Ok("Product deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                GetProductByIdQuery query = new()
                {
                    Id = id
                };

                var result = await _getProductByIdUseCase.ExecuteAsync(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                GetAllProductsQuery query = new();
                var results = await _getAllProductsUseCase.ExecuteAsync(query);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public record CreateProductRequest(string Name, decimal Price, int? CategoryId);
        public record UpdateProductRequest(string Name, decimal Price, int? CategoryId);
    }
}

