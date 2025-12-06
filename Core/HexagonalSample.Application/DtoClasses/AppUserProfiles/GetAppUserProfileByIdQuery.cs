using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUserProfiles
{
    public class GetAppUserProfileByIdQuery : IRequest<AppUserProfileResult>
    {
        public int Id { get; set; }
    }
}
