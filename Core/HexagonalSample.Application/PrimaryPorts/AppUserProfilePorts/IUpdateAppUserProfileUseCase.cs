using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts
{
    public interface IUpdateAppUserProfileUseCase : IRequestHandler<UpdateAppUserProfileCommand, Unit>
    {
        Task ExecuteAsync(UpdateAppUserProfileCommand command);
    }
}
