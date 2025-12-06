using AutoMapper;
using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.DtoClasses.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalSample.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUserProfileController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public AppUserProfileController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUserProfile([FromBody] CreateAppUserProfileRequest request)
        {
            try
            {
                var command = _mapper.Map<CreateAppUserProfileCommand>(request);
                await _mediator.Send(command);
                return Ok("AppUserProfile created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAppUserProfile(int id, [FromBody] UpdateAppUserProfileRequest request)
        {
            try
            {
                var command = _mapper.Map<UpdateAppUserProfileCommand>(request);
                command.Id = id;
                await _mediator.Send(command);
                return Ok("AppUserProfile updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUserProfile(int id)
        {
            try
            {
                DeleteAppUserProfileCommand command = new()
                {
                    Id = id
                };

                await _mediator.Send(command);
                return Ok("AppUserProfile deleted successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUserProfileById(int id)
        {
            try
            {
                GetAppUserProfileByIdQuery query = new()
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
        public async Task<IActionResult> GetAllAppUserProfiles()
        {
            try
            {
                GetAllAppUserProfilesQuery query = new();
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
