using HexagonalSample.Application.DtoClasses.AppUsers;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserPorts
{
    public interface IGetAllAppUsersUseCase : IRequestHandler<GetAllAppUsersQuery, List<AppUserResult>>
    {
        Task<List<AppUserResult>> ExecuteAsync(GetAllAppUsersQuery query);
    }
}
