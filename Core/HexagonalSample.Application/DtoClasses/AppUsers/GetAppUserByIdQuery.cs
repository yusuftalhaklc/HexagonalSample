using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUsers
{
    public class GetAppUserByIdQuery : IRequest<AppUserResult>
    {
        public int Id { get; set; }
    }
}
