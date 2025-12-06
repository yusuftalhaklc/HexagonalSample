using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserProfileUseCases
{
    public class UpdateAppUserProfileUseCase : IUpdateAppUserProfileUseCase
    {
        private readonly IAppUserProfileRepository _repository;

        public UpdateAppUserProfileUseCase(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(UpdateAppUserProfileCommand command)
        {
            var profile = await _repository.GetByIdAsync(command.Id);
            if (profile == null)
                throw new Exception($"AppUserProfile with id {command.Id} not found");

            profile.FirstName = command.FirstName;
            profile.LastName = command.LastName;
            profile.AppUserId = command.AppUserId;
            profile.UpdatedDate = DateTime.Now;
            profile.Status = Domain.Enums.DataStatus.Updated;

            await _repository.UpdateAsync(profile);
        }
    }
}
