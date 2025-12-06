using HexagonalSample.Application.DtoClasses.AppUserProfiles;
using HexagonalSample.Application.PrimaryPorts.AppUserProfilePorts;
using HexagonalSample.Domain.Entities;
using HexagonalSample.Domain.SecondaryPorts;
using MediatR;

namespace HexagonalSample.Application.UseCases.AppUserProfileUseCases
{
    public class CreateAppUserProfileUseCase : ICreateAppUserProfileUseCase
    {
        private readonly IAppUserProfileRepository _repository;

        public CreateAppUserProfileUseCase(IAppUserProfileRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateAppUserProfileCommand request, CancellationToken cancellationToken)
        {
            await ExecuteAsync(request);
            return Unit.Value;
        }

        public async Task ExecuteAsync(CreateAppUserProfileCommand command)
        {
            AppUserProfile profile = new()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                AppUserId = command.AppUserId,
                CreatedDate = DateTime.Now,
                Status = Domain.Enums.DataStatus.Inserted
            };

            await _repository.CreateAsync(profile);
        }
    }
}
