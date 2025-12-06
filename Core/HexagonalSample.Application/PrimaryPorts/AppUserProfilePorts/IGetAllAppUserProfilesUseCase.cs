using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts
{
    public interface IGetAllAppUserProfilesUseCase : IRequestHandler<GetAllAppUserProfilesQuery, List<AppUserProfileResult>>
    {
        Task<List<AppUserProfileResult>> ExecuteAsync(GetAllAppUserProfilesQuery query);
    }
}
