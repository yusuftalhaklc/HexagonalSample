using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts
{
    public interface IGetAppUserProfileByIdUseCase : IRequestHandler<GetAppUserProfileByIdQuery, AppUserProfileResult>
    {
        Task<AppUserProfileResult> ExecuteAsync(GetAppUserProfileByIdQuery query);
    }
}
