using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUsers
{
    public class GetAllAppUsersQuery : IRequest<List<AppUserResult>>
    {
    }
}
