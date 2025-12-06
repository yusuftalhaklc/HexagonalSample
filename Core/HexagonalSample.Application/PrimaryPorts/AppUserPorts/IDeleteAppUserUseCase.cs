using HexagonalSample.Application.DtoClasses.AppUsers;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserPorts
{
    public interface IDeleteAppUserUseCase : IRequestHandler<DeleteAppUserCommand, Unit>
    {
        Task ExecuteAsync(DeleteAppUserCommand command);
    }
}
