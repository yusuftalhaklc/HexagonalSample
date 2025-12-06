using MediatR;

namespace HexagonalSample.Application.DtoClasses.AppUsers
{
    public class DeleteAppUserCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
