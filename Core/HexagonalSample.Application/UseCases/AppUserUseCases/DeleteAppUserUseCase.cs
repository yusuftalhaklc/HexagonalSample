using HexagonalSample.Application.DtoClasses.AppUsers;
using HexagonalSample.Application.PrimaryPorts.AppUserPorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserUseCases
{
    public class DeleteAppUserUseCase : IDeleteAppUserUseCase
    {
        private readonly IAppUserRepository _repository;

        public DeleteAppUserUseCase(IAppUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteAppUserCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(DeleteAppUserCommand command)
        {
            var appUser = await _repository.GetByIdAsync(command.Id);
            if (appUser == null)
                throw new Exception($"AppUser with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}
