using HexagonalSample.Application.DtoClasses.AppUsers;
using MediatR;

namespace HexagonalSample.Application.PrimaryPorts.AppUserPorts
{
    public interface IGetAppUserByIdUseCase : IRequestHandler<GetAppUserByIdQuery, AppUserResult>
    {
        Task<AppUserResult> ExecuteAsync(GetAppUserByIdQuery query);
    }
}
