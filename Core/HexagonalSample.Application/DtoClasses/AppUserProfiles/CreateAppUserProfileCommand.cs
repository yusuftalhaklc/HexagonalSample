using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUserProfiles
{
    public class CreateAppUserProfileCommand : IRequest<Unit>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int AppUserId { get; set; }
    }
}
