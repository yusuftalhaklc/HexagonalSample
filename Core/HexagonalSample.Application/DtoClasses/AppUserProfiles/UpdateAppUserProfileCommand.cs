using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUserProfiles
{
    public class UpdateAppUserProfileCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int AppUserId { get; set; }
    }
}
