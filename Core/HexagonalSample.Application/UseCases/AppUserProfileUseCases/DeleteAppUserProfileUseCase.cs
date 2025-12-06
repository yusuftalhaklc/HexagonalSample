using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserProfileUseCases
{
    public class DeleteAppUserProfileUseCase : IDeleteAppUserProfileUseCase
    {
        private readonly IAppUserProfileRepository _repository;

        public DeleteAppUserProfileUseCase(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(DeleteAppUserProfileCommand command)
        {
            var profile = await _repository.GetByIdAsync(command.Id);
            if (profile == null)
                throw new Exception($"AppUserProfile with id {command.Id} not found");

            await _repository.DeleteAsync(command.Id);
        }
    }
}
