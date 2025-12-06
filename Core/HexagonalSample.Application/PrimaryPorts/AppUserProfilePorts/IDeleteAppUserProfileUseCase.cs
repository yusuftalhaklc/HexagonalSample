using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts
{
    public interface IDeleteAppUserProfileUseCase : IRequestHandler<DeleteAppUserProfileCommand, Unit>
    {
        Task ExecuteAsync(DeleteAppUserProfileCommand command);
    }
}
