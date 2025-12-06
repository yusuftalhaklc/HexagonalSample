using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUserProfiles
{
    public class GetAllAppUserProfilesQuery : IRequest<List<AppUserProfileResult>>
    {
    }
}
