using AutoMapper;
using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.DtoClasses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AppUserController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser([FromBody] CreateAppUserRequest request)
        {
            try
            {
                var command = _mapper.Map<CreateAppUserCommand>(request);
                await _mediator.Send(command);
                return Ok("AppUser created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppUser(int id, [FromBody] UpdateAppUserRequest request)
        {
            try
            {
                var command = _mapper.Map<UpdateAppUserCommand>(request);
                command.Id = id;
                await _mediator.Send(command);
                return Ok("AppUser updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            try
            {
                DeleteAppUserCommand command = new()
                {
                    Id = id
                };

                await _mediator.Send(command);
                return Ok("AppUser deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUserById(int id)
        {
            try
            {
                GetAppUserByIdQuery query = new()
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
        public async Task<IActionResult> GetAllAppUsers()
        {
            try
            {
                GetAllAppUsersQuery query = new();
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
