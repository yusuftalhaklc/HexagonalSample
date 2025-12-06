using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUsers
{
    public class CreateAppUserCommand : IRequest<Unit>
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
