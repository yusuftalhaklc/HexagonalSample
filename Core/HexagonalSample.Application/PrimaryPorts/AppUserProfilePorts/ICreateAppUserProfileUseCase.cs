using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts
{
    public interface ICreateAppUserProfileUseCase : IRequestHandler<CreateAppUserProfileCommand, Unit>
    {
        Task ExecuteAsync(CreateAppUserProfileCommand command);
    }
}
