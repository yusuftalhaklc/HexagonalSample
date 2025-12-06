using HexagonalSample.Application.DtoClasses.AppUsers;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserPorts
{
    public interface IUpdateAppUserUseCase : IRequestHandler<UpdateAppUserCommand, Unit>
    {
        Task ExecuteAsync(UpdateAppUserCommand command);
    }
}
