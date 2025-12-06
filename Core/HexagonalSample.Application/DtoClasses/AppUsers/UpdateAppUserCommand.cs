using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUsers
{
    public class UpdateAppUserCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
