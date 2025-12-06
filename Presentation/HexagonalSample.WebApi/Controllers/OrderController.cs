using AutoMapper;
using HexagonalSample.Application.DtoClasses.Orders;
using HexagonalSample.Application.DtoClasses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrderController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            try
            {
                var command = _mapper.Map<CreateOrderCommand>(request);
                await _mediator.Send(command);
                return Ok("Order created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] UpdateOrderRequest request)
        {
            try
            {
                var command = _mapper.Map<UpdateOrderCommand>(request);
                command.Id = id;
                await _mediator.Send(command);
                return Ok("Order updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                DeleteOrderCommand command = new()
                {
                    Id = id
                };

                await _mediator.Send(command);
                return Ok("Order deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            try
            {
                GetOrderByIdQuery query = new()
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
        public async Task<IActionResult> GetAllOrders()
        {
            try
            {
                GetAllOrdersQuery query = new();
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
