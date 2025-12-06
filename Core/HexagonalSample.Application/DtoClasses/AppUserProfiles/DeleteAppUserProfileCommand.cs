using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUserProfiles
{
    public class DeleteAppUserProfileCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
