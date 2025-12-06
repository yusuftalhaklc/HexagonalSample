using HexagonalSample.Application.DtoClasses.AppUsers;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserPorts
{
    public interface ICreateAppUserUseCase : IRequestHandler<CreateAppUserCommand, Unit>
    {
        Task ExecuteAsync(CreateAppUserCommand command);
    }
}
