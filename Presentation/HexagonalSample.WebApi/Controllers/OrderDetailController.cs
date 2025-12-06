using AutoMapper;
using HexagonalSample.Application.DtoClasses.OrderDetails;
using HexagonalSample.Application.DtoClasses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderDetailController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderDetailController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail([FromBody] CreateOrderDetailRequest request)
        {
            try
            {
                var command = _mapper.Map<CreateOrderDetailCommand>(request);
                await _mediator.Send(command);
                return Ok("OrderDetail created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrderDetail(int id, [FromBody] UpdateOrderDetailRequest request)
        {
            try
            {
                var command = _mapper.Map<UpdateOrderDetailCommand>(request);
                command.Id = id;
                await _mediator.Send(command);
                return Ok("OrderDetail updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            try
            {
                DeleteOrderDetailCommand command = new()
                {
                    Id = id
                };

                await _mediator.Send(command);
                return Ok("OrderDetail deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailById(int id)
        {
            try
            {
                GetOrderDetailByIdQuery query = new()
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
        public async Task<IActionResult> GetAllOrderDetails()
        {
            try
            {
                GetAllOrderDetailsQuery query = new();
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
